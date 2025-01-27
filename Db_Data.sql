USE [master]
GO
/****** Object:  Database [CramSchool]    Script Date: 9/16/2024 3:54:25 AM ******/
CREATE DATABASE [CramSchool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CramSchool', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CramSchool.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CramSchool_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CramSchool_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CramSchool] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CramSchool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CramSchool] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CramSchool] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CramSchool] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CramSchool] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CramSchool] SET ARITHABORT OFF 
GO
ALTER DATABASE [CramSchool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CramSchool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CramSchool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CramSchool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CramSchool] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CramSchool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CramSchool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CramSchool] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CramSchool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CramSchool] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CramSchool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CramSchool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CramSchool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CramSchool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CramSchool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CramSchool] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CramSchool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CramSchool] SET RECOVERY FULL 
GO
ALTER DATABASE [CramSchool] SET  MULTI_USER 
GO
ALTER DATABASE [CramSchool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CramSchool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CramSchool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CramSchool] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CramSchool] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CramSchool] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CramSchool', N'ON'
GO
ALTER DATABASE [CramSchool] SET QUERY_STORE = ON
GO
ALTER DATABASE [CramSchool] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CramSchool]
GO
/****** Object:  Table [dbo].[TblLecture]    Script Date: 9/16/2024 3:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLecture](
	[lectureId] [tinyint] IDENTITY(1,1) NOT NULL,
	[lectureName] [varchar](20) NULL,
 CONSTRAINT [PK_TblLecture] PRIMARY KEY CLUSTERED 
(
	[lectureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSchedule]    Script Date: 9/16/2024 3:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSchedule](
	[courseId] [int] IDENTITY(1,1) NOT NULL,
	[lecture] [tinyint] NULL,
	[teacher] [tinyint] NULL,
	[student] [smallint] NULL,
	[courseDate] [varchar](10) NULL,
	[courseHour] [char](5) NULL,
	[courseStatus] [bit] NULL,
 CONSTRAINT [PK_TblSchedule] PRIMARY KEY CLUSTERED 
(
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudent]    Script Date: 9/16/2024 3:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudent](
	[stdId] [smallint] IDENTITY(1,1) NOT NULL,
	[stdName] [varchar](20) NULL,
	[stdSurname] [varchar](20) NULL,
	[stdPicture] [varchar](max) NULL,
	[stdClass] [char](2) NULL,
	[stdPhone] [varchar](20) NULL,
	[stdMail] [varchar](50) NULL,
 CONSTRAINT [PK_TblStudent] PRIMARY KEY CLUSTERED 
(
	[stdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTeacher]    Script Date: 9/16/2024 3:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTeacher](
	[thcId] [tinyint] IDENTITY(1,1) NOT NULL,
	[thcName] [varchar](20) NULL,
	[thcSurname] [varchar](20) NULL,
	[thcLecture] [tinyint] NULL,
 CONSTRAINT [PK_TblTeacher] PRIMARY KEY CLUSTERED 
(
	[thcId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblSchedule] ADD  CONSTRAINT [DF_TblSchedule_status]  DEFAULT ((0)) FOR [courseStatus]
GO
ALTER TABLE [dbo].[TblSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TblSchedule_TblLecture] FOREIGN KEY([lecture])
REFERENCES [dbo].[TblLecture] ([lectureId])
GO
ALTER TABLE [dbo].[TblSchedule] CHECK CONSTRAINT [FK_TblSchedule_TblLecture]
GO
ALTER TABLE [dbo].[TblSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TblSchedule_TblStudent] FOREIGN KEY([student])
REFERENCES [dbo].[TblStudent] ([stdId])
GO
ALTER TABLE [dbo].[TblSchedule] CHECK CONSTRAINT [FK_TblSchedule_TblStudent]
GO
ALTER TABLE [dbo].[TblSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TblSchedule_TblTeacher] FOREIGN KEY([teacher])
REFERENCES [dbo].[TblTeacher] ([thcId])
GO
ALTER TABLE [dbo].[TblSchedule] CHECK CONSTRAINT [FK_TblSchedule_TblTeacher]
GO
ALTER TABLE [dbo].[TblTeacher]  WITH CHECK ADD  CONSTRAINT [FK_TblTeacher_TblLecture] FOREIGN KEY([thcLecture])
REFERENCES [dbo].[TblLecture] ([lectureId])
GO
ALTER TABLE [dbo].[TblTeacher] CHECK CONSTRAINT [FK_TblTeacher_TblLecture]
GO
/****** Object:  StoredProcedure [dbo].[list]    Script Date: 9/16/2024 3:54:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[list]
as
select courseId , lectureName as 'Lecture'
, thcName + ' ' + thcSurname as 'Teacher'
, stdName + ' ' + stdSurname as 'Student'
, courseDate as 'Date', courseHour as 'Hour'
, courseStatus as 'Status' from TblSchedule
inner join TblLecture on TblLecture.lectureId = TblSchedule.lecture 
inner join TblTeacher on TblTeacher.thcId = TblSchedule.teacher
inner join TblStudent on TblStudent.stdId = TblSchedule.student
GO
USE [master]
GO
ALTER DATABASE [CramSchool] SET  READ_WRITE 
GO
