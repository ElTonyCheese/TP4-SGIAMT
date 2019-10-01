

--provincia paita

insert into E_Distrito values (1,'Ancón')
insert into E_Distrito values (2,'Ate Vitarte')

--provincia huancabamba

insert into E_Distrito values (3,'barranco')
insert into E_Distrito values (4,'breña')


--provincia lima

insert into E_Distrito values (5,'chorrillo')
insert into E_Distrito values (6,'comas')

--provincia barranca

insert into E_Distrito values (7,'lima')
insert into E_Distrito values (8,'cieneguilla')


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
select * from E_NivelxTipoNivel


