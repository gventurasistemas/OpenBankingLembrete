USE [master]
GO
/****** Object:  Database [RndLembreteDataBase]    Script Date: 04/03/2020 15:55:16 ******/
CREATE DATABASE [RndLembreteDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RndLembreteDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RndLembreteDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RndLembreteDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RndLembreteDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RndLembreteDataBase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RndLembreteDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RndLembreteDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RndLembreteDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RndLembreteDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RndLembreteDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RndLembreteDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RndLembreteDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RndLembreteDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [RndLembreteDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RndLembreteDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RndLembreteDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RndLembreteDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RndLembreteDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RndLembreteDataBase] SET QUERY_STORE = OFF
GO
USE [RndLembreteDataBase]
GO
/****** Object:  Table [dbo].[HorariosAgendamento]    Script Date: 04/03/2020 15:55:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorariosAgendamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LembreteId] [int] NOT NULL,
	[HorarioLembrete] [smalldatetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorariosVisto]    Script Date: 04/03/2020 15:55:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorariosVisto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LembreteId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[HorarioQueFoiVisto] [smalldatetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lembretes]    Script Date: 04/03/2020 15:55:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lembretes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[DescricaoLembrete] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[Visto] [bit] NOT NULL,
	[Efetuado] [bit] NOT NULL,
	[CadastradoPor] [nvarchar](50) NOT NULL,
	[DataCadastro] [smalldatetime] NOT NULL,
	[AlteradoPor] [nvarchar](50) NULL,
	[DataAlteracao] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Lembretes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 04/03/2020 15:55:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HorariosAgendamento] ON 

INSERT [dbo].[HorariosAgendamento] ([Id], [LembreteId], [HorarioLembrete]) VALUES (1, 1, CAST(N'2020-03-04T16:00:00' AS SmallDateTime))
INSERT [dbo].[HorariosAgendamento] ([Id], [LembreteId], [HorarioLembrete]) VALUES (3, 2, CAST(N'2020-03-04T16:00:00' AS SmallDateTime))
INSERT [dbo].[HorariosAgendamento] ([Id], [LembreteId], [HorarioLembrete]) VALUES (4, 7, CAST(N'2020-03-04T16:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[HorariosAgendamento] OFF
SET IDENTITY_INSERT [dbo].[Lembretes] ON 

INSERT [dbo].[Lembretes] ([Id], [UsuarioId], [DescricaoLembrete], [Status], [Visto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao]) VALUES (1, 1, N'LOGAR NO SISTEMA ABC', 0, 0, 1, N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime), N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime))
INSERT [dbo].[Lembretes] ([Id], [UsuarioId], [DescricaoLembrete], [Status], [Visto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao]) VALUES (2, 2, N'INSERIR UPDATE', 1, 1, 1, N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime), N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime))
INSERT [dbo].[Lembretes] ([Id], [UsuarioId], [DescricaoLembrete], [Status], [Visto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao]) VALUES (7, 1, N'TESTAR APLICATIVO', 0, 0, 0, N'MASTER', CAST(N'2020-02-24T14:00:00' AS SmallDateTime), N'MASTER', CAST(N'2020-02-25T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Lembretes] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [NomeUsuario]) VALUES (1, N'MARCIO')
INSERT [dbo].[Usuarios] ([Id], [NomeUsuario]) VALUES (2, N'PEDRO')
INSERT [dbo].[Usuarios] ([Id], [NomeUsuario]) VALUES (3, N'JOÃO')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
USE [master]
GO
ALTER DATABASE [RndLembreteDataBase] SET  READ_WRITE 
GO
