USE [master]
GO
/****** Object:  Database [Jueves]    Script Date: 07/11/2016 12:52:55 ******/
CREATE DATABASE [Jueves]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Jueves', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Jueves.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Jueves_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Jueves_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Jueves] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Jueves].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Jueves] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Jueves] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Jueves] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Jueves] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Jueves] SET ARITHABORT OFF 
GO
ALTER DATABASE [Jueves] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Jueves] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Jueves] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Jueves] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Jueves] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Jueves] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Jueves] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Jueves] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Jueves] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Jueves] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Jueves] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Jueves] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Jueves] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Jueves] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Jueves] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Jueves] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Jueves] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Jueves] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Jueves] SET  MULTI_USER 
GO
ALTER DATABASE [Jueves] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Jueves] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Jueves] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Jueves] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Jueves] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Jueves]
GO
/****** Object:  UserDefinedTableType [dbo].[T_LibrosAutores]    Script Date: 07/11/2016 12:52:55 ******/
CREATE TYPE [dbo].[T_LibrosAutores] AS TABLE(
	[IdAutor] [int] NOT NULL,
	[ISBN] [varchar](50) NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TLibrosAutores]    Script Date: 07/11/2016 12:52:55 ******/
CREATE TYPE [dbo].[TLibrosAutores] AS TABLE(
	[ISBN] [varchar](50) NOT NULL,
	[IdAutor] [int] NOT NULL
)
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autores](
	[IdAutor] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Nacionalidad] [varchar](30) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Editoriales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Editoriales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Generos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Libros](
	[ISBN] [varchar](50) NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Edicion] [int] NOT NULL,
	[idGenero] [int] NOT NULL,
	[idEditorial] [int] NOT NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LibrosAutores]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LibrosAutores](
	[ISBN] [varchar](50) NOT NULL,
	[IdAutor] [int] NOT NULL,
 CONSTRAINT [PK_LibrosAutores] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC,
	[IdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Nombre] [nchar](10) NULL,
	[Clave] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_Libros]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[v_Libros]
as
select isbn,isbn + ' ' + Titulo as Libro
from Libros 

GO
/****** Object:  View [dbo].[vista_autores]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista_autores]
as
select idAutor as codigo,
	   Apellido,
	   Nombre,
	   FechaNacimiento,
	   Nacionalidad
from Autores





GO
/****** Object:  View [dbo].[vista_libro]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vista_libro]
as
select 
	l.ISBN ,
	l.Titulo as Nombre,
	l.Edicion,
	g.Descripcion as Genero,
	e.Descripcion as Editorial
from Libros as l
join Generos as g on l.IDGenero=g.ID
join Editoriales as e on e.ID=l.IDEditorial




GO
/****** Object:  View [dbo].[vista_libros]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vista_libros]
as
select 
	l.ISBN ,
	l.Titulo as Nombre,
	l.Edicion,
	g.Descripcion as Genero,
	e.Descripcion as Editorial
from Libros as l
join Generos as g on l.IDGenero=g.ID
join Editoriales as e on e.ID=l.IDEditorial




GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (1, N'Borges', N'Jorge Luis', CAST(N'1920-10-20' AS Date), N'Colombia')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (2, N'Cortazar', N'Julio', CAST(N'1930-10-20' AS Date), N'Colombia')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (3, N'Garcia Marquez', N'Gabriel', CAST(N'1931-10-20' AS Date), N'Colombia')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (4, N'Bioy Casares', N'Adolfo', CAST(N'1926-10-20' AS Date), N'Colombia')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (5, N'Pigna', N'Felipe', CAST(N'1962-10-20' AS Date), N'Argentina')
GO
INSERT [dbo].[Autores] ([IdAutor], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (6, N'Neruda', N'Pablo', CAST(N'1917-10-20' AS Date), N'Chile')
GO
SET IDENTITY_INSERT [dbo].[Autores] OFF
GO
SET IDENTITY_INSERT [dbo].[Editoriales] ON 

GO
INSERT [dbo].[Editoriales] ([ID], [Descripcion]) VALUES (1, N'Sudamericana')
GO
INSERT [dbo].[Editoriales] ([ID], [Descripcion]) VALUES (2, N'Planeta')
GO
INSERT [dbo].[Editoriales] ([ID], [Descripcion]) VALUES (3, N'Alfaguara')
GO
INSERT [dbo].[Editoriales] ([ID], [Descripcion]) VALUES (4, N'Santillana')
GO
SET IDENTITY_INSERT [dbo].[Editoriales] OFF
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 

GO
INSERT [dbo].[Generos] ([ID], [Descripcion]) VALUES (3, N'Policial')
GO
INSERT [dbo].[Generos] ([ID], [Descripcion]) VALUES (5, N'Novela')
GO
INSERT [dbo].[Generos] ([ID], [Descripcion]) VALUES (6, N'Autobiografia')
GO
INSERT [dbo].[Generos] ([ID], [Descripcion]) VALUES (7, N'Drama')
GO
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'114455', N'El mensaje de los sabios', 2002, 2, 3)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1188', N'Mitos de la Argentina I', 2005, 3, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'121212', N'wwwwww', 222, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'121244', N'borrar', 1980, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'123', N'El Aleph', 1973, 2, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1232323', N'23232', 1978, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'124', N'Rayuela', 1976, 1, 5)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'125', N'100 años de soledad', 1963, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'126', N'Aprenda PHP en 12 Hs', 2016, 3, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'128', N'La Biblia de ASP NET', 2004, 5, 4)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1298', N'El Tunel', 1967, 2, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1299', N'El Cartero', 1979, 1, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'135', N'Obras Completas', 2000, 2, 3)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'138', N'El Principito', 2014, 3, 3)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1455', N'Aprenda PHP en 21 hs', 2012, 1, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'1818', N'dfdfdf', 1818, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'199', N'Borrar de prueba', 1950, 2, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'222', N'Steve Jobs', 2014, 1, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'2222344', N'33244343', 1970, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'22344', N'La Biblia de VB 6.0', 2000, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'2434', N'Nuevo Libro', 1970, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'2545', N'Eee', 1970, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'321', N'Sobre Heroes y Tumbas', 2009, 3, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'3333', N'PROGRAMACION EN PYTHON', 2014, 7, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'33333', N'3333333333', 1970, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'33334555', N'Borrar5', 1978, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'4445', N'El Capital', 1944, 3, 4)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'454545454', N'COMO CERRAR LOS PARTIDOS', 1970, 3, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'45566', N'En Marcha', 2016, 5, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'556677', N'1984', 1960, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'5666', N'El Libro de la selva Parte 1', 2011, 2, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'6655', N'Nuevo Libro', 1970, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'778788', N'33333333334', 1978, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'888', N'Los Mitos de Arg. Tomo III', 2008, 5, 2)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'909', N'El Señor de los anillos', 2010, 2, 5)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'929292', N'Nuevo Libro 3', 1978, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'992233', N'Como programar en C++', 2004, 1, 1)
GO
INSERT [dbo].[Libros] ([ISBN], [Titulo], [Edicion], [idGenero], [idEditorial]) VALUES (N'998899', N'Poemas', 1976, 2, 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'114455', 9)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1188', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'121212', 0)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'121212', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'121244', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'121244', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'123', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'123', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1232323', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1232323', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'124', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'124', 6)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'125', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'125', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'125', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'126', 0)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'128', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'128', 6)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'128', 11)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1298', 129)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1299', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1299', 6)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1299', 129)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'135', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'135', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'135', 11)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'138', 33)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1455', 0)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1455', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1818', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'1818', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'199', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'199', 4)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'199', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'222', 8)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'222', 10)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2222344', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2222344', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'22344', 0)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'22344', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2434', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2434', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2545', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'2545', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'321', 6)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'321', 8)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33333', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33333', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33334555', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33334555', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33334555', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'33334555', 6)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'454545454', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'454545454', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'556677', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'5666', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'6655', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'6655', 9)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'778788', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'778788', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'888', 5)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'929292', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'929292', 3)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'992233', 1)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'992233', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'998899', 2)
GO
INSERT [dbo].[LibrosAutores] ([ISBN], [IdAutor]) VALUES (N'998899', 3)
GO
INSERT [dbo].[Usuarios] ([Nombre], [Clave]) VALUES (N'Admin     ', N'123       ')
GO
INSERT [dbo].[Usuarios] ([Nombre], [Clave]) VALUES (N'Pedro     ', N'124       ')
GO
INSERT [dbo].[Usuarios] ([Nombre], [Clave]) VALUES (N'Juan      ', N'125       ')
GO
ALTER TABLE [dbo].[LibrosAutores]  WITH CHECK ADD  CONSTRAINT [FK_LibrosAutores_Libros] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Libros] ([ISBN])
GO
ALTER TABLE [dbo].[LibrosAutores] CHECK CONSTRAINT [FK_LibrosAutores_Libros]
GO
/****** Object:  StoredProcedure [dbo].[proc_alta]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_alta]
(
	@Tabla nvarchar(50),
	@Descripcion nvarchar(50)

)
as
declare @sentencia nvarchar(200)
set @sentencia='Insert into '+ @Tabla + '(Descripcion) Values ('''+@Descripcion+''')' 
execute(@sentencia)





GO
/****** Object:  StoredProcedure [dbo].[proc_alta_libro]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_alta_libro]
(
	/* argumentos */
	@ISBN nvarchar(50),
	@Titulo nvarchar(50),
	@Edicion int,
	@idGenero int,
	@idEditorial int,
	@Autores TLibrosAutores readOnly
)
as
/* cuerpo principal */
/*BEGIN TRY*/
  BEGIN TRANSACTION
	insert Libros
	(ISBN,titulo,edicion,idgenero,ideditorial)
	values(@ISBN ,@Titulo ,
			  @Edicion ,
			  @idGenero ,
	          @idEditorial )
	/* insert de librosAutores*/
	insert LibrosAutores 
	select * from @Autores

	COMMIT TRANSACTION
/*END TRY
BEGIN CATCH
	RAISERROR('ERROR, NO SE PUDO DAR EL ALTA EL LIBRO ',16,1)
	ROLLBACK TRANSACTION
END CATCH*/



GO
/****** Object:  StoredProcedure [dbo].[proc_baja]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_baja]
(
	@Tabla nvarchar(50),
	@id int

)
as
declare @sentencia nvarchar(200)
set @sentencia='Delete '+ @Tabla + ' where id='+Convert(varchar(20),@id) 
execute(@sentencia)





GO
/****** Object:  StoredProcedure [dbo].[proc_modi_libro]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_modi_libro]
(
	@ISBN varchar(50),
	@Titulo varchar(50),
	@Edicion int,
	@idGenero int,
	@idEditorial int
)
as
update libros
set Titulo=@Titulo,
	Edicion=@Edicion,
	Idgenero=@idGenero,
	idEDitorial=@idEditorial
where isbn=@isbn
GO
/****** Object:  StoredProcedure [dbo].[proc_modifica]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_modifica]
(
	@Tabla nvarchar(50),
	@id int,
	@Descripcion nvarchar(50)

)
as
declare @sentencia nvarchar(200)
set @sentencia='Update '+ @Tabla + ' set descripcion='''+@Descripcion+''' where id='+Convert(varchar(20),@id) 
execute(@sentencia)





GO
/****** Object:  StoredProcedure [dbo].[proc_modifica_autor]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_modifica_autor]
/* parametros */
(
	@IdAutor int,
	@Apellido varchar(30),
	@Nombre varchar(30),
	@FechaNacimiento date,
	@Nacionalidad varchar(30)
)
as
/* cuerpo principal*/
update autores
set Apellido=@Apellido,
    Nombre=@Nombre,
	FechaNacimiento =@FechaNacimiento,
	Nacionalidad = @Nacionalidad
where IdAutor=@IdAutor





GO
/****** Object:  StoredProcedure [dbo].[proc_traer]    Script Date: 07/11/2016 12:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_traer]
( @Tabla nvarchar(20) )
as
declare @sentencia nvarchar(200)
set @sentencia='select * from ' + @Tabla 
execute (@sentencia)





GO
USE [master]
GO
ALTER DATABASE [Jueves] SET  READ_WRITE 
GO
