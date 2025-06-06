USE [Nirvana_Demo]
GO
/****** Object:  Database [Training]    Script Date: 1/31/2023 1:41:39 PM ******/
CREATE DATABASE [Training]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Training', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER19\MSSQL\DATA\Training.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Training_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER19\MSSQL\DATA\Training_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Training] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Training].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Training] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Training] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Training] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Training] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Training] SET ARITHABORT OFF 
GO
ALTER DATABASE [Training] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Training] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Training] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Training] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Training] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Training] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Training] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Training] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Training] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Training] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Training] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Training] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Training] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Training] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Training] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Training] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Training] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Training] SET RECOVERY FULL 
GO
ALTER DATABASE [Training] SET  MULTI_USER 
GO
ALTER DATABASE [Training] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Training] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Training] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Training] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Training] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Training', N'ON'
GO
USE [Training]
GO
/****** Object:  Table [dbo].[T_CompanyFunds]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_CompanyFunds](
	[Username] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_CompanyUser]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_CompanyUser](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Group]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Group](
	[Symbol] [nvarchar](50) NOT NULL,
	[Side] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
	[AvgPrice] [nvarchar](50) NOT NULL,
	[RemainingQuantity] [nvarchar](50) NOT NULL,
	[OrderStatus] [nvarchar](50) NOT NULL,
	[CLOrderId] [nvarchar](50) NOT NULL,
	[ParentCLOrderId] [nvarchar](50) NOT NULL,
	[StagedOrderId] [nvarchar](50) NOT NULL,
	[OriginalCLOrderId] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_OrderAndSub]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_OrderAndSub](
	[Symbol] [nvarchar](50) NOT NULL,
	[Side] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
	[AvgPrice] [nvarchar](50) NOT NULL,
	[RemainingQuantity] [nvarchar](50) NOT NULL,
	[OrderStatus] [nvarchar](50) NOT NULL,
	[CLOrderId] [nvarchar](50) NOT NULL,
	[ParentCLOrderId] [nvarchar](50) NOT NULL,
	[StagedOrderId] [nvarchar](50) NOT NULL,
	[OriginalCLOrderId] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_TradedOrders]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_TradedOrders](
	[Symbol] [nvarchar](50) NOT NULL,
	[Side] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
	[AvgPrice] [nvarchar](50) NOT NULL,
	[RemainingQuantity] [nvarchar](50) NOT NULL,
	[OrderStatus] [nvarchar](50) NOT NULL,
	[CLOrderId] [nvarchar](50) NOT NULL,
	[ParentCLOrderId] [nvarchar](50) NOT NULL,
	[StagedOrderId] [nvarchar](50) NOT NULL,
	[OriginalCLOrderId] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[accChange]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[accChange]
    @Symbol nvarchar(50),
    @Side nvarchar(50),
    @Account nvarchar(50)
  AS
    BEGIN
     UPDATE T_Group 
     SET Account=@Account 
     WHERE Symbol = @Symbol;
     Update T_TradedOrders
     set Account=@Account
     where Symbol=@symbol;
    END
GO
/****** Object:  StoredProcedure [dbo].[del]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[del]
    @Symbol nvarchar(50)
  AS
    BEGIN
     DELETE FROM T_TradedOrders
     WHERE Symbol = @Symbol;
     DELETE FROM T_Group
     WHERE Symbol = @Symbol;
     DELETE FROM T_OrderAndSub
     WHERE Symbol = @Symbol;
    END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrder]
    @Symbol nvarchar(50),
    @Side nvarchar(50),
    @Account nvarchar(50),
    @Quantity nvarchar(50),
    @AvgPrice nvarchar(50),
    @RemainingQuantity nvarchar(50),
    @OrderStatus nvarchar(50),
    @CLOrderId nvarchar(50),
    @ParentCLOrderId nvarchar(50),
    @StagedOrderId nvarchar(50),
    @OriginalCLOrderId nvarchar(50)
AS
BEGIN

    SET NOCOUNT ON;

    insert into T_TradedOrders (Symbol ,Side ,Account ,Quantity ,AvgPrice ,RemainingQuantity ,OrderStatus ,CLOrderId,ParentCLOrderId ,StagedOrderId ,OriginalCLOrderId)
    values(@Symbol ,@Side ,@Account ,@Quantity ,@AvgPrice ,@RemainingQuantity ,@OrderStatus ,@CLOrderId,@ParentCLOrderId ,@StagedOrderId ,@OriginalCLOrderId)

END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder1]    Script Date: 1/31/2023 1:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrder1]
    @Symbol nvarchar(50),
    @Side nvarchar(50),
    @Account nvarchar(50),
    @Quantity nvarchar(50),
    @AvgPrice nvarchar(50),
    @RemainingQuantity nvarchar(50),
    @OrderStatus nvarchar(50),
    @CLOrderId nvarchar(50),
    @ParentCLOrderId nvarchar(50),
    @StagedOrderId nvarchar(50),
    @OriginalCLOrderId nvarchar(50)
AS
BEGIN

    SET NOCOUNT ON;

    insert into T_Group (Symbol ,Side ,Account ,Quantity ,AvgPrice ,RemainingQuantity ,OrderStatus ,CLOrderId,ParentCLOrderId ,StagedOrderId ,OriginalCLOrderId)
    values(@Symbol ,@Side ,@Account ,@Quantity ,@AvgPrice ,@RemainingQuantity ,@OrderStatus ,@CLOrderId,@ParentCLOrderId ,@StagedOrderId ,@OriginalCLOrderId)

	insert into T_OrderAndSub (Symbol ,Side ,Account ,Quantity ,AvgPrice ,RemainingQuantity ,OrderStatus ,CLOrderId,ParentCLOrderId ,StagedOrderId ,OriginalCLOrderId)
    values(@Symbol ,@Side ,@Account ,@Quantity ,@AvgPrice ,@RemainingQuantity ,@OrderStatus ,@CLOrderId,@ParentCLOrderId ,@StagedOrderId ,@OriginalCLOrderId)

	insert into T_TradedOrders (Symbol ,Side ,Account ,Quantity ,AvgPrice ,RemainingQuantity ,OrderStatus ,CLOrderId,ParentCLOrderId ,StagedOrderId ,OriginalCLOrderId)
    values(@Symbol ,@Side ,@Account ,@Quantity ,@AvgPrice ,@RemainingQuantity ,@OrderStatus ,@CLOrderId,@ParentCLOrderId ,@StagedOrderId ,@OriginalCLOrderId)

END
GO
USE [master]
GO
ALTER DATABASE [Training] SET  READ_WRITE 
GO
