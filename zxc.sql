USE [master]
GO
/****** Object:  Database [CinemaGlushkov]    Script Date: 22.03.2023 10:55:12 ******/
CREATE DATABASE [CinemaGlushkov]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CinemaGlushkov', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CinemaGlushkov.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CinemaGlushkov_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CinemaGlushkov_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CinemaGlushkov] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CinemaGlushkov].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CinemaGlushkov] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET ARITHABORT OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaGlushkov] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CinemaGlushkov] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CinemaGlushkov] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CinemaGlushkov] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CinemaGlushkov] SET  MULTI_USER 
GO
ALTER DATABASE [CinemaGlushkov] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CinemaGlushkov] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CinemaGlushkov] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CinemaGlushkov] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CinemaGlushkov] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CinemaGlushkov] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CinemaGlushkov] SET QUERY_STORE = OFF
GO
USE [CinemaGlushkov]
GO
/****** Object:  Table [dbo].[Buffet]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buffet](
	[idProduct] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Buffet] PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[idEmployee] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[EmployeePost] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[idEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[idMovie] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](50) NULL,
	[MovieLenght] [nvarchar](50) NULL,
	[FilmCompany] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[idMovie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[idOrder] [int] NOT NULL,
	[idTicket] [int] NOT NULL,
	[idProduct] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[idEmployee] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[idOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[idTicket] [int] IDENTITY(1,1) NOT NULL,
	[idMovie] [int] NOT NULL,
	[Time] [time](5) NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[idTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22.03.2023 10:55:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Buffet] ON 

INSERT [dbo].[Buffet] ([idProduct], [ProductName], [Price]) VALUES (1, N'Попкорн Мал.', CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[Buffet] ([idProduct], [ProductName], [Price]) VALUES (2, N'Попкорн Сред.', CAST(120.00 AS Decimal(18, 2)))
INSERT [dbo].[Buffet] ([idProduct], [ProductName], [Price]) VALUES (3, N'Попкорн Бол', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Buffet] ([idProduct], [ProductName], [Price]) VALUES (4, N'Кок-кола 0.5', CAST(80.00 AS Decimal(18, 2)))
INSERT [dbo].[Buffet] ([idProduct], [ProductName], [Price]) VALUES (5, N'Кок-кола 1.0', CAST(160.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Buffet] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([idEmployee], [EmployeeName], [EmployeePost]) VALUES (1, N'Фыф)', N'Кассир')
INSERT [dbo].[Employee] ([idEmployee], [EmployeeName], [EmployeePost]) VALUES (2, N'Кто', N'Кассир')
INSERT [dbo].[Employee] ([idEmployee], [EmployeeName], [EmployeePost]) VALUES (3, N'Илон Маск', N'Кассир')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([idMovie], [MovieName], [MovieLenght], [FilmCompany]) VALUES (1, N'Большой куш', N'1ч.44мин.', N'Columbia Pictures')
INSERT [dbo].[Movies] ([idMovie], [MovieName], [MovieLenght], [FilmCompany]) VALUES (2, N'Бойцовский клуб', N'2ч.19мин.', N'Fox 2000 Pictures')
INSERT [dbo].[Movies] ([idMovie], [MovieName], [MovieLenght], [FilmCompany]) VALUES (3, N'Интерстеллар', N'2ч.49мин.', N'Legedary Pictures Syncopy')
INSERT [dbo].[Movies] ([idMovie], [MovieName], [MovieLenght], [FilmCompany]) VALUES (4, N'Начало ', N'2ч.28мин.', N'Legedary Pictures Syncopy')
INSERT [dbo].[Movies] ([idMovie], [MovieName], [MovieLenght], [FilmCompany]) VALUES (5, N'Джентельмены', N'1ч.53мин.', N'Miramax Films')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (1, 1, 1, CAST(430.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (2, 2, 4, CAST(480.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (3, 2, 3, CAST(500.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (4, 4, 2, CAST(420.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (5, 5, 1, CAST(530.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Orders] ([idOrder], [idTicket], [idProduct], [Price], [idEmployee]) VALUES (6, 3, 5, CAST(410.00 AS Decimal(18, 2)), 2)
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([idTicket], [idMovie], [Time], [Price]) VALUES (1, 1, CAST(N'17:00:00' AS Time), CAST(350.00 AS Decimal(18, 2)))
INSERT [dbo].[Tickets] ([idTicket], [idMovie], [Time], [Price]) VALUES (2, 2, CAST(N'20:00:00' AS Time), CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[Tickets] ([idTicket], [idMovie], [Time], [Price]) VALUES (3, 3, CAST(N'12:00:00' AS Time), CAST(250.00 AS Decimal(18, 2)))
INSERT [dbo].[Tickets] ([idTicket], [idMovie], [Time], [Price]) VALUES (4, 4, CAST(N'15:00:00' AS Time), CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[Tickets] ([idTicket], [idMovie], [Time], [Price]) VALUES (5, 5, CAST(N'23:00:00' AS Time), CAST(450.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [username], [password]) VALUES (1, N'admin', N'111')
INSERT [dbo].[Users] ([id], [username], [password]) VALUES (2, N'user1', N'user1')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Buffet] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Buffet] ([idProduct])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Buffet]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employee] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Employee] ([idEmployee])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employee]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Tickets] FOREIGN KEY([idTicket])
REFERENCES [dbo].[Tickets] ([idTicket])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Tickets]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Movies] FOREIGN KEY([idMovie])
REFERENCES [dbo].[Movies] ([idMovie])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Movies]
GO
USE [master]
GO
ALTER DATABASE [CinemaGlushkov] SET  READ_WRITE 
GO
