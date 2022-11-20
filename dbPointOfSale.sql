USE [master]
GO
/****** Object:  Database [dbPointOfSale]    Script Date: 27-Jun-21 4:36:07 PM ******/
CREATE DATABASE [dbPointOfSale]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbPointOfSale_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.WARSI\MSSQL\DATA\dbPointOfSale.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbPointOfSale_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.WARSI\MSSQL\DATA\dbPointOfSale.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbPointOfSale] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPointOfSale].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbPointOfSale] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbPointOfSale] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbPointOfSale] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbPointOfSale] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbPointOfSale] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbPointOfSale] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbPointOfSale] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbPointOfSale] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbPointOfSale] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbPointOfSale] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbPointOfSale] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbPointOfSale] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbPointOfSale] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbPointOfSale] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbPointOfSale] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbPointOfSale] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbPointOfSale] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbPointOfSale] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbPointOfSale] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbPointOfSale] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbPointOfSale] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbPointOfSale] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbPointOfSale] SET RECOVERY FULL 
GO
ALTER DATABASE [dbPointOfSale] SET  MULTI_USER 
GO
ALTER DATABASE [dbPointOfSale] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbPointOfSale] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbPointOfSale] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbPointOfSale] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbPointOfSale] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbPointOfSale] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbPointOfSale', N'ON'
GO
ALTER DATABASE [dbPointOfSale] SET QUERY_STORE = OFF
GO
USE [dbPointOfSale]
GO
/****** Object:  User [PointOfSale]    Script Date: 27-Jun-21 4:36:08 PM ******/
CREATE USER [PointOfSale] FOR LOGIN [PointOfSale] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [PointOfSale]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone_No] [nvarchar](17) NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](70) NULL,
	[Category] [nvarchar](20) NULL,
	[Size] [nvarchar](50) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
	[SalesPrice] [decimal](18, 2) NULL,
	[DateOfEntry] [date] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SalesID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [bigint] NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](70) NULL,
	[SalesPrice] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[InvoiceNumber] [bigint] NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[TotalProducts] [int] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[PurchaseDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[CustomeName] [nvarchar](50) NULL,
	[InvoiceNumber] [bigint] NULL,
	[ServiceDate] [date] NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sizes]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizes](
	[SizeID] [int] IDENTITY(1,1) NOT NULL,
	[Size] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED 
(
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersLogin]    Script Date: 27-Jun-21 4:36:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersLogin](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](30) NULL,
	[Role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Phone_No], [Address]) VALUES (1, N'Walk in Customer', N'300 1234567', N'Karachi')
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Phone_No], [Address]) VALUES (12, N'Arsalan', N'300 7654321', N'Islambad')
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Phone_No], [Address]) VALUES (13, N'Aliyan', N'300 9876789', N'Lahore')
GO
INSERT [dbo].[Customers] ([CustomerID], [Name], [Phone_No], [Address]) VALUES (14, N'Hamza', N'311 1221121', N'Multan')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (19, N'Chilli Garlic Sauce', N'Both', N'500 grams', CAST(172.00 AS Decimal(18, 2)), CAST(207.00 AS Decimal(18, 2)), CAST(N'2020-03-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (20, N'BBQ Sauce', N'Both', N'250 grams', CAST(560.00 AS Decimal(18, 2)), CAST(590.00 AS Decimal(18, 2)), CAST(N'2020-09-21' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (21, N'Pickle Mix', N'Both', N'250 grams', CAST(129.00 AS Decimal(18, 2)), CAST(159.00 AS Decimal(18, 2)), CAST(N'2020-07-06' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (22, N'Pickle Mango', N'Both', N'250 grams', CAST(129.00 AS Decimal(18, 2)), CAST(159.00 AS Decimal(18, 2)), CAST(N'2020-01-04' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (23, N'Pickle Garlic', N'Both', N'250 grams', CAST(129.00 AS Decimal(18, 2)), CAST(159.00 AS Decimal(18, 2)), CAST(N'2020-01-04' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (24, N'Suji', N'Both', N'500 grams', CAST(23.00 AS Decimal(18, 2)), CAST(58.00 AS Decimal(18, 2)), CAST(N'2019-06-12' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (25, N'Cornflour', N'Both', N'500 grams', CAST(68.00 AS Decimal(18, 2)), CAST(103.00 AS Decimal(18, 2)), CAST(N'2019-05-24' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (26, N'Red Lobia', N'Both', N'500 grams', CAST(138.00 AS Decimal(18, 2)), CAST(173.00 AS Decimal(18, 2)), CAST(N'2018-12-12' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (27, N'White Lobial', N'Both', N'500 grams', CAST(119.00 AS Decimal(18, 2)), CAST(154.00 AS Decimal(18, 2)), CAST(N'2018-12-12' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (29, N'Maida', N'Both', N'1 kg', CAST(83.00 AS Decimal(18, 2)), CAST(128.00 AS Decimal(18, 2)), CAST(N'2018-03-16' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (30, N'Mezan Cooking Oil', N'Both', N'5 Ltr', CAST(645.00 AS Decimal(18, 2)), CAST(705.00 AS Decimal(18, 2)), CAST(N'2020-11-22' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (31, N'Dalda Cooking Oil', N'Both', N'5 Ltr', CAST(735.00 AS Decimal(18, 2)), CAST(795.00 AS Decimal(18, 2)), CAST(N'2019-01-04' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (32, N'Eva Cooking Oil', N'Both', N'5 Ltr', CAST(735.00 AS Decimal(18, 2)), CAST(795.00 AS Decimal(18, 2)), CAST(N'2019-03-05' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (33, N'Mezan Ghee', N'Both', N'5 kg', CAST(790.00 AS Decimal(18, 2)), CAST(840.00 AS Decimal(18, 2)), CAST(N'2020-11-11' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (34, N'Tullo Ghee', N'Female', N'5 Ltr', CAST(655.00 AS Decimal(18, 2)), CAST(715.00 AS Decimal(18, 2)), CAST(N'2021-03-20' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (35, N'Habib Ghee', N'Both', N'5 Ltr', CAST(735.00 AS Decimal(18, 2)), CAST(795.00 AS Decimal(18, 2)), CAST(N'2021-02-10' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (36, N'Mozzarella Cheese', N'Both', N'100 grams', CAST(250.00 AS Decimal(18, 2)), CAST(270.00 AS Decimal(18, 2)), CAST(N'2020-07-08' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (37, N'Pizza Cheese', N'Both', N'100 grams', CAST(320.00 AS Decimal(18, 2)), CAST(340.00 AS Decimal(18, 2)), CAST(N'2020-07-08' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (38, N'Chaddar Cheese', N'Both', N'100 grams', CAST(270.00 AS Decimal(18, 2)), CAST(290.00 AS Decimal(18, 2)), CAST(N'2020-07-08' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (39, N'Sunsilk Shampoo', N'Female', N'200 ml', CAST(254.00 AS Decimal(18, 2)), CAST(279.00 AS Decimal(18, 2)), CAST(N'2021-04-12' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (40, N'Match Box', N'Both', N'12 Pcs', CAST(23.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(N'2021-03-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (41, N'Surface Cleaner', N'Female', N'200 ml', CAST(74.00 AS Decimal(18, 2)), CAST(99.00 AS Decimal(18, 2)), CAST(N'2020-06-17' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (42, N'Colgate Toothpaste', N'Male', N'100 grams', CAST(229.00 AS Decimal(18, 2)), CAST(249.00 AS Decimal(18, 2)), CAST(N'2021-02-27' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (43, N'Colgate Toothpaste', N'Female', N'100 grams', CAST(329.00 AS Decimal(18, 2)), CAST(349.00 AS Decimal(18, 2)), CAST(N'2021-02-27' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (44, N'Colgate Mouthwash', N'Female', N'100 ml', CAST(155.00 AS Decimal(18, 2)), CAST(165.00 AS Decimal(18, 2)), CAST(N'2021-04-05' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (45, N'Tang Mango', N'Both', N'250 grams', CAST(138.00 AS Decimal(18, 2)), CAST(168.00 AS Decimal(18, 2)), CAST(N'2019-08-19' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (46, N'Tang Mosambi', N'Both', N'250 grams', CAST(169.00 AS Decimal(18, 2)), CAST(199.00 AS Decimal(18, 2)), CAST(N'2019-08-19' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (47, N'Tang Pineapple', N'Both', N'250 grams', CAST(159.00 AS Decimal(18, 2)), CAST(189.00 AS Decimal(18, 2)), CAST(N'2019-08-19' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (48, N'supreme dates', N'Both', N'250 grams', CAST(68.00 AS Decimal(18, 2)), CAST(78.00 AS Decimal(18, 2)), CAST(N'2020-05-12' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (49, N'Chocolate', N'Female', N'50 grams', CAST(274.00 AS Decimal(18, 2)), CAST(279.00 AS Decimal(18, 2)), CAST(N'2020-02-14' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (50, N'Chocolate', N'Male', N'100 grams', CAST(259.00 AS Decimal(18, 2)), CAST(279.00 AS Decimal(18, 2)), CAST(N'2020-02-14' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (51, N'Apple Jam', N'Both', N'200 grams', CAST(160.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), CAST(N'2021-03-14' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (52, N'Orange Jam', N'Both', N'200 grams', CAST(165.00 AS Decimal(18, 2)), CAST(185.00 AS Decimal(18, 2)), CAST(N'2021-03-14' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (53, N'Rooh Afza', N'Both', N'500 ml', CAST(125.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), CAST(N'2019-04-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (54, N'Olpers Milk', N'Both', N'12 Pcs', CAST(1340.00 AS Decimal(18, 2)), CAST(1440.00 AS Decimal(18, 2)), CAST(N'2020-01-30' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (55, N'Sugar', N'Both', N'5 kg', CAST(265.00 AS Decimal(18, 2)), CAST(320.00 AS Decimal(18, 2)), CAST(N'2020-04-22' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (56, N'Dal Masoor', N'Both', N'1 kg', CAST(99.00 AS Decimal(18, 2)), CAST(144.00 AS Decimal(18, 2)), CAST(N'2020-11-06' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (57, N'Dal Mash', N'Both', N'500 grams', CAST(103.00 AS Decimal(18, 2)), CAST(138.00 AS Decimal(18, 2)), CAST(N'2020-11-07' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (58, N'Nationam Salt', N'Both', N'250 grams', CAST(75.00 AS Decimal(18, 2)), CAST(105.00 AS Decimal(18, 2)), CAST(N'2020-08-08' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (59, N'Tapal Family Mixture', N'Both', N'250 grams', CAST(282.00 AS Decimal(18, 2)), CAST(312.00 AS Decimal(18, 2)), CAST(N'2021-02-25' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (60, N'Dairy Omung Milk', N'Both', N'5 Ltr', CAST(650.00 AS Decimal(18, 2)), CAST(710.00 AS Decimal(18, 2)), CAST(N'2021-03-29' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (61, N'Knorr Noodle', N'Both', N'50 grams', CAST(34.00 AS Decimal(18, 2)), CAST(39.00 AS Decimal(18, 2)), CAST(N'2021-04-05' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (62, N'Dairy Pure Milk', N'Both', N'1 Ltr', CAST(150.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), CAST(N'2020-09-13' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (63, N'LUX Soap', N'Both', N'100 grams', CAST(57.00 AS Decimal(18, 2)), CAST(62.00 AS Decimal(18, 2)), CAST(N'2021-06-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (64, N'LUX Soap', N'Female', N'100 grams', CAST(120.00 AS Decimal(18, 2)), CAST(130.00 AS Decimal(18, 2)), CAST(N'2021-06-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (65, N'LUX Soap', N'Male', N'100 grams', CAST(60.00 AS Decimal(18, 2)), CAST(67.00 AS Decimal(18, 2)), CAST(N'2021-06-01' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (66, N'Safeguard Soap', N'Both', N'100 grams', CAST(77.00 AS Decimal(18, 2)), CAST(82.00 AS Decimal(18, 2)), CAST(N'2021-01-06' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (67, N'Safeguard Soap', N'Female', N'100 grams', CAST(157.00 AS Decimal(18, 2)), CAST(162.00 AS Decimal(18, 2)), CAST(N'2021-01-06' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (68, N'Shampoo', N'Both', N'200 ml', CAST(225.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)), CAST(N'2021-03-02' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (69, N'Clear Shampoo', N'Male', N'200 ml', CAST(440.00 AS Decimal(18, 2)), CAST(561.00 AS Decimal(18, 2)), CAST(N'2021-03-02' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (70, N'Dove Shampoo', N'Female', N'200 ml', CAST(254.00 AS Decimal(18, 2)), CAST(274.00 AS Decimal(18, 2)), CAST(N'2021-03-02' AS Date))
GO
INSERT [dbo].[Products] ([ProductID], [Name], [Category], [Size], [PurchasePrice], [SalesPrice], [DateOfEntry]) VALUES (71, N'Tresemme Smooth', N'Female', N'200 ml', CAST(245.00 AS Decimal(18, 2)), CAST(259.00 AS Decimal(18, 2)), CAST(N'2021-03-02' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleDetails] ON 
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30196, 1910391977, 20, N'BBQ Sauce', CAST(590.00 AS Decimal(18, 2)), 1, CAST(590.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30197, 1910391977, 21, N'Pickle Mix', CAST(159.00 AS Decimal(18, 2)), 1, CAST(159.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30198, 1910391977, 22, N'Pickle Mango', CAST(159.00 AS Decimal(18, 2)), 1, CAST(159.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30199, 1910391977, 40, N'Match Box', CAST(25.00 AS Decimal(18, 2)), 1, CAST(25.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30200, 1910391977, 39, N'Sunsilk Shampoo', CAST(279.00 AS Decimal(18, 2)), 3, CAST(837.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30203, 1910422163, 40, N'Match Box', CAST(25.00 AS Decimal(18, 2)), 5, CAST(125.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30204, 1910422163, 51, N'Apple Jam', CAST(180.00 AS Decimal(18, 2)), 1, CAST(180.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30207, 2111333659, 20, N'BBQ Sauce', CAST(590.00 AS Decimal(18, 2)), 1, CAST(590.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30208, 2111333659, 49, N'Chocolate', CAST(279.00 AS Decimal(18, 2)), 1, CAST(279.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30209, 2111333659, 48, N'supreme dates', CAST(78.00 AS Decimal(18, 2)), 2, CAST(156.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30210, 2111333659, 45, N'Tang Mango', CAST(168.00 AS Decimal(18, 2)), 1, CAST(168.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30211, 2111333659, 46, N'Tang Mosambi', CAST(199.00 AS Decimal(18, 2)), 5, CAST(995.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30212, 2111333659, 63, N'LUX Soap', CAST(62.00 AS Decimal(18, 2)), 1, CAST(62.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30213, 2111333659, 71, N'Tresemme Smooth', CAST(259.00 AS Decimal(18, 2)), 1, CAST(259.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30214, 2111342874, 22, N'Pickle Mango', CAST(159.00 AS Decimal(18, 2)), 1, CAST(159.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30215, 2111342874, 26, N'Red Lobia', CAST(173.00 AS Decimal(18, 2)), 1, CAST(173.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30216, 2111342874, 29, N'Maida', CAST(128.00 AS Decimal(18, 2)), 2, CAST(256.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30217, 2111342874, 54, N'Olpers Milk', CAST(1440.00 AS Decimal(18, 2)), 1, CAST(1440.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30218, 2111344547, 65, N'LUX Soap', CAST(67.00 AS Decimal(18, 2)), 3, CAST(201.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30219, 2111344547, 64, N'LUX Soap', CAST(130.00 AS Decimal(18, 2)), 1, CAST(130.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30220, 2111344547, 58, N'Nationam Salt', CAST(105.00 AS Decimal(18, 2)), 1, CAST(105.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30221, 2713562045, 21, N'Pickle Mix', CAST(159.00 AS Decimal(18, 2)), 1, CAST(159.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30222, 2713562045, 30, N'Mezan Cooking Oil', CAST(705.00 AS Decimal(18, 2)), 2, CAST(1410.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30223, 2713562045, 32, N'Eva Cooking Oil', CAST(795.00 AS Decimal(18, 2)), 1, CAST(795.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30224, 2713562045, 31, N'Dalda Cooking Oil', CAST(795.00 AS Decimal(18, 2)), 1, CAST(795.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30226, 2713562045, 29, N'Maida', CAST(128.00 AS Decimal(18, 2)), 1, CAST(128.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30227, 2714394439, 20, N'BBQ Sauce', CAST(590.00 AS Decimal(18, 2)), 1, CAST(590.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30228, 2714394439, 21, N'Pickle Mix', CAST(159.00 AS Decimal(18, 2)), 1, CAST(159.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30229, 2714394439, 30, N'Mezan Cooking Oil', CAST(705.00 AS Decimal(18, 2)), 3, CAST(2115.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30230, 2714394439, 44, N'Colgate Mouthwash', CAST(165.00 AS Decimal(18, 2)), 1, CAST(165.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30231, 2714394439, 43, N'Colgate Toothpaste', CAST(349.00 AS Decimal(18, 2)), 1, CAST(349.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30232, 2714394439, 45, N'Tang Mango', CAST(168.00 AS Decimal(18, 2)), 2, CAST(336.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30233, 2714394439, 47, N'Tang Pineapple', CAST(189.00 AS Decimal(18, 2)), 1, CAST(189.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30234, 2714394439, 65, N'LUX Soap', CAST(67.00 AS Decimal(18, 2)), 1, CAST(67.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30235, 2714394439, 64, N'LUX Soap', CAST(130.00 AS Decimal(18, 2)), 4, CAST(520.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[SaleDetails] ([SalesID], [InvoiceNumber], [ProductID], [ProductName], [SalesPrice], [Quantity], [TotalPrice]) VALUES (30236, 2714394439, 70, N'Dove Shampoo', CAST(274.00 AS Decimal(18, 2)), 1, CAST(274.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[SaleDetails] OFF
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (1910391977, N'Walk in Customer', 5, CAST(1212.00 AS Decimal(18, 2)), CAST(N'2021-06-19' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (1910422163, N'Aliyan', 2, CAST(205.00 AS Decimal(18, 2)), CAST(N'2021-06-19' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (2111333659, N'Hamza', 7, CAST(2509.00 AS Decimal(18, 2)), CAST(N'2021-06-07' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (2111342874, N'Walk in Customer', 4, CAST(2028.00 AS Decimal(18, 2)), CAST(N'2021-06-21' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (2111344547, N'Aliyan', 3, CAST(436.00 AS Decimal(18, 2)), CAST(N'2021-06-21' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (2713562045, N'Arsalan', 5, CAST(2582.00 AS Decimal(18, 2)), CAST(N'2021-06-27' AS Date))
GO
INSERT [dbo].[Sales] ([InvoiceNumber], [CustomerName], [TotalProducts], [TotalPrice], [PurchaseDate]) VALUES (2714394439, N'Walk in Customer', 10, CAST(4764.00 AS Decimal(18, 2)), CAST(N'2021-06-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Services] ON 
GO
INSERT [dbo].[Services] ([ServiceID], [CustomeName], [InvoiceNumber], [ServiceDate]) VALUES (3010, N'Walk in Customer', 1910391977, CAST(N'2021-06-19' AS Date))
GO
INSERT [dbo].[Services] ([ServiceID], [CustomeName], [InvoiceNumber], [ServiceDate]) VALUES (3011, N'Aliyan', 1910422163, CAST(N'2021-06-19' AS Date))
GO
INSERT [dbo].[Services] ([ServiceID], [CustomeName], [InvoiceNumber], [ServiceDate]) VALUES (3012, N'Arsalan', 2713562045, CAST(N'2021-06-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Sizes] ON 
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (1, N'50 grams')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (2, N'100 grams')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (3, N'250 grams')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (4, N'500 grams')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (5, N'1 kg')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (6, N'5 kg')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (7, N'1 Ltr')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (8, N'5 Ltr')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (9, N'1 Pcs')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (10, N'6 Pcs')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (11, N'12 Pcs')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (12, N'100 ml')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (13, N'200 ml')
GO
INSERT [dbo].[Sizes] ([SizeID], [Size]) VALUES (14, N'500 ml')
GO
SET IDENTITY_INSERT [dbo].[Sizes] OFF
GO
INSERT [dbo].[UsersLogin] ([UserName], [Password], [Role]) VALUES (N'admin', N'123', N'admin')
GO
INSERT [dbo].[UsersLogin] ([UserName], [Password], [Role]) VALUES (N'admin1', N'321', N'Staff')
GO
INSERT [dbo].[UsersLogin] ([UserName], [Password], [Role]) VALUES (N'admin2', N'123', N'Admin')
GO
INSERT [dbo].[UsersLogin] ([UserName], [Password], [Role]) VALUES (N'staff', N'123', N'staff')
GO
INSERT [dbo].[UsersLogin] ([UserName], [Password], [Role]) VALUES (N'warsi', N'321', N'Staff')
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_ProductID]
GO
USE [master]
GO
ALTER DATABASE [dbPointOfSale] SET  READ_WRITE 
GO
