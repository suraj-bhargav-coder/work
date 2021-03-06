USE [master]
GO

/****** Object:  Database [CompanyManagementDb]    Script Date: 3/28/2020 11:02:19 AM ******/
CREATE DATABASE [CompanyManagementDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CompanyManagementDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CompanyManagementDb.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CompanyManagementDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CompanyManagementDb_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [CompanyManagementDb] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CompanyManagementDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CompanyManagementDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [CompanyManagementDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CompanyManagementDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CompanyManagementDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET  ENABLE_BROKER 
GO

ALTER DATABASE [CompanyManagementDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CompanyManagementDb] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [CompanyManagementDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [CompanyManagementDb] SET  MULTI_USER 
GO

ALTER DATABASE [CompanyManagementDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CompanyManagementDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CompanyManagementDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CompanyManagementDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [CompanyManagementDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CompanyManagementDb] SET  READ_WRITE 
GO

