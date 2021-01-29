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










