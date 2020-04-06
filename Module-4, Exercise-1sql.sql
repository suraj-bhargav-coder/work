use CompanyManagementDb;

CREATE SCHEMA DirectMarketing
AUTHORIZATION dbo
go



create table Directmarketing.Competitors(
 CompetitorId int NOT Null,
 CompetitorName nvarchar(50) not null,
 BrandValue varchar(15) not null,
 Rating int not null,
 CompetitiorLoacation varchar(50) not null
 )



 create table DirectMarketing.Advertisements

 (
 AdvertisementId int not null,
 AdvertisementName nvarchar(50) not null,
 AddBrandName nvarchar(50) not null,
 AddDuration int not null,
 AddDescription nvarchar not null,
 Price int not null
 )
  

  
create table  DirectMarketing.CampaignResponces(

  CampaignId int not null,
  CampaignName nvarchar(50) not null,
  StartDate datetimeoffset(7) NOT NULL,
  CampainLocation nvarchar(5) not null,
  CampaignLoacation nvarchar(100) not null,
  CampaignDescription nvarchar  ,
  Comments nvarchar
  )

  alter table  DirectMarketing.CampaignResponces
  add Addescription varchar(100);

  alter table DirectMarketing.CampaignResponces
  drop column Comments;


  select * from DirectMarketing.CampaignResponces;

  ALTER TABLE DirectMarketing.CampaignResponces
  ADD CONSTRAINT CR_location
  DEFAULT 'Delhi' FOR CampainLocation; 


  


 ALTER TABLE DirectMarketing.CampaignResponces
 drop CampaignLocation;


  alter table DirectMarketing.CampaignResponces
  add primary key  (CampaignId);

  



  alter table DirectMarketing.Advertisements
add primary key(AdvertisementId); 





alter table  DirectMarketing.CampaignResponces
add AdvertisementId  int FOREIGN KEY REFERENCES DirectMarketing.Advertisements(AdvertisementId )





insert into [DirectMarketing].[Advertisements](
  [AdvertisementId],
 [AdvertisementName],
 [AddBrandName],
 [AddDuration],
 [AddDescription],
 [Price] )
 values(1,'Lux add','Lux',30,'lus soap product advertisement',40000);