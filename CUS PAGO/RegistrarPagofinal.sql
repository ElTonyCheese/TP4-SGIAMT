create database [BD_SGIAMTvsregistrarpago]

USE [BD_SGIAMTvsregistrarpago]
GO
/****** Object:  Table [dbo].[T_Concepto_Pago]    Script Date: 3/10/2019 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Concepto_Pago](
	[PK_ICP_Id] [int] IDENTITY(1,1) NOT NULL,
	[VCP_Descripcion] [varchar](50) NULL,
	[VCP_Valor] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_ICP_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Pago]    Script Date: 3/10/2019 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Pago](
	[PK_IP_Id] [int] IDENTITY(1,1) NOT NULL,
	[VP_Valor] [decimal](18, 0) NULL,
	[VP_Fecha] [date] NULL,
	[VP_Mes] [varchar](50) NULL,
	[VP_Año] [int] NULL,
	[VP_Pdf] [varbinary](1) NULL,
	[FK_IU_Dni] [int] NULL,
	[FK_ICP_Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_IP_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Usuario]    Script Date: 3/10/2019 14:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
PRIMARY KEY CLUSTERED 
(
	[PK_IU_Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[T_Pago]  WITH CHECK ADD FOREIGN KEY([FK_ICP_Id])
REFERENCES [dbo].[T_Concepto_Pago] ([PK_ICP_Id])
GO
ALTER TABLE [dbo].[T_Pago]  WITH CHECK ADD FOREIGN KEY([FK_IU_Dni])
REFERENCES [dbo].[T_Usuario] ([PK_IU_Dni])
GO
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Anual',30.00);
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Mensual',80.00);
INSERT INTO [dbo].[T_Concepto_Pago] ([VCP_Descripcion],[VCP_Valor]) VALUES ('Pago Total',110.00);
/*DE AQUI SON DATOS QUE UTILIZO PARA PRUEBAS, NO INCLUIR*/
INSERT INTO [dbo].[T_Usuario] ([PK_IU_Dni],[VU_Nombre],[VU_APaterno],[VU_AMaterno],[VU_Celular],[VU_Correo],[VU_Direccion],[DU_FechaNacimiento],[VU_Sexo],[VU_Contraseña],[VU_Estado],[VU_Horario]) VALUES (18635870,'Alvera','Gebhard','Pickthorne',984324001,'correo','coricancha 745 zarate','17-01-1997','masculino','holamundo','inactivo','4:00-5:00 pm');
SELECT * FROM T_Pago