USE [master]
GO

/****** Object:  Database [CuentaPorCobtrarDB]    Script Date: 03/10/2016 10:34:39 p.m. ******/
DROP DATABASE [CuentaPorCobtrarDB]
GO

/****** Object:  Database [CuentaPorCobtrarDB]    Script Date: 03/10/2016 10:34:39 p.m. ******/
CREATE DATABASE [CuentaPorCobtrarDB]
GO

USE [CuentaPorCobtrarDB]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 03/10/2016 10:37:24 p.m. ******/
DROP TABLE [dbo].[Estado]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 03/10/2016 10:37:24 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estado](
	[Id] [int] NOT NULL,
	[Descripcion] [nchar](25) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [CuentaPorCobtrarDB]
GO

ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_Cliente_Estado]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 03/10/2016 10:37:01 p.m. ******/
DROP TABLE [dbo].[Cliente]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 03/10/2016 10:37:01 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] NOT NULL,
	[Nombre] [nchar](40) NOT NULL,
	[Cedula] [nchar](11) NOT NULL,
	[LimiteDeCredito] [money] NOT NULL,
	[IdEstado] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Estado] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estado] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Estado]
GO




USE [CuentaPorCobtrarDB]
GO

/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 03/10/2016 10:36:17 p.m. ******/
DROP TABLE [dbo].[TipoDocumento]
GO

/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 03/10/2016 10:36:17 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[TipoDocumento](
	[IdTipoDocumento] [int] NOT NULL,
	[Descripcion] [nchar](25) NOT NULL,
	[CuentaContable] [nchar](25) NOT NULL,
	[IdEstado] [int] NOT NULL
) ON [PRIMARY]

GO

USE [CuentaPorCobtrarDB]
GO

/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 03/10/2016 10:36:36 p.m. ******/
DROP TABLE [dbo].[TipoMovimiento]
GO

/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 03/10/2016 10:36:36 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TipoMovimiento](
	[IdTipoMovimiento] [int] NOT NULL,
	[Descripcion] [nchar](25) NOT NULL
) ON [PRIMARY]

GO



USE [CuentaPorCobtrarDB]
GO



ALTER TABLE [dbo].[Balance] DROP CONSTRAINT [FK_Balance_Cliente]
GO

/****** Object:  Table [dbo].[Balance]    Script Date: 03/10/2016 10:35:54 p.m. ******/
DROP TABLE [dbo].[Balance]
GO

/****** Object:  Table [dbo].[Balance]    Script Date: 03/10/2016 10:35:54 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Balance](
	[IdCliente] [int] NOT NULL,
	[FechaCorte] [date] NOT NULL,
	[AntiguedadPromedioSaldos] [money] NOT NULL,
	[Monto] [money] NOT NULL,
 CONSTRAINT [PK_Balance] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Balance]  WITH CHECK ADD  CONSTRAINT [FK_Balance_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO

ALTER TABLE [dbo].[Balance] CHECK CONSTRAINT [FK_Balance_Cliente]
GO




USE [CuentaPorCobtrarDB]
GO

/****** Object:  Table [dbo].[AsientoContable]    Script Date: 03/10/2016 10:35:35 p.m. ******/
DROP TABLE [dbo].[AsientoContable]
GO

/****** Object:  Table [dbo].[AsientoContable]    Script Date: 03/10/2016 10:35:35 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AsientoContable](
	[IdAsiento] [int] NOT NULL,
	[Descripcion] [nchar](50) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Cuenta] [nchar](30) NOT NULL,
	[IdTipoMovimiento] [int] NOT NULL,
	[FechaAsiento] [money] NOT NULL,
	[MontoAsiento] [money] NOT NULL,
	[IdEstado] [int] NOT NULL
) ON [PRIMARY]

GO


USE [CuentaPorCobtrarDB]
GO

/****** Object:  Table [dbo].[Transaccion]    Script Date: 03/10/2016 10:38:46 p.m. ******/
DROP TABLE [dbo].[Transaccion]
GO

/****** Object:  Table [dbo].[Transaccion]    Script Date: 03/10/2016 10:38:46 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transaccion](
	[IdTransaccion] [int] NOT NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [nchar](30) NOT NULL,
	[Fecha] [date] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Monto] [money] NOT NULL,
	[IdTipoMovimiento] [int] NOT NULL
) ON [PRIMARY]

GO

