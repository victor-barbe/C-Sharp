USE [master]
GO

/****** Object:  Database [grades_managment]    Script Date: 03/04/2022 23:53:38 ******/
CREATE DATABASE [grades_managment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'grades_managment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\grades_managment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'grades_managment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\grades_managment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [grades_managment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [grades_managment] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [grades_managment] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [grades_managment] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [grades_managment] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [grades_managment] SET ARITHABORT OFF 
GO

ALTER DATABASE [grades_managment] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [grades_managment] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [grades_managment] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [grades_managment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [grades_managment] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [grades_managment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [grades_managment] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [grades_managment] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [grades_managment] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [grades_managment] SET  DISABLE_BROKER 
GO

ALTER DATABASE [grades_managment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [grades_managment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [grades_managment] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [grades_managment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [grades_managment] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [grades_managment] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [grades_managment] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [grades_managment] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [grades_managment] SET  MULTI_USER 
GO

ALTER DATABASE [grades_managment] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [grades_managment] SET DB_CHAINING OFF 
GO

ALTER DATABASE [grades_managment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [grades_managment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [grades_managment] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [grades_managment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [grades_managment] SET QUERY_STORE = OFF
GO

ALTER DATABASE [grades_managment] SET  READ_WRITE 
GO


USE [grades_managment]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 03/04/2022 23:59:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course](
	[CourseID] [nvarchar](50) NOT NULL,
	[CoursName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [grades_managment]
GO

/****** Object:  Table [dbo].[Grade]    Script Date: 04/04/2022 00:00:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Grade](
	[StudentID] [nvarchar](50) NULL,
	[CourseID] [nvarchar](50) NULL,
	[Grade] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO

ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Course]
GO

ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO

ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Student]
GO

USE [grades_managment]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 04/04/2022 00:00:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Family] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

