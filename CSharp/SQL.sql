--Tablo Getirme
Select * from Products

--Tablodaki istenilen Kolonları getirme
Select ProductID,ProductName From Products

--Tablodaki aynı verilerin tekrar getirilmesini engeller. Örneğin İstanbul 2 kez kullanıldıysa 1 kez getirilir.
Select DISTINCT City from Customers

--Tablodaki farklı şehirlerin toplam sayısı
Select Count(distinct City) from Customers

--Tabloda belirli bir koşula ait verileri getirmek için where kullanılır
Select * From Products where ProductID=1 

--Tabloda birden fazla değeri getirebilmek için kullanırız.
Select * From Products where ProductID=1 or ProductID=2 or ProductID=5

--And yazdığımızda o değerleri taşıyan veriyi getirir.
SELECT * FROM Customers WHERE Country='Germany' AND City='Berlin'

--Country='Germany' dışındaki tüm müşterileri getir.
SELECT * FROM Customers WHERE NOT Country='Germany'

--Country='Germany' ve Country='USA' olmayan müşterileri getir.
SELECT * FROM Customers WHERE NOT Country='Germany' AND NOT Country='USA'

--Müşterileri Ülkelere göre sınıflandırmak için 
SELECT * FROM Customers ORDER BY Country

--Desc düşen anlamındadır. Z-A yada azalan bir şekilde sıralama yapar.
SELECT * FROM Customers ORDER BY Country DESC

--ASC artan anlamındadır. A-Z yada artan bir şekilde sıralama yapar.
SELECT * FROM Customers ORDER BY Country ASC

SELECT * FROM Customers ORDER BY Country ASC, CustomerName DESC;

--Tabloya kayıt eklemek için INSERT INTO kullanılır.
INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal','Tom B. Erichsen','9 21','Stavanger','4006','Norway');

--Müşteriler tablosundaki boş olan adres verilerini geri getir. Boş olmayanlar için ----> is not null 
SELECT CustomerName, ContactName, Address
FROM Customers
WHERE Address IS NULL;

--Customer tablosundaki CustomerID=1 olan müşterinin ContactName,City verilerini güncelemek.
UPDATE Customers
SET ContactName='Alfred Schmidt', City='Frankfurt'
WHERE CustomerID=1;

--CustomerName="Alfreds Futterkiste olan müşteriyi sil.
DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

--Tablodaki başta bulunan 3 veriyi ekrana getirir.
SELECT TOP 3 * FROM Customers;

--Ürünler tablosundaki Price kolonundaki minumum değeri getirme
SELECT MIN(UnitPrice) AS SmallestPrice
FROM Products;

--Ürünler tablosundaki Price kolonundaki maksimum değeri getirme
SELECT max(UnitPrice) AS SmallestPrice FROM Products;

--Product tablosundaki ProductId lerin  sayısı.
SELECT COUNT(ProductID) FROM Products;

--Ortalama hesaplamak için kulllanılır
SELECT AVG(UnitPrice) FROM Products;

--Tüm product tablosundaki fiyatlrın toplamını getirir.
SELECT SUM(UnitPrice) FROM Products

--------------LIKE OPERATÖR------------------

--A ile başlayan müşterilerin isimlerini getirir.
SELECT * FROM Customers WHERE CustomerName LIKE 'a%'

--A ile biten müşterilerin isimlerini getirir.
SELECT * FROM Customers WHERE CustomerName LIKE '%a'

--İçerisinde or geçen isimleri getirme.
SELECT * FROM Customers WHERE CustomerName LIKE '%or%'

--2. harfi r olan müşteri isimleri getirme.
SELECT * FROM Customers WHERE CustomerName LIKE '_r%'

--A ile başlayıp en az 3 karakterli isimleri getir.
SELECT * FROM Customers WHERE CustomerName LIKE 'a__%'

--A ile başlayan ve o ile biten isimleri getir.
SELECT * FROM Customers WHERE ContactName LIKE 'a%o'

--A ile başlamayan müşterilerin isimlerini getirir.
SELECT * FROM Customers WHERE CustomerName NOT LIKE 'a%';

--Müşteriler tablosundaki City kolonu b , s , p ile başlayanları getir.
SELECT * FROM Customers WHERE City LIKE '[bsp]%';

--a , b , c , d ile başlayanları getir.
SELECT * FROM Customers WHERE City LIKE '[a-d]%';

--Müşteriler tablosundaki City kolonu b , s , p ile başlamayanları getir.
SELECT * FROM Customers WHERE City LIKE '[!bsp]%';
SELECT * FROM Customers WHERE City NOT LIKE '[bsp]%';
--------------SON------------------

--Ülkesi Germany France UK olan müşterileri getir.
SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK');

-- Ürünlerin fiyatı 10 ve 20 arasında olan ürünleri getir.
SELECT * FROM Products WHERE Price BETWEEN 10 AND 20;

SELECT CustomerID AS ID, ContactName AS Customers FROM Customers;

--Eşleşmiş 2 tablonun ortak verileri.
SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders
INNER JOIN Customers
ON Orders.CustomerID=Customers.CustomerID;

--Left Join ----> Soldaki tüm tablolar ve sağdakinde eşleşmiş teblolar geri döner.
SELECT Customers.CustomerName, Orders.OrderID
FROM Customers
LEFT JOIN Orders
ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CustomerName;

--Customers ile Suppliers City kolonlarınındaki veriler birleştirilerek (Tekrar olmadan) getirilir.
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

--2 Tablodaki City'deki tüm değerleri getirir. (All ifadesinden)
SELECT City FROM Customers
UNION ALL
SELECT City FROM Suppliers
ORDER BY City;

--Ülkeleri kendi içinde gruplandırarak O ülkelere ait veri bulunduran müşterilerin id'sini getirir.
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country;

--Toplam ülkelerin içindeki müşteri sayısının 5 üzerinde olan verileri getirme.
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;









