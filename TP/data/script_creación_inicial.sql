USE GD1C2015
GO

SET LANGUAGE Spanish

/*	****************************************	CREACION DEL SCHENMA	*********************************************** */

IF NOT EXISTS (SELECT 1 FROM [sys].[schemas] WHERE [name] = 'GEM4')
	EXECUTE ('CREATE SCHEMA GEM4 AUTHORIZATION gd;');
GO

/*	****************************************	BORRADO DE OBJETOS	*************************************************** */
/*

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Logs')
	DROP TABLE GEM4.Logs;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tipo_Log')
	DROP TABLE GEM4.Tipo_Log;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Factura_Por_Operacion')
	DROP TABLE GEM4.Factura_Por_Operacion;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Factura')
	DROP TABLE GEM4.Factura;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Retiro')
	DROP TABLE GEM4.Retiro;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Desposito')
	DROP TABLE GEM4.Deposito;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Transferencia')
	DROP TABLE GEM4.Transferencia;		
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Operacion')
	DROP TABLE GEM4.Operacion;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tarjeta_Por_Cliente')
	DROP TABLE GEM4.Tarjeta_Por_Cliente;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Cuenta_Por_Usuario')
	DROP TABLE GEM4.Cuenta_Por_Usuario;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Estado_Cuenta')
	DROP TABLE GEM4.Estado_Cuenta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Tipo_Cuenta')
	DROP TABLE GEM4.Tipo_Cuenta;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Banco')
	DROP TABLE GEM4.Banco;*/
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
	DROP TABLE GEM4.Moneda;/*
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Emisora_Tarjeta')
	DROP TABLE GEM4.Emisora_Tarjeta;	
*/
/*	****************************************	CREACION DE LAS TABLAS	*********************************************** */

CREATE TABLE GEM4.Pais(
	Pais_Cod					INT IDENTITY(1,1),
	Pais_Descripcion			NVARCHAR(60),
	PRIMARY KEY (Pais_Cod)
	);

CREATE TABLE GEM4.Rol(
	Rol_Cod 					INT IDENTITY(1,1),
	Rol_Nombre					NVARCHAR(50) NOT NULL,					
	Rol_Habilitado				BIT NOT NULL DEFAULT 1,
	PRIMARY KEY (Rol_Cod)
	);
	
CREATE TABLE GEM4.Funcionalidad(
	Funcionalidad_Cod			TINYINT ,
	Funcionalidad_Descripcion	NVARCHAR(50) NOT NULL,
	Funcionalidad_Habilitada	BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY (Funcionalidad_Cod)
	);

CREATE TABLE GEM4.Rol_Por_Funcionalidad(
	Rol_Cod								INT,
	Funcionalidad_Cod					TINYINT,
	Rol_Por_Funcionalidad_Habilitado	BIT DEFAULT 1,	
	PRIMARY KEY (Rol_Cod, Funcionalidad_Cod),
	FOREIGN KEY (Rol_Cod) REFERENCES GEM4.Rol(Rol_Cod),
	FOREIGN KEY (Funcionalidad_Cod) REFERENCES GEM4.Funcionalidad(Funcionalidad_Cod)
	);
	
CREATE TABLE GEM4.Documento(
	Documento_Tipo_Codigo					INT IDENTITY(10001,1),
	Documento_Tipo_Descripcion				NVARCHAR(60),
	PRIMARY KEY (Documento_Tipo_Codigo)
	)
	
CREATE TABLE GEM4.Cliente(
	Cliente_ID					INT IDENTITY(1,1),					
	Cliente_Nombre				NVARCHAR(60),
	Cliente_Apellido			NVARCHAR(60),
	Cliente_Tipo_Doc			INT,
	Cliente_Numero_Documento	INT,						--no esta en maestra (no tienen ndoc)
	Cliente_Mail				NVARCHAR(60) UNIQUE,
	Cliente_Pais				INT,
	Cliente_Dom_Calle			NVARCHAR(60),
	Cliente_Dom_Numero			INT,
	Cliente_Dom_Piso			INT,
	Cliente_Dom_Depto			NVARCHAR(60),
	Cliente_Localidad			NVARCHAR(60),				--no esta en maestra
	Cliente_Nacionalidad		NVARCHAR(60),				--no esta en maestra
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
	Usuario_Respuesta_Secreta 				DATETIME,
	Cliente_ID								INT,
	Usuario_Habilitado						BIT NOT NULL DEFAULT 1,
	PRIMARY KEY (Usuario_ID),
	FOREIGN KEY(Cliente_ID) REFERENCES GEM4.Cliente(Cliente_ID),
	UNIQUE (Usuario_Username)
	);
	
CREATE TABLE GEM4.Usuario_Por_Rol(
	Usuario_ID								INT,
	Rol_Cod									INT,
	Habilitado								BIT DEFAULT 1,
	PRIMARY KEY (Usuario_ID, Rol_Cod),
	FOREIGN KEY (Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY (Rol_Cod) REFERENCES GEM4.Rol(Rol_Cod)
	);
	
CREATE TABLE GEM4.Moneda(
	Moneda_Codigo							INT IDENTITY(1,1),
	Moneda_Descripcion						NVARCHAR(60),
--	Habilitado			NVARCHAR(60), --Para que???
	PRIMARY KEY	(Moneda_Codigo)
	)
/*

-- A DISCUTIR:-------------------------------------------------
CREATE TABLE GEM4.Tipo_Log(
	Log_Cod			INT IDENTITY(1,1),
	Descripcion		NVARCHAR(60),
	Habilitado		BIT DEFAULT 1,
	PRIMARY KEY (Log_Cod)
	)

CREATE TABLE GEM4.Logs(
	Logs_ID			INT IDENTITY(1,1),
	Tipo_Log		INT,
	Fecha_Hora_Log	DATETIME,
	Numero_Intento	TINYINT
	)


CREATE TABLE GEM4.Cliente(
	Cliente_ID			INT IDENTITY(1,1),					
	Usuario_ID			INT,						
	Nombre				NVARCHAR(60),
	Apellido			NVARCHAR(60),
	Tipo_Doc_ID			INT,
	Numero_Documento	INT,
	Mail				NVARCHAR(60) UNIQUE,
	Pais_ID				INT,
	Domicilio			NVARCHAR(60), --FALTAN CALLE, NUMERO, DEPTO Y PISO
	Localidad			NVARCHAR(60),
	Nacionalidad		NVARCHAR(60),
	Fecha_Nacimiento	DATETIME,
	Habilitado			BIT DEFAULT 1,
	PRIMARY KEY	(Cliente_ID),
	FOREIGN KEY(Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY(Tipo_Doc_ID) REFERENCES GEM4.Tipo_Documento(Tipo_Doc_ID),
	FOREIGN KEY(Pais_ID) REFERENCES GEM4.Pais(Pais_ID)
	)
	
CREATE TABLE GEM4.Emisora_Tarjeta(
	Emisora_Tarjeta_ID	INT IDENTITY(1,1),
	Descripcion	NVARCHAR(60),
	Habilitado	BIT DEFAULT 1,   -- para quee?
	PRIMARY KEY(Emisora_Tarjeta_ID)
	)
CREATE TABLE GEM4.Tarjeta_Por_Cliente(  --yo le pondria tarjeta
	Tarjeta_Por_Cliente_ID	INT IDENTITY(1,1), --y esto que seria?? el numero de tarjeta??
	Emisora_Tarjeta_ID		INT,
	Cliente_ID				INT,
	Fecha_Emision			DATETIME,
	Fecha_Vencimiento		DATETIME,
	Codigo_Seguridad		INT,
	Habilitado				BIT DEFAULT 1,
	PRIMARY KEY (Tarjeta_Por_Cliente_ID),
	FOREIGN KEY(Emisora_Tarjeta_ID) REFERENCES	GEM4.Emisora_Tarjeta(Emisora_Tarjeta_ID),
	FOREIGN KEY (Cliente_ID)		REFERENCES	GEM4.Cliente(Cliente_ID)
	)

CREATE TABLE GEM4.Tipo_Cuenta(
	Tipo_Cuenta_ID		INT IDENTITY(1,1),
	Descripcion			NVARCHAR(60),
	Costo_Creacion		NUMERIC(18,2),
	Costo_Modificacion	NUMERIC(18,2),  --Faltaria la duracion
	Habilitado			BIT DEFAULT 1
	PRIMARY KEY (Tipo_Cuenta_ID)
	)

CREATE TABLE GEM4.Estado_Cuenta(
	Estado_Cuenta_ID	INT IDENTITY(1,1),
	Descripcion			NVARCHAR(60),
	PRIMARY KEY(Estado_Cuenta_ID)
	)

CREATE TABLE GEM4.Cuenta_Por_Usuario(  --NO ENTIENDO PARA QUE ESTA TABLA, FALTARIA LA TABLA CUENTA
	Cuenta_Por_Usuario_ID	INT IDENTITY(1,1),
	Usuario_ID				INT,
	Tipo_Cuenta_ID			INT,
	Estado_Cuenta_ID		INT,
	Habilitado				BIT DEFAULT 1,
	PRIMARY KEY (Cuenta_Por_Usuario_ID),
	FOREIGN KEY(Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY(TipoCuenta_ID) REFERENCES GEM4.Tipo_Cuenta(Tipo_Cuenta_ID),
	FOREIGN KEY(Estado_Cuenta_ID) REFERENCES GEM4.Estado_Cuenta(Estado_Cuenta_ID)
	)
	
CREATE TABLE GEM4.Operacion( -- esta tabla que seria?
	Operacion_ID	INT IDENTITY(1,1),
	Costo			NUMERIC(18,2),
	PRIMARY KEY(Operacion_ID)
	)
CREATE TABLE GEM4.Deposito(
	Deposito_ID				INT IDENTITY(1,1),
	Operacion_ID			INT,
	Cuenta_Por_Usuario_ID	INT,
	Importe					NUMERIC(18,2) CHECK(Importe>1),
	Moneda_ID				INT,							--Faltaria una FK al cliente??
	Tarjeta_Por_Cliente_ID	INT,
	Fecha					DATETIME,
	--EN NECESARIO EL BANCO??? HAY Q PREGUNTAR EN EL GRUPO EL ENUNCIADO NO DICE NADA
	--PERO NO SERIA ILOGICO QUE EL BANCO ESTE, AUNQUE CON LA TARJETA SE PUEDE AVERIGUAR EL BANCO
	PRIMARY KEY(Deposito_ID),
	FOREIGN KEY(Operacion_ID) REFERENCES GEM4.Operacion(Operacion_ID),
	FOREIGN KEY(Cuenta_Por_Usuario_ID)	REFERENCES GEM4.Cuenta_Por_Usuario_ID(Cuenta_Por_Usario_ID),
	FOREIGN	KEY(Moneda_ID) REFERENCES GEM4.Moneda(Moneda_ID),
	FOREIGN KEY(Tarjeta_Por_Cliente_ID) REFERENCES GEM4.Tarjeta_Por_Cliente(Tarjeta_Por_Cliente_ID)
	)
	
CREATE TABLE GEM4.Banco(
	Banco_ID	INT IDENTITY(1,1),
	Descripcion	NVARCHAR(60), --falta banco direccion
	PRIMARY KEY(Banco_ID),
	)
		
CREATE TABLE GEM4.Retiro(
	Retiro_ID				INT IDENTITY(1,1),
	Operacion_ID			INT,
	Cuenta_Por_Usuario_ID	INT,
	Importe					NUMERIC(18,2) CHECK (Importe>1),
	Moneda_ID				INT,
	Tarjeta_Por_Cliente_ID	INT,
	Fecha					DATETIME,
	Numero_Cheque			INT,
	Librador_ID				INT,--(USUARIO CON CUENTA DEL BANCO QUE CONFECCIONO EL CHEQUE) --no entiendo
	Banco_ID				INT,
	Habilitado				BIT DEFAULT 1,			--para que??
	PRIMARY KEY(Retiro_ID),
	FOREIGN KEY(Operacion_ID) REFERENCES GEM4.Operacion(Operacion_ID),
	FOREIGN KEY(Cuenta_Por_Usuario_ID) REFERENCES GEM4.Cuenta_Por_Usuario(Cuena_Por_Usuario_ID),
	FOREIGN	KEY(Moneda_ID) REFERENCES GEM4.Moneda(Moneda_ID),
	FOREIGN KEY(Tarjeta_Por_Cliente_ID) REFERENCES GEM4.Tarjeta_Por_Cliente(Tarjeta_Por_Cliente_ID),
	FOREIGN KEY(Librador_ID)	REFERENCES	GEM4.Usuario(Usuario_ID),
	FOREIGN KEY (Banco_ID) REFERENCES GEM4.Banco(Banco_ID)
	)
		
CREATE TABLE GEM4.Transferencia(
	Transferencia_ID	INT IDENTITY(1,1),
	Operacion_ID		INT,
	Cuenta_Origen		INT,
	Cuenta_Destino		INT,
	Importe				INT CHECK(Importe>0),
	Costo_Fijo			NUMERIC(18,2),
	Habilitado			BIT DEFAULT 1,					--falta fecha
	PRIMARY KEY (Transferencia_ID),
	FOREIGN KEY (Operacion_ID) REFERENCES GEM4.Operacion(Operacion_ID),
	FOREIGN KEY (Cuenta_Origen) REFERENCES GEM4.Cuenta_Por_Usuario(Cuenta_Por_Usuario_ID),
	FOREIGN KEY (Cuenta_Destino) REFERENCES GEM4.Cuenta_Por_Usuario(Cuenta_Por_Usuario_ID)
	)

CREATE TABLE GEM4.Factura(
	Factura_ID					INT IDENTITY(1,1),
	Fecha						DATETIME,
	Habilitado					BIT DEFAULT 1, --para que?
	PRIMARY KEY(Factura_ID)
	)
	
CREATE TABLE GEM4.Factura_Por_Operacion( --para mi iria en items, porq	ue una operacion es un item de una factura
	Factura_Por_Operacion_ID	INT IDENTITY(1,1),
	Factura_ID					INT,
	Operacion_ID				INT,
	PRIMARY KEY (Factura_Por_Operacion_ID),
	FOREIGN KEY (Factura_ID) REFERENCES GEM4.Factura(Factura_ID),
	FOREIGN KEY (Operacion_ID) REFERENCES GEM4.Operacion(Operacion_ID)
	)					
	
	
		*/
	
	
	
	
	
/*	*******************************************	    VIEWS   	********************************************************** */

/* *****************************************     CREACION DE TRIGGERS    ********************************************** */

/* ***************************************** INICIALIZACION DE DATOS ************************************************** */

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
	(1,'D�lar estadounidense');
SET IDENTITY_INSERT GEM4.Moneda OFF;

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

INSERT INTO GEM4.Cliente(Cliente_Pais, Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc, Cliente_Dom_Calle, Cliente_Dom_Numero, Cliente_Dom_Piso, Cliente_Dom_Depto, Cliente_Fecha_Nacimiento, Cliente_Mail)
SELECT DISTINCT Cli_Pais_Codigo, Cli_Nombre, Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Dom_Calle, Cli_Dom_Nro, Cli_Dom_Piso, Cli_Dom_Depto, Cli_Fecha_Nac, Cli_Mail
FROM gd_esquema.Maestra

INSERT INTO GEM4.Usuario(Usuario_Username, Usuario_Contrasena, Usuario_Fecha_Creacion, Usuario_Fecha_Ultima_Modificacion, Cliente_ID)
SELECT Cliente_Nombre +'.'+ Cliente_Apellido, '5rhwUL/LgUP8uNsBcKTcntANkE3dPipK0bHo3A/cm+c=', SYSDATETIME(), SYSDATETIME(), Cliente_ID
FROM GEM4.Cliente

INSERT INTO GEM4.Usuario_Por_Rol(Usuario_ID,Rol_Cod)
SELECT Usuario_ID, 2
FROM GEM4.Usuario
WHERE Usuario_ID > 3

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
