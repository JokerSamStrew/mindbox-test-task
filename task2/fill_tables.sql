DELETE FROM dbo.products;
DELETE FROM dbo.categories;
DELETE FROM dbo.products_categories;

SET IDENTITY_INSERT dbo.products ON;

INSERT INTO dbo.products (Id, Name)
VALUES
	(1, 'Product1'),
	(2, 'Product2'),
	(3, 'Product3'),
	(4, 'Product4'),
	(5, 'Product5'),
	(6, 'Product6'),
	(7, 'Product7'),
	(8, 'Product8'),
	(9, 'Product9'),
	(10, 'Product10'),
	(11, 'Product11'),
	(12, 'Product12');

SET IDENTITY_INSERT dbo.products OFF;

SET IDENTITY_INSERT dbo.categories ON;

INSERT INTO dbo.categories (Id, Name)
VALUES
	(1, 'Category1'),
	(2, 'Category2'),
	(3, 'Category3'),
	(4, 'Category4'),
	(5, 'Category5'),
	(6, 'Category6'),
	(7, 'Category7'),
	(8, 'Category8'),
	(9, 'Category9'),
	(10, 'Category10'),
	(11, 'Category11'),
	(12, 'Category12');

SET IDENTITY_INSERT dbo.categories OFF;

INSERT INTO dbo.products_categories (productId, categoryId)
VALUES
	(1, 1),
	(1, 2),
	(1, 3),
	(2, 1),
	(2, 3),
	(3, 10),
	(4, 11),
	(5, 12),
	(6, 4),
	(7, 1),
	(8, 10),
	(9, 1);
