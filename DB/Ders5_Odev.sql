-- 1. Product isimlerini (`ProductName`) ve birim başına miktar (`QuantityPerUnit`) değerlerini almak için sorgu yazın.

SELECT PRODUCT_NAME,
	QUANTITY_PER_UNIT
FROM PRODUCTS;

-- 2. Ürün Numaralarını (`ProductID`) ve Product isimlerini (`ProductName`) değerlerini almak için sorgu yazın.
-- Artık satılmayan ürünleri (`Discontinued`) filtreleyiniz.

SELECT PRODUCT_ID,
	PRODUCT_NAME
FROM PRODUCTS
WHERE DISCONTINUED = 1;

-- 3. Durdurulan Ürün Listesini, Ürün kimliği ve ismi (`ProductID`, `ProductName`) değerleriyle almak için bir sorgu yazın.

SELECT PRODUCT_ID,
	PRODUCT_NAME
FROM PRODUCTS
WHERE DISCONTINUED = 1;

-- 4. Ürünlerin maliyeti 20'dan az olan Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.

SELECT PRODUCT_ID,
	PRODUCT_NAME,
	UNIT_PRICE
FROM PRODUCTS
WHERE UNIT_PRICE < 20;

-- 5. Ürünlerin maliyetinin 15 ile 25 arasında olduğu Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.

SELECT PRODUCT_ID,
	PRODUCT_NAME,
	UNIT_PRICE
FROM PRODUCTS
WHERE UNIT_PRICE > 15
	AND UNIT_PRICE < 25;

-- 6. Ürün listesinin (`ProductName`, `UnitsOnOrder`, `UnitsInStock`) stoğun siparişteki miktardan az olduğunu almak için bir sorgu yazın.

SELECT PRODUCT_NAME,
	UNITS_ON_ORDER,
	UNITS_IN_STOCK
FROM PRODUCTS
WHERE UNITS_IN_STOCK < UNITS_ON_ORDER;

-- 7. İsmi `a` ile başlayan ürünleri listeleyeniz.

SELECT *
FROM PRODUCTS
WHERE LOWER(PRODUCT_NAME) LIKE 'a%';

-- 8. İsmi `i` ile biten ürünleri listeleyeniz.

SELECT *
FROM PRODUCTS
WHERE LOWER(PRODUCT_NAME) LIKE '%i';

-- 9. Ürün birim fiyatlarına %18’lik KDV ekleyerek listesini almak (ProductName, UnitPrice, UnitPriceKDV) için bir sorgu yazın.

SELECT PRODUCT_NAME,
	UNIT_PRICE,
	(UNIT_PRICE + (UNIT_PRICE * 0.20)) AS UNIT_PRICE_KDV
FROM PRODUCTS;

-- 10. Fiyatı 30 dan büyük kaç ürün var?

SELECT COUNT(*)
FROM PRODUCTS
WHERE UNIT_PRICE > 30;

-- 11. Ürünlerin adını tamamen küçültüp fiyat sırasına göre tersten listele

SELECT LOWER(PRODUCT_NAME),
	UNIT_PRICE
FROM PRODUCTS
ORDER BY UNIT_PRICE DESC;

-- 12. Çalışanların ad ve soyadlarını yanyana gelecek şekilde yazdır

SELECT CONCAT(FIRST_NAME,' ',LAST_NAME) AS FULL_NAME
FROM EMPLOYEES;

/*SELECT FIRST_NAME || ' ' || LAST_NAME AS FULL_NAME
FROM EMPLOYEES;*/

/*SELECT FIRST_NAME + '-' + LAST_NAME AS FULL_NAME
FROM EMPLOYEES;*/ /*(mssql)*/

-- 13. Region alanı NULL olan kaç tedarikçim var?

SELECT COUNT(*)
FROM SUPPLIERS
WHERE REGION IS NULL;

-- 14. Null olmayanlar?

SELECT COUNT(*)
FROM SUPPLIERS
WHERE REGION IS NOT NULL;

-- 15. Ürün adlarının hepsinin soluna TR koy ve büyültüp olarak ekrana yazdır.

SELECT UPPER('TR ' || PRODUCT_NAME)
FROM PRODUCTS;

-- 16. a.Fiyatı 20den küçük ürünlerin adının başına TR ekle

SELECT UNIT_PRICE,
	'TR ' || PRODUCT_NAME
FROM PRODUCTS
WHERE UNIT_PRICE < 20;

-- 17. En pahalı ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

SELECT PRODUCT_NAME,
	UNIT_PRICE
FROM PRODUCTS
WHERE UNIT_PRICE =
		(SELECT MAX(UNIT_PRICE)
			FROM PRODUCTS);

-- 18. En pahalı on ürünün Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

SELECT PRODUCT_NAME,
	UNIT_PRICE
FROM PRODUCTS
ORDER BY UNIT_PRICE DESC
LIMIT 10;

-- 19. Ürünlerin ortalama fiyatının üzerindeki Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.

SELECT PRODUCT_NAME,
	UNIT_PRICE
FROM PRODUCTS
WHERE UNIT_PRICE >
		(SELECT AVG(UNIT_PRICE)
			FROM PRODUCTS);

-- 20. Stokta olan ürünler satıldığında elde edilen miktar ne kadardır.

SELECT SUM(UNIT_PRICE * UNITS_IN_STOCK)
FROM PRODUCTS
WHERE UNITS_IN_STOCK > 0
	AND DISCONTINUED = 0;

-- 21. Mevcut ve Durdurulan ürünlerin sayılarını almak için bir sorgu yazın.

SELECT COUNT(*)
FROM PRODUCTS
WHERE UNITS_IN_STOCK > 0
	AND DISCONTINUED = 1;

-- 22. Ürünleri kategori isimleriyle birlikte almak için bir sorgu yazın.

SELECT PRODUCT_ID,
	PRODUCT_NAME,
	CATEGORY_NAME
FROM PRODUCTS
INNER JOIN CATEGORIES ON PRODUCTS.CATEGORY_ID = CATEGORIES.CATEGORY_ID;

--SELECT p.product_id, p.product_name, c.category_name
--FROM products p, categories c
--WHERE p.category_id = c.category_id;

-- 23. Ürünlerin kategorilerine göre fiyat ortalamasını almak için bir sorgu yazın.

SELECT AVG(UNIT_PRICE),
	CATEGORY_NAME
FROM PRODUCTS
INNER JOIN CATEGORIES ON PRODUCTS.CATEGORY_ID = CATEGORIES.CATEGORY_ID
GROUP BY CATEGORY_NAME;

-- 24. En pahalı ürünümün adı, fiyatı ve kategorisin adı nedir?

SELECT PRODUCT_NAME,
	UNIT_PRICE,
	CATEGORY_NAME
FROM PRODUCTS
INNER JOIN CATEGORIES ON PRODUCTS.CATEGORY_ID = CATEGORIES.CATEGORY_ID
ORDER BY UNIT_PRICE DESC
LIMIT 1;

-- 25. En çok satılan ürününün adı, kategorisinin adı ve tedarikçisinin adı

SELECT PRODUCT_NAME,
	CATEGORY_NAME,
	COMPANY_NAME
FROM PRODUCTS
INNER JOIN CATEGORIES ON PRODUCTS.CATEGORY_ID = CATEGORIES.CATEGORY_ID
INNER JOIN SUPPLIERS ON PRODUCTS.SUPPLIER_ID = SUPPLIERS.SUPPLIER_ID
ORDER BY UNIT_PRICE DESC
LIMIT 1;