USE MASTER 
GO 
IF EXISTS(SELECT NAME FROM SYS.DATABASES WHERE NAME = 'VirtualMind') 
BEGIN 
DROP DATABASE VirtualMind 
END 
CREATE DATABASE VirtualMind
GO 
PRINT 'La base de datos: VirtualMind ha sido creada con exito.' 
GO 
USE VirtualMind 
GO 
CREATE TABLE [User] 
( 
[id] INT NOT NULL, 
[nombre] NVARCHAR(50) NOT NULL, 
[apellido] NVARCHAR(50) NOT NULL, 
[email] NVARCHAR(50) NOT NULL, 
[password] NVARCHAR(50) NOT NULL, 
CONSTRAINT [PK id] PRIMARY KEY([id] ASC) 
) 
GO 
PRINT 'La tabla: Tabla User ha sido creada con exito' 
INSERT INTO [User] VALUES(1, 'Gustavo', 'Ali', 'gustavoali@gmail.com', 'xylom1234') 
INSERT INTO [User] VALUES(2, 'Ramon', 'Valdes', 'ramonvaldes@gmail.com', 'pepermint1234') 
INSERT INTO [User] VALUES(3, 'Hector', 'Sanchez', 'hectorsanchez@gmail.com', 'derogan1234') 
INSERT INTO [User] VALUES(4, 'Gonzalo', 'Torres', 'gonzalotorres@gmail.com', 'dersatuy1234') 
INSERT INTO [User] VALUES(5, 'Walter', 'Frias', 'walterfrias@gmail.com', 'sortedi1234') 