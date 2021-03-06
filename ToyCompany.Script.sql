USE [master]
GO

/****** Object:  Database [ToyCompanyDb]    Script Date: 3/27/2020 9:18:13 AM ******/
CREATE DATABASE [ToyCompanyDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ToyCompanyDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ToyCompanyDb.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ToyCompanyDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ToyCompanyDb_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ToyCompanyDb] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ToyCompanyDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ToyCompanyDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [ToyCompanyDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ToyCompanyDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ToyCompanyDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET  ENABLE_BROKER 
GO

ALTER DATABASE [ToyCompanyDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ToyCompanyDb] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [ToyCompanyDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ToyCompanyDb] SET  MULTI_USER 
GO

ALTER DATABASE [ToyCompanyDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ToyCompanyDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ToyCompanyDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ToyCompanyDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ToyCompanyDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ToyCompanyDb] SET  READ_WRITE 
GO

