
USE TSQL;
GO

--Task 1
-- Write a script to create a table to store the Competitor data.


 create table Directmarketing.Competitors(
 CompetitorId int NOT Null,
 CompetitorName nvarchar(50) not null,
 BrandValue varchar(15) not null,
 Rating int not null,
 CompetitiorLoacation varchar(50) not null
 )


 --Task 2
 -- Write a script to create a table to store the TVAdvertisement data.

 create table DirectMarketing.Advertisements

 (
 AdvertisementId int not null,
 AdvertisementName nvarchar(50) not null,
 AddBrandName nvarchar(50) not null,
 AddDuration int not null,
 AddDescription nvarchar not null,
 Price int not null
 )
  

  --Task 
  -- Write a script to create a table to store the CampaignResponse data
create table  DirectMarketing.CampaignResponces(

  CampaignId int not null,
  CampaignName nvarchar(50) not null,
  StartDate datetimeoffset(7) NOT NULL,
  CampainLocatio nvarchar(5) not null,
  CampaignLoacation nvarchar(100) not null,
  CampaignDescription nvarchar  ,
  Comments nvarchar
  )
  
