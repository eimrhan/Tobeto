--SQL => sturucted query language

--SELECT
--Select [kolonlar] form [tablo_adi]
Select product_name, unit_price from products;

--WHERE
--'den 'dan anlamı katıyor
Select * from products where unit_price > 20;
Select product_name as "ürün adı", unit_price as "ürün fiyatı" from products where unit_price > 20;

Select * from products
where unit_price >= 100 AND unit_price <= 200;

Select * from products
where unit_price Between 100 AND 200;

Select * from products
where unit_price>20 OR units_in_stock>15;

--IN()
--içerisine aldığı parametre olarak verilen n kadar veri ile ilgili alanların uyuşmasını bekler
Select * from products
where product_name IN('Chai','Chang','Ikura');

Select * from products
where category_id IN(1,2);

--LIKE
--pattern => kalıba benzer ifadeleri getiriyor
Select * from products
where product_name LIKE '%te%';

Select * from products
where LOWER(product_name) LIKE 'te%';

Select * from products
where LOWER(product_name) LIKE '__r%'; --3. harf r olsun

--Built-in Functions
--Summary => Toplama
Select SUM(unit_price) from products;

--Average Ortalama
Select AVG(unit_price) from products;

--Maximum
Select MAX(unit_price) from products;

--Minimum
Select MIN(unit_price) from products;

--DISTINCT tekrarı engeller
--Kaç farklı şehirden çalışanım var
Select DISTINCT city from employees;

-- DATE
-- Bugünün tarihi
Select current_date;
--interval
Select date_part('month',current_date);

--DATEDIFF(interval,date1,date2)
--Select first_name, Datediff('year',birth_date, current_date) from employees;
--Select FirstName, DATEDIFF(YEAR,BirthDate,GETDATE()) from Employees;

SELECT first_name, DATE_PART('year', age(current_date,birth_date)) FROM employees;

--son 10 gün içerisindeki sipraişler
Select * from orders where
date_part('year',current_date) = date_part('year',order_date) AND
date_part('month',current_date) = date_part('month',order_date) AND
date_part('day',current_date) - date_part('day',order_date) <10;

--SUB-QUERY iç içe sorgular
--ortalamanın altında bir fiyata sahip olan ürünlerimi listelemek istiyorum
select AVG(Unit_price) from products;
select product_name, unit_price from products;

select product_name, unit_price from products
where unit_price < (select AVG(unit_price) from products);

--En pahalı ürünümün bilgilerini getirelim
select max(unit_price) from products;
select * from products where unit_price = 263.5;

select * from products
where unit_price = (select max(unit_price) from products);

--ORDER BY sıralama
--default olarak küçükten büyüğe
--asc
--desc
select product_name, unit_price from products 
ORDER BY unit_price desc
LIMIT 1;

--***************************************************
--***************************************************
