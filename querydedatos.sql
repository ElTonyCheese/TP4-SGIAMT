

--provincia paita

insert into E_Distrito values (1,'Anc�n')
insert into E_Distrito values (2,'Ate Vitarte')

--provincia huancabamba

insert into E_Distrito values (3,'barranco')
insert into E_Distrito values (4,'bre�a')


--provincia lima

insert into E_Distrito values (5,'chorrillo')
insert into E_Distrito values (6,'comas')

--provincia barranca

insert into E_Distrito values (7,'lima')
insert into E_Distrito values (8,'cieneguilla')


select * from E_Distrito



--categoria 

insert into E_Categor�a values (1,'Categoria Pre-infantes')
insert into E_Categor�a values (2,'Categoria Infantes')
insert into E_Categor�a values (3,'Categoria Infantil')
insert into E_Categor�a values (4,'Categoria J�nior')
insert into E_Categor�a values (5,'Categoria Juvenil')
insert into E_Categor�a values (6,'Categoria Adultos')
insert into E_Categor�a values (7,'Categoria Senior')
insert into E_Categor�a values (8,'Categoria Master')
insert into E_Categor�a values (9,'Categoria Oro')
insert into E_Categor�a values (10,'no tiene categoria')

select * from E_Categor�a


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

insert into E_TipoNivel values (1,'Pre-Infantil(3-6 a�os)')
insert into E_TipoNivel values (2,'Pre-Infantil(7-12 a�os)')
insert into E_TipoNivel values (3,'Pre-Infantil(13-a mas a�os)')

select * from E_TipoNivel 


select * from E_Usuario
select * from E_NivelxTipoNivel


