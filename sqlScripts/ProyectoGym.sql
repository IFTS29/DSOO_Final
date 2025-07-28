/*--------------------------------------------------------------------*/
/* ----- Base de Datos del Proyecto Integrador: Club Deportivo ----- */
/*--------------------------------------------------------------------*/


drop database if exists ProyectoGym;
create database ProyectoGym;
use ProyectoGym;


-- Tabla roles --
create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

-- Tabla usuario --
create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(NombreUsu,PassUsu,RolUsu) values
('Mari2023','123456',120),
('LopezRamiro','empleado500',121),
('UsuarioPrueba','Usu2023',120);


-- Tabla Cliente --
create table cliente(
    Doc int,
    TDoc varchar(20),
    Nombre varchar(30),
    Apellido varchar(40),
    FechaNac date,
    Direccion varchar(50),
    Telefono varchar(20),
    Email varchar(50),
    AptoMedico boolean not null,
    constraint pk_cliente primary key (Doc)
);


-- Tabla Socio --
create table socio (
    idSocio int,
    Doc int, 
    Estado varchar(10) DEFAULT 'Activo', 
    CarnetEntregado boolean DEFAULT false,  
    FechaInscripcion DATE,
    constraint pk_socio primary key(idSocio),
    foreign key (Doc) references cliente(Doc)
);

-- Tabla NoSocio --
create table noSocio (
    idNoSocio int,
    Doc int,
    FechaInscripcion DATE,
    constraint pk_nosocio primary key(idNoSocio),
    foreign key (Doc) references cliente(Doc)
);


-- Tabla CuotaMensual --
create table cuotaMensual (
    idCuota int auto_increment,
    idSocio int,
    montoCuota decimal(8,2)  default 30500.00, 
    medioPago enum('Efectivo', 'TarjetaCredito'),
    fechaPago date,
    fechaVencimiento date,
    cantCuotas int check (cantCuotas between 0 and 3),
    constraint pk_cuota primary key (idCuota),
    constraint fk_cuota_socio foreign key (idSocio) references socio(idSocio)
);

-- Tabla Actividad --
create table Actividad (
    idActividad int auto_increment,
    nombreActividad varchar(50),
    fechaActividad date,
    horaActividad time,
    costoActividad decimal(8,2),
    constraint pk_actividad primary key (idActividad)
);

-- Insertar actividades disponibles
INSERT INTO Actividad (nombreActividad, horaActividad, costoActividad)
VALUES
('Yoga', '08:00:00', 14500.00),
('Spinning', '09:30:00', 14700.00),
('CrossFit', '11:00:00', 15200.00),
('Pilates', '13:00:00', 14600.00),
('BodyPump', '15:00:00', 14900.00),
('Natación', '17:00:00', 15300.00),
('Artes Marciales', '19:00:00', 15500.00);

-- Tabla CuotaDiaria --
create table CuotaDiaria (
    idCuotaDiaria int auto_increment,
    idNoSocio int,
    idActividad int,
    monto decimal(8,2),
    medioPago enum('Efectivo', 'TarjetaCredito'),
    fechaPago date,
    cantCuotas int check (cantCuotas between 0 and 3),
    constraint pk_cuotadiaria primary key (idCuotaDiaria),
    constraint fk_cuota_nosocio foreign key (idNoSocio) references noSocio(idNoSocio),
    constraint fk_cuota_actividad foreign key (idActividad) references Actividad(idActividad)
);

