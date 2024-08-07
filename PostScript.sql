USE [master]
GO
/****** Object:  Database [PostManagement1]    Script Date: 10/19/2019 17:28:26 ******/
CREATE DATABASE [PostManagement1] ON  PRIMARY 
( NAME = N'PostManagement1', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PostManagement1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PostManagement1_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PostManagement1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PostManagement1] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PostManagement1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PostManagement1] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PostManagement1] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PostManagement1] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PostManagement1] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PostManagement1] SET ARITHABORT OFF
GO
ALTER DATABASE [PostManagement1] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PostManagement1] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PostManagement1] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PostManagement1] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PostManagement1] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PostManagement1] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PostManagement1] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PostManagement1] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PostManagement1] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PostManagement1] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PostManagement1] SET  DISABLE_BROKER
GO
ALTER DATABASE [PostManagement1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PostManagement1] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PostManagement1] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PostManagement1] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PostManagement1] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PostManagement1] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PostManagement1] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PostManagement1] SET  READ_WRITE
GO
ALTER DATABASE [PostManagement1] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PostManagement1] SET  MULTI_USER
GO
ALTER DATABASE [PostManagement1] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PostManagement1] SET DB_CHAINING OFF
GO
USE [PostManagement1]
GO
/****** Object:  Table [dbo].[AddNewDetails]    Script Date: 10/19/2019 17:28:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AddNewDetails](
	[SerialNo] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NULL,
	[ReceivedFrom] [varchar](50) NULL,
	[LetterNo] [varchar](30) NULL,
	[LetterDate] [datetime] NULL,
	[ReceivingMode] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Attachement] [varchar](50) NULL,
	[AssignToUser] [varchar](50) NULL,
	[UserWork] [varchar](50) NULL,
	[Directions] [varchar](50) NULL,
	[DueDate] [datetime] NULL,
	[WorkDone] [varchar](50) NULL,
	[DoneDate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[AddNewDetails] ON
INSERT [dbo].[AddNewDetails] ([SerialNo], [EntryDate], [ReceivedFrom], [LetterNo], [LetterDate], [ReceivingMode], [Subject], [Attachement], [AssignToUser], [UserWork], [Directions], [DueDate], [WorkDone], [DoneDate]) VALUES (2, CAST(0x0000AAE600000000 AS DateTime), N'Direct', N'11', CAST(0x0000AAE600000000 AS DateTime), NULL, N'bca', N'IT', N'Admin', N'Design', N'gioalsgfhgf', CAST(0x0000AAE600000000 AS DateTime), N'Yes', CAST(0x0000AAE600000000 AS DateTime))
INSERT [dbo].[AddNewDetails] ([SerialNo], [EntryDate], [ReceivedFrom], [LetterNo], [LetterDate], [ReceivingMode], [Subject], [Attachement], [AssignToUser], [UserWork], [Directions], [DueDate], [WorkDone], [DoneDate]) VALUES (3, CAST(0x0000AAE000000000 AS DateTime), N'Direct', N'12', CAST(0x0000AAE700000000 AS DateTime), NULL, N'', N'hjhgj', N'Admin', N'hjghjhg', N'hgjghjh', CAST(0x0000AAE600000000 AS DateTime), N'hjghjg', CAST(0x0000AAE600000000 AS DateTime))
INSERT [dbo].[AddNewDetails] ([SerialNo], [EntryDate], [ReceivedFrom], [LetterNo], [LetterDate], [ReceivingMode], [Subject], [Attachement], [AssignToUser], [UserWork], [Directions], [DueDate], [WorkDone], [DoneDate]) VALUES (4, CAST(0x0000AAE700000000 AS DateTime), N'E-mail', N'2', CAST(0x0000AAE700000000 AS DateTime), NULL, N'English ', N'kkkk', N'Admin', N'jjjjj', N'ggg', CAST(0x0000AAE700000000 AS DateTime), N'fdgfhg', CAST(0x0000AAE700000000 AS DateTime))
INSERT [dbo].[AddNewDetails] ([SerialNo], [EntryDate], [ReceivedFrom], [LetterNo], [LetterDate], [ReceivingMode], [Subject], [Attachement], [AssignToUser], [UserWork], [Directions], [DueDate], [WorkDone], [DoneDate]) VALUES (5, CAST(0x0000AAE700000000 AS DateTime), N'E-mail', N'1', CAST(0x0000AAE700000000 AS DateTime), NULL, N'bca', N'ghjgj', N'Admin', N'hjhgj', N'hjh', CAST(0x0000AAE700000000 AS DateTime), N'hgjh', CAST(0x0000AAE700000000 AS DateTime))
INSERT [dbo].[AddNewDetails] ([SerialNo], [EntryDate], [ReceivedFrom], [LetterNo], [LetterDate], [ReceivingMode], [Subject], [Attachement], [AssignToUser], [UserWork], [Directions], [DueDate], [WorkDone], [DoneDate]) VALUES (6, CAST(0x0000AAEA004A4228 AS DateTime), N'E-mail', N'99', CAST(0x0000AAEA004A4228 AS DateTime), N'Direct', N'English ', N'project', N'Admin', N'computer', N'goals', CAST(0x0000AAEA004A4228 AS DateTime), N'no', CAST(0x0000AAEA004A4228 AS DateTime))
SET IDENTITY_INSERT [dbo].[AddNewDetails] OFF
/****** Object:  Table [dbo].[UserPost1]    Script Date: 10/19/2019 17:28:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserPost1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Atype] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Department] [varchar](50) NULL,
	[ContectNumber] [varchar](50) NULL,
	[UserID] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[ConfirmPassword] [varchar](50) NULL,
 CONSTRAINT [PK_UserPost1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserPost1] ON
INSERT [dbo].[UserPost1] ([Id], [UserName], [Atype], [Designation], [Department], [ContectNumber], [UserID], [Password], [ConfirmPassword]) VALUES (1, N'Deepak', N'User', NULL, N'User', NULL, N'deepak1', N'123', N'123')
INSERT [dbo].[UserPost1] ([Id], [UserName], [Atype], [Designation], [Department], [ContectNumber], [UserID], [Password], [ConfirmPassword]) VALUES (2, NULL, NULL, NULL, N'Admin', NULL, N'Null', NULL, NULL)
INSERT [dbo].[UserPost1] ([Id], [UserName], [Atype], [Designation], [Department], [ContectNumber], [UserID], [Password], [ConfirmPassword]) VALUES (3, N'kuldeep', NULL, N'Project', N'SST', N'4455667893', N'kuldeep123', N'12345', NULL)
INSERT [dbo].[UserPost1] ([Id], [UserName], [Atype], [Designation], [Department], [ContectNumber], [UserID], [Password], [ConfirmPassword]) VALUES (4, N'hjkj', NULL, N'Project', N'Others', N'5676', N'aa', N'11', NULL)
INSERT [dbo].[UserPost1] ([Id], [UserName], [Atype], [Designation], [Department], [ContectNumber], [UserID], [Password], [ConfirmPassword]) VALUES (5, N'Surjeet', N'User ', N'Project', N'IT', N'8945784', N'surjeet1', N'12', N'12')
SET IDENTITY_INSERT [dbo].[UserPost1] OFF
/****** Object:  StoredProcedure [dbo].[SearchPost]    Script Date: 10/19/2019 17:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchPost](@SerialNo int)
as
select * from AddNewDetails Where SerialNo=@SerialNo
GO
/****** Object:  StoredProcedure [dbo].[PostUpdate]    Script Date: 10/19/2019 17:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PostUpdate](@SerialNo int 
      ,@EntryDate datetime
      , @ReceivedFrom varchar(50)
      ,@LetterNo varchar(30)
      , @LetterDate datetime
      ,@ReceivingMode varchar(50)
      , @Subject varchar(50)
      , @Attachement varchar(50)
      , @AssignToUser varchar(50)
      , @UserWork varchar(50)
      , @Directions varchar(50)
      , @DueDate datetime
      , @WorkDone varchar(50)
      , @DoneDate datetime)
      as
      
UPDATE [PostManagement1].[dbo].[AddNewDetails]
   SET [EntryDate] = @EntryDate
      ,[ReceivedFrom] = @ReceivedFrom
      ,[LetterNo] = @LetterNo
      ,[LetterDate] = @LetterDate
      ,[ReceivingMode] =@ReceivingMode
      ,[Subject] = @Subject
      ,[Attachement] = @Attachement
      ,[AssignToUser] = @AssignToUser
      ,[UserWork] = @UserWork
      ,[Directions] = @Directions
      ,[DueDate] = @DueDate
      ,[WorkDone] = @WorkDone
      ,[DoneDate] = @DoneDate
 WHERE SerialNo=@SerialNo
GO
/****** Object:  StoredProcedure [dbo].[PostDelete]    Script Date: 10/19/2019 17:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PostDelete](@SerialNo int)
as

DELETE FROM [PostManagement1].[dbo].[AddNewDetails]
      WHERE SerialNo=@SerialNo
GO
/****** Object:  StoredProcedure [dbo].[Post]    Script Date: 10/19/2019 17:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Post](@EntryDate datetime
           ,@ReceivedFrom varchar(50)
           ,@LetterNo varchar(30)
           ,@LetterDate datetime
           ,@ReceivingMode varchar(50)
           ,@Subject varchar(50)
           ,@Attachement varchar(50)
           ,@AssignToUser varchar(50)
           ,@UserWork varchar(50)
           ,@Directions varchar(50)
           ,@DueDate datetime
           ,@WorkDone varchar(50)
           ,@DoneDate datetime)
           as
           
INSERT INTO [PostManagement1].[dbo].[AddNewDetails]
           ([EntryDate]
           ,[ReceivedFrom]
           ,[LetterNo]
           ,[LetterDate]
           ,[ReceivingMode]
           ,[Subject]
           ,[Attachement]
           ,[AssignToUser]
           ,[UserWork]
           ,[Directions]
           ,[DueDate]
           ,[WorkDone]
           ,[DoneDate])
     VALUES
           (@EntryDate
           ,@ReceivedFrom
           ,@LetterNo
           ,@LetterDate
           ,@ReceivingMode
           ,@Subject
           ,@Attachement
           ,@AssignToUser
           ,@UserWork
           ,@Directions
           ,@DueDate
           ,@WorkDone
           ,@DoneDate)
GO
/****** Object:  StoredProcedure [dbo].[InsertPost]    Script Date: 10/19/2019 17:28:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertPost](@UserName varchar(50)
           ,@Atype varchar(50)
           ,@Designation varchar(50)
           ,@Department varchar(50)
           ,@ContectNumber varchar(50)
           ,@UserID varchar(50)
           ,@Password varchar(50)
           ,@ConfirmPassword varchar(50))
           as
           
INSERT INTO [PostManagement1].[dbo].[UserPost1]
           ([UserName]
           ,[Atype]
           ,[Designation]
           ,[Department]
           ,[ContectNumber]
           ,[UserID]
           ,[Password]
           ,[ConfirmPassword])
           
     VALUES
           (@UserName
           ,@Atype
           ,@Designation
           ,@Department
           ,@ContectNumber
           ,@UserID
           ,@Password
           ,@ConfirmPassword)
GO
