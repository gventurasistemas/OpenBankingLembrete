
IF NOT EXISTS(SELECT * FROM sys.databases where name = 'RndLembreteDataBase')
CREATE DATABASE RndLembreteDataBase
GO

USE [RndLembreteDataBase]
GO
/****** Object:  Table [dbo].[Lembretes]    Script Date: 24/02/2020 20:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lembretes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [nvarchar](20) NOT NULL,
	[DescricaoLembrete] [nvarchar](max) NOT NULL,
	[HorarioLembrete] [smalldatetime] NOT NULL,
	[Status] [bit] NOT NULL,
	[Visto] [bit] NOT NULL,
	[HorarioQueFoiVisto] [smalldatetime] NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Lembretes] ON 

INSERT [dbo].[Lembretes] ([Id], [NomeUsuario], [DescricaoLembrete], [HorarioLembrete], [Status], [Visto], [HorarioQueFoiVisto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao]) VALUES (1, N'TESTE', N'LOGAR NO SISTEMA', CAST(N'2020-02-24T18:00:00' AS SmallDateTime), 0, 1, CAST(N'2020-02-24T18:02:00' AS SmallDateTime), 1, N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime), N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime))
INSERT [dbo].[Lembretes] ([Id], [NomeUsuario], [DescricaoLembrete], [HorarioLembrete], [Status], [Visto], [HorarioQueFoiVisto], [Efetuado], [CadastradoPor], [DataCadastro], [AlteradoPor], [DataAlteracao]) VALUES (2, N'TESTE-2', N'LOGAR NO SISTEMA', CAST(N'2020-02-24T18:00:00' AS SmallDateTime), 1, 1, CAST(N'2020-02-24T18:02:00' AS SmallDateTime), 1, N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime), N'ADMIN', CAST(N'2020-02-24T14:02:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Lembretes] OFF
