
insert into E_Departamento values (1,'piura')
insert into E_Departamento values (2,'lima')

--departamento piura

insert into E_Provincia values (1,'paita',1)
insert into E_Provincia values (2,'huancabamba',1)

--provincia paita

insert into E_Distrito values (1,'LA HUACA',1)
insert into E_Distrito values (2,'AMOTAPE',1)

--provincia huancabamba

insert into E_Distrito values (3,'huarmaca',2)
insert into E_Distrito values (4,'canchaque',2)

--departamento lima

insert into E_Provincia values (3,'lima',2)
insert into E_Provincia values (4,'barranca',2)

--provincia lima

insert into E_Distrito values (5,'barranco',3)
insert into E_Distrito values (6,'chorrillo',3)

--provincia barranca

insert into E_Distrito values (7,'distrito de paramonga',4)
insert into E_Distrito values (8,'distrito de pativilca',4)


select * from E_Departamento 
select * from E_Provincia
select * from E_Distrito


--categoria 

insert into E_Categoría values (1,'Categoria Pre-infantes')
insert into E_Categoría values (2,'Categoria Infantes')
insert into E_Categoría values (3,'Categoria Infantil')
insert into E_Categoría values (4,'Categoria Júnior')
insert into E_Categoría values (5,'Categoria Juvenil')
insert into E_Categoría values (6,'Categoria Adultos')
insert into E_Categoría values (7,'Categoria Senior')
insert into E_Categoría values (8,'Categoria Master')
insert into E_Categoría values (9,'Categoria Oro')
insert into E_Categoría values (10,'no tiene categoria')

select * from E_Categoría

--Tipo de usuario

insert into E_TipoUsuario values (1,'alumno')
insert into E_TipoUsuario values (2,'secretaria')
insert into E_TipoUsuario values (3,'profesor')

select * from E_TipoUsuario

-- Nivel

insert into E_Nivel values (1,'basico')
insert into E_Nivel values (2,'intermedio')
insert into E_Nivel values (3,'avanzado')

select * from E_Nivel

--tipo de nivel

insert into E_TipoNivel values (1,'Pre-Infantil(3-6 años)')
insert into E_TipoNivel values (2,'Pre-Infantil(7-12 años)')
insert into E_TipoNivel values (3,'Pre-Infantil(13-a mas años)')

select * from E_TipoNivel 


select * from E_Usuario
