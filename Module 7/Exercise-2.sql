 SET STATISTICS TIME OFF
GO
USE [AdventureWorksDW]
GO

sp_spaceused 'dbo.FactInternetSales'
GO

SET STATISTICS TIME ON
GO

SELECT SalesTerritoryRegion
		,p.EnglishProductName
		,d.WeekNumberOfYear
		,d.CalendarYear
		,SUM(fi.SalesAmount) Revenue
		,AVG(OrderQuantity) AverageQuantity
		,STDEV(UnitPrice) PriceStandardDeviation
		,SUM(TaxAmt) TotalTaxPayable
FROM dbo.FactInternetSales as fi
INNER JOIN dbo.DimProduct as p ON fi.ProductKey = p.ProductKey
INNER JOIN dbo.DimDate as d ON fi.OrderDate = d.FullDateAlternateKey
INNER JOIN dbo.DimSalesTerritory as st on fi.SalesTerritoryKey = st.SalesTerritoryKey
	AND fi.OrderDate BETWEEN '1/1/2007' AND '12/31/2007'
GROUP BY SalesTerritoryRegion, d.CalendarYear, d.WeekNumberOfYear, p.EnglishProductName
ORDER BY SalesTerritoryRegion, SUM(fi.SalesAmount) desc;

-- REMOVING THE CLUSTEREDSTORE INDEXES AND RECREATE THE KEYS ON THE TABLE
DROP INDEX [IX_FactIneternetSales_ShipDateKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_CurrencyKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_CustomerKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_DueDateKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_OrderDateKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_ProductKey] ON [dbo].[FactInternetSales];
DROP INDEX [IX_FactInternetSales_PromotionKey] ON [dbo].[FactInternetSales];
GO

/****** All foreign keys need to be removed ******/
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimCustomer];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimCurrency];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimDate];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimDate1];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimDate2];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimProduct];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimPromotion];
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [FK_FactInternetSales_DimSalesTerritory];
ALTER TABLE [dbo].[FactInternetSalesReason] DROP CONSTRAINT [FK_FactInternetSalesReason_FactInternetSales]
ALTER TABLE [dbo].[FactInternetSales] DROP CONSTRAINT [PK_FactInternetSales_SalesOrderNumber_SalesOrderLineNumber]
GO