create database VetApp
use VetApp

create table tipos_mascotas
(
 id_tipo_mascota int identity (1,1)not null,
 descripcion varchar(70),
 constraint pk_id_tipo primary key(id_tipo_mascota)
)

create table clientes
(
 id_cliente int identity (1,1)not null,
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

INSERT INTO TIPOS VALUES ('PERRO')
INSERT INTO TIPOS VALUES ('GATO')
INSERT INTO TIPOS VALUES ('ARAÑA')
INSERT INTO TIPOS VALUES ('IGUANA')

INSERT INTO CLIENTES VALUES ('PEPE', '1')
INSERT INTO CLIENTES VALUES ('JUAN', '1')
INSERT INTO CLIENTES VALUES ('PEPA', '0')
INSERT INTO CLIENTES VALUES ('JUANA', '0')

INSERT INTO MASCOTAS VALUES ('TITAN', 12, 1, 1)
INSERT INTO MASCOTAS VALUES ('BOBY', 13, 2, 1)
INSERT INTO MASCOTAS VALUES ('DYLAN', 5, 3, 2)
INSERT INTO MASCOTAS VALUES ('ROCKY', 7, 4, 3)
INSERT INTO MASCOTAS VALUES ('BOB MARLEY', 9, 2, 4)
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





CREATE PROCEDURE SP_INSERTAR_CLIENTE(
    @Nombre VARCHAR(50),
    @Sexo INT
AS
BEGIN
    INSERT INTO Clientes(Nombre, Sexo)
    VALUES (@Nombre, @Sexo)
END



CREATE PROCEDURE SP_MODIFICAR_CLIENTE
    @id_cliente INT,
    @Nombre VARCHAR(50),
    @Sexo INT
AS
BEGIN
    UPDATE Clientes
    SET nombre=@Nombre, sexo=@Sexo
    WHERE  id_cliente=@id_cliente
END


CREATE PROCEDURE SP_PROXIMO_CLIENTE
@nroCliente int OUTPUT
AS
BEGIN
    SET @nroCliente = (SELECT MAX(id_cliente)+1  FROM clientes);
END