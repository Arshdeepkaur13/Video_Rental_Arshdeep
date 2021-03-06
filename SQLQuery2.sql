USE [master]
GO
/****** Object:  Database [VideoRental_Arshdeep]    Script Date: 20-05-2020 05:51:55 AM ******/
CREATE DATABASE [VideoRental_Arshdeep]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRental_Arshdeep', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VideoRental_Arshdeep.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRental_Arshdeep_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\VideoRental_Arshdeep_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRental_Arshdeep] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRental_Arshdeep].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRental_Arshdeep] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VideoRental_Arshdeep] SET DELAYED_DURABILITY = DISABLED 
GO
USE [VideoRental_Arshdeep]
GO
/****** Object:  Table [dbo].[CustomerTable]    Script Date: 20-05-2020 05:51:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](500) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_CustomerTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MoviesTable]    Script Date: 20-05-2020 05:51:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoviesTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [text] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_MoviesTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMoviesTable]    Script Date: 20-05-2020 05:51:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMoviesTable](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMoviesTable] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CustomerTable] ON 

GO
INSERT [dbo].[CustomerTable] ([ID], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Nirmal', N'Singh', N'Abcd', N'980988789')
GO
INSERT [dbo].[CustomerTable] ([ID], [FirstName], [LastName], [Address], [Phone]) VALUES (3, N'Raman', N'Singh', N'asdfa', N'22636474')
GO
INSERT [dbo].[CustomerTable] ([ID], [FirstName], [LastName], [Address], [Phone]) VALUES (4, N'Arsh', N'deep kaur', N'qwerty', N'221323')
GO
SET IDENTITY_INSERT [dbo].[CustomerTable] OFF
GO
SET IDENTITY_INSERT [dbo].[MoviesTable] ON 

GO
INSERT [dbo].[MoviesTable] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (2, N'5', N'Hum Tum', N'2010', 2.0000, N'5', N'48', N'89', N'Dec  1 2019  3:41PM')
GO
INSERT [dbo].[MoviesTable] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (3, N'5', N'Devdas', N'2019', 5.0000, N'5', N'4', N'55', N'May 19 2020 12:37PM')
GO
INSERT [dbo].[MoviesTable] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (1002, N'5', N'My Love', N'2012', 2.0000, N'2', N'2', N'56', N'May 19 2020 12:36PM')
GO
INSERT [dbo].[MoviesTable] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (1003, N'3', N'Mile Ho tum humko', N'2020', 5.0000, N'5', N'5', N'56', N'May 19 2020 12:37PM')
GO
SET IDENTITY_INSERT [dbo].[MoviesTable] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMoviesTable] ON 

GO
INSERT [dbo].[RentedMoviesTable] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 2, 1, CAST(N'2019-12-01 00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[RentedMoviesTable] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (2, 3, 3, CAST(N'2019-12-01 00:00:00.000' AS DateTime), CAST(N'2019-12-01 20:04:59.000' AS DateTime))
GO
INSERT [dbo].[RentedMoviesTable] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1001, 2, 3, CAST(N'2020-05-19 00:00:00.000' AS DateTime), CAST(N'2020-05-19 05:38:27.000' AS DateTime))
GO
INSERT [dbo].[RentedMoviesTable] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1002, 3, 3, CAST(N'2020-05-20 00:00:00.000' AS DateTime), CAST(N'2020-05-20 05:28:34.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RentedMoviesTable] OFF
GO
USE [master]
GO
ALTER DATABASE [VideoRental_Arshdeep] SET  READ_WRITE 
GO
