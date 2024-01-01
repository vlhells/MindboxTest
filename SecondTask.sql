CREATE TABLE dbo.Products(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	ProductTitle NVARCHAR(128) NOT NULL
);

CREATE TABLE dbo.Categories(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	CategoryTitle NVARCHAR(128) NOT NULL
);

CREATE TABLE dbo.CategoriesProducts(
	CategoryId INT,
	ProductId INT NOT NULL
);

INSERT dbo.Products VALUES
('V8'),
('Deathadder Chroma'),
('Deathstalker'),
('Mamba'),
('Naga');

INSERT INTO dbo.Categories VALUES
('Bloody'),
('Razer');

INSERT dbo.CategoriesProducts (CategoryId, ProductId) VALUES
(1, 1),
(2, 2),
(2, 3),
(2, 4),
(NULL, 5);


-- Запрос:
SELECT DISTINCT ISNULL(c.CategoryTitle, 'Категория не указана') AS 'Категория', p.ProductTitle AS 'Товар'
FROM Categories c
RIGHT JOIN
    CategoriesProducts catPr ON c.Id = catPr.CategoryId
RIGHT JOIN
    Products p ON catPr.ProductId = p.Id
ORDER BY p.ProductTitle;