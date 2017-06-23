USE [master]
GO
/****** Object:  Database [INGLES_SEM_MESTRE]    Script Date: 23/06/2017 09:40:44 ******/
CREATE DATABASE [INGLES_SEM_MESTRE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INGLES_SEM_MESTRE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEREBELO\MSSQL\DATA\INGLES_SEM_MESTRE.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'INGLES_SEM_MESTRE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEREBELO\MSSQL\DATA\INGLES_SEM_MESTRE_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INGLES_SEM_MESTRE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ARITHABORT OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET RECOVERY FULL 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET  MULTI_USER 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'INGLES_SEM_MESTRE', N'ON'
GO
USE [INGLES_SEM_MESTRE]
GO
/****** Object:  User [s536102]    Script Date: 23/06/2017 09:40:44 ******/
CREATE USER [s536102] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [s536101]    Script Date: 23/06/2017 09:40:44 ******/
CREATE USER [s536101] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [s536102]
GO
ALTER ROLE [db_owner] ADD MEMBER [s536101]
GO
/****** Object:  Table [dbo].[Licoes]    Script Date: 23/06/2017 09:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Licoes](
	[Numero] [bigint] NOT NULL,
	[Titulo] [nvarchar](100) NULL,
	[Materia_Portugues] [nvarchar](max) NULL,
	[Grupo] [int] NOT NULL CONSTRAINT [DF_Licoes_Grupo]  DEFAULT ((1)),
 CONSTRAINT [PK_Licoes] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lista_de_Traducoes]    Script Date: 23/06/2017 09:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_de_Traducoes](
	[Numero_Secao] [bigint] NOT NULL,
	[Numero_Lista_de_Traducoes] [bigint] IDENTITY(1,1) NOT NULL,
	[Ingles] [nvarchar](4000) NULL,
	[Traducao] [nvarchar](4000) NULL,
	[Transliteracao] [nvarchar](4000) NULL,
	[Fonetico] [nvarchar](4000) NULL,
	[Materia_Portugues] [nvarchar](max) NULL,
 CONSTRAINT [PK_Lista_de_Traducoes] PRIMARY KEY CLUSTERED 
(
	[Numero_Lista_de_Traducoes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Secao]    Script Date: 23/06/2017 09:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secao](
	[Numero] [bigint] NOT NULL,
	[Numero_Secao] [bigint] IDENTITY(1,1) NOT NULL,
	[Titulo_Secao] [nvarchar](100) NULL,
	[Materia_Portugues] [nvarchar](max) NULL,
 CONSTRAINT [PK_Secao_1] PRIMARY KEY CLUSTERED 
(
	[Numero_Secao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Lista_de_Traducoes]  WITH CHECK ADD  CONSTRAINT [FK_Lista_de_Traducoes_Secao] FOREIGN KEY([Numero_Secao])
REFERENCES [dbo].[Secao] ([Numero_Secao])
GO
ALTER TABLE [dbo].[Lista_de_Traducoes] CHECK CONSTRAINT [FK_Lista_de_Traducoes_Secao]
GO
ALTER TABLE [dbo].[Secao]  WITH CHECK ADD  CONSTRAINT [FK_Secao_Licoes] FOREIGN KEY([Numero])
REFERENCES [dbo].[Licoes] ([Numero])
GO
ALTER TABLE [dbo].[Secao] CHECK CONSTRAINT [FK_Secao_Licoes]
GO
USE [master]
GO
ALTER DATABASE [INGLES_SEM_MESTRE] SET  READ_WRITE 
GO
