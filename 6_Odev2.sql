SELECT P.ProductName AS 'Product Name',
SUM(Od.Quantity*Od.UnitPrice)AS 'Total Price'
FROM Products P
INNER JOIN [Order Details] AS Od
ON P.ProductID=Od.ProductID
INNER JOIN ORDERS O
ON O.OrderID=Od.OrderID GROUP BY P.ProductName
