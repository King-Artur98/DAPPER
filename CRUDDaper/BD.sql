CREATE DATABASE AArteagaDapper;

Create table alumno (
Id_alumno INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR (50) NOT NULL,
AP_Paterno VARCHAR (50) NOT NULL,
AP_Materno VARCHAR (50)NOT NULL,
FechaNac DATE  NULL,
Matricula VARCHAR (50) NULL,
Sexo CHAR (5) NULL,
Email VARCHAR (50) NOT NULL,
Id_semestre TINYINT NOT NULL
); 

CREATE TABLE semestre(
Id_semestre tinyint primary key identity (1,1),
Nombre VARCHAR (50) NOT NULL
);

INSERT INTO semestre (Nombre) VALUES ('Primero')
INSERT INTO semestre (Nombre) VALUES ('Segundo')
INSERT INTO semestre (Nombre) VALUES ('Tercero')

ALTER TABLE alumno ADD Foreign Key (Id_semestre) REFERENCES semestre (Id_semestre);

------------------------------------------------------------------------------------------

CREATE PROCEDURE [AlumnoAdd] 
@Nombre VARCHAR(50),
@AP_Paterno VARCHAR(50),
@AP_Materno VARCHAR(50),
@FechaNac VARCHAR(20),
@Matricula VARCHAR(50),
@Sexo CHAR(2),
@Email VARCHAR(50),
@Id_semestre TINYINT
AS
	INSERT INTO [alumno]--TABLA 
           ([Nombre]
           ,[AP_Paterno]
           ,[AP_Materno]
           ,[FechaNac]
           ,[Matricula]
           ,[Sexo]
           ,[Email]
		   ,Id_semestre)--COLUMNAS 
     VALUES
           (@Nombre,
		   @AP_Paterno,
		   @AP_Materno,
		   CONVERT(DATE,@FechaNac,105),--dd--MM-yyyy
		   @Matricula,
		   @Sexo,
		   @Email,
		   @Id_semestre)--DATOS
------------------------------------------------------------------------------------------

CREATE PROCEDURE AlumnoDel
@Id_alumno INT
AS
	  DELETE FROM Alumno
 WHERE Id_alumno= @Id_alumno;
 ------------------------------------------------------------------------------------------
 
 CREATE PROCEDURE AlumnoUpdate
@Id_alumno INT,
@Nombre VARCHAR(50),
@AP_Paterno VARCHAR(50),
@AP_Materno VARCHAR(50),
@FechaNac VARCHAR(20),
@Matricula VARCHAR(50),
@Sexo CHAR(2),
@Email VARCHAR(50),
@Id_semestre TINYINT
AS
	UPDATE [alumno]	
   SET [Nombre] = @Nombre
      ,[AP_Paterno] = @AP_Paterno
      ,[AP_Materno] = @AP_Materno
	  ,[FechaNac] = @FechaNac
	  ,[Matricula] = @Matricula
	  ,[Sexo] = @Sexo
	  ,[Email] = @Email
	  ,Id_semestre = @Id_semestre

	WHERE Id_alumno = @Id_alumno
  
  -------------------------------------------------------------------
  CREATE PROCEDURE [AlumnoGetAll]
AS
	SELECT [Id_alumno]
		  ,[Nombre]
		  ,[AP_Paterno]
		  ,[AP_Materno]
		  ,[FechaNac]
		  ,[Matricula]
		  ,[Sexo]
		  ,[Email]
		  ,Id_semestre
	  FROM [alumno]
--------------------------------------------------------------------------

CREATE PROCEDURE [AlumnoGetAllBy]
@Id_alumno INT
AS
	SELECT [Id_alumno]
		  ,[Nombre]
		  ,[AP_Paterno]
		  ,[AP_Materno]
		  ,[FechaNac]
		  ,[Matricula]
		  ,[Sexo]
		  ,[Email]
		  ,Id_semestre
	  FROM [alumno]

	  WHERE Id_alumno= @Id_alumno;
