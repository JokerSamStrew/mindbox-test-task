CREATE TABLE dbo.products (
	Id        INT            IDENTITY (1, 1) NOT NULL,
	PRIMARY KEY CLUSTERED (Id ASC),
	Name		NVARCHAR(255)
);

CREATE TABLE dbo.categories (
	Id        INT            IDENTITY (1, 1) NOT NULL,
	PRIMARY KEY CLUSTERED (Id ASC),
	Name		NVARCHAR(255)
);

CREATE TABLE dbo.products_categories (
    Id INT IDENTITY(1,1) NOT NULL,
	PRIMARY KEY CLUSTERED (Id ASC),
    productId INT NOT NULL,
    categoryId INT NOT NULL,
	FOREIGN KEY(productId) REFERENCES dbo.products(Id),
	FOREIGN KEY(categoryId) REFERENCES dbo.categories(Id)
);