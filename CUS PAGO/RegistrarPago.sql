USE master;
GO
---------------
create database [BD_SGIAMTvsregistrarpago]


ALTER AUTHORIZATION ON DATABASE::BD_SGIAMT TO SA;
GO
--NO INCLUIR SOLO ESTA TABLA EN LA INTEGRACION
CREATE TABLE [dbo].[T_Usuario](
	[PK_IU_Dni] [int] NOT NULL,
	[VU_Nombre] [varchar](50) NOT NULL,
	[VU_APaterno] [varchar](50) NOT NULL,
	[VU_AMaterno] [varchar](50) NOT NULL,
	[VU_Celular] [int] NOT NULL,
	[VU_Correo] [varchar](50) NOT NULL,
	[VU_Direccion] [varchar](50) NOT NULL,
	[DU_FechaNacimiento] [date] NOT NULL,
	[VU_Sexo] [varchar](50) NOT NULL,
	[VU_Contraseña] [varchar](50) NOT NULL,
	[VU_Estado] [varchar](50) NOT NULL,
	[VU_Horario] [varchar](50) NOT NULL,
);
-----------------------
CREATE TABLE [dbo].[T_Pago](
	[PK_IP_Id] [int] NOT NULL IDENTITY(1,1),
	[VP_Valor] [money] NULL,
	[VP_Fecha] [date] NULL,
	[VP_Mes] [varchar](50) NULL,
	[VP_Año] [int] NULL,
	[VP_Pdf] [varbinary] NULL,
	[FK_IU_Dni] [int] NULL,
	[FK_ICP_Id] [int] NULL,
);
GO
CREATE TABLE [dbo].[T_Concepto_Pago](
	[PK_ICP_Id] [int] NOT NULL IDENTITY(1,1),
	[VCP_Descripcion] [varchar](50) NULL,
	[VCP_Valor] [money] NULL,
);
GO
--NO INCLUIR ESTA ALTERACION EN LA INTEGRACION
ALTER TABLE [dbo].[T_Usuario] ADD PRIMARY KEY ([PK_IU_Dni]);
GO
ALTER TABLE [dbo].[T_Pago] ADD PRIMARY KEY ([PK_IP_Id]);
GO
ALTER TABLE [dbo].[T_Concepto_Pago] ADD PRIMARY KEY ([PK_ICP_Id]);
GO
ALTER TABLE [dbo].[T_Pago] ADD  FOREIGN KEY ([FK_IU_Dni]) REFERENCES [dbo].[T_Usuario]([PK_IU_Dni]);
GO
ALTER TABLE [dbo].[T_Pago] ADD  FOREIGN KEY ([FK_ICP_Id]) REFERENCES [dbo].[T_Concepto_Pago]([PK_ICP_Id]);
GO
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Anual',30.00);
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Mensual',80.00);
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Total',110.00);
/*DE AQUI SON DATOS QUE UTILIZO PARA PRUEBAS, NO INCLUIR*/
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno],[VU_Celular],[VU_Correo],[VU_Direccion],[DU_FechaNacimiento],[VU_Sexo],[VU_Contraseña],[VU_Estado],[VU_Horario]) VALUES (18635870,'Alvera','Gebhard','Pickthorne',984324001,'correo','coricancha 745 zarate','17-01-1997','masculino','holamundo','inactivo','4:00-5:00 pm');


SELECT * FROM T_Pago