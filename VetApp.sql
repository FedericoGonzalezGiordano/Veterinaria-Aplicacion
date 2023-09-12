create database VetApp_0_3
use VetApp_0_3


create table tipos_mascotas
(
 id_tipo_mascota int identity (0,1),
 descripcion varchar(100),
 constraint pk_id_tipo primary key(id_tipo_mascota)
)


create table clientes
(
 id_cliente int identity (0,1),
 nombreC varchar(100),
 sexo int
 constraint pk_cliente primary key(id_cliente)
)


create table mascotas
(
 id_mascota int identity (1,1),
 nombreM varchar(100),
 edad int,
 tipo int not null,
 cliente int not null
 constraint pk_mascota primary key(id_mascota),
 constraint fk_tipo foreign key(tipo) references tipos_mascotas(id_tipo_mascota),
 constraint fk_cliente foreign key(cliente) references clientes(id_cliente)
)

create table atenciones
(
 id_atencion int identity (1,1),
 tratamiento varchar(150),
 importe decimal,
 fecha datetime,
 mascota int not null
 constraint pk_atencion primary key(id_atencion),
 constraint fk_mascota foreign key(mascota) references mascotas(id_mascota)
)

CREATE PROCEDURE SP_CONSULTAR_MASCOTAS
AS
BEGIN

    SELECT * from MASCOTAS;
END

create procedure sp_cliente
as 
begin
select * from clientes 
end

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



CREATE PROCEDURE SP_INSERTAR_MASCOTA
@id_mascota int OUTPUT,
@nombre varchar(100),
@edad int,
@tipo int,
@cliente int
AS
BEGIN
INSERT INTO mascotas(nombreM,edad,tipo,cliente)
VALUES(@nombre,@edad,@tipo,@cliente)
SET @id_mascota =SCOPE_IDENTITY();
END

CREATE PROCEDURE SP_INSERTAR_ATENCION
@tratamiento varchar(150),
@importe decimal(18,0),
@fecha datetime,
@mascota int
AS
BEGIN
INSERT INTO atenciones(tratamiento,importe,fecha,mascota)
VALUES(@tratamiento,@importe,GETDATE(),@mascota)
END

create procedure SP_CONSULTA_ATENCION
@nombreC varchar(100),
@nombreM varchar(100)
AS
BEGIN
select a.id_atencion,t.descripcion,a.importe,a.fecha,a.tratamiento
from tipos_mascotas t join mascotas m on t.id_tipo_mascota=m.tipo
join clientes c on c.id_cliente=m.cliente 
join atenciones a on a.mascota=m.id_mascota
where c.nombreC=@nombreC and m.nombreM=@nombreM
END

create procedure SP_CONSULTA_MASCOTAS
@atencion int
as
begin
select cod_mascota,nombreM,edad,descripcion,nombreC
from mascotas m join atenciones a on m.cod_mascota=a.mascota 
join tipos_mascotas t on t.id_tipo_mascota=m.tipo
join clientes c on c.id_cliente=m.cliente
where a.id_atencion=@atencion
end




INSERT INTO tipos_mascotas (descripcion) VALUES ('Perro');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Gato');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Conejo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Hámster');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Pájaro');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Tortuga');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Cobra');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Cangrejo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Iguana');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Caimán');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Erizo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Pez Dorado');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Tiburón');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Pulpo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Serpiente');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Loro');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Ratón');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Hurón');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Canario');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Ardilla');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Pavo Real');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Cabra');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Puercoespín');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Camello');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Jirafa');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Elefante');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Cebra');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Leopardo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Puma');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Oso');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Tigre');
INSERT INTO tipos_mascotas (descripcion) VALUES ('León');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Lince');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Gorila');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Orangután');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Hipopótamo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Rinoceronte');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Koala');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Panda');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Kangaroo');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Araña');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Escorpión');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Avestruz');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Mapache');
INSERT INTO tipos_mascotas (descripcion) VALUES ('Castor');

INSERT INTO clientes (nombreC, sexo) VALUES ('Juan', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('María', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Pedro', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Ana', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Luis', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Elena', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Carlos', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Sofía', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Miguel', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Laura', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Javier', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Isabella', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('David', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Valentina', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Fernando', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Camila', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('José', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Adriana', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Roberto', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Paula', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Ricardo', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Carolina', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Alejandro', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Natalia', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Gustavo', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Sara', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Andrés', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Daniela', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Felipe', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Lucía', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Antonio', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Cristina', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Manuel', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Mariana', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Hugo', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Patricia', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Raúl', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Alicia', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Rafael', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Julia', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Eduardo', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Lorena', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Oscar', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Monica', 2);
INSERT INTO clientes (nombreC, sexo) VALUES ('Joaquín', 1);
INSERT INTO clientes (nombreC, sexo) VALUES ('Carmen', 2);

INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Max', 3, 1, 1);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Luna', 2, 2, 2);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Bugs', 1, 3, 3);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Whiskers', 4, 1, 4);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Fido', 2, 2, 5);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Nibbles', 1, 3, 6);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Rocky', 3, 1, 7);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Sasha', 2, 2, 8);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Fluffy', 4, 4, 9);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Oreo', 1, 5, 10);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Simba', 5, 1, 11);
INSERT INTO mascotas (nombreM, edad, tipo, cliente) VALUES ('Misty', 3, 2, 12);

INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Vacunación anual', 50.00, '2023-01-15', 1);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Revisión dental', 30.00, '2023-02-20', 2);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Cirugía de esterilización', 100.00, '2023-03-10', 3);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Chequeo de salud', 45.00, '2023-04-05', 4);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Vacuna contra la rabia', 25.00, '2023-05-12', 5);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Limpieza dental', 35.00, '2023-06-20', 6);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Control de peso', 20.00, '2023-07-03', 7);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Desparasitación', 15.00, '2023-08-15', 8);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Vacunación felina', 28.00, '2023-09-02', 9);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Corte de uñas', 12.00, '2023-10-11', 10);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Radiografía', 75.00, '2023-11-25', 11);
INSERT INTO atenciones (tratamiento, importe, fecha, mascota) VALUES ('Esterilización', 90.00, '2023-12-05', 12);