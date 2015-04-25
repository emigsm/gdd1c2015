USE GD1C2015
GO

SET LANGUAGE Spanish

/*	****************************************	CREACION DEL SCHENMA	*********************************************** */

IF NOT EXISTS (SELECT 1 FROM [sys].[schemas] WHERE [name] = 'GEM4')
	EXECUTE ('CREATE SCHEMA GEM4 AUTHORIZATION gd;');
GO

/*	****************************************	BORRADO DE OBJETOS	*************************************************** */

IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND TABLE_NAME = 'Pais')
	DROP TABLE GEM4.Pais;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND TABLE_NAME = 'Rol_Por_Funcionalidad')
	DROP TABLE GEM4.Rol_Por_Funcionalidad;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Usuario_Por_Rol')
	DROP TABLE GEM4.Usuario_Por_Rol;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Rol')
	DROP TABLE GEM4.Rol;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Funcionalidad')
	DROP TABLE GEM4.Funcionalidad;
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'GEM4' AND  TABLE_NAME = 'Usuario')
	DROP TABLE GEM4.Usuario;
	
/*	****************************************	CREACION DE LAS TABLAS	*********************************************** */

CREATE TABLE GEM4.Pais(
	Pais_ID					INT IDENTITY(1,1),
	Nombre_Pais					NVARCHAR(60),
	Pais_Habilitado				BIT NOT NULL DEFAULT 1
	PRIMARY KEY (Pais_ID)
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
	
CREATE TABLE GEM4.Usuario(
	Usuario_ID 								INT IDENTITY(0,1),
	Usuario_Username						NVARCHAR(30) UNIQUE NOT NULL,
	Usuario_Contrasena						CHAR(44) NOT NULL,
	Usuario_Fecha_Creacion 					DATETIME,
	Usuario_Fecha_Ultima_Modificacion 		DATETIME,
	Usuario_Pregunta_Secreta 				NVARCHAR(60),
	Usuario_Respuesta_Secreta 				DATETIME,
	Usuario_Habilitado						BIT NOT NULL DEFAULT 1,
	PRIMARY KEY (Usuario_ID),
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


-- A DISCUTIR:-------------------------------------------------
CREATE TABLE GEM4.Tipo_Log(
	Log_Cod			INT IDENTITY(1,1),
	Descripcion		NVARCHAR(60),
	habilitado		BIT DEFAULT 1,
	PRIMARY KEY (Log_Cod)
	)

CREATE TABLE GEM4.Logs(
	Logs_ID			INT IDENTITY(1,1),
	Tipo_Log		INT,
	Fecha_Hora_Log	DATETIME,
	Numero_Intento	TINYINT
	)

CREATE TABLE GEM4.Tipo_Documento(
	Tipo_Doc_ID		INT IDENTITY(1,1),
	Descrípcion		NVARCHAR(60),
	Habilitado		BIT DEFAULT 1,
	PRIMARY KEY (Tipo_Doc_ID)
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
	Domicilio			NVARCHAR(60),
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
	Habilitado	BIT DEFAULT 1,
	PRIMARY KEY(Emisora_Tarjeta_ID)
	)
CREATE TABLE GEM4.Tarjeta_Por_Cliente(
	Tarjeta_Por_Cliente_ID	INT IDENTITY(1,1),
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
	
		
CREATE TABLE GEM4.Moneda(
	Moneda_ID		INT IDENTITY(1,1),
	Descripcion		NVARCHAR(60),
	Habilitado		NVARCHAR(60),
	PRIMARY KEY	(Moneda_ID)
	)

CREATE TABLE GEM4.Tipo_Cuenta(
	Tipo_Cuenta_ID		INT IDENTITY(1,1),
	Descripcion			NVARCHAR(60),
	Costo_Creacion		NUMERIC(18,2),
	Costo_Modificacion	NUMERIC(18,2),
	Habilitado			BIT DEFAULT 1
	PRIMARY KEY (Tipo_Cuenta_ID)
	)

CREATE TABLE GEM4.Estado_Cuenta(
	Estado_Cuenta_ID	INT IDENTITY(1,1),
	Descripcion			NVARCHAR(60),
	PRIMARY KEY(Estado_Cuenta_ID)
	)

CREATE TABLE GEM4.Cuenta_Por_Usuario(
	Cuenta_Por_Usuario	INT IDENTITY(1,1),
	Usuario_ID			INT,
	Cuenta_ID			INT,
	Habilitado			BIT DEFAULT 1,
	PRIMARY KEY (Cuenta_Por_Usuario),
	FOREIGN KEY(Usuario_ID) REFERENCES GEM4.Usuario(Usuario_ID),
	FOREIGN KEY(Cuenta_ID) REFERENCES GEM4.Cuenta(Cuenta_ID)
	)
CREATE TABLE GEM4.Operacion(
	Operacion_ID	INT IDENTITY(1,1),
	PRIMARY KEY(Operacion_ID)
	)

	
	Importe				NUMERIC(18,2) CHECK(Importe>1),
	Tipo_Moneda			INT,	
	
		
	
	
	
	
	
/*	*******************************************	    VIEWS   	********************************************************** */

/* *****************************************     CREACION DE TRIGGERS    ********************************************** */

/*	****************************************	MIGRACION 	******************************************* */

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
	
/* ***************************************** STORED PROCEDURES ************************************************** */

IF EXISTS (SELECT 1 FROM sys.sysobjects WHERE name = 'spLoginUsuario')
	DROP PROCEDURE GEM4.spLoginUsuario;
go
CREATE PROCEDURE GEM4.spLoginUsuario
    @usuario nvarchar(30), 
    @pass char(44) 
AS 
    SELECT Usuario_ID
		FROM GEM4.Usuario
		WHERE Usuario_Username = @usuario AND Usuario_Contrasena = @pass AND Usuario_Habilitado = 1;
GO

