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

--TABLA NUEVA NO IMPLEMENTADA	
/*
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Operaciones_Facturables')	
	DROP TABLE GEM4.Operaciones_Facturables; 
*/
	
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
	PRIMARY KEY(Factura_Numero),
	-----> 	Le agregaría una FK de Cliente_ID y Cuenta_Nro, de ahi tengo acceso a todos los datos del Cliente y sus Cuentas.
	)


CREATE TABLE GEM4.Tipo_Operacion(
	Tipo_Operacion_ID						INT IDENTITY(1,1),
	Tipo_Operacion_Descripcion				NVARCHAR(255),
	
	PRIMARY KEY(Tipo_Operacion_ID)
	)

/* NUEVA TABLA (A IMPLEMENTAR)

CREATE TABLE GEM4.Tipo_Operacion(
	Tipo_Operacion_ID						INT IDENTITY(1,1),
	Tipo_Operacion_Descripcion				NVARCHAR(255),
	Tipo_Operacion_Descripcion_Costeo		NVARCHAR(255), --Que sería este item?
	Tipo_Operacion_Importe					NUMERIC(18,2)
	PRIMARY KEY(Tipo_Operacion_ID)
	)
	
	*/
	
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
	
/* NUEVA TABLA (A IMPLEMENTAR)

CREATE TABLE GEM4.Operacion(
	Operacion_ID						INT IDENTITY(1,1),
	Operacion_Tipo						INT,
	Operacion_Fecha						DATETIME,
	Operacion_Usuario_ID				INT,
	PRIMARY KEY(Operacion_ID),
	FOREIGN KEY(Operacion_Tipo) REFERENCES GEM4.Tipo_Operacion(Tipo_Operacion_ID),
	FOREIGN KEY(Operacion_Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	)
	*/

/* NUEVA TABLA  (TABLA INTERMEDIA)

CREATE TABLE GEM4.Operaciones_Facturables(
	Operacion_Facturable_Cod				INT IDENTITY(1,1),
	Operacion_Facturable_Operacion_ID		INT,
	Operacion_Facturable_Factura_Numero		NUMERIC(18,0), -- aca le agregaría un item 'DESCRIPCION DETALLADA' o algo por el estilo que muestra  directamente lo que iria en la factura, tipo [Apertura de cuenta 122422313234]
	Operacion_Facturable_Costo				NUMERIC(18,2)
	PRIMARY KEY(Operacion_Facturable_Cod),
	FOREIGN KEY(Operacion_Facturable_Factura_Numero) REFERENCES GEM4.Factura(Factura_Numero),
	FOREIGN KEY(Operacion_Facturable_Operacion_ID) REFERENCES GEM4.Operacion(Operacion_ID),
	)
	
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
	FOREIGN KEY(Transferencia_Operacion_ID)	REFERENCES	GEM4.Operacion(Operacion_ID)
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


IF EXISTS (SELECT id FROM sys.sysobjects WHERE name='fnValidarRetiro')
	DROP FUNCTION GEM4.fnValidarRetiro
GO

CREATE FUNCTION GEM4.fnValidarRetiro(@nroDoc INT,@tipoDoc INT,@clienteID INT,@cuentaID NUMERIC(18,0),@importe NUMERIC(18,0))
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
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID,
											Operacion_Costo,Factura_Numero)
				VALUES(@nOperacion,1,GEM4.fnValidarFecha(@depositoFecha),@usuarioID,0,@nFactura);
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
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID,
											Operacion_Costo,Factura_Numero)
				VALUES(@nOperacion,2,GEM4.fnValidarFecha(@retiroFecha),@usuarioID,0,@nFactura);
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
				INSERT INTO GEM4.Operacion(Operacion_ID,Operacion_Tipo,Operacion_Fecha,Operacion_Usuario_ID,
											Operacion_Costo,Factura_Numero)
				VALUES(@nOperacion,3,GEM4.fnValidarFecha(@retiroFecha),@usuarioID,0,@nFactura);
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


SET IDENTITY_INSERT GEM4.Factura ON;
INSERT INTO GEM4.Factura(Factura_Numero,Factura_Fecha)
SELECT DISTINCT m.Factura_Numero,GEM4.fnValidarFecha(m.Factura_Fecha)
FROM gd_esquema.Maestra m
WHERE M.Factura_Numero IS NOT NULL;
SET IDENTITY_INSERT GEM4.Factura OFF;

SET IDENTITY_INSERT GEM4.Cuenta ON;
INSERT INTO GEM4.Cuenta(Cuenta_Numero,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,Cuenta_Pais,Cuenta_Cliente_ID)
SELECT	DISTINCT m.Cuenta_Numero,GEM4.fnValidarFecha(m.Cuenta_Fecha_Creacion),m.Cuenta_Fecha_Cierre,m.Cuenta_Pais_Codigo,c.Cliente_ID
FROM gd_esquema.Maestra m JOIN GEM4.Cliente c ON (m.Cli_Mail=c.Cliente_Mail)
WHERE M.Cuenta_Numero IS NOT NULL
SET IDENTITY_INSERT GEM4.Cuenta OFF;

/*AGREGO FECHAS DE COMPRA DE SUSCRIPCION*/
UPDATE GEM4.Cuenta
SET Cuenta_Suscripciones_Fecha = SYSDATETIME(); --tiene esta fecha por ahora, despues vemos la fecha de que ponerle

EXEC GEM4.spInsertaOperaciones
GO
/* ******************************************TRIGGERS************************************************************ */
IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'tgModificacionUsuario')
	DROP PROCEDURE GEM4.tgModificacionUsuario;
GO

CREATE TRIGGER GEM4.tgModificacionUsuario
ON  GEM4.Usuario 
FOR UPDATE
AS
	BEGIN
		DECLARE @usuarioID INT,@usuarioHab BIT,@cliente INT,
				@username NVARCHAR(30),@pass CHAR(44),
				@fechaCreacion	DATETIME,@pregSecreta NVARCHAR(60),
				@respSecreta NVARCHAR(60),@habilitado BIT,@cuentaEstado TINYINT;
		
		SELECT @usuarioID=Usuario_ID,@usuarioHab=Usuario_Habilitado,
				@cliente=Cliente_ID,@habilitado=Usuario_Habilitado
		FROM inserted;
		
		UPDATE GEM4.Cliente
		SET	Cliente_Habilitado=@habilitado
		WHERE Cliente_ID=@cliente;
		
		IF(@habilitado=0)
		BEGIN
			SET	@cuentaEstado=2;
		UPDATE GEM4.Cuenta
			SET	Cuenta_Estado=@cuentaEstado
		WHERE Cuenta_Cliente_ID=@cliente;
		
		END;
		
		
		
	END
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'tgActualizaRol')
	DROP TRIGGER GEM4.tgActualizaRol;
GO

-- Creo que no lo necesito
/*
CREATE TRIGGER GEM4.tgActualizaRol
ON GEM4.Rol
FOR UPDATE
AS
	BEGIN
		DECLARE @rolCod INT	,@habilitado BIT;
		
		SELECT @rolCod=Rol_Cod,@habilitado=Rol_Habilitado
		FROM inserted;
		
		UPDATE GEM4.Rol_Por_Funcionalidad
		SET Rol_Por_Funcionalidad_Habilitado=@habilitado
		WHERE Rol_Cod=@rolCod;
		
	END		
GO
*/

/* ***************************************** STORED PROCEDURES ************************************************** */

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spLoginUsuario')
	DROP PROCEDURE GEM4.spLoginUsuario;
GO
CREATE PROCEDURE GEM4.spLoginUsuario
    @usuario nvarchar(30), 
    @pass char(44) 
AS 
    SELECT Rol_Cod
		FROM GEM4.Usuario JOIN GEM4.Usuario_Por_Rol ON (Usuario.Usuario_ID = Usuario_Por_Rol.Usuario_ID)
		WHERE Usuario_Username = @usuario AND Usuario_Contrasena = @pass AND Usuario_Habilitado = 1;
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCantidadRoles')
	DROP PROCEDURE GEM4.spCantidadRoles;
GO
CREATE PROCEDURE GEM4.spCantidadRoles
	@usuario NVARCHAR(30)
AS
	SELECT COUNT(Usuario_Por_Rol.Usuario_ID) CantidadRoles
	FROM GEM4.Usuario_Por_Rol JOIN GEM4.Usuario ON (Usuario.Usuario_ID = Usuario_Por_Rol.Usuario_ID)
	WHERE Usuario.Usuario_Username = @usuario AND Habilitado = 1
	GROUP BY Usuario_Por_Rol.Usuario_ID
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerRoles')
	DROP PROCEDURE GEM4.spObtenerRoles;
GO
CREATE PROCEDURE GEM4.spObtenerRoles
AS
	SELECT Rol_Nombre, Rol_Cod
	FROM GEM4.Rol
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerFuncionalidades')
	DROP PROCEDURE GEM4.spObtenerFuncionalidades;
GO
CREATE PROCEDURE GEM4.spObtenerFuncionalidades
	@rol_cod	TINYINT
AS
	SELECT Funcionalidad_Descripcion
	FROM GEM4.Funcionalidad JOIN GEM4.Rol_Por_Funcionalidad ON (Funcionalidad.Funcionalidad_Cod = Rol_Por_Funcionalidad.Funcionalidad_Cod)
	WHERE Rol_Por_Funcionalidad.Rol_Cod = @rol_cod AND Rol_Por_Funcionalidad_Habilitado=1
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spInhabilitarUsuario')
	DROP PROCEDURE GEM4.spInhabilitarUsuario;
GO
CREATE PROCEDURE GEM4.spInhabilitarUsuario
	@username	NVARCHAR(30)
AS
	UPDATE GEM4.Usuario
	SET Usuario_Habilitado = 0,
		Usuario_Fecha_Ultima_Modificacion=GETDATE()
	WHERE Usuario_Username = @username
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spLogLogin')
	DROP PROCEDURE GEM4.spLogLogin
GO
CREATE PROCEDURE GEM4.spLogLogin
	@username	NVARCHAR(30),
	@incorrecto	BIT,
	@nIntento	TINYINT
AS
	DECLARE @usuarioID INT
	SET @usuarioID = (SELECT Usuario_ID FROM Usuario WHERE Usuario_Username = @username)
	INSERT INTO GEM4.Log_Login (Log_Login_Usuario_ID, Log_Login_Fecha, Log_Login_Incorrecto, Log_Login_NIntento) VALUES
		(@usuarioID, GETDATE(), @incorrecto, @nIntento)
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerDatosUsuario')
	DROP PROCEDURE GEM4.spObtenerDatosUsuario
GO
CREATE PROCEDURE GEM4.spObtenerDatosUsuario
	@username	NVARCHAR(30)
AS
	SELECT Usuario_ID, Usuario_Username, Usuario_Fecha_Creacion, Usuario_Fecha_Ultima_Modificacion, Usuario_Habilitado, Usuario_Contrasena, Usuario_Pregunta_Secreta, Usuario_Respuesta_Secreta
	FROM GEM4.Usuario
	WHERE Usuario_Username LIKE '%'+@username+'%'
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spBajaLogicaUsuario')
	DROP PROCEDURE GEM4.spBajaLogicaUsuario
GO
CREATE PROCEDURE GEM4.spBajaLogicaUsuario
	@usuarioID	INT
AS
	UPDATE GEM4.Usuario
	SET Usuario_Habilitado = 0,
		Usuario_Fecha_Ultima_Modificacion=GETDATE() 
	WHERE Usuario_ID = @usuarioID
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spBuscarRoles')
	DROP PROCEDURE GEM4.spBuscarRoles
GO

CREATE PROCEDURE GEM4.spBuscarRoles
	@rol_cod	INT,
	@rol_nombre NVARCHAR(50)
AS
	SELECT r.Rol_Cod,r.Rol_Nombre,r.Rol_Habilitado	
	FROM GEM4.Rol r
	WHERE (@Rol_Cod ='' OR @Rol_Cod =r.Rol_Cod)
	AND (@Rol_Nombre='' OR r.Rol_Nombre like @Rol_Nombre+'%' )
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerFuncionalidadesAsignables')
	DROP PROCEDURE GEM4.spObtenerFuncionalidadesAsignables
GO

CREATE PROCEDURE GEM4.spObtenerFuncionalidadesAsignables
AS
	SELECT F.Funcionalidad_Descripcion,F.Funcionalidad_Cod
	FROM GEM4.Funcionalidad F
	WHERE F.Funcionalidad_Habilitada= 1
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCambiarHabilitacionUsuario')
	DROP PROCEDURE GEM4.spCambiarHabilitacionUsuario
GO

CREATE PROCEDURE GEM4.spCambiarHabilitacionUsuario
	@estado BIT,
	@usuarioID INT
AS
	UPDATE GEM4.Usuario
	SET Usuario_Habilitado = @estado,
		Usuario_Fecha_Ultima_Modificacion=GETDATE() 
	WHERE Usuario_ID = @usuarioID
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spAgregarFuncionalidadARol')
	DROP PROCEDURE GEM4.spAgregarFuncionalidadARol;
go
CREATE PROCEDURE GEM4.spAgregarFuncionalidadARol
    @Rol_Nombre			NVARCHAR(50),
    @Funcionalidad_Cod	TINYINT,
    @Funcionalidad_Hab	BIT
AS 
	UPDATE GEM4.Rol_Por_Funcionalidad
		SET Rol_Por_Funcionalidad_Habilitado = @Funcionalidad_Hab
		WHERE Rol_Cod = (SELECT Rol_Cod FROM GEM4.ROL WHERE Rol_Nombre =@Rol_Nombre)
			AND Funcionalidad_Cod = @Funcionalidad_Cod;
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCrearRol')
	DROP PROCEDURE GEM4.spCrearRol;
GO

CREATE PROCEDURE GEM4.spCrearRol
    @Rol_Nombre			NVARCHAR(50),
    @Rol_Habilitado			BIT
AS 
	INSERT INTO GEM4.Rol(Rol_Nombre,Rol_Habilitado)
		VALUES (@Rol_Nombre,@Rol_Habilitado);
	
	INSERT INTO GEM4.Rol_Por_Funcionalidad (Funcionalidad_Cod,Rol_Cod,Rol_Por_Funcionalidad_Habilitado)
		SELECT Funcionalidad_Cod,Rol_Cod,0
			FROM GEM4.Rol,GEM4.Funcionalidad
			WHERE Rol_Nombre=@Rol_Nombre;
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCambiarContraseña')
	DROP PROCEDURE GEM4.spCambiarContraseña;
GO

CREATE PROCEDURE GEM4.spCambiarContraseña
	@usuarioID		INT,
	@nuevaPass		CHAR(44)
AS
	UPDATE GEM4.Usuario
	SET Usuario_Contrasena = @nuevaPass,
	Usuario_Fecha_Ultima_Modificacion=GETDATE()
	WHERE Usuario_ID = @usuarioID
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCambiarPreguntaSecreta')
	DROP PROCEDURE GEM4.spCambiarPreguntaSecreta;
GO

CREATE PROCEDURE GEM4.spCambiarPreguntaSecreta
	@usuarioID		INT,
	@nuevaPreg		NVARCHAR(60),
	@nuevaResp		NVARCHAR(60)
AS
	UPDATE GEM4.Usuario
	SET Usuario_Pregunta_Secreta = @nuevaPreg,
		Usuario_Respuesta_Secreta = @nuevaResp,
		Usuario_Fecha_Ultima_Modificacion=GETDATE()
	WHERE Usuario_ID = @usuarioID
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerRolesParaUsuario')
	DROP PROCEDURE GEM4.spObtenerRolesParaUsuario;
GO
CREATE PROCEDURE GEM4.spObtenerRolesParaUsuario
	@usuarioID		INT
AS
	SELECT Rol.Rol_Nombre, Rol.Rol_Cod
	FROM GEM4.Rol JOIN GEM4.Usuario_Por_Rol ON (Rol.Rol_Cod = Usuario_Por_Rol.Rol_Cod)
	WHERE Usuario_ID = @usuarioID AND Habilitado = 1
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spAgregarRolAUsuario')
	DROP PROCEDURE GEM4.spAgregarRolAUsuario;
GO
CREATE PROCEDURE GEM4.spAgregarRolAUsuario
	@usuarioID		INT,
	@rolCod			INT
AS
	INSERT INTO GEM4.Usuario_Por_Rol(Usuario_ID, Rol_Cod, Habilitado) VALUES
		(@usuarioID, @rolCod, 1)
GO	

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spModificarRolAUsuario')
	DROP PROCEDURE GEM4.spModificarRolAUsuario;
GO
CREATE PROCEDURE GEM4.spModificarRolAUsuario
	@usuarioID		INT,
	@viejoRolCod	INT,
	@nuevoRolCod	INT
AS
	UPDATE GEM4.Usuario_Por_Rol
	SET Rol_Cod = @nuevoRolCod
	WHERE Usuario_ID = @usuarioID AND Rol_Cod = @viejoRolCod
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spEliminarRolAUsuario')
	DROP PROCEDURE GEM4.spEliminarRolAUsuario;
GO
CREATE PROCEDURE GEM4.spEliminarRolAUsuario
	@usuarioID		INT,
	@rolCod			INT
AS
	UPDATE GEM4.Usuario_Por_Rol
	SET Habilitado = 0
	WHERE Usuario_ID = @usuarioID AND Rol_Cod = @rolCod
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spAltaUsuario')
	DROP PROCEDURE GEM4.spAltaUsuario;
GO
CREATE PROCEDURE GEM4.spAltaUsuario
	@username		NVARCHAR(30),
	@contraseña		CHAR(44),
	@rolCod			INT,
	@pregSec		NVARCHAR(60),
	@respSec		NVARCHAR(60),
	@clienteID		INT
AS
	IF @clienteID = -1
	BEGIN
		SET @clienteID = NULL
	END
	INSERT INTO GEM4.Usuario(Usuario_Username, Usuario_Contrasena, Usuario_Pregunta_Secreta, Usuario_Respuesta_Secreta, Usuario_Fecha_Creacion, Usuario_Fecha_Ultima_Modificacion, Cliente_ID) VALUES
		(@username, @contraseña, @pregSec, @respSec, SYSDATETIME(), SYSDATETIME(), @clienteID);
	DECLARE @usuarioID INT
	SET @usuarioID = (SELECT Usuario_ID FROM GEM4.Usuario WHERE Usuario_Username = @username)
	INSERT INTO GEM4.Usuario_Por_Rol(Usuario_ID, Rol_Cod, Habilitado) VALUES
		(@usuarioID, @rolCod, 1);
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spUsuarioExiste')
	DROP PROCEDURE GEM4.spUsuarioExiste;
GO
CREATE PROCEDURE GEM4.spUsuarioExiste
	@username		NVARCHAR(30)
AS
	SELECT COUNT(Usuario_Username) FROM GEM4.Usuario WHERE Usuario_Username = @username
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerDatosCuenta')
	DROP PROCEDURE GEM4.spObtenerDatosCuenta
GO
CREATE PROCEDURE GEM4.spObtenerDatosCuenta
	@numeroCuenta	BIGINT,
	@clienteID		INT
AS
	SELECT Cuenta_Numero, Cuenta_Cliente_ID, Cuenta_Fecha_Creacion, Cuenta_Fecha_Cierre, Cuenta_Saldo, Cuenta_Tipo, Cuenta_Suscripciones_Compradas, Cuenta_Suscripciones_Fecha, Cuenta_Estado, Cuenta_Moneda, Cuenta_Pais
	FROM GEM4.Cuenta_ABM
	WHERE Cuenta_Cliente_ID = @clienteID OR Cuenta_Numero = @numeroCuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'sphabilitarODeshabilitarRol')
	DROP PROCEDURE GEM4.sphabilitarODeshabilitarRol;
go
CREATE PROCEDURE GEM4.sphabilitarODeshabilitarRol
    @Rol_Cod			INT,
    @Rol_Habilitado		BIT
AS 
	UPDATE GEM4.Rol
		SET Rol_Habilitado=@Rol_Habilitado
		WHERE @Rol_Cod  = Rol_Cod
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerNumeroCliente')
	DROP PROCEDURE GEM4.spObtenerNumeroCliente;
GO
CREATE PROCEDURE GEM4.spObtenerNumeroCliente
	@username			NVARCHAR(30)
AS
	SELECT Cliente_ID
	FROM GEM4.Usuario
	WHERE Usuario_Username = @username
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerPaises')
	DROP PROCEDURE GEM4.spObtenerPaises;
GO
CREATE PROCEDURE GEM4.spObtenerPaises
AS
	SELECT Pais_Descripcion, Pais_Cod
	FROM GEM4.Pais
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerMonedas')
	DROP PROCEDURE GEM4.spObtenerMonedas;
GO
CREATE PROCEDURE GEM4.spObtenerMonedas
AS
	SELECT Moneda_Descripcion, Moneda_Codigo
	FROM GEM4.Moneda
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerTipoCuentas')
	DROP PROCEDURE GEM4.spObtenerTipoCuentas;
GO
CREATE PROCEDURE GEM4.spObtenerTipoCuentas
AS
	SELECT Tipo_Cuenta_Descripcion, Tipo_Cuenta_ID
	FROM GEM4.Tipo_Cuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spAltaCuenta')
	DROP PROCEDURE GEM4.spAltaCuenta;
GO
CREATE PROCEDURE GEM4.spAltaCuenta
	@clienteID		INT,
	@codPais		INT,
	@codMoneda		INT,
	@tipoCuenta		INT
AS
	INSERT INTO GEM4.Cuenta(Cuenta_Cliente_ID, Cuenta_Pais, Cuenta_Moneda, Cuenta_Tipo, Cuenta_Fecha_Creacion, Cuenta_Estado, Cuenta_Saldo, Cuenta_Suscripciones_Compradas, Cuenta_Suscripciones_Fecha) VALUES
		(@clienteID, @codPais, @codMoneda, @tipoCuenta, SYSDATETIME(), 4, 0, 0, NULL)
	
	 
		
		SELECT TOP 1 Cuenta_Numero 
		FROM GEM4.Cuenta 
		WHERE Cuenta_Cliente_ID = @clienteID 
		ORDER BY Cuenta_Fecha_Creacion DESC
	
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spBuscarClientes')
	DROP PROCEDURE GEM4.spBuscarClientes;
GO

CREATE PROCEDURE GEM4.spBuscarClientes
	@nombreCliente		NVARCHAR(255),
	@apellidoCliente	NVARCHAR(255),
	@tipoDoc			NVARCHAR(255),
	@nroDoc				VARCHAR(255),
	@mail				NVARCHAR(255)
AS
	

	
	SELECT *
	FROM GEM4.Cliente c
	WHERE (@nombreCliente='' OR c.Cliente_Nombre LIKE @nombreCliente+'%')
		   AND(@apellidoCliente='' OR c.Cliente_Apellido LIKE @apellidoCliente+'%')
		   AND (@tipoDoc='' OR CONVERT(numeric(18, 2),@tipoDoc)=c.Cliente_Tipo_Doc)
		   AND (@nroDoc=''OR /*(CONVERT(numeric(18, 2),@nroDoc)=c.Cliente_Numero_Documento)OR*/ c.Cliente_Numero_Documento LIKE @nroDoc+'%')
		   AND (@mail='' OR c.Cliente_Mail LIKE @mail+'%');
			

GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerTiposDoc')
	DROP PROCEDURE GEM4.spObtenerTiposDoc;
GO

CREATE PROCEDURE GEM4.spObtenerTiposDoc

AS
	
	SELECT Documento_Tipo_Codigo,Documento_Tipo_Descripcion
	FROM GEM4.Documento;
	
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerFuncionesHabilitadasPorRol')
	DROP PROCEDURE GEM4.spObtenerFuncionesHabilitadasPorRol;
GO
CREATE PROCEDURE GEM4.spObtenerFuncionesHabilitadasPorRol
	@rol_cod	TINYINT
AS
	SELECT Funcionalidad.Funcionalidad_Cod
	FROM GEM4.Funcionalidad JOIN GEM4.Rol_Por_Funcionalidad ON (Funcionalidad.Funcionalidad_Cod = Rol_Por_Funcionalidad.Funcionalidad_Cod)
	WHERE Rol_Por_Funcionalidad.Rol_Cod = @rol_cod AND Rol_Por_Funcionalidad.Rol_Por_Funcionalidad_Habilitado=1
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerTarjetasCliente')
	DROP PROCEDURE GEM4.spObtenerTarjetasCliente;
GO
CREATE PROCEDURE GEM4.spObtenerTarjetasCliente
	@clienteID	INT
AS
	SELECT t.Tarjeta_Numero,t.Tarjeta_Codigo_Seg,GEM4.fnObtenerEmisorTarjeta(t.Tarjeta_Emisor),t.Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,Tarjeta_Habilitado
	FROM GEM4.Tarjeta t
	WHERE t.Tarjeta_Cliente_ID=@clienteID
GO				

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spModificarNombreRol')
	DROP PROCEDURE GEM4.spModificarNombreRol;
GO

CREATE PROCEDURE GEM4.spModificarNombreRol
	@Rol_Cod INT,
	@Rol_Nombre	NVARCHAR(255)
	
AS
	UPDATE GEM4.Rol
	SET Rol_Nombre =@Rol_Nombre
	WHERE Rol_Cod =@Rol_Cod
GO	


IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spDarBajaCliente')
	DROP PROCEDURE GEM4.spDarBajaCliente;
GO

CREATE PROCEDURE GEM4.spDarBajaCliente
	@clienteID INT
AS
	UPDATE GEM4.Cliente
	SET Cliente_Habilitado=0
	WHERE Cliente_ID=@clienteID;
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCrearCliente')
	DROP PROCEDURE GEM4.spCrearCliente;
GO

CREATE PROCEDURE GEM4.spCrearCliente
	@nombre				NVARCHAR(255),
	@apellido			NVARCHAR(255),
	@tipoDoc			NUMERIC(18,0),
	@nroDoc				NUMERIC(18,0),
	@mail				NVARCHAR(255),
	@pais				NUMERIC(18,0),
	@domicilio			NVARCHAR(255),
	@domicilioNumero	NVARCHAR(255),
	@domicilioPiso		NVARCHAR(255),
	@domicilioDepto		NVARCHAR(10),
	@localidad			NVARCHAR(60),
	@nacionalidad		NVARCHAR(60),
	@fechaNac			DATETIME
AS
	
	IF(@domicilioNumero='')
	BEGIN
		SET @domicilioNumero=null;
	END

	
	IF(@domicilioPiso='')
	BEGIN
		SET @domicilioPiso=null;
	END
	
	INSERT INTO GEM4.Cliente(Cliente_Nombre,Cliente_Apellido,Cliente_Tipo_Doc,Cliente_Numero_Documento,Cliente_Mail,Cliente_Pais,
				Cliente_Dom_Calle,Cliente_Dom_Numero,Cliente_Dom_Piso,Cliente_Dom_Depto,Cliente_Localidad,Cliente_Nacionalidad,Cliente_Fecha_Nacimiento,Cliente_Habilitado)
	VALUES (@nombre,@apellido,@tipoDoc,@nroDoc,@mail,@pais,@domicilio,
			@domicilioNumero,@domicilioPiso,@domicilioDepto,@localidad,@nacionalidad,@fechaNac,1)
			
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerCuentasDeUsuario')
	DROP PROCEDURE GEM4.spObtenerCuentasDeUsuario
GO
CREATE PROCEDURE GEM4.spObtenerCuentasDeUsuario
	@Username	NVARCHAR(30)
AS
	SELECT C.Cuenta_Numero
	FROM GEM4.Cuenta C, GEM4.Usuario U
	WHERE U.Usuario_Username = @Username and U.Cliente_ID = C.Cuenta_Cliente_ID
GO


IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spModificarCliente')
	DROP PROCEDURE GEM4.spModificarCliente
GO

CREATE PROCEDURE GEM4.spModificarCliente
	@clienteID	INT,
	@nombre NVARCHAR(255),
	@apellido NVARCHAR(255),
	@tipoDoc  NUMERIC(18,0),
	@nroDoc	  NUMERIC(18,0),
	@mail	  NVARCHAR(255),
	@pais	  NUMERIC(18,0),
	@domicilio NVARCHAR(255),
	@domicilioNumero NUMERIC(18,0),
	@domicilioPiso	 NUMERIC(18,0),
	@domicilioDepto	 NVARCHAR(10),
	@localidad		 NVARCHAR(60),
	@nacionalidad	 NVARCHAR(60),
	@fechaNac		 DATETIME,
	@habilitado		BIT
AS
	UPDATE GEM4.Cliente
	SET  Cliente_Nombre=@nombre,Cliente_Apellido=@apellido,Cliente_Tipo_Doc=@tipoDoc,
		 Cliente_Numero_Documento=@nroDoc,Cliente_Mail=@mail,Cliente_Pais=@pais,
		 Cliente_Dom_Calle=@domicilio,Cliente_Dom_Numero=@domicilioNumero,Cliente_Dom_Piso=@domicilioPiso,
		 Cliente_Dom_Depto=@domicilioDepto,Cliente_Localidad=@localidad,Cliente_Nacionalidad=@nacionalidad,
		 Cliente_Fecha_Nacimiento=@fechaNac,Cliente_Habilitado=@habilitado
	WHERE Cliente_ID=@clienteID
	
	
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spModificarPaisCuenta')
	DROP PROCEDURE GEM4.spModificarPaisCuenta;
GO
CREATE PROCEDURE GEM4.spModificarPaisCuenta
	@codPais		INT,
	@clienteID		INT,
	@numeroCuenta	NUMERIC(18,0)
AS
	UPDATE GEM4.Cuenta
	SET Cuenta_Pais = @codPais
	WHERE Cuenta_Cliente_ID = @clienteID AND Cuenta_Numero = @numeroCuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spModificarTipoCuenta')
	DROP PROCEDURE GEM4.spModificarTipoCuenta;
GO
CREATE PROCEDURE GEM4.spModificarTipoCuenta
	@codTipo		INT,
	@clienteID		INT,
	@numeroCuenta	NUMERIC(18,0)
AS
	UPDATE GEM4.Cuenta
	SET Cuenta_Tipo = @codTipo
	WHERE Cuenta_Cliente_ID = @clienteID AND Cuenta_Numero = @numeroCuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spInhabilitarCuenta')
	DROP PROCEDURE GEM4.spInhabilitarCuenta;
GO
CREATE PROCEDURE GEM4.spInhabilitarCuenta
	@clienteID		INT,
	@numeroCuenta	NUMERIC(18,0)
AS
	UPDATE GEM4.Cuenta
	SET Cuenta_Estado = 2
	WHERE Cuenta_Cliente_ID = @clienteID AND Cuenta_Numero = @numeroCuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spCerrarCuenta')
	DROP PROCEDURE GEM4.spCerrarCuenta;
GO
CREATE PROCEDURE GEM4.spCerrarCuenta
	@clienteID		INT,
	@numeroCuenta	NUMERIC(18,0)
AS

--TIENE QUE HABER ALGUN PROCEDURE DE FATUCTURACION PARA VERIFICAR SI ESTA TDO PAGO ANTES DE CERRARLA
	UPDATE GEM4.Cuenta
	SET Cuenta_Estado = 3, Cuenta_Fecha_Cierre = SYSDATETIME()
	WHERE Cuenta_Cliente_ID = @clienteID AND Cuenta_Numero = @numeroCuenta
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerTarjetasUsuario')
	DROP PROCEDURE GEM4.spObtenerTarjetasUsuario;
GO
CREATE PROCEDURE GEM4.spObtenerTarjetasUsuario
	@usuarioNombre	NVARCHAR(30)
AS
	DECLARE @Cliente INT;
	SET @Cliente = (SELECT u.Cliente_ID	FROM Usuario u WHERE u.Usuario_Username= @usuarioNombre);
	EXEC GEM4.spObtenerTarjetasCliente @Cliente;
GO	

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerCuentasCliente')
	DROP PROCEDURE GEM4.spObtenerCuentasCliente;
GO
CREATE PROCEDURE GEM4.spObtenerCuentasCliente
	@clienteID	INT
AS
	SELECT Cuenta_Numero 
	FROM GEM4.Cuenta
	WHERE Cuenta_Cliente_ID = @clienteID
GO	
IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spDesvincularTarjeta')
	DROP PROCEDURE GEM4.spDesvincularTarjeta;

GO

CREATE PROCEDURE GEM4.spDesvincularTarjeta
	@tarjetaNumero NVARCHAR(16)
AS

UPDATE GEM4.Tarjeta
SET Tarjeta_Habilitado=0
WHERE Tarjeta_Numero=@tarjetaNumero;

GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spVincularTarjeta')
	DROP PROCEDURE GEM4.spVincularTarjeta;

GO

CREATE PROCEDURE GEM4.spVincularTarjeta
	@tarjetaNumero NVARCHAR(16)
AS

UPDATE GEM4.Tarjeta
SET Tarjeta_Habilitado=1
WHERE Tarjeta_Numero=@tarjetaNumero;

GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spAltaTarjeta')
	DROP PROCEDURE GEM4.spAltaTarjeta;

GO

CREATE PROCEDURE GEM4.spAltaTarjeta
	
	@emisorDescripcion	NVARCHAR(255),
	@clienteID			INT
AS
	
	DECLARE @codigo INT;
		
	SET @codigo=(ABS(CAST(NEWID() as binary(6)) % 999) + 1)
	
	INSERT INTO GEM4.Tarjeta(Tarjeta_Numero,Tarjeta_Codigo_Seg,Tarjeta_Emisor,Tarjeta_Fecha_Emision,
							Tarjeta_Fecha_Vencimiento,Tarjeta_Cliente_ID)
	VALUES(GEM4.fnObtenerNumTarjetaCredito(),CONVERT(NVARCHAR(3),@codigo),GEM4.fnInsertarCodigoDeEmisor(@emisorDescripcion) ,GEM4.fnDevolverFechaSistema(),
			DATEADD(YEAR,1,GEM4.fnDevolverFechaSistema()),@clienteID);
GO




IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spConsultaSaldosDepositos')
	DROP PROCEDURE GEM4.spConsultaSaldosDepositos;

GO

CREATE PROCEDURE GEM4.spConsultaSaldosDepositos
	@clienteID			INT,
	@cuentaNro			NUMERIC(18,0)
AS
	SELECT TOP 5 Deposito_Codigo, Deposito_Fecha, Deposito_Importe, Deposito_Tarjeta 
	FROM GEM4.Deposito	JOIN GEM4.Cuenta ON (Deposito.Deposito_Cuenta = Cuenta.Cuenta_Numero)
	WHERE Cuenta_Cliente_ID = @clienteID AND Deposito_Cuenta = @cuentaNro
	ORDER BY Deposito_Fecha DESC
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spConsultaSaldosRetiros')
	DROP PROCEDURE GEM4.spConsultaSaldosRetiros;

GO

CREATE PROCEDURE GEM4.spConsultaSaldosRetiros
	@clienteID			INT,
	@cuentaNro			NUMERIC(18,0)
AS
	SELECT TOP 5 Retiro_Codigo, Retiro_Fecha, Retiro_Importe, Retiro_Cheque
	FROM GEM4.Retiro	JOIN GEM4.Cuenta ON (Retiro.Retiro_Cuenta = Cuenta.Cuenta_Numero)
	WHERE Cuenta_Cliente_ID = @clienteID AND Retiro_Cuenta = @cuentaNro
	ORDER BY Retiro_Fecha DESC
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spConsultaSaldosTransferencias')
	DROP PROCEDURE GEM4.spConsultaSaldosTransferencias;

GO

CREATE PROCEDURE GEM4.spConsultaSaldosTransferencias
	@clienteID			INT,
	@cuentaNro			NUMERIC(18,0)
AS
	SELECT TOP 10 Transferencia_Codigo, Transferencia_Fecha, Transferencia_Importe, Transferencia_Costo_Trans, Transferencia_Cuenta_Destino
	FROM GEM4.Transferencia	JOIN GEM4.Cuenta ON (Transferencia.Transferencia_Cuenta_Origen = Cuenta.Cuenta_Numero)
	WHERE Cuenta_Cliente_ID = @clienteID AND Transferencia_Cuenta_Origen = @cuentaNro
	ORDER BY Transferencia_Fecha DESC
GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerClienteRecienCreado')
	DROP PROCEDURE GEM4.spObtenerClienteRecienCreado;

GO

CREATE PROCEDURE GEM4.spObtenerClienteRecienCreado

AS
	SELECT TOP 1 Cliente_ID
	FROM GEM4.Cliente
	ORDER BY Cliente_ID DESC
GO


IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spObtenerEmisoresTarjetas')
	DROP PROCEDURE GEM4.spObtenerEmisoresTarjetas;
GO

CREATE PROCEDURE GEM4.spObtenerEmisoresTarjetas
AS
	SELECT Emisor_Cod,Emisor_Descripcion
	FROM GEM4.Emisor
	
GO





IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spEfectuarRetiro')
	DROP PROCEDURE GEM4.spEfectuarRetiro;
GO

CREATE PROCEDURE GEM4.spEfectuarRetiro
	@cuentaNro	NUMERIC(18,0),
	@importe	NUMERIC(18,2),
	@tipoDoc	INT,
	@nroDoc		INT,
	@nroCheque	NUMERIC(18,0),
	@fecha		DATETIME,
	@usuarioID	NUMERIC(18,0)

AS
	BEGIN
	
		IF(@nroDoc=1)   --ESTA INCOMPLETO, LO DEJE ASI MOCKEADO PARA VER COMO FUNCA
			BEGIN
				
				SELECT 'RETIRO EFECTUADO CORRECTAMENTE!';
			
			END;
		ELSE
			BEGIN
				SELECT 'HUBO UN PROBLEMA CON EL RETIRO, LO SENTIMOS!'
			END;
		
		
		
	END;

GO

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spBuscarCliente')
	DROP PROCEDURE GEM4.spBuscarCliente;
GO

CREATE PROCEDURE GEM4.spBuscarCliente
@username	VARCHAR(255)
AS

	SELECT Cliente_Apellido,Cliente_Nombre,GEM4.Cliente.Cliente_ID
	FROM GEM4.Cliente JOIN GEM4.Usuario ON (GEM4.Cliente.Cliente_ID=GEM4.Usuario.Cliente_ID)
	
	

GO



/* 
PREGUNTAR

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spDepositar')
	DROP PROCEDURE GEM4.spDepositar;

GO

CREATE PROCEDURE GEM4.spDepositar
@Cuenta		NVARCHAR (18),
@Importe	NUMERIC(18,2),
@Moneda		NVARCHAR (60),
@Tarjeta	NVARCHAR(16)

AS

DECLARE @FECHA DATETIME;
DECLARE @CLIENTE INT;
DECLARE @MONEDA_COD INT;
DECLARE @CUENTA_NRO NUMERIC (18,0);
DECLARE @OPERACION INT;

SET @FECHA= (SELECT TOP 1 a.fechaSistema FROM GEM4.fechaSistema a );
SET @CLIENTE =(SELECT T.Tarjeta_Cliente_ID FROM GEM4.Tarjeta T WHERE T.Tarjeta_Numero=@Tarjeta);
SET @MONEDA_COD = (SELECT M.Moneda_Codigo FROM GEM4.Moneda M WHERE M.Moneda_Descripcion = @Moneda);
SET @CUENTA_NRO = (SELECT C.Cuenta_Numero FROM GEM4.Cuenta C WHERE C.Cuenta_Numero LIKE @Cuenta);
SET @OPERACION =(SELECT O.Tipo_Operacion_ID FROM GEM4.Tipo_Operacion O WHERE O.Tipo_Operacion_Descripcion LIKE 'Deposito');

	INSERT GEM4.Deposito (	Deposito_Fecha,	Deposito_Importe,Deposito_Cliente,Deposito_Tarjeta,Deposito_Moneda							
	,Deposito_Cuenta)
	VALUES (@FECHA,@Importe,@CLIENTE,@Tarjeta,@MONEDA_COD,@CUENTA_NRO)

GO

*/
