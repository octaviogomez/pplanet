USE [A]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumnos](
	[pk_alumno] [int] IDENTITY(1,1) NOT NULL,
	[rol] [int] NOT NULL,
	[id] [int] NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[activo] [int] NOT NULL,
	[correo] [varchar](50) NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellidos] [varchar](35) NOT NULL,
	[anioIngreso] [date] NULL,
	[anioEgreso] [date] NULL,
	[estadoPago] [int] NULL,
	[facebook] [varchar](50) NULL,
	[telefono] [varchar](30) NULL,
	[celular] [varchar](30) NULL,
	[sexo] [varbinary](2) NULL,
	[edad] [int] NULL,
	[nivel] [int] NOT NULL,
	[direccion] [varchar](50) NULL,
	[noClubs] [int] NULL,
	[noPelis] [int] NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[pk_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BuzonSugerencias]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BuzonSugerencias](
	[pk_buzonSugerencia] [int] IDENTITY(1,1) NOT NULL,
	[fk_alumno] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [varchar](20) NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_BuzonSugerencias] PRIMARY KEY CLUSTERED 
(
	[pk_buzonSugerencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_EstadoGenerico]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_EstadoGenerico](
	[pk_estadoGenerico] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cat_EstadoGenerico] PRIMARY KEY CLUSTERED 
(
	[pk_estadoGenerico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_EstadoReservacion]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_EstadoReservacion](
	[pk_estadoReservacion] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cat_EstadoReservacion] PRIMARY KEY CLUSTERED 
(
	[pk_estadoReservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_EstatusPago]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_EstatusPago](
	[pk_estatusPago] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cat_estatusPago] PRIMARY KEY CLUSTERED 
(
	[pk_estatusPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_Horarios]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_Horarios](
	[pk_horario] [int] NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [PK_cat_Horarios] PRIMARY KEY CLUSTERED 
(
	[pk_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_NivelIngles]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_NivelIngles](
	[pk_nivelIngles] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cat_NivelIngles] PRIMARY KEY CLUSTERED 
(
	[pk_nivelIngles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cat_TipoCitas]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cat_TipoCitas](
	[pk_tipoCitas] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[valor] [int] NOT NULL,
 CONSTRAINT [PK_cat_TipoCitas] PRIMARY KEY CLUSTERED 
(
	[pk_tipoCitas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[pk_cita] [int] IDENTITY(1,1) NOT NULL,
	[estado] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[fk_hora] [int] NOT NULL,
	[NoProfes] [int] NOT NULL,
	[id_registro] [int] NOT NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[pk_cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clubs](
	[pk_club] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[descripcion] [text] NULL,
	[estado] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[fk_hora] [int] NOT NULL,
	[fk_profesor] [int] NOT NULL,
	[cupo] [int] NOT NULL,
	[fk_tipoClub] [int] NOT NULL,
	[id_creacion] [int] NOT NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[pk_club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListaEspera]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ListaEspera](
	[pk_listaEspera] [int] IDENTITY(1,1) NOT NULL,
	[fk_alumno] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ListaEspera] PRIMARY KEY CLUSTERED 
(
	[pk_listaEspera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mensajes]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mensajes](
	[pk_mensaje] [int] IDENTITY(1,1) NOT NULL,
	[fk_alumno] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [varchar](20) NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_Mensajes] PRIMARY KEY CLUSTERED 
(
	[pk_mensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesor](
	[pk_profesor] [int] IDENTITY(1,1) NOT NULL,
	[rol] [int] NOT NULL,
	[id] [int] NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[activo] [int] NOT NULL,
	[correo] [varchar](50) NULL,
	[nombre] [varchar](35) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[anioIngreso] [date] NULL,
	[anioEgreso] [date] NULL,
	[telefono] [varchar](20) NOT NULL,
	[celular] [varchar](20) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[pk_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegistroCitas]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroCitas](
	[pk_registroCita] [int] IDENTITY(1,1) NOT NULL,
	[fk_cita] [int] NOT NULL,
	[fk_alumno] [int] NOT NULL,
	[fk_tipoCitas] [int] NOT NULL,
	[estadoReservacion] [int] NOT NULL,
	[id_registro] [int] NOT NULL,
 CONSTRAINT [PK_RegistroCitas] PRIMARY KEY CLUSTERED 
(
	[pk_registroCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RegistroClubs]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroClubs](
	[pk_registroClub] [int] IDENTITY(1,1) NOT NULL,
	[fk_club] [int] NOT NULL,
	[fk_alumno] [int] NOT NULL,
	[fk_maestro] [int] NOT NULL,
	[estadoReservacion] [int] NOT NULL,
	[pk_registro] [int] NOT NULL,
 CONSTRAINT [PK_RegistroClubs] PRIMARY KEY CLUSTERED 
(
	[pk_registroClub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[pk_rol] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[pk_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Secretaria]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Secretaria](
	[pk_secreatria] [int] IDENTITY(1,1) NOT NULL,
	[rol] [int] NOT NULL,
	[id] [int] NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[activo] [int] NOT NULL,
	[correo] [varchar](50) NULL,
	[nombre] [varchar](35) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[anioIngreso] [date] NULL,
	[anioEgreso] [date] NULL,
	[telefono] [varchar](20) NULL,
	[celular] [varchar](20) NULL,
 CONSTRAINT [PK_Secretaria] PRIMARY KEY CLUSTERED 
(
	[pk_secreatria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoClub]    Script Date: 04/02/2018 12:25:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoClub](
	[pk_tipoClub] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[valor] [int] NOT NULL,
 CONSTRAINT [PK_TipoClub] PRIMARY KEY CLUSTERED 
(
	[pk_tipoClub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
