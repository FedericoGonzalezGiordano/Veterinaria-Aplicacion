create database VetApp
use VetApp

create table tipos_mascotas
(
 id_tipo_mascota int identity (0,1)not null,
 descripcion varchar(70),
 constraint pk_id_tipo primary key(id_tipo_mascota)
)

create table clientes
(
 id_cliente int identity (0,1)not null,
 nombre varchar(40),
 sexo int
 constraint pk_cliente primary key(id_cliente)
)


create table mascotas
(
 id_mascota int identity (1,1)not null,
 nombre varchar(40),
 edad int,
 tipo int not null,
 cliente int not null
 constraint pk_mascota primary key(id_mascota),
 constraint fk_tipo foreign key(tipo) references tipos_mascotas(id_tipo_mascota),
 constraint fk_cliente foreign key(cliente) references clientes(id_cliente)
)

create table atenciones
(
 id_atencion int identity (1,1)not null,
 descripcion varchar(40),
 importe decimal,
 fecha datetime,
 mascota int not null
 constraint pk_atencion primary key(id_atencion),
 constraint fk_mascota foreign key(mascota) references mascotas(id_mascota)
)

INSERT INTO tipos_mascotas VALUES ('PERRO')
INSERT INTO tipos_mascotas VALUES ('GATO')
INSERT INTO tipos_mascotas VALUES ('ARAÑA')
INSERT INTO tipos_mascotas VALUES ('IGUANA')

INSERT INTO CLIENTES VALUES ('PEPE', '1')
INSERT INTO CLIENTES VALUES ('JUAN', '1')
INSERT INTO CLIENTES VALUES ('PEPA', '2')
INSERT INTO CLIENTES VALUES ('JUANA', '2')


CREATE PROCEDURE SP_CONSULTAR_MASCOTAS
AS
BEGIN

    SELECT * from MASCOTAS;
END


CREATE PROCEDURE SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
    SET @next = (SELECT MAX(id_atencion)+1  FROM ATENCIONES);
END


create procedure sp_tipo_mascota
as 
begin
select * from tipos_mascotas 
end

create procedure sp_cliente
as 
begin
select * from clientes 
end

CREATE PROCEDURE SP_INSERTAR_MASCOTA
@id_mascota int OUTPUT,
@nombre varchar(50),
@edad int,
@tipo int,
@cliente int
AS
BEGIN
INSERT INTO mascotas(nombre,edad,tipo,cliente)
VALUES(@nombre,@edad,@tipo,@cliente)
SET @id_mascota =SCOPE_IDENTITY();
END

CREATE PROCEDURE SP_INSERTAR_ATENCION
@descripcion varchar(40),
@importe decimal(18,0),
@fecha datetime,
@mascota int
AS
BEGIN
INSERT INTO atenciones(descripcion,importe,fecha,mascota)
VALUES(@descripcion,@importe,GETDATE(),@mascota)
END
