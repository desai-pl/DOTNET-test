CREATE DATABASE [WildlifeTracker]
GO
ALTER DATABASE [WildlifeTracker] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WildlifeTracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
USE [WildlifeTracker]
GO
/*================================================================================================
Table: DeviceInfo

This table defines Device/Animal specific information. A 'DeviceInfo' record
typically represents animal that is being 'tracked'.

================================================================================================*/

CREATE TABLE [dbo].[DeviceInfo](
	[DeviceID] [varchar](50) NOT NULL,
	[EquipmentType] [varchar](50) NOT NULL,
	[SerialNumber] [varchar](50) NOT NULL,
	[EquipmentStatus] [varchar](50) NULL,
	[AnimalID] [varchar](50) NULL,
	[AnimalType] varchar](50) NULL,
	[AnimalStatus] [int] NOT NULL,
	[AnimalGroup] varchar](50) NULL,
	[SimID] varchar](50) NULL,
	[ImeiNumber] varchar](50) NULL,
	[IPAddress] [varchar](50) NULL,
	[LastValidLatitude] [varchar](50) NULL,
	[LastValidLongitude] [varchar](50) NULL,
	[LastGPSTimestamp] [varchar](50) NULL,
	[LastUpdateTime] [datetime]NULL,
	[CreationTime] [datetime]NULL,
	[Description] [varchar](50) NOT NULL
	
) ON [PRIMARY]
GO

/*================================================================================================
Table: EventData

This table contains events which have been generated by all client devices.

================================================================================================*/

CREATE TABLE [dbo].[EventData](
	[DeviceID] [varchar](50) NOT NULL,
	[Latitude] [varchar](50) NULL,
	[Longitude] [varchar](50) NULL,	
	[SerialNumber] [varchar](50) NOT NULL,
	[EquipmentStatus] [varchar](50) NULL,
	[AnimalID] [varchar](50) NULL,
	[AnimalType] varchar](50) NULL,
	[AnimalStatus] [int] NOT NULL,	
	[IPAddress] [varchar](50) NULL,		
	[LastUpdateTime] [datetime]NULL,
	[CreationTime] [datetime]NULL,
	[Description] [varchar](50) NOT NULL
	
) ON [PRIMARY]
GO

/*================================================================================================
Table: EventTemplate

This table contains DMTP event packet 'template's (Custom Event Packet Negotiation parse
templates) which have been received from client devices.

================================================================================================*/

CREATE TABLE [dbo].[EventTemplate](
	[DeviceID] [varchar](50) NOT NULL,
	[CustomType] [int] NOT NULL,
	[SerialNumber] [varchar](50) NOT NULL,
	[RepeatLast] [int] NOT NULL,
	[Template] [varchar](50) NULL,	
	[CreationTime] [datetime]NULL	
	
) ON [PRIMARY]
GO

/*================================================================================================
Table: PendingPacket

This table contains configuration packets which are to be sent to the DMTP client device the
next time it 'checks-in' with the server.

================================================================================================*/

CREATE TABLE [dbo].[PendingPacket](
	[DeviceID] [varchar](50) NOT NULL,
	[QueueTime] [int] NOT NULL,
	[SequenceID] [int] NOT NULL,	
	[PacketBytes] [varchar](50) NOT NULL,
	[autoDelete] [int] NOT NULL
	
) ON [PRIMARY]
GO

/*================================================================================================
Table: Property

This table contains Device specific property information collected from client devices.

================================================================================================*/

CREATE TABLE [dbo].[Property](
	[DeviceID] [varchar](50) NOT NULL,
	[PropKey] [int] NOT NULL,
	[timestampID] [int] NOT NULL
	
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveDeviceInfo]
@DeviceID varchar(50),
@EquipmentType varchar(50),
@SerialNumber varchar(50),
@EquipmentStatus varchar(50),
@AnimalID varchar(50),
@AnimalType varchar(50),
@AnimalStatus int,
@AnimalGroup varchar(50),
@SimID varchar(50),
@ImeiNumber varchar(50)
@IPAddress varchar(50)
@LastValidLatitude varchar(50),
@LastValidLongitude varchar(50),
@LastGPSTimestamp varchar(50)
@currentTimeStamp datetime,
@currentTimeStamp datetime,
@Description varchar(50)

AS
BEGIN
INSERT INTO DeviceInfo (DeviceID,,EquipmentType,SerialNumber,EquipmentStatus,AnimalID,AnimalType,AnimalStatus,AnimalGroup,SimID,ImeiNumber,IPAddress,LastValidLatitude,LastValidLongitude,LastGPSTimestamp,currentTimeStamp,currentTimeStamp,Description)
     VALUES (@DeviceID,,@EquipmentType,@SerialNumber,@EquipmentStatus,@AnimalID,@AnimalType,@AnimalStatus,@AnimalGroup,@SimID,@ImeiNumber,@IPAddress,@LastValidLatitude,@LastValidLongitude,@LastGPSTimestamp,@currentTimeStamp,@currentTimeStamp,@Description)
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FetchDeviceInfo]
as
begin
select DeviceID,,EquipmentType,SerialNumber,EquipmentStatus,AnimalID,AnimalType,AnimalStatus,AnimalGroup,SimID,ImeiNumber,IPAddress,LastValidLatitude,LastValidLongitude,LastGPSTimestamp,currentTimeStamp,currentTimeStamp,Description from DeviceInfo order by logtime desc
end
GO
