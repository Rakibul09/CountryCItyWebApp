USE [master]
GO
/****** Object:  Database [Data]    Script Date: 13-06-2015 02:43:04 PM ******/
CREATE DATABASE [Data]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Data', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Data.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Data_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Data_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Data] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Data].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Data] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Data] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Data] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Data] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Data] SET ARITHABORT OFF 
GO
ALTER DATABASE [Data] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Data] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Data] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Data] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Data] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Data] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Data] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Data] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Data] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Data] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Data] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Data] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Data] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Data] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Data] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Data] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Data] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Data] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Data] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Data] SET  MULTI_USER 
GO
ALTER DATABASE [Data] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Data] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Data] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Data] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Data]
GO
/****** Object:  Table [dbo].[City]    Script Date: 13-06-2015 02:43:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[ci_Id] [int] IDENTITY(1,1) NOT NULL,
	[ci_Name] [varchar](50) NOT NULL,
	[ci_About] [varchar](250) NOT NULL,
	[ci_NoofDwellers] [int] NOT NULL,
	[ci_Location] [varchar](50) NOT NULL,
	[ci_Weather] [varchar](50) NOT NULL,
	[c_id] [int] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[ci_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Country]    Script Date: 13-06-2015 02:43:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[c_Id] [int] IDENTITY(1,1) NOT NULL,
	[c_Name] [varchar](50) NOT NULL,
	[c_About] [varchar](250) NOT NULL,
	[c_TotalPopulation] [int] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[c_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([ci_Id], [ci_Name], [ci_About], [ci_NoofDwellers], [ci_Location], [ci_Weather], [c_id]) VALUES (1, N'Birgunj', N'Industrilist Area', 120000, N'West Side ', N'Normal', 1)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (1, N'Bangladesh', N'Beautiful country', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (2, N'Nepal', N'Beautiful country', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (3, N'Japan', N'Beautiful country', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (4, N'India', N'Beautiful country', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (5, N'America ', N'Land of Oppurtanities...', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (6, N'Srilanka', N'Land of Ravan', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (8, N'South Africa', N'Country of Nelson Mendela', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (9, N'vv', N'vv', 0)
INSERT [dbo].[Country] ([c_Id], [c_Name], [c_About], [c_TotalPopulation]) VALUES (10, N'Malaysia', N'Beautiful Country', 0)
SET IDENTITY_INSERT [dbo].[Country] OFF
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [DF_Country_TotalPopulation]  DEFAULT ((0)) FOR [c_TotalPopulation]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([c_id])
REFERENCES [dbo].[Country] ([c_Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Country]
GO
USE [master]
GO
ALTER DATABASE [Data] SET  READ_WRITE 
GO
