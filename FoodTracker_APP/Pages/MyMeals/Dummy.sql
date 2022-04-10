/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Type]
  FROM [Food Tracker].[Identity].[QuantityTypes] 

  INSERT INTO [Food Tracker].[Identity].[QuantityTypes] (Type) values ('Teste')