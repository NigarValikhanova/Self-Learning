---- TASK 6

--Select * from Notebooks
--where Price Between 2000 and 5000 Or Price<5000

---- TASK 7

--Select * from Phones
--where Price Between 1000 and 1500 Or Price>1500

---- TASK 8

--Select b.Name, Count(*) 'Count' from Brands b
--join Notebooks n on n.BrandID = b.ID
--Group By b.Name

---- TASK 9

--Select b.Name, Count(*) 'Count' from Brands b
--join Phones p on p.BrandID = b.ID
--Group By b.Name

---- TASK 10

--Select [Name], BrandID from Notebooks 
--union all
--Select [Name], BrandID from Phones

---- TASK 11

--Select Products.BrandID, Products.Name, Products.Price, b.Name from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID

---- TASK 12

--Select Products.BrandID, Products.Name, Products.Price, b.Name 'Brand Name' from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID

---- TASK 13

--Select Products.BrandID, Products.Name, Products.Price, b.Name 'Brand Name' from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID
--where Products.Price>3000

---- TASK 14

--Select b.Name, SUM(p.Price) 'Total Price', COUNT(*) 'Product Count' 
--from Phones p
--join Brands b on b.ID =p.BrandID
--Group By b.Name

---- TASK 15

--Select b.Name 'Brand Name', SUM(n.Price) 'Total Price', COUNT(*) 'Product Count' 
--from Notebooks n
--join Brands b on b.ID =n.BrandID
--Group By b.Name
--having COUNT(*)> 1 AND SUM(n.Price)>2000

---- HAVING aggregate function larla ishlenir, count, sum, max ve s.
---- WHERE aggregate function larla ishlenmir.

---- VIEW

--Create View [AllProduct] AS
--Select Products.BrandID, Products.Name, Products.Price, b.Name 'Brand Name' from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID

--select * from [AllProduct]
--where [AllProduct].Price>3000


--insert into Phones (Name, Price, BrandID)
--values 
--('P50 Pro', 1999.99, 4),
--('Nova Y70', 429.99, 4)

----o tablelari update etdikde view da avtomatik update olur
--select * from [AllProduct]