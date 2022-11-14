SELECT p.Name, c.Name
	FROM dbo.products as p
LEFT JOIN dbo.products_categories as pc
	ON p.Id = pc.productId
LEFT JOIN dbo.categories as c
	ON c.Id = pc.categoryId


--Name	Name
--Product1	Category1
--Product1	Category2
--Product1	Category3
--Product2	Category1
--Product2	Category3
--Product3	Category10
--Product4	Category11
--Product5	Category12
--Product6	Category4
--Product7	Category1
--Product8	Category10
--Product9	Category1
--Product10	NULL
--Product11	NULL
--Product12	NULL