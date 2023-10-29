--use Electronics


--create procedure usp_GetDataByPrice @price float
--as
--select Brands.Name, SUM(n.Price) 'Total Price', COUNT(*) 'Count'
--from Notebooks n
--join Brands on Brands.ID=n.BrandID
--group by Brands.Name
--having SUM(n.Price)>@price

--execute usp_GetDataByPrice 2000

select *from Notebooks
select *from Brands

--create procedure usp_AddNotebooks @name nvarchar(50), @price float, @BrandID int
--as
--insert into Notebooks([Name], Price, BrandID)
--values
--(@name, @price, @BrandID)

--exec usp_AddNotebooks 'Sebastian 15-FD0088CI', 900, 2
--exec usp_AddNotebooks 'Pavilion Strelka 15-EG3049CI', 1800, 2

--exec usp_AddNotebooks 'Lenovo Loq', 5500, 6

--create procedure usp_UpdtNotebooks 
--@name nvarchar(50), @price float, 
--@brandId int, @id int
--as
--update Notebooks
--set [Name] = ISNULL(@name, Name), Price = ISNULL(@price, Price), BrandID=ISNULL(@brandId, BrandID) 
--where ID = @id

--exec usp_UpdtNotebooks 'Lenovo Loq', null, null, 10

--create procedure usp_DeleteNotebooks @id int
--as
--delete from Notebooks
--where id = @id

--exec usp_DeleteNotebooks 10