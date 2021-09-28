drop database if exists Prototipo2P;
create database Prototipo2P;
use Prototipo2P;
create table empleado(
codEmpleado tinyint auto_increment,
nombre varchar (45),
puesto varchar (45),
idDepto tinyInt,
estado tinyint,
primary key (codEmpleado)
);

create table departamento(
codDepto tinyint auto_increment,
nombreDepto varchar (45),
primary key (codDepto)
);

ALTER TABLE empleado
ADD CONSTRAINT fkDepto FOREIGN KEY (idDepto) REFERENCES departamento (codDepto);

insert into departamento values(1,"Gerencia"),(2,"Contabilidad"),(3,"Informatica");
insert into empleado values(1,"Mario Lopez","Contador",2,1),(2,"Mateo Cifuentes","Programador",3,1),(3,"Marisol Paredes","Gerente",1,1);