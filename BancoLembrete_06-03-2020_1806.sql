USE [master]
GO
/****** Object:  Database [RndLembreteDataBase2]    Script Date: 06/03/2020 18:04:54 ******/
CREATE DATABASE [RndLembreteDataBase2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RndLembreteDataBase2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RndLembreteDataBase2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RndLembreteDataBase2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RndLembreteDataBase2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RndLembreteDataBase2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RndLembreteDataBase2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RndLembreteDataBase2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET ARITHABORT OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RndLembreteDataBase2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RndLembreteDataBase2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RndLembreteDataBase2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RndLembreteDataBase2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RndLembreteDataBase2] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [RndLembreteDataBase2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RndLembreteDataBase2] SET  MULTI_USER 
GO
ALTER DATABASE [RndLembreteDataBase2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RndLembreteDataBase2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RndLembreteDataBase2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RndLembreteDataBase2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RndLembreteDataBase2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RndLembreteDataBase2] SET QUERY_STORE = OFF
GO
USE [RndLembreteDataBase2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 06/03/2020 18:04:54 ******/
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
/****** Object:  Table [dbo].[Lembretes]    Script Date: 06/03/2020 18:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lembretes](
	[LembreteId] [int] IDENTITY(1,1) NOT NULL,
	[DescricaoLembrete] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[Visto] [bit] NOT NULL,
	[Efetuado] [bit] NOT NULL,
	[CadastradoPor] [nvarchar](max) NOT NULL,
	[DataCadastro] [datetime2](7) NOT NULL,
	[AlteradoPor] [nvarchar](max) NULL,
	[DataAlteracao] [datetime2](7) NOT NULL,
	[UsuarioId] [int] NULL,
 CONSTRAINT [PK_Lembretes] PRIMARY KEY CLUSTERED 
(
	[LembreteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/03/2020 18:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200306202831_InitialMigration', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Lembretes] ON 

INSERT [dbo].[Lembretes] ([LembreteId], [DescricaoLembrete], [Status], [Visto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao], [UsuarioId]) VALUES (1, N'ATUALIZAR TFS', 0, 0, 0, N'ADMIN', CAST(N'2020-03-06T00:00:00.0000000' AS DateTime2), N'ADMIN', CAST(N'2020-03-06T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Lembretes] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([UsuarioId], [NomeUsuario]) VALUES (1, N'MARCIO')
INSERT [dbo].[Usuarios] ([UsuarioId], [NomeUsuario]) VALUES (2, N'PAULO')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Index [IX_Lembretes_UsuarioId]    Script Date: 06/03/2020 18:04:54 ******/
CREATE NONCLUSTERED INDEX [IX_Lembretes_UsuarioId] ON [dbo].[Lembretes]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lembretes]  WITH CHECK ADD  CONSTRAINT [FK_Lembretes_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
GO
ALTER TABLE [dbo].[Lembretes] CHECK CONSTRAINT [FK_Lembretes_Usuarios_UsuarioId]
GO
USE [master]
GO
ALTER DATABASE [RndLembreteDataBase2] SET  READ_WRITE 
GO
