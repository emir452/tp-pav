use "database pav"
CREATE TABLE profesores 
	(legajo                       INT, 
nombre                       VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL, 
dni INT NOT NULL,
telefono VARCHAR(50) NOT NULL ,
email VARCHAR(100),
anioIncreso INT NOT NULL,
domicilio INT NOT NULL,
     CONSTRAINT PRIMARI_KEY PRIMARY KEY (legajo),
CONSTRAINT fk FOREIGN KEY(domicilio) REFERENCES domicilio	
  
  )

 CREATE TABLE alumnos (
legajo INT,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
dni INT NOT NULL,
 FECHA_NACIMIENTO DATETIME, 
  domicilio INT NOT NULL,
CONSTRAINT PRIMARI_KEY PRIMARY KEY (legajo),
CONSTRAINT fk FOREIGN KEY(domicilio) REFERENCES domicilios,
)
CREATE TABLE temas (
id INT, 
NAME VARCHAR(50) NOT NULL,
description TEXT,
     CONSTRAINT PRIMARI_KEY PRIMARY KEY (id),
)
CREATE  TABLE clases (
id_clase INT,
date DATETIME NOT NULL,
profesor int NOT NULL,
alumno INT NOT NULL, 
nota DECIMAL NOT NULL,
CONSTRAINT fk_alumnos FOREIGN KEY (alumno) REFERENCES alumnos,   
CONSTRAINT fk_profesores FOREIGN KEY (profesor) REFERENCES  profesores,
CONSTRAINT PRIMARI_KEY PRIMARY KEY (id_clase),
)
CREATE TABLE temasPorClase (
id_clase INT,
tema INT,
nota_tema DECIMAL NOT NULL,
 CONSTRAINT PRIMARI_KEY PRIMARY KEY(id_clase, tema),
 CONSTRAINT FK_CLASE FOREIGN KEY (id_clase) REFERENCEs clases, 

)
CREATE TABLE  profesoresPorAlumno (
alumno INT,
profesor INT,
CONSTRAINT fk_profesores FOREIGN KEY (profesor) REFERENCES profesores, 
CONSTRAINT fk_alumnos FOREIGN KEY (alumno) REFERENCES alumnos,    
CONSTRAINT pk PRIMARY KEY (profesor, alumno),
)
CREATE TABLE domicilios 
(
id INT,
calle VARCHAR(100),
altura INT,
barrio  VARCHAR(100),
ciudad VARCHAR(100),
pais VARCHAR(100),
CONSTRAINT pk_domicilio PRIMARY KEY (ID)
)
