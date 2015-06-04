USE GD1C2015
GO

SET LANGUAGE Spanish

/*	****************************************	CREACION DEL SCHENMA	*********************************************** */

IF NOT EXISTS (SELECT 1 FROM [sys].[schemas] WHERE [name] = 'GEM4')
	EXECUTE ('CREATE SCHEMA GEM4 AUTHORIZATION gd;');
GO

/*	****************************************	FECHA DEL SISTEMA	*************************************************** */

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'fechaSistema')
	DROP TABLE GEM4.fechaSistema;

CREATE TABLE GEM4.fechaSistema (
		fechaSistema	DATETIME NOT NULL
	);

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='spRegistrarFechaDelSistema')
	DROP PROCEDURE GEM4.spRegistrarFechaDelSistema
GO
CREATE PROCEDURE GEM4.spRegistrarFechaDelSistema
	@fecha DATETIME
AS
BEGIN
	IF @fecha is NULL
			INSERT GEM4.fechaSistema (fechaSistema) VALUES (GETDATE())
	ELSE
			INSERT GEM4.fechaSistema (fechaSistema) VALUES (@fecha)
END;
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnDevolverFechaSistema')
	DROP FUNCTION GEM4.fnDevolverFechaSistema
GO
CREATE FUNCTION GEM4.fnDevolverFechaSistema()
RETURNS DATETIME
AS
	BEGIN
	DECLARE @fecha DATETIME
	SELECT TOP 1 @fecha = fechaSistema FROM GEM4.fechaSistema
	RETURN @fecha
	END
GO

EXEC GEM4.spRegistrarFechaDelSistema '2015-01-01 00:00:00.000' --NULL

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='spInsertarFechaFuncionamiento')
	DROP PROCEDURE GEM4.spInsertarFechaFuncionamiento
GO
CREATE PROCEDURE GEM4.spInsertarFechaFuncionamiento
	@fecha DATETIME
AS
BEGIN
	UPDATE GEM4.fechaSistema
	SET fechaSistema = @fecha
END;
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarFecha')
	DROP FUNCTION GEM4.fnValidarFecha
GO
CREATE FUNCTION GEM4.fnValidarFecha(@unaFecha DATETIME)
RETURNS DATETIME
AS
	BEGIN
		IF((@unaFecha IS NULL)OR(@unaFecha > GETDATE()))
			BEGIN
				RETURN GEM4.fnDevolverFechaSistema();
			END
		RETURN @unaFecha;
	END
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarSaldoCuenta')
	DROP FUNCTION GEM4.fnValidarSaldoCuenta
GO
CREATE FUNCTION GEM4.fnValidarSaldoCuenta(@saldo NUMERIC(18,2))
RETURNS NUMERIC(18,2)
AS
	BEGIN
		IF(@saldo <1)
			BEGIN
				RETURN 1000;
			END
		RETURN @saldo;
	END
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='spSolicitarFecha')
	DROP PROCEDURE GEM4.spSolicitarFecha
GO
CREATE PROCEDURE GEM4.spSolicitarFecha
AS
	SELECT TOP 1 fechaSistema FROM GEM4.fechaSistema
GO



/*	****************************************	BORRADO DE OBJETOS	*************************************************** */
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Deposito')
	DROP TABLE GEM4.Deposito;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Transferencia')
	DROP TABLE GEM4.Transferencia;	
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Retiro')
	DROP TABLE GEM4.Retiro;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Operacion_Por_Factura')
	DROP TABLE GEM4.Operacion_Por_Factura;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND TABLE_NAME = 'Operacion')
	DROP TABLE GEM4.Operacion
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Log_Operacion')
	DROP TABLE GEM4.Log_Operacion;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tipo_Operacion')
	DROP TABLE GEM4.Tipo_Operacion;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Log_Login')
	DROP TABLE GEM4.Log_Login;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Item_Por_Factura')
	DROP TABLE GEM4.Item_Por_Factura;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Factura')
	DROP TABLE GEM4.Factura;

 --BORRAR ES DE LA TABLA ANTERIOR
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Operaciones_Facturables')	
	DROP TABLE GEM4.Operaciones_Facturables;
--TABLA NUEVA IMPLEMENTADA	
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Operacion_Facturable')	
	DROP TABLE GEM4.Operacion_Facturable; 
	
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Item')
	DROP TABLE GEM4.Item;

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Cheque')
	DROP TABLE GEM4.Cheque;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Banco')
	DROP TABLE GEM4.Banco;


IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tarjeta')
	DROP TABLE GEM4.Tarjeta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Emisor')
	DROP TABLE GEM4.Emisor;	
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Cuenta')
	DROP TABLE GEM4.Cuenta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tipo_Cuenta')
	DROP TABLE GEM4.Tipo_Cuenta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Estado_Cuenta')
	DROP TABLE GEM4.Estado_Cuenta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Usuario_Por_Rol')
	DROP TABLE GEM4.Usuario_Por_Rol;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Usuario')
	DROP TABLE GEM4.Usuario;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Cliente')
	DROP TABLE GEM4.Cliente;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Documento')
	DROP TABLE GEM4.Documento;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND TABLE_NAME = 'Pais')
	DROP TABLE GEM4.Pais;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND TABLE_NAME = 'Rol_Por_Funcionalidad')
	DROP TABLE GEM4.Rol_Por_Funcionalidad;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Rol')
	DROP TABLE GEM4.Rol;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Funcionalidad')
	DROP TABLE GEM4.Funcionalidad;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Moneda')
	DROP TABLE GEM4.Moneda;
/*	****************************************	CREACION DE LAS TABLAS	*********************************************** */

CREATE TABLE GEM4.Pais(
	Pais_Cod					NUMERIC(18,0) IDENTITY(1,1),
	Pais_Descripcion			NVARCHAR(250),
	PRIMARY KEY(Pais_Cod)
	);

CREATE TABLE GEM4.Rol(
	Rol_Cod 					INT IDENTITY(1,1),
	Rol_Nombre					NVARCHAR(50) NOT NULL,					
	Rol_Habilitado				BIT NOT NULL DEFAULT 1,
	PRIMARY KEY(Rol_Cod)
	);
	
CREATE TABLE GEM4.Funcionalidad(
	Funcionalidad_Cod			TINYINT ,
	Funcionalidad_Descripcion	NVARCHAR(50) NOT NULL,
	Funcionalidad_Habilitada	BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY(Funcionalidad_Cod)
	);

CREATE TABLE GEM4.Rol_Por_Funcionalidad(
	Rol_Cod								INT,
	Funcionalidad_Cod					TINYINT,
	Rol_Por_Funcionalidad_Habilitado	BIT DEFAULT 1,	
	PRIMARY KEY(Rol_Cod, Funcionalidad_Cod),
	FOREIGN KEY(Rol_Cod) REFERENCES GEM4.Rol(Rol_Cod),
	FOREIGN KEY(Funcionalidad_Cod) REFERENCES GEM4.Funcionalidad(Funcionalidad_Cod)
	);
	
CREATE TABLE GEM4.Documento(
	Documento_Tipo_Codigo					NUMERIC(18,0) IDENTITY(10001,1),
	Documento_Tipo_Descripcion				NVARCHAR(255),
	PRIMARY KEY(Documento_Tipo_Codigo)
	)
	
CREATE TABLE GEM4.Cliente(
	Cliente_ID					INT IDENTITY(1,1),					
	Cliente_Nombre				NVARCHAR(255),
	Cliente_Apellido			NVARCHAR(255),
	Cliente_Tipo_Doc			NUMERIC(18,0),
	Cliente_Numero_Documento	NUMERIC(18,0),					
	Cliente_Mail				NVARCHAR(255) UNIQUE,
	Cliente_Pais				NUMERIC(18,0),
	Cliente_Dom_Calle			NVARCHAR(255),
	Cliente_Dom_Numero			NUMERIC(18,0),
	Cliente_Dom_Piso			NUMERIC(18,0),
	Cliente_Dom_Depto			NVARCHAR(10),
	Cliente_Localidad			NVARCHAR(60),				
	Cliente_Nacionalidad		NVARCHAR(60),				
	Cliente_Fecha_Nacimiento	DATETIME,
	Cliente_Habilitado			BIT DEFAULT 1,
	PRIMARY KEY(Cliente_ID),
	FOREIGN KEY(Cliente_Tipo_Doc) REFERENCES GEM4.Documento(Documento_Tipo_Codigo),
	FOREIGN KEY(Cliente_Pais) REFERENCES GEM4.Pais(Pais_Cod)
	)	
	
CREATE TABLE GEM4.Usuario(
	Usuario_ID 								INT IDENTITY(0,1),
	Usuario_Username						NVARCHAR(30) UNIQUE NOT NULL,
	Usuario_Contrasena						CHAR(44) NOT NULL,
	Usuario_Fecha_Creacion 					DATETIME,
	Usuario_Fecha_Ultima_Modificacion 		DATETIME,
	Usuario_Pregunta_Secreta 				NVARCHAR(60),
	Usuario_Respuesta_Secreta 				NVARCHAR(60),
	Cliente_ID								INT,
	Usuario_Habilitado						BIT NOT NULL DEFAULT 1,
	PRIMARY KEY(Usuario_ID),
	FOREIGN KEY(Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID),
	UNIQUE(Usuario_Username)
	);
	
CREATE TABLE GEM4.Usuario_Por_Rol(
	Usuario_ID								INT,
	Rol_Cod									INT,
	Habilitado								BIT DEFAULT 1,
	PRIMARY KEY(Usuario_ID, Rol_Cod),
	FOREIGN KEY(Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY(Rol_Cod) REFERENCES GEM4.Rol(Rol_Cod)
	);
	
CREATE TABLE GEM4.Moneda(
	Moneda_Codigo							INT IDENTITY(1,1),
	Moneda_Descripcion						NVARCHAR(60),
	PRIMARY KEY(Moneda_Codigo)
	)

CREATE TABLE GEM4.Estado_Cuenta(
	Estado_Codigo							INT IDENTITY(1,1),
	Estado_Descripcion						NVARCHAR(255),
	PRIMARY KEY(Estado_Codigo)
	)
	
CREATE TABLE GEM4.Tipo_Cuenta(
	Tipo_Cuenta_ID						INT IDENTITY(1,1),
	Tipo_Cuenta_Descripcion				NVARCHAR(60),
	Tipo_Cuenta_Costo_Creacion			NUMERIC(18,2),
	Tipo_Cuenta_Costo_Modificacion		NUMERIC(18,2),
	Tipo_Cuenta_Costo_Transf			NUMERIC(18,2), 
	Tipo_Cuenta_Duracion				INT,
	Habilitado							BIT DEFAULT 1
	PRIMARY KEY (Tipo_Cuenta_ID)
	)	
	
CREATE TABLE GEM4.Cuenta( --agregar 2 cosos
	Cuenta_Numero							NUMERIC(18,0) IDENTITY(1,1),
	Cuenta_Fecha_Creacion					DATETIME,
	Cuenta_Estado							INT	DEFAULT 1,
	Cuenta_Pais								NUMERIC(18,0),
	Cuenta_Fecha_Cierre						DATETIME,
	Cuenta_Moneda							INT	DEFAULT 1,
	Cuenta_Tipo								INT	DEFAULT 4,
	Cuenta_Cliente_ID						INT,
	Cuenta_Saldo							NUMERIC(18,2) DEFAULT 0,-- LO INICIALIZO EN CERO A VER SI FUNCA LO QUE NOS DIJERON LOS AYUDANTES
	Cuenta_Suscripciones_Compradas			TINYINT DEFAULT 1, --AL MIGRAR, TODOS TIENEN UNA SOLA SUSCRIPCION COMPRADA POR DEFAULT
	Cuenta_Suscripciones_Fecha				DATETIME --Fecha de compra de las suscripciones, para poder calcular si esta inhabilitado o no. --> Por defauult cuando migra que tenga la fecha de migracion
	PRIMARY KEY(Cuenta_Numero),
	FOREIGN KEY(Cuenta_Estado) REFERENCES GEM4.Estado_Cuenta(Estado_Codigo),
	FOREIGN KEY(Cuenta_Moneda) REFERENCES GEM4.Moneda(Moneda_Codigo),
	FOREIGN KEY(Cuenta_Tipo) REFERENCES GEM4.Tipo_Cuenta(Tipo_Cuenta_ID),
	FOREIGN KEY(Cuenta_Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID) 
	)

	CREATE TABLE GEM4.Emisor(
	Emisor_Cod								INT IDENTITY(1,1),
	Emisor_Descripcion						NVARCHAR(255),
	PRIMARY KEY(Emisor_Cod)
	)


CREATE TABLE GEM4.Tarjeta(
	Tarjeta_Numero							NVARCHAR(16),
	Tarjeta_Fecha_Emision					DATETIME,
	Tarjeta_Fecha_Vencimiento				DATETIME,
	Tarjeta_Codigo_Seg						NVARCHAR(3),
	Tarjeta_Emisor							INT,
	Tarjeta_Cliente_ID						INT,
	Tarjeta_Habilitado						BIT DEFAULT 1
	PRIMARY KEY(Tarjeta_Numero),
	FOREIGN KEY(Tarjeta_Emisor) REFERENCES	GEM4.Emisor,	
	FOREIGN KEY(Tarjeta_Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID)		
	)
CREATE TABLE GEM4.Factura(
	Factura_Numero							NUMERIC(18,0) IDENTITY(1,1),
	Factura_Fecha							DATETIME,
	Factura_Cliente_ID						INT
	PRIMARY KEY(Factura_Numero),
	FOREIGN KEY(Factura_Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID) 
	-----> 	Le agregaría una FK de Cliente_ID y Cuenta_Nro, de ahi tengo acceso a todos los datos del Cliente y sus Cuentas.
	)

/* TABLA VIEJA
CREATE TABLE GEM4.Tipo_Operacion(
	Tipo_Operacion_ID						INT IDENTITY(1,1),
	Tipo_Operacion_Descripcion				NVARCHAR(255),
	
	PRIMARY KEY(Tipo_Operacion_ID)
	)
	*/

 
CREATE TABLE GEM4.Tipo_Operacion(
	Tipo_Operacion_ID						INT IDENTITY(1,1),
	Tipo_Operacion_Descripcion				NVARCHAR(255),
	Tipo_Operacion_Importe					NUMERIC(18,2)
	PRIMARY KEY(Tipo_Operacion_ID)
	)
	
	
/* TABLA VIEJA	
CREATE TABLE GEM4.Operacion(
	Operacion_ID						INT IDENTITY(1,1),
	Operacion_Tipo						INT,
	Operacion_Fecha						DATETIME,
	Operacion_Usuario_ID				INT,
	Operacion_Costo						NUMERIC(18,2),
	Factura_Numero						NUMERIC(18,0),
	PRIMARY KEY(Operacion_ID),
	FOREIGN KEY(Operacion_Tipo) REFERENCES GEM4.Tipo_Operacion(Tipo_Operacion_ID),
	FOREIGN KEY(Operacion_Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY (Factura_Numero) REFERENCES GEM4.Factura(Factura_Numero)
	)
	*/


CREATE TABLE GEM4.Operacion(
	Operacion_ID						INT IDENTITY(1,1),
	Operacion_Tipo						INT,
	Operacion_Fecha						DATETIME,
	Operacion_Usuario_ID				INT,
	Operacion_Detalle					NVARCHAR(255),			--GUARDA CON ESTO, AVISAR
	PRIMARY KEY(Operacion_ID),
	FOREIGN KEY(Operacion_Tipo) REFERENCES GEM4.Tipo_Operacion(Tipo_Operacion_ID),
	FOREIGN KEY(Operacion_Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID)
	)
	


CREATE TABLE GEM4.Operacion_Facturable(
	Operacion_Facturable_ID					INT IDENTITY(1,1),
	Operacion_Facturable_Tipo				INT,
	Operacion_Facturable_Fecha				DATETIME,
	Operacion_Facturable_Usuario_ID			INT,
	Operacion_Facturable_Detalle			NVARCHAR(255), --'DESCRIPCION DETALLADA' o algo por el estilo que muestra  directamente lo que iria en la factura, tipo [Apertura de cuenta 122422313234]
	Operacion_Facturable_Costo				NUMERIC(18,2),
	Operacion_Facturable_Factura_Numero		NUMERIC(18,0) 
	PRIMARY KEY(Operacion_Facturable_ID),
	FOREIGN KEY(Operacion_Facturable_Factura_Numero) REFERENCES GEM4.Factura(Factura_Numero),
	FOREIGN KEY(Operacion_Facturable_Tipo) REFERENCES GEM4.Tipo_Operacion(Tipo_Operacion_ID)
	)
/*	
Agrego una lista de cosas facturables que encontre (creo que son todas, vayan aggregando si encuentran mas), son las cosas que irian en operaciones facturables

COMISION POR TRANSFERENCIA DESDE GRATUITA (entre cuentas de usuarios distintos)	COSTO FIJO -----> Inventar?
COMISION POR TRANSFERENCIA DESDE BRONCE(entre cuentas de usuarios distintos)	COSTO FIJO -----> Inventar?
COMISION POR TRANSFERENCIA DESDE PLATA(entre cuentas de usuarios distintos)		COSTO FIJO -----> Inventar?
COMISION POR TRANSFERENCIA DESDE ORO(entre cuentas de usuarios distintos)		COSTO FIJO -----> Inventar?
Apertura Cuenta ORO																COSTO FIJO -----> Inventar?
Apertura Cuenta PLATA															COSTO FIJO -----> Inventar?
Apertura Cuenta BRONCE															COSTO FIJO -----> Inventar?
Apertura Cuenta GRATUITA														COSTO 0
Modificacion de tipo de cuenta													COSTO CUENTA MAYOR - COSTO CUENTA MENOR
Costo de Apertura de cuenta														COSTO FIJO + costo tipo de cuenta? -----> Inventar?

*/
	
CREATE TABLE GEM4.Deposito(
	Deposito_Codigo							NUMERIC(18,0) IDENTITY(1,1),
	Deposito_Fecha							DATETIME,
	Deposito_Importe						NUMERIC(18,2),
	Deposito_Cliente						INT,
	Deposito_Tarjeta						NVARCHAR(16),
	Deposito_Moneda							INT DEFAULT 1,
	Deposito_Cuenta							NUMERIC(18,0),
	Deposito_Operacion_ID							INT,
	PRIMARY KEY(Deposito_Codigo),
	FOREIGN KEY(Deposito_Cliente) REFERENCES GEM4.Cliente(Cliente_ID),
	FOREIGN KEY(Deposito_Tarjeta) REFERENCES GEM4.Tarjeta(Tarjeta_Numero),
	FOREIGN KEY(Deposito_Cuenta) REFERENCES GEM4.Cuenta(Cuenta_Numero),
	FOREIGN KEY(Deposito_Operacion_ID)	REFERENCES GEM4.Operacion(Operacion_ID)
	)




CREATE TABLE GEM4.Transferencia( 
	Transferencia_Codigo					INT IDENTITY(1,1),
	Transferencia_Fecha						DATETIME,
	Transferencia_Importe					NUMERIC(18,2),
	Transferencia_Costo_Trans				NUMERIC(18,2),
	Transferencia_Cuenta_Origen				NUMERIC(18,0),
	Transferencia_Cuenta_Destino			NUMERIC(18,0),
	Transferencia_Operacion_ID				INT,
	PRIMARY KEY(Transferencia_Codigo),
	FOREIGN KEY(Transferencia_Cuenta_Origen) REFERENCES GEM4.Cuenta(Cuenta_Numero),
	FOREIGN KEY(Transferencia_Cuenta_Destino) REFERENCES GEM4.Cuenta(Cuenta_Numero),
	FOREIGN KEY(Transferencia_Operacion_ID)	REFERENCES	GEM4.Operacion_Facturable(Operacion_Facturable_ID)
	)

CREATE TABLE GEM4.Banco(
	Banco_Codigo							NUMERIC(18,0) IDENTITY(1,1),
	Banco_Nombre							NVARCHAR(255),
	Banco_Direccion							NVARCHAR(255),
	PRIMARY KEY(Banco_Codigo)
	)

CREATE TABLE GEM4.Cheque(
	Cheque_Numero							NUMERIC(18,0) IDENTITY(1,1),
	Cheque_Fecha							DATETIME,
	Cheque_Importe							NUMERIC(18,2),
	Cheque_Cliente_ID						INT,
	Cheque_Banco							NUMERIC(18,0),
	PRIMARY KEY(Cheque_Numero),
	FOREIGN KEY(Cheque_Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID),
	FOREIGN KEY(Cheque_Banco) REFERENCES GEM4.Banco(Banco_Codigo)							
	)

CREATE TABLE GEM4.Retiro(
	Retiro_Codigo							NUMERIC(18,0) IDENTITY(1,1),
	Retiro_Importe							NUMERIC(18,2),
	Retiro_Fecha							DATETIME,
	Retiro_Cuenta							NUMERIC(18,0),
	Retiro_Cheque							NUMERIC(18,0),
	Operacion_ID							INT,
	PRIMARY KEY(Retiro_Codigo),
	FOREIGN KEY(Retiro_Cuenta) REFERENCES GEM4.Cuenta(Cuenta_Numero),
	FOREIGN KEY(Retiro_Cheque) REFERENCES GEM4.Cheque(Cheque_Numero),
	FOREIGN KEY(Operacion_ID)	REFERENCES GEM4.Operacion(Operacion_ID)
	)

CREATE TABLE GEM4.Log_Login(
	Log_Login_Numero						INT IDENTITY(1,1),
	Log_Login_Usuario_ID					INT,
	Log_Login_Fecha							DATETIME,
	Log_Login_Incorrecto					BIT, --Si es TRUE -----> LOGIN FUE INCORRECTO
	Log_Login_NIntento						INT,
	PRIMARY KEY(Log_Login_Numero),
	FOREIGN KEY(Log_Login_Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID)
	)
GO
	
/*	*******************************************	    VIEWS   	********************************************************** */

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.VIEWS WHERE  TABLE_NAME  = 'Cuenta_ABM')
	DROP VIEW GEM4.Cuenta_ABM;
GO
CREATE VIEW GEM4.Cuenta_ABM(Cuenta_Numero, Cuenta_Cliente_ID, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, Cuenta_Saldo, Cuenta_Tipo, Cuenta_Estado, Cuenta_Moneda, Cuenta_Pais, Cuenta_Suscripciones_Compradas, Cuenta_Suscripciones_Fecha) AS
SELECT Cuenta_Numero, Cuenta_Cliente_ID, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, Cuenta_Saldo, Tipo_Cuenta_Descripcion, Estado_Descripcion, Moneda_Descripcion, Pais_Descripcion, Cuenta_Suscripciones_Compradas, Cuenta_Suscripciones_Fecha  		
FROM GEM4.Cuenta JOIN GEM4.Tipo_Cuenta ON (Cuenta.Cuenta_Tipo = Tipo_Cuenta.Tipo_Cuenta_ID)
					JOIN GEM4.Estado_Cuenta ON (Cuenta.Cuenta_Estado = Estado_Cuenta.Estado_Codigo)
					JOIN GEM4.Moneda ON (Cuenta.Cuenta_Moneda = Moneda.Moneda_Codigo)
					JOIN GEM4.Pais ON (Cuenta.Cuenta_Pais = Pais.Pais_Cod)
GO

/* *****************************************     CREACION DE TRIGGERS    ********************************************** */
/* *****************************************	PROCEDIMIENTOS DE MIGRACION *******************************************/


/*******************************************	FUNCIONES AUXILIARES		*******************************************/

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnObtenerNumTarjetaCredito')
	DROP FUNCTION GEM4.fnObtenerNumTarjetaCredito
GO
CREATE FUNCTION GEM4.fnObtenerNumTarjetaCredito()
RETURNS  NVARCHAR(16)
AS
	BEGIN
		DECLARE @numeroTarjeta NUMERIC(18,0);
		
		SELECT TOP 1 @numeroTarjeta=CONVERT(NUMERIC(18,0),t.Tarjeta_Numero)+1
		FROM GEM4.Tarjeta t
		ORDER BY Tarjeta_Numero DESC;
		
		RETURN CONVERT(NVARCHAR(16),@numeroTarjeta);
		
	END;
	
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnInsertarCodigoDeEmisor')
	DROP FUNCTION GEM4.fnInsertarCodigoDeEmisor
GO
CREATE FUNCTION GEM4.fnInsertarCodigoDeEmisor(@emisorDescripcion NVARCHAR(255))
RETURNS  INT
AS
	BEGIN
	
		DECLARE @codigoEmisor INT;
		
		SELECT @codigoEmisor=Emisor_Cod
		FROM GEM4.Emisor
		WHERE Emisor_Descripcion=@emisorDescripcion
		
		RETURN @codigoEmisor;
		
	END;
	
GO


IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarClienteParaRetiro')
	DROP FUNCTION GEM4.fnValidarClienteParaRetiro
GO

CREATE FUNCTION GEM4.fnValidarClienteParaRetiro(@nroDoc NUMERIC(18,0),@tipoDoc NUMERIC(18,0),@clienteID INT)
RETURNS  INT
AS 
	BEGIN
		
		IF NOT EXISTS (SELECT 1 FROM GEM4.Cliente WHERE @nroDoc=Cliente_Numero_Documento 
					AND @tipoDoc=Cliente_Tipo_Doc AND Cliente_ID=@clienteID)
		BEGIN
			RETURN 0;
		END;


		RETURN 1;
	END;
GO

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnObtenerEmisorTarjeta')
	DROP FUNCTION GEM4.fnObtenerEmisorTarjeta
GO
CREATE FUNCTION GEM4.fnObtenerEmisorTarjeta(@emisorCodigo INT)
RETURNS  NVARCHAR(255)
AS
	BEGIN
	
		DECLARE @emisorDescripcion NVARCHAR(255);
		
		SELECT @emisorDescripcion=Emisor_Descripcion
		FROM GEM4.Emisor
		WHERE Emisor_Cod=@emisorCodigo;
		
		RETURN @emisorDescripcion;
		
	END;
	
GO


IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarSaldoSuficiente')
	DROP FUNCTION GEM4.fnValidarSaldoSuficiente
GO

CREATE FUNCTION GEM4.fnValidarSaldoSuficiente(@importe NUMERIC(18,2),@cuentaNum NUMERIC(18,0))
RETURNS  INT
AS
	BEGIN
		DECLARE @saldo NUMERIC(18,2);
		
		SELECT @saldo=Cuenta_Numero
		FROM GEM4.Cuenta;
		
		IF(@importe>@saldo)
			BEGIN 
				RETURN 0;
			END;
	
	
		RETURN 1;
	
		
	END;

GO


IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarCuentaHabilitada')
	DROP FUNCTION GEM4.fnValidarCuentaHabilitada
GO

CREATE FUNCTION GEM4.fnValidarCuentaHabilitada(@cuentaNum NUMERIC(18,0))
RETURNS  INT
AS
	BEGIN
		DECLARE @estadoCuenta INT;
		
		SELECT @estadoCuenta=Cuenta_Estado
		FROM GEM4.Cuenta;
		
		IF(@estadoCuenta<>1)
			BEGIN
				RETURN 0; 
			END;
		RETURN 1;
	END;
GO




/* ***************************************** INICIALIZACION DE DATOS ************************************************** */
IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spInsertaOperaciones')
	DROP PROCEDURE GEM4.spInsertaOperaciones
GO

SET IDENTITY_INSERT GEM4.Rol ON;
INSERT INTO GEM4.Rol (Rol_Cod,Rol_Nombre) VALUES 
	(1,'Administrador'),
	(2,'Cliente');
SET IDENTITY_INSERT GEM4.Rol OFF;

INSERT INTO GEM4.Funcionalidad(Funcionalidad_Cod,Funcionalidad_Descripcion) VALUES 
	(1,'ABM de Rol'),
	(2,'ABM de Usuario'),
	(3,'ABM de Clientes'),
	(4,'ABM de Cuenta'),
	(5,'Asociar/Desasociar Tarjetas de Credito'),
	(6,'Depositos'),
	(7,'Retiros'),
	(8,'Transferencias'),
	(9,'Facturacion'),
	(10,'Consulta Saldos'),
	(11,'Listados Estadisticos');
	
INSERT INTO GEM4.Rol_Por_Funcionalidad (Rol_Cod, Funcionalidad_Cod) VALUES
	(1,1),
	(1,2),
	(1,3),
	(1,4),
	(2,4),
	(2,5),
	(2,6),
	(2,7),
	(2,8),
	(1,9),
	(2,9),
	(1,10),
	(2,10),
	(1,11);
	
--Completa las funcionalidades deshabilitadas--

INSERT INTO GEM4.Rol_Por_Funcionalidad (Funcionalidad_Cod,Rol_Cod,Rol_Por_Funcionalidad_Habilitado)
		SELECT F.Funcionalidad_Cod,R.Rol_Cod,0
			FROM GEM4.Funcionalidad F,GEM4.Rol R
			WHERE F.Funcionalidad_Cod not in (SELECT Q.Funcionalidad_Cod  FROM GEM4.Rol_Por_Funcionalidad Q
			WHERE Q.Rol_Cod =R.Rol_Cod)
;
	
SET IDENTITY_INSERT GEM4.Usuario ON;
INSERT INTO GEM4.Usuario (Usuario_ID,Usuario_Username,Usuario_Contrasena) VALUES 
	(1,'admin','5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c='), --contrasena w23e
	(2,'admin2','5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c='), --contrasena w23e
	(3,'admin3','5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c='); --contrasena w23e
SET IDENTITY_INSERT GEM4.Usuario OFF;

INSERT INTO GEM4.Usuario_Por_Rol (Usuario_ID, Rol_Cod) VALUES
	(1,1),
	(2,1),
	(3,1);

SET IDENTITY_INSERT GEM4.Moneda ON;	
INSERT INTO GEM4.Moneda(Moneda_Codigo, Moneda_Descripcion) VALUES
	(1,'Dólar estadounidense');
SET IDENTITY_INSERT GEM4.Moneda OFF;


INSERT INTO GEM4.Tipo_Operacion(Tipo_Operacion_Descripcion)
VALUES('Deposito'),('Retiro'),('Transferencia'),('Apertura Cuenta'),('Cierre Cuenta');

SET IDENTITY_INSERT GEM4.Tipo_Cuenta ON;
INSERT INTO GEM4.Tipo_Cuenta(Tipo_Cuenta_ID,Tipo_Cuenta_Descripcion,Tipo_Cuenta_Costo_Creacion,Tipo_Cuenta_Costo_Modificacion,Tipo_Cuenta_Costo_Transf,Tipo_Cuenta_Duracion)
VALUES(1,'Oro',500,500,20,360),(2,'Plata',400,400,10,160),
		(3,'BRONCE',300,300,5,80),(4,'Gratuita',0,0,0,80);

SET IDENTITY_INSERT GEM4.Tipo_Cuenta OFF;

INSERT INTO GEM4.Emisor(Emisor_Descripcion)
SELECT DISTINCT Tarjeta_Emisor_Descripcion
FROM gd_esquema.Maestra
WHERE Tarjeta_Emisor_Descripcion IS NOT NULL;


SET IDENTITY_INSERT GEM4.Estado_Cuenta ON;
INSERT INTO GEM4.Estado_Cuenta(Estado_Codigo,Estado_Descripcion)
VALUES(1,'HABILITADA'),(2,'INHABILITADA'),(3,'CERRADA'),(4,'PENDIENTE ACTIVACION');
SET IDENTITY_INSERT GEM4.Estado_Cuenta OFF;

GO
CREATE PROCEDURE GEM4.spInsertaOperaciones 
AS
BEGIN
	DECLARE @nFactura NUMERIC(18,0), @nOperacion INT,@clienteID INT,
			@clienteMail NVARCHAR(255),@depositoCodigo NUMERIC(18,0),
			@depositoFecha DATETIME,@depositoImporte NUMERIC(18,2),
			@tarjeta NVARCHAR(16),@cuentaNumero NUMERIC(18,0),@usuarioID INT,
			@retiroCodigo NUMERIC(18,0),@retiroFecha DATETIME,@retiroImporte NUMERIC(18,2),
			@chequeNumero NUMERIC(18,0),@chequeFecha DATETIME,@chequeImporte NUMERIC(18,2),@banco NUMERIC(18,0),
			@transfFecha DATETIME,@transfImporte NUMERIC(18,2),@transfCosto NUMERIC(18,2),
			@cuentaDestino NUMERIC(18,0);
	
	

	DECLARE Cursor1 CURSOR FOR
	SELECT DISTINCT Factura_Numero,Cli_Mail,Retiro_Codigo,Retiro_Fecha,Retiro_Importe,
					Cuenta_Numero,Cheque_Numero,Cheque_Fecha,Cheque_Importe,Banco_Cogido,
					Deposito_Codigo,Deposito_Fecha,Deposito_Importe,Tarjeta_Numero,
					Transf_Fecha,Trans_Importe,Trans_Costo_Trans,Cuenta_Dest_Numero
	FROM gd_esquema.Maestra
	ORDER BY Deposito_Fecha asc,Retiro_Fecha asc,Transf_Fecha asc ;

	    OPEN Cursor1;
	FETCH NEXT FROM Cursor1 INTO @nFactura,@clienteMail,@retiroCodigo,@retiroFecha,@retiroImporte,@cuentaNumero,
								@chequeNumero,@chequeFecha,@chequeImporte,@banco,@depositoCodigo,@depositoFecha,
								 @depositoImporte,@tarjeta,@transfFecha,@transfImporte,@transfCosto,@cuentaDestino;
	SET @nOperacion=1;
    
    BEGIN TRANSACTION;
    WHILE @@FETCH_STATUS = 0
		BEGIN
		
			SELECT @clienteID=c.Cliente_ID
			FROM Cliente c
			WHERE c.Cliente_Mail=@clienteMail;
		
			SELECT @usuarioID=u.Usuario_ID
			FROM GEM4.Usuario u
			WHERE u.Cliente_ID=@clienteID;
	
		IF(@depositoCodigo IS NOT NULL)
			BEGIN
				SET IDENTITY_INSERT GEM4.Operacion ON;
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID)
											--Operacion_Costo,--Factura_Numero)
				VALUES(@nOperacion,1,GEM4.fnValidarFecha(@depositoFecha),@usuarioID);--,0,@nFactura);
				SET IDENTITY_INSERT GEM4.Operacion OFF;
				
				SET IDENTITY_INSERT GEM4.Deposito ON;
				INSERT INTO GEM4.Deposito(Deposito_Codigo,Deposito_Fecha,Deposito_Importe,
									  Deposito_Cliente,Deposito_Tarjeta,
									  Deposito_Cuenta,Deposito_Operacion_ID)
				VALUES(@depositoCodigo,GEM4.fnValidarFecha(@depositoFecha),@depositoImporte,@clienteID,@tarjeta,@cuentaNumero,@nOperacion);
				SET IDENTITY_INSERT GEM4.Deposito OFF;
				
				UPDATE GEM4.Cuenta
				SET Cuenta_Saldo=Cuenta_Saldo + @depositoImporte
				WHERE Cuenta_Numero=@cuentaNumero
				
				
			END;	
		IF(@retiroCodigo IS NOT NULL)
			BEGIN
				
				SET IDENTITY_INSERT GEM4.Operacion ON;
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID)
											--Operacion_Costo,Factura_Numero)
				VALUES(@nOperacion,2,GEM4.fnValidarFecha(@retiroFecha),@usuarioID);--0,@nFactura)
				SET IDENTITY_INSERT GEM4.Operacion OFF;
				
				SET IDENTITY_INSERT GEM4.Cheque ON; 
				INSERT INTO GEM4.Cheque(Cheque_Numero,Cheque_Fecha,Cheque_Importe,Cheque_Cliente_ID,Cheque_Banco)
				VALUES(@chequeNumero,GEM4.fnValidarFecha(@chequeFecha),@chequeImporte,@clienteID,@banco);
				SET IDENTITY_INSERT GEM4.Cheque OFF;
				
				SET IDENTITY_INSERT GEM4.Retiro ON;
				INSERT INTO GEM4.Retiro(Retiro_Codigo,Retiro_Importe,Retiro_Fecha,Retiro_Cheque,Operacion_ID,Retiro_Cuenta)
				VALUES(@retiroCodigo,@retiroImporte,GEM4.fnValidarFecha(@retiroFecha),@chequeNumero,@nOperacion,@cuentaNumero);
				SET IDENTITY_INSERT GEM4.Retiro OFF;
				
				UPDATE GEM4.Cuenta
				SET Cuenta_Saldo=Cuenta_Saldo - @retiroImporte
				WHERE Cuenta_Numero=@cuentaNumero
				 
			END;
		IF(@cuentaDestino IS NOT NULL)
			BEGIN
				IF(@cuentaDestino=@cuentaNumero)
					BEGIN
							SET @transfCosto=0
					END
				ELSE
					BEGIN
						SELECT @transfCosto=c.Tipo_Cuenta_Costo_Transf
						FROM GEM4.Tipo_Cuenta c
						WHERE c.Tipo_Cuenta_ID=1;
					END;
				
				SET IDENTITY_INSERT GEM4.Operacion ON;
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID)
											--Operacion_Costo,Factura_Numero)
				VALUES(@nOperacion,3,GEM4.fnValidarFecha(@retiroFecha),@usuarioID)--,0,@nFactura);
				SET IDENTITY_INSERT GEM4.Operacion OFF;
				
				INSERT INTO GEM4.Transferencia(Transferencia_Fecha,Transferencia_Importe,Transferencia_Costo_Trans
											,Transferencia_Cuenta_Origen,Transferencia_Cuenta_Destino,Transferencia_Operacion_ID)
				VALUES(GEM4.fnValidarFecha(@transfFecha),@transfImporte,@transfCosto,@cuentaNumero,@cuentaDestino,@nOperacion);
				
				UPDATE GEM4.Cuenta
				SET Cuenta_Saldo=Cuenta_Saldo - @transfImporte -- -@transfCosto
				WHERE Cuenta_Numero=@cuentaNumero;
				
				UPDATE GEM4.Cuenta
				SET Cuenta_Saldo=Cuenta_Saldo + @transfImporte 
				WHERE Cuenta_Numero=@cuentaDestino;
				
			END;	
		SET @nOperacion=@nOperacion+1;				
		FETCH NEXT FROM Cursor1 INTO @nFactura,@clienteMail,@retiroCodigo,@retiroFecha,@retiroImporte,@cuentaNumero,
								@chequeNumero,@chequeFecha,@chequeImporte,@banco,@depositoCodigo,@depositoFecha,
								 @depositoImporte,@tarjeta,@transfFecha,@transfImporte,@transfCosto,@cuentaDestino;
	END;
	CLOSE Cursor1;
DEALLOCATE Cursor1;
	IF @@ERROR=0
		BEGIN
			COMMIT TRANSACTION;
		END
	ELSE
		BEGIN
			ROLLBACK TRANSACTION;
		END;
END;
GO

/* No pude inicializar la tabla Operaciones_Facturables debido a que con la información que contamos 
	tanto en la tabla maestra como luego en la migración es imposible identificar a que operación le corresponde que factura.
	La única forma de identificar esto sería usando el mismo cursor ue queremos sacar, porque no nos alcanza con saber
	el cliente que realizó la op, la fecha y el importe, porque en muchos casos estos datos son idénticos para cada
	registro.

Una opción sería incluir en a factura el campo calculado TOTAL, y acotar el error lo más posible ya ue conoceríamos
Cliente que realizó la operación y el importe total para relacionar.

INSERT INTO GEM4.Operaciones_Facturables(Operacion_Facturable_Operacion_ID,Operacion_Facturable_Factura_Numero,Operacion_Facturable_Costo)
SELECT DISTINCT o.Operacion_ID,f.Factura_Numero,t.Tipo_Operacion_Importe 
FROM GEM4.Operacion o join GEM4.Tipo_Operacion t on(o.Operacion_Tipo =t.Tipo_Operacion_ID) Right join GEM4.Factura f on (o.Operacion_Usuario_ID = (select top 1 u.Usuario_ID FROM GEM4.Usuario u WHERE u.Cliente_ID = f.Factura_Cliente_ID))
*/


/*	****************************************	MIGRACION 	******************************************* */

SET IDENTITY_INSERT GEM4.Pais ON;
INSERT INTO GEM4.Pais(Pais_Cod, Pais_Descripcion)
(SELECT DISTINCT Cuenta_Dest_Pais_Codigo, Cuenta_Dest_Pais_Desc
FROM gd_esquema.Maestra 
WHERE Cuenta_Dest_Pais_Codigo IS NOT NULL

UNION
SELECT DISTINCT Cli_Pais_Codigo, Cli_Pais_Desc
FROM gd_esquema.Maestra
WHERE Cli_Pais_Codigo IS NOT NULL);
SET IDENTITY_INSERT GEM4.Pais OFF;

SET IDENTITY_INSERT GEM4.Documento ON;
INSERT INTO GEM4.Documento(Documento_Tipo_Codigo,Documento_Tipo_Descripcion)
SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc
FROM gd_esquema.Maestra;
SET IDENTITY_INSERT GEM4.Documento OFF;

INSERT INTO GEM4.Cliente(Cliente_Pais, Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc,Cliente_Numero_Documento ,Cliente_Dom_Calle, Cliente_Dom_Numero, Cliente_Dom_Piso, Cliente_Dom_Depto, Cliente_Fecha_Nacimiento, Cliente_Mail)
SELECT DISTINCT Cli_Pais_Codigo, Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod,Cli_Nro_Doc ,Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Fecha_Nac, Cli_Mail
FROM gd_esquema.Maestra

INSERT INTO GEM4.Usuario(Usuario_Username, Usuario_Contrasena, Usuario_Fecha_Creacion, Usuario_Fecha_Ultima_Modificacion, Cliente_ID)
SELECT Cliente_Nombre +'.'+ Cliente_Apellido, '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c=', GEM4.fnDevolverFechaSistema(), GEM4.fnDevolverFechaSistema(), Cliente_ID
FROM GEM4.Cliente

INSERT INTO GEM4.Usuario_Por_Rol(Usuario_ID,Rol_Cod)
SELECT Usuario_ID, 2
FROM GEM4.Usuario
WHERE Usuario_ID > 3

INSERT INTO GEM4.Tarjeta(Tarjeta_Numero,Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,Tarjeta_Codigo_Seg,
						 Tarjeta_Emisor,Tarjeta_Cliente_ID)
SELECT DISTINCT m.Tarjeta_Numero,GEM4.fnValidarFecha(m.Tarjeta_Fecha_Emision),m.Tarjeta_Fecha_Vencimiento,m.Tarjeta_Codigo_Seg,
	   GEM4.fnInsertarCodigoDeEmisor(m.Tarjeta_Emisor_Descripcion),c.Cliente_ID
FROM gd_esquema.Maestra m JOIN  GEM4.Cliente c ON (m.Cli_Mail=c.Cliente_Mail AND m.Cli_Apellido=c.Cliente_Apellido)
WHERE m.Tarjeta_Numero IS NOT NULL



SET IDENTITY_INSERT GEM4.Banco ON;
INSERT INTO GEM4.Banco(Banco_Codigo,Banco_Direccion,Banco_Nombre)
SELECT DISTINCT m.Banco_Cogido,m.Banco_Direccion,m.Banco_Nombre
FROM gd_esquema.Maestra m
WHERE m.Banco_Cogido IS NOT NULL;
SET IDENTITY_INSERT GEM4.Banco OFF;

SET IDENTITY_INSERT GEM4.Cuenta ON;
INSERT INTO GEM4.Cuenta(Cuenta_Numero,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,Cuenta_Pais,Cuenta_Cliente_ID)
SELECT	DISTINCT m.Cuenta_Numero,GEM4.fnValidarFecha(m.Cuenta_Fecha_Creacion),m.Cuenta_Fecha_Cierre,m.Cuenta_Pais_Codigo,c.Cliente_ID
FROM gd_esquema.Maestra m JOIN GEM4.Cliente c ON (m.Cli_Mail=c.Cliente_Mail)
WHERE M.Cuenta_Numero IS NOT NULL
SET IDENTITY_INSERT GEM4.Cuenta OFF;

/*AGREGO FECHAS DE COMPRA DE SUSCRIPCION*/
UPDATE GEM4.Cuenta
SET Cuenta_Suscripciones_Fecha = SYSDATETIME(); --tiene esta fecha por ahora, despues vemos la fecha de que ponerle

--NUEVA MIGRACIÓN
--DEPOSITO

SET IDENTITY_INSERT GEM4.Deposito ON
INSERT INTO GEM4.Deposito(Deposito_Codigo,Deposito_Fecha,Deposito_Importe,
									  Deposito_Cliente,Deposito_Tarjeta,
									  Deposito_Cuenta)
SELECT DISTINCT  M.Deposito_Codigo,M.Deposito_Fecha,M.Deposito_Importe,c.Cliente_ID,
					M.Tarjeta_Numero,M.Cuenta_Numero
	FROM gd_esquema.Maestra M JOIN GEM4.Cliente C ON(M.Cli_Mail = C.Cliente_Mail)
	WHERE M.Deposito_Codigo IS NOT NULL
	ORDER BY Deposito_Fecha asc
SET IDENTITY_INSERT GEM4.Deposito OFF	

INSERT INTO GEM4.Operacion(Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID)
	
	SELECT DISTINCT 1, D.Deposito_Fecha, U.Usuario_ID
	FROM GEM4.Deposito D JOIN GEM4.Usuario U ON(D.Deposito_Cliente = U.Cliente_ID)								
	ORDER BY Deposito_Fecha asc				

UPDATE GEM4.Deposito
SET Deposito_Fecha = GEM4.fnDevolverFechaSistema()
WHERE ((Deposito_Fecha IS NULL)OR(Deposito_Fecha > GETDATE()))

UPDATE GEM4.Deposito
SET Deposito_Operacion_ID = Deposito_Codigo
WHERE Deposito_Operacion_ID IS NULL

UPDATE GEM4.Cuenta
SET Cuenta_Saldo = (SELECT SUM(D.Deposito_Importe) FROM GEM4.Deposito D WHERE D.Deposito_Cuenta = GEM4.Cuenta.Cuenta_Numero)
WHERE Cuenta_Saldo IS NULL
					
