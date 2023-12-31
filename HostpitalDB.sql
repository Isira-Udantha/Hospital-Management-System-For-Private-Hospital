USE [master]
GO
/****** Object:  Database [Hostpital]    Script Date: 12/28/2019 10:26:57 ******/
CREATE DATABASE [Hostpital] ON  PRIMARY 
( NAME = N'Hostpital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.THILINA\MSSQL\DATA\Hostpital.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hostpital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.THILINA\MSSQL\DATA\Hostpital_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hostpital] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hostpital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hostpital] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Hostpital] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Hostpital] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Hostpital] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Hostpital] SET ARITHABORT OFF
GO
ALTER DATABASE [Hostpital] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Hostpital] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Hostpital] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Hostpital] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Hostpital] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Hostpital] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Hostpital] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Hostpital] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Hostpital] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Hostpital] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Hostpital] SET  DISABLE_BROKER
GO
ALTER DATABASE [Hostpital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Hostpital] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Hostpital] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Hostpital] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Hostpital] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Hostpital] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Hostpital] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Hostpital] SET  READ_WRITE
GO
ALTER DATABASE [Hostpital] SET RECOVERY FULL
GO
ALTER DATABASE [Hostpital] SET  MULTI_USER
GO
ALTER DATABASE [Hostpital] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Hostpital] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hostpital', N'ON'
GO
USE [Hostpital]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [varchar](200) NOT NULL,
	[GuardianName] [varchar](200) NULL,
	[NIC] [varchar](15) NOT NULL,
	[ContactNumber] [varchar](12) NOT NULL,
	[EmergencyContact] [varchar](12) NOT NULL,
	[DOB] [date] NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[BloodGroup] [varchar](10) NULL,
	[AllergyDescription] [varchar](max) NULL,
	[GeneralDescription] [varchar](max) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [varchar](200) NOT NULL,
	[NIC] [varchar](15) NOT NULL,
	[ContactNumber] [varchar](12) NOT NULL,
	[Speciality] [varchar](500) NOT NULL,
	[Rates] [money] NOT NULL,
	[ACNumber] [varchar](30) NOT NULL,
	[Active] [int] NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AddNewPatient]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Thilina Wanshathilaka
-- Create date: 07-12-2019
-- Description:	Add New Patient details in to system  
-- =============================================
CREATE PROCEDURE [dbo].[AddNewPatient]
--Declare Parameters
           (@PatientName varchar(200),
            @GuardianName varchar(200),
            @NIC varchar(15),
            @ContactNumber varchar(12),
            @EmergencyContact varchar(12),
            @DOB date,
            @Address varchar(500),
            @BloodGroup varchar(10),
            @AllergyDescription varchar,
            @GeneralDescription varchar)
AS
BEGIN
INSERT INTO [Hostpital].[dbo].[Patient]
           ([PatientName]
           ,[GuardianName]
           ,[NIC]
           ,[ContactNumber]
           ,[EmergencyContact]
           ,[DOB]
           ,[Address]
           ,[BloodGroup]
           ,[AllergyDescription]
           ,[GeneralDescription])
     VALUES
           (@PatientName,
            @GuardianName,
            @NIC,
            @ContactNumber,
            @EmergencyContact,
            @DOB,
            @Address,
            @BloodGroup,
            @AllergyDescription,
            @GeneralDescription)

END
GO
/****** Object:  StoredProcedure [dbo].[AddNewDoctor]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewDoctor] 
           (@DoctorName varchar(200),
            @NIC varchar(15),
            @ContactNumber varchar(12),
            @Speciality varchar(500),
            @Rates money,
            @ACNumber varchar(30),
            @Active int)
AS
BEGIN
INSERT INTO [Hostpital].[dbo].[Doctors]
           ([DoctorName]
           ,[NIC]
           ,[ContactNumber]
           ,[Speciality]
           ,[Rates]
           ,[ACNumber]
           ,[Active])
     VALUES
           (@DoctorName,@NIC,@ContactNumber,
            @Speciality,@Rates,@ACNumber,
            @Active)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePatientDetails]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePatientDetails]
--Declare Parameters
           (@PatientID int,
            @PatientName varchar(200),
            @GuardianName varchar(200),
            @NIC varchar(15),
            @ContactNumber varchar(12),
            @EmergencyContact varchar(12),
            @DOB date,
            @Address varchar(500),
            @BloodGroup varchar(10),
            @AllergyDescription varchar,
            @GeneralDescription varchar)
AS
BEGIN
UPDATE [Hostpital].[dbo].[Patient]
   SET [PatientName] = @PatientName
      ,[GuardianName] = @GuardianName
      ,[NIC] = @NIC
      ,[ContactNumber] = @ContactNumber
      ,[EmergencyContact] = @EmergencyContact
      ,[DOB] = @DOB
      ,[Address] = @Address
      ,[BloodGroup] = @BloodGroup
      ,[AllergyDescription] = @AllergyDescription
      ,[GeneralDescription] = @GeneralDescription
 WHERE PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDoctorsDetails]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateDoctorsDetails]
           (@DoctorID int,
            @DoctorName varchar(200),
            @NIC varchar(15),
            @ContactNumber varchar(12),
            @Speciality varchar(500),
            @Rates money,
            @ACNumber varchar(30),
            @Active int)
AS
BEGIN
UPDATE [Hostpital].[dbo].[Doctors]
   SET [DoctorName] = @DoctorName 
      ,[NIC] = @NIC
      ,[ContactNumber] = @ContactNumber
      ,[Speciality] = @Speciality
      ,[Rates] = @Rates
      ,[ACNumber] = @ACNumber
      ,[Active] = @Active 
 WHERE DoctorID=@DoctorID

END
GO
/****** Object:  StoredProcedure [dbo].[SearchPatient]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Thilina Wanshathilaka
-- Create date: 07-12-2019
-- Description:	List All Patient 
-- =============================================
CREATE PROCEDURE [dbo].[SearchPatient] 
(@NIC varchar(15))
AS
BEGIN
SELECT [PatientID]
      ,[PatientName]
      ,[GuardianName]
      ,[NIC]
      ,[ContactNumber]
      ,[EmergencyContact]
      ,[DOB]
      ,[Address]
      ,[BloodGroup]
      ,[AllergyDescription]
      ,[GeneralDescription]
  FROM [Hostpital].[dbo].[Patient]
  WHERE NIC =@NIC
END
GO
/****** Object:  StoredProcedure [dbo].[SearchDoctors]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchDoctors]
(@NIC varchar(15))
AS
BEGIN
SELECT [DoctorID]
      ,[DoctorName]
      ,[NIC]
      ,[ContactNumber]
      ,[Speciality]
      ,[Rates]
      ,[ACNumber]
      ,[Active]
  FROM [Hostpital].[dbo].[Doctors]
  WHERE NIC=@NIC
END
GO
/****** Object:  Table [dbo].[Availability]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Availability](
	[DoctorID] [int] NOT NULL,
	[AvailabilityID] [int] IDENTITY(1,1) NOT NULL,
	[Day] [varchar](20) NOT NULL,
	[InTime] [time](7) NOT NULL,
	[OutTime] [time](7) NOT NULL,
	[NumberOfHours] [float] NOT NULL,
 CONSTRAINT [PK_Availability] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC,
	[AvailabilityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [date] NOT NULL,
	[AppointmentTime] [time](7) NOT NULL,
	[AppointmentNumber] [int] NOT NULL,
	[DoctorsCharge] [money] NOT NULL,
	[HospitalCharges] [money] NOT NULL,
	[Tax] [money] NOT NULL,
	[TotalCharges] [money] NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ListPatient]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Thilina Wanshathilaka
-- Create date: 07-12-2019
-- Description:	List All Patient 
-- =============================================
CREATE PROCEDURE [dbo].[ListPatient] 

AS
BEGIN
SELECT [PatientID]
      ,[PatientName]
      ,[GuardianName]
      ,[NIC]
      ,[ContactNumber]
      ,[EmergencyContact]
      ,[DOB]
      ,[Address]
      ,[BloodGroup]
      ,[AllergyDescription]
      ,[GeneralDescription]
  FROM [Hostpital].[dbo].[Patient]
END
GO
/****** Object:  StoredProcedure [dbo].[ListDoctors]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ListDoctors]

AS
BEGIN
SELECT [DoctorID]
      ,[DoctorName]
      ,[NIC]
      ,[ContactNumber]
      ,[Speciality]
      ,[Rates]
      ,[ACNumber]
      ,[Active]
  FROM [Hostpital].[dbo].[Doctors]
  WHERE Active=1
END
GO
/****** Object:  StoredProcedure [dbo].[GetAvailabilityDetails]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAvailabilityDetails]
(@DoctorID int)
AS
BEGIN
SELECT [DoctorID]
      ,[AvailabilityID]
      ,[Day]
      ,[InTime]
      ,[OutTime]
      ,[NumberOfHours]
  FROM [Hostpital].[dbo].[Availability]
  Where DoctorID=@DoctorID
END
GO
/****** Object:  StoredProcedure [dbo].[AddTimeSlot]    Script Date: 12/28/2019 10:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddTimeSlot]
           (@DoctorID int
           ,@Day varchar(20)
           ,@InTime time(7)
           ,@OutTime time(7)
           ,@NumberOfHours float)

AS
BEGIN
INSERT INTO [Hostpital].[dbo].[Availability]
           ([DoctorID]
           ,[Day]
           ,[InTime]
           ,[OutTime]
           ,[NumberOfHours])
     VALUES
 (@DoctorID,@Day,@InTime,@OutTime,@NumberOfHours)
END
GO
/****** Object:  ForeignKey [FK_Availability_Doctors]    Script Date: 12/28/2019 10:26:57 ******/
ALTER TABLE [dbo].[Availability]  WITH CHECK ADD  CONSTRAINT [FK_Availability_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Availability] CHECK CONSTRAINT [FK_Availability_Doctors]
GO
/****** Object:  ForeignKey [FK_Appointment_Doctors]    Script Date: 12/28/2019 10:26:57 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctors]
GO
/****** Object:  ForeignKey [FK_Appointment_Patient]    Script Date: 12/28/2019 10:26:57 ******/
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patient] ([PatientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
