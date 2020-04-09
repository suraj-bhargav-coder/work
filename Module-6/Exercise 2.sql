--Exercise 2

IF OBJECT_ID(N'Sales.SalesOrderDetailHeap', N'U') IS NOT NULL
	DROP TABLE Sales.SalesOrderDetailHeap;
GO

SELECT SalesOrderID, ISNULL(SalesOrderDetailID * 2, 0) AS 'SalesOrderDetailID', CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate
	INTO Sales.SalesOrderDetailHeap
	FROM Sales.SalesOrderDetail;
GO

IF OBJECT_ID(N'Sales.SalesOrderDetailClustered', N'U') IS NOT NULL
	DROP TABLE Sales.SalesOrderDetailClustered;
GO

SELECT SalesOrderID, ISNULL(SalesOrderDetailID * 2, 0) AS 'SalesOrderDetailID', CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate
	INTO Sales.SalesOrderDetailClustered
	FROM Sales.SalesOrderDetail;
GO

ALTER TABLE Sales.SalesOrderDetailClustered
	ADD CONSTRAINT PK_SalesOrderDetailClustered PRIMARY KEY CLUSTERED (SalesOrderID, SalesOrderDetailID);
GO

SET STATISTICS XML ON;
SET STATISTICS IO ON;
SET STATISTICS TIME ON;

SELECT *
	FROM Sales.SalesOrderDetailHeap;

SELECT *
	FROM Sales.SalesOrderDetailClustered;

SELECT *
	FROM Sales.SalesOrderDetailHeap
	ORDER BY SalesOrderID, SalesOrderDetailID
	OPTION (MAXDOP 1);


SELECT *
	FROM Sales.SalesOrderDetailClustered

SELECT *
	FROM Sales.SalesOrderDetailHeap
	WHERE SalesOrderID BETWEEN 50000 AND 53000;

SELECT *
	FROM Sales.SalesOrderDetailClustered
	WHERE SalesOrderID BETWEEN 50000 AND 53000;

SELECT *
	FROM Sales.SalesOrderDetailHeap
	WHERE SalesOrderID BETWEEN 50000 AND 53000
	ORDER BY SalesOrderID, SalesOrderDetailID;

SELECT *
	FROM Sales.SalesOrderDetailClustered
	WHERE SalesOrderID BETWEEN 50000 AND 53000
	ORDER BY SalesOrderID, SalesOrderDetailID;

INSERT INTO Sales.SalesOrderDetailHeap (SalesOrderID, SalesOrderDetailID, CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate)
	SELECT SalesOrderID, ISNULL((SalesOrderDetailID * 2) + 1, 0) AS 'SalesOrderDetailID', CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate
		FROM Sales.SalesOrderDetail;

INSERT INTO Sales.SalesOrderDetailClustered (SalesOrderID, SalesOrderDetailID, CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate)
	SELECT SalesOrderID, ISNULL((SalesOrderDetailID * 2) + 1, 0) AS 'SalesOrderDetailID', CarrierTrackingNumber, OrderQty, ProductID, SpecialOfferID, UnitPrice, UnitPriceDiscount, LineTotal, rowguid, ModifiedDate
		FROM Sales.SalesOrderDetail
	OPTION (MAXDOP 1);

SET STATISTICS XML OFF;
SET STATISTICS IO OFF;
SET STATISTICS TIME ON;

  