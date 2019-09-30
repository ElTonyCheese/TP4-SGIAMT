USE master;
GO
---------------
CREATE DATABASE BD_SGIAMT;
GO
USE BD_SGIAMT;
GO
ALTER AUTHORIZATION ON DATABASE::BD_SGIAMT TO SA;
GO
--NO INCLUIR SOLO ESTA TABLA EN LA INTEGRACION
CREATE TABLE [dbo].[T_Usuario](
	[PK_IU_Dni] [int] NOT NULL,
	[VU_Nombre] [varchar](50) NULL,
	[VU_APaterno] [varchar](50) NULL,
	[VU_AMaterno] [varchar](50) NULL,
);
-----------------------
CREATE TABLE [dbo].[T_Pago](
	[PK_IP_Id] [int] NOT NULL IDENTITY(1,1),
	[VP_Valor] [money] NULL,
	[VP_Fecha] [date] NULL,
	[VP_Mes] [varchar](50) NULL,
	[VP_A�o] [int] NULL,
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
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('MATRICULA',30.00);
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('MENSUALIDAD',80.00);
/*DE AQUI SON DATOS QUE UTILIZO PARA PRUEBAS, NO INCLUIR*/
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (18635870,'Alvera','Gebhard','Pickthorne');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (55753213,'Timmy','Cozby','Kort');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (98171851,'Wittie','Fairn','Grinstead');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (10325966,'Lorita','Trighton','Trenbay');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (83545288,'Lucien','McIlhone','Blackborough');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (15043998,'Bryce','Robathon','Ozelton');
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno]) VALUES (80715877,'Rhea','Locksley','Plett');