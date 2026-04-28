CREATE DATABASE [WIM];
GO

USE [WIM];
GO

CREATE TABLE dbo.Products (
    Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Products PRIMARY KEY,
    Name NVARCHAR(200) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Category NVARCHAR(100) NOT NULL
);
GO

INSERT INTO dbo.Products (Name, Quantity, Price, Category)
VALUES
  (N'Ноутбук Lenovo', 15, 45000, N'Электроника', SYSUTCDATETIME()),
  (N'Мышь Logitech', 50, 1200,  N'Периферия',   SYSUTCDATETIME()),
  (N'Клавиатура механическая', 25, 3500, N'Периферия', SYSUTCDATETIME());
GO


SELECT
    Id, Name, Quantity, Price, Category
FROM dbo.Products
ORDER BY Id ASC;
GO