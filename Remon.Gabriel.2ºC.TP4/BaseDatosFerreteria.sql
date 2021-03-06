USE [master]
GO
/****** Object:  Database [Ferreteria]    Script Date: 20/6/2022 07:15:53 ******/
CREATE DATABASE [Ferreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ferreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ferreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ferreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ferreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ferreteria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ferreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ferreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ferreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ferreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ferreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ferreteria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ferreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ferreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ferreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ferreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ferreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ferreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ferreteria] SET RECOVERY FULL 
GO
ALTER DATABASE [Ferreteria] SET  MULTI_USER 
GO
ALTER DATABASE [Ferreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ferreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ferreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ferreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ferreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ferreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ferreteria', N'ON'
GO
ALTER DATABASE [Ferreteria] SET QUERY_STORE = OFF
GO
USE [Ferreteria]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 20/6/2022 07:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](max) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[dni] [int] NOT NULL,
	[estadoFiscal] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 20/6/2022 07:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](max) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[dni] [int] NOT NULL,
	[fechaContratacion] [datetime] NOT NULL,
	[sueldo] [decimal](18, 0) NOT NULL,
	[cargo] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoStock]    Script Date: 20/6/2022 07:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoStock](
	[precio] [decimal](18, 0) NOT NULL,
	[cantidadStock] [int] NOT NULL,
	[cantidadEstandar] [int] NOT NULL,
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoVenta]    Script Date: 20/6/2022 07:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoVenta](
	[precio] [decimal](18, 0) NOT NULL,
	[cantidadVentidos] [int] NOT NULL,
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[idVenta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 20/6/2022 07:15:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id] [int] NOT NULL,
	[fechaCompra] [datetime] NOT NULL,
	[dniComprado] [int] NOT NULL,
	[ventaRealizada] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'20201036', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'juan', N'martitegui', CAST(N'1990-06-06T15:34:13.000' AS DateTime), 20201036, 0)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'40150365', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'Gabriel', N'Martinez', CAST(N'1995-07-13T15:34:13.000' AS DateTime), 40150365, 0)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'40000205', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'Micaela', N'Dominguez', CAST(N'2000-04-07T15:34:13.000' AS DateTime), 40000205, 0)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'100204015', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'Pepe', N'Juanito', CAST(N'1973-02-06T15:34:13.000' AS DateTime), 100204015, 0)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'20365189', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'Fabian', N'Dominguez', CAST(N'1973-08-24T15:34:13.000' AS DateTime), 20365189, 2)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'35168971', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'Milagros', N'Suarez', CAST(N'1990-11-15T15:34:13.000' AS DateTime), 35168971, 1)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'10222333', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'pepe', N'ortiz', CAST(N'2022-06-03T15:34:13.000' AS DateTime), 10222333, 0)
INSERT [dbo].[Cliente] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [estadoFiscal]) VALUES (N'10100100', N'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', N'pepe', N'rodriguez', CAST(N'1999-11-25T15:34:13.000' AS DateTime), 10100100, 3)
GO
INSERT [dbo].[Empleado] ([usuario], [contraseña], [nombre], [apellido], [fechaNacimiento], [dni], [fechaContratacion], [sueldo], [cargo]) VALUES (N'22333444', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'pepe', N'dominguez', CAST(N'1995-05-30T15:34:13.000' AS DateTime), 22333444, CAST(N'1995-05-30T15:34:13.000' AS DateTime), CAST(40000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(2500 AS Decimal(18, 0)), 3, 2, 102032, N'moladora 400W')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(2 AS Decimal(18, 0)), 200, 200, 203233, N'Tornillo Fix metrica: Milimetrico')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(250 AS Decimal(18, 0)), 4, 2, 202031, N'Destornillador Philips 4x30')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(250 AS Decimal(18, 0)), 0, 2, 202032, N'Destornillador Philips 4x50')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(300 AS Decimal(18, 0)), 0, 2, 202033, N'Destornillador Philips 4x60')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(350 AS Decimal(18, 0)), 0, 2, 202034, N'Destornillador Philips 5x30')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(360 AS Decimal(18, 0)), 2, 3, 202035, N'Destornillador Philips 5x45')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(400 AS Decimal(18, 0)), 6, 2, 202036, N'Destornillador Philips 5x60')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(5 AS Decimal(18, 0)), 208, 400, 153001, N'Tornillo Fix metrica: Otro')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(6 AS Decimal(18, 0)), 0, 400, 153002, N'Tornillo Fix metrica: Otro')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(7 AS Decimal(18, 0)), 300, 200, 153003, N'Tornillo Fix metrica: Otro')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(15 AS Decimal(18, 0)), 0, 100, 204001, N'Tornillo Bulon metrica: Pulgada')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(20 AS Decimal(18, 0)), 0, 100, 154001, N'Tornillo Bulon metrica: Pulgada')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(50 AS Decimal(18, 0)), 40, 30, 154002, N'Tornillo Bulon metrica: Pulgada')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(800 AS Decimal(18, 0)), 10, 10, 101001, N'caño PVC, 40 Ø  largo: 4 ')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(1000 AS Decimal(18, 0)), 6, 8, 101002, N'caño PVC, 50 Ø  largo: 4 ')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(1400 AS Decimal(18, 0)), 8, 8, 101003, N'caño PVC, 60 Ø  largo: 4 ')
INSERT [dbo].[ProductoStock] ([precio], [cantidadStock], [cantidadEstandar], [codigo], [descripcion]) VALUES (CAST(1800 AS Decimal(18, 0)), 6, 8, 101004, N'caño PVC, 110 Ø  largo: 4 ')
GO
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(300 AS Decimal(18, 0)), 2, 202033, N'Destornillador Philips 4x60', 0)
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(6 AS Decimal(18, 0)), 200, 153002, N'Tornillo Fix metrica: Otro', 1)
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(350 AS Decimal(18, 0)), 3, 202034, N'Destornillador Philips 5x30', 2)
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(15 AS Decimal(18, 0)), 200, 204001, N'Tornillo Bulon metrica: Pulgada', 3)
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(20 AS Decimal(18, 0)), 50, 154001, N'Tornillo Bulon metrica: Pulgada', 4)
INSERT [dbo].[ProductoVenta] ([precio], [cantidadVentidos], [codigo], [descripcion], [idVenta]) VALUES (CAST(250 AS Decimal(18, 0)), 4, 202032, N'Destornillador Philips 4x50', 4)
GO
INSERT [dbo].[Venta] ([id], [fechaCompra], [dniComprado], [ventaRealizada]) VALUES (0, CAST(N'2022-06-19T00:02:01.623' AS DateTime), 100204015, 1)
INSERT [dbo].[Venta] ([id], [fechaCompra], [dniComprado], [ventaRealizada]) VALUES (1, CAST(N'2022-06-19T00:07:16.653' AS DateTime), 20365189, 0)
INSERT [dbo].[Venta] ([id], [fechaCompra], [dniComprado], [ventaRealizada]) VALUES (2, CAST(N'2022-06-19T00:10:59.623' AS DateTime), 100204015, 0)
INSERT [dbo].[Venta] ([id], [fechaCompra], [dniComprado], [ventaRealizada]) VALUES (3, CAST(N'2022-06-19T01:57:08.610' AS DateTime), 20201036, 1)
INSERT [dbo].[Venta] ([id], [fechaCompra], [dniComprado], [ventaRealizada]) VALUES (4, CAST(N'2022-06-19T14:06:06.323' AS DateTime), 100204015, 1)
GO
USE [master]
GO
ALTER DATABASE [Ferreteria] SET  READ_WRITE 
GO
