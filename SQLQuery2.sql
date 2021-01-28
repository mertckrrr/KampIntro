--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'


selEct * from Products where CategoryId=1 or categoryId=3


select * from Products where CategoryId=1 and UnitPrice>=10

select * from Products order by UnitPrice asc --ascending

select * from Products where categoryId=1 order by UnitPrice desc --descending

select count(*) Adet from Products where CategoryID=2


select categoryID,count(*) from products group by CategoryID


select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

--köşeli parantez arasında boşluk var diye
Select * from Products p left join [Order Details] od    
on p.ProductID= OD.ProductID

--üstekinin başka versiyonu
Select * from Products p inner join [Orders Details] od 
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

--yönetim dedi ki sisteme kayıt olup ürün almamış pasifleri söyle onları aktif hale getirelim derse
Select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null
