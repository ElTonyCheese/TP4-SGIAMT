

--provincia paita

insert into T_Distrito values (1,'Ancón')
insert into T_Distrito values (2,'Ate Vitarte')

--provincia huancabamba

insert into T_Distrito values (3,'barranco')
insert into T_Distrito values (4,'breña')


--provincia lima

insert into T_Distrito values (5,'chorrillo')
insert into T_Distrito values (6,'comas')

--provincia barranca

insert into T_Distrito values (7,'lima')
insert into T_Distrito values (8,'cieneguilla')






--categoria 

insert into T_Categoría values (1,'Categoria Pre-infantes')
insert into T_Categoría values (2,'Categoria Infantes')
insert into T_Categoría values (3,'Categoria Infantil')
insert into T_Categoría values (4,'Categoria Júnior')
insert into T_Categoría values (5,'Categoria Juvenil')
insert into T_Categoría values (6,'Categoria Adultos')
insert into T_Categoría values (7,'Categoria Senior')
insert into T_Categoría values (8,'Categoria Master')
insert into T_Categoría values (9,'Categoria Oro')
insert into T_Categoría values (10,'no tiene categoria')




--Tipo de usuario

insert into T_TipoUsuario values (1,'alumno')
insert into T_TipoUsuario values (2,'secretaria')
insert into T_TipoUsuario values (3,'profesor')



-- Nivel

insert into T_Nivel values (1,'basico')
insert into T_Nivel values (2,'intermedio')
insert into T_Nivel values (3,'avanzado')



--tipo de nivel

insert into T_TipoNivel values (1,'Pre-Infantil(3-6 años)')
insert into T_TipoNivel values (2,'infantes(7-12 años)')
insert into T_TipoNivel values (3,'Adulto(13-a mas años)')

select * from T_TipoNivel 
select * from T_Nivel
select * from T_Distrito
select * from T_Categoría


select * from T_TipoUsuario
select * from T_Usuario

delete from T_NivelxTipoNivel

delete from T_Usuario

select * from T_NivelxTipoNivel



