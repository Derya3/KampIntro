Select Products.ProductName As [Ürün Adı], SUM([Order Details].Unitprice*[Order Details].Quantity) As [Kazanılan Toplam Miktar]
From (([Order Details]
Inner Join Products On Products.ProductID = [Order Details].ProductID)
Inner Join Orders On Orders.OrderID = [Order Details].OrderID)
Group by Products.ProductName