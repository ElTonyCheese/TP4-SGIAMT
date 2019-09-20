USE [BD_SGIAMT]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_Categoría]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_Categoría](
	[PK_IC_Id] [int] NOT NULL,
	[VC_NombreCat] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_E_Categoría2] PRIMARY KEY CLUSTERED 
(
	[PK_IC_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_Distrito]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_Distrito](
	[PK_IDI_Cod] [int] NOT NULL,
	[VDI_NombreDis] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_E_Distrito5] PRIMARY KEY CLUSTERED 
(
	[PK_IDI_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_Nivel]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_Nivel](
	[PK_IN_Cod] [int] NOT NULL,
	[VN_NombreNivel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_E_Nivel7] PRIMARY KEY CLUSTERED 
(
	[PK_IN_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_NivelxTipoNivel]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_NivelxTipoNivel](
	[Nro_Alumno] [int] NOT NULL,
	[PK_ITN_Cod] [int] NOT NULL,
	[PK_IN_Cod] [int] NOT NULL,
	[PK_INTN_Cod] [int] NOT NULL,
	[PK_IU_Dni] [int] NOT NULL,
 CONSTRAINT [PK_E_NivelxTipoNivel_1] PRIMARY KEY CLUSTERED 
(
	[PK_INTN_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_TipoNivel]    Script Date: 17/09/2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_TipoNivel](
	[PK_ITN_Cod] [int] NOT NULL,
	[ITN_NombreTipoNivel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_E_TipoNivel8] PRIMARY KEY CLUSTERED 
(
	[PK_ITN_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_TipoUsuario]    Script Date: 17/09/2019 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_TipoUsuario](
	[PK_ITU_TipoUsuario] [int] NOT NULL,
	[VTU_NombreTipoUsuario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_E_TipoUsuario0] PRIMARY KEY CLUSTERED 
(
	[PK_ITU_TipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[E_Usuario]    Script Date: 17/09/2019 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[E_Usuario](
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
	[PK_ITU_TipoUsuario] [int] NOT NULL,
	[PK_IC_Id] [int] NOT NULL,
	[PK_IDI_Cod] [int] NOT NULL,
 CONSTRAINT [PK_T_E_Usuario3] PRIMARY KEY CLUSTERED 
(
	[PK_IU_Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel]  WITH CHECK ADD  CONSTRAINT [FK_E_NivelxTipoNivel_E_Usuario] FOREIGN KEY([PK_IU_Dni])
REFERENCES [dbo].[E_Usuario] ([PK_IU_Dni])
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel] CHECK CONSTRAINT [FK_E_NivelxTipoNivel_E_Usuario]
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel]  WITH CHECK ADD  CONSTRAINT [FK_T_E_NivelxTipoNivel7] FOREIGN KEY([PK_ITN_Cod])
REFERENCES [dbo].[E_TipoNivel] ([PK_ITN_Cod])
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel] CHECK CONSTRAINT [FK_T_E_NivelxTipoNivel7]
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel]  WITH CHECK ADD  CONSTRAINT [FK_T_E_NivelxTipoNivel8] FOREIGN KEY([PK_IN_Cod])
REFERENCES [dbo].[E_Nivel] ([PK_IN_Cod])
GO
ALTER TABLE [dbo].[E_NivelxTipoNivel] CHECK CONSTRAINT [FK_T_E_NivelxTipoNivel8]
GO
ALTER TABLE [dbo].[E_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_E_Usuario_E_Distrito] FOREIGN KEY([PK_IDI_Cod])
REFERENCES [dbo].[E_Distrito] ([PK_IDI_Cod])
GO
ALTER TABLE [dbo].[E_Usuario] CHECK CONSTRAINT [FK_E_Usuario_E_Distrito]
GO
ALTER TABLE [dbo].[E_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_E_Usuario0] FOREIGN KEY([PK_ITU_TipoUsuario])
REFERENCES [dbo].[E_TipoUsuario] ([PK_ITU_TipoUsuario])
GO
ALTER TABLE [dbo].[E_Usuario] CHECK CONSTRAINT [FK_T_E_Usuario0]
GO
ALTER TABLE [dbo].[E_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_E_Usuario2] FOREIGN KEY([PK_IC_Id])
REFERENCES [dbo].[E_Categoría] ([PK_IC_Id])
GO
ALTER TABLE [dbo].[E_Usuario] CHECK CONSTRAINT [FK_T_E_Usuario2]
GO
