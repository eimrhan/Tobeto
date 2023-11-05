-- 26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını
-- (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.
select product_id, product_name, company_name, phone from suppliers s
inner join products p on p.supplier_id=s.supplier_id
where units_in_stock=0;

-- 27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı
select first_name, last_name, ship_address, order_date from employees e
inner join orders o on e.employee_id=o.employee_id
where extract(year from order_date)=1998 and
extract(month from order_date)=3;

-- 28. 1997 yılı şubat ayında kaç siparişim var?
select count(order_id) as order_count_in_02_1997 from orders
where extract(year from order_date)=1997 and
extract(month from order_date)=2;

-- 29. London şehrinden 1998 yılında kaç siparişim var?
select count(order_id) as order_count_on_london_in_1998 from orders
where ship_city='London' and extract(year from order_date)=1998;

-- 30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası
select distinct contact_name, phone from customers c
inner join orders o on c.customer_id=o.customer_id
where extract(year from order_date)=1997;

-- 31. Taşıma ücreti 40 üzeri olan siparişlerim
select * from orders
where freight>40;

-- 32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı
select order_id, ship_city, contact_name from orders o
inner join customers c on o.customer_id=c.customer_id
where freight>40;

-- 33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı-soyadı 
-- (ad soyad birleşik olacak ve büyük harf)
select order_date, ship_city, UPPER(first_name||last_name) from orders o
inner join employees e on o.employee_id=e.employee_id
where extract(year from order_date)=1997;

-- 34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları
-- (telefon formatı 2223322 gibi olmalı)
select distinct contact_name, TRANSLATE(Phone, '()-. ', '') from customers c
inner join orders o on o.customer_id=c.customer_id
where extract(year from order_date)=1997

-- 35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad
select o.order_date, c.contact_name, e.first_name, e.last_name from customers c
inner join orders o on o.customer_id=c.customer_id
inner join employees e on e.employee_id=o.employee_id;

-- 36. Geciken siparişlerim?
select order_id, required_date, shipped_date from orders
where shipped_date>required_date;

-- 37. Geciken siparişlerimin tarihi, müşterisinin adı
select order_id, required_date, shipped_date, contact_name from orders o
inner join customers c on o.customer_id=c.customer_id
where shipped_date>required_date;

-- 38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
select p.product_name, c.category_name, od.quantity from products p
inner join categories c on p.category_id=c.category_id
inner join order_details od on p.product_id=od.product_id
where od.order_id=10248;

-- 39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı
select product_name, contact_name from products p
inner join suppliers s on s.supplier_id=p.supplier_id
inner join order_details od on p.product_id=od.product_id
where od.order_id=10248;

-- 40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti
select p.product_name, od.quantity from orders o
inner join employees e on o.employee_id=e.employee_id
inner join order_details od on o.order_id=od.order_id
inner join products p on p.product_id=od.product_id
where o.employee_id = 3 and extract(year from order_date)=1997;

-- 41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad
select e.employee_id, e.first_name||' '||e.last_name as full_name, od.quantity from employees e
inner join orders o on o.employee_id=e.employee_id
inner join order_details od on o.order_id=od.order_id
where extract(year from order_date)=1997
order by od.quantity desc limit 1;

-- 42. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****
select e.employee_id, e.first_name||' '||e.last_name as full_name, sum(od.quantity) from employees e
inner join orders o on o.employee_id=e.employee_id
inner join order_details od on o.order_id=od.order_id
where extract(year from order_date)=1997
group by e.employee_id, od.quantity
order by sum(od.quantity) desc limit 1

-- 43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?
select p.product_name, p.unit_price, c.category_name from products p
inner join categories c on p.category_id=c.category_id
order by unit_price desc limit 1;

-- 44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
select e.first_name, e.last_name, o.order_date, o.order_id from employees e
inner join orders o on o.employee_id=e.employee_id
order by order_date;

-- 45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?
Select od.order_id, AVG(od.unit_price * od.quantity) as "ORTALAMA FİYAT" from order_details od
group by od.order_id
order by od.order_id desc limit 5

-- 46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?
select p.product_name, c.category_name, SUM(od.quantity) as "TOPLAM SATIŞ" from orders o
inner join order_details od on o.order_id = od.order_id
inner join products p on p.product_id = od.product_id
inner join categories c on c.category_id = p.category_id
where extract(month from o.order_date)=1
group by p.product_name, c.category_name

-- 47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
Select od.order_id, od.quantity from order_details od
inner join orders o on o.order_id = od.order_id
where od.quantity>(select avg(quantity) from order_details);

-- 48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
select p.product_name, c.category_name, s.company_name from products p
inner join suppliers s on s.supplier_id = p.supplier_id
inner join categories c on c.category_id = p.category_id
order by p.units_on_order desc limit 1

-- 49. Kaç ülkeden müşterim var
select count(distinct country) from customers

-- 50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?
select SUM(od.unit_price*od.quantity) AS "TOPLAM SATIŞ MİKTARI" from order_details od
inner join orders o on o.order_id = od.order_id
inner join employees e on e.employee_id = o.employee_id
where e.employee_id=3

-- 51-62, 64, 79 ve 80. sorular tekrar edilmiş. daha önce çözüldü. --

-- 63. Hangi ülkeden kaç müşterimiz var
select country, count(*) from customers
group by country

-- 64. çözüldü (50.sorunun aynısı) --

-- 65. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?
select sum(od.unit_price*od.quantity) from products p
inner join order_details od on p.product_id = od.product_id
inner join orders o on o.order_id = od.order_id
where p.product_id = 10 AND 
o.order_date > now() - interval '3 MONTHS'
--o.order_date > now() - interval '26 YEARS'

-- 66. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?
select employee_id, count(*) from orders
group by employee_id

-- 67. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun
select * from customers c
left join orders o on o.customer_id = c.customer_id
where order_id is NULL

-- 68. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri
select company_name, contact_name, address, city, country from customers
where country = 'Brazil'

-- 69. Brezilya’da olmayan müşteriler
select company_name, contact_name, address, city, country from customers
where country != 'Brazil'

-- 70. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
select * from customers
where country in('Spain', 'France', 'Germany')

-- 71. Faks numarasını bilmediğim müşteriler
select * from customers
where fax is NULL

-- 72. Londra’da ya da Paris’de bulunan müşterilerim
select * from customers
where city in('London', 'Paris')

-- 73. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler
select * from customers
where city = 'México D.F.' and contact_title = 'Owner'

-- 74. C ile başlayan ürünlerimin isimleri ve fiyatları
select product_name, unit_price from products
where product_name like 'C%'

-- 75. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri
select first_name || ' ' || last_name as full_name, birth_date from employees
where first_name like ('A%')

-- 76. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları
select company_name from customers
where UPPER(company_name) like ('%RESTAURANT%')

-- 77. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları
select product_name, unit_price from products
where unit_price between 50 and 100

-- 78. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri
select order_id, order_date from orders
where order_date between '01-07-1996' and '31-12-1996'

-- 79. çözüldü (70.sorunun aynısı) --
-- 80. çözüldü (71.sorunun aynısı) --

-- 81. Müşterilerimi ülkeye göre sıralıyorum:
select * from customers
order by country

-- 82. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price from products
order by unit_price desc

-- 83. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price, units_in_stock from products
order by unit_price desc, units_in_stock asc

-- 84. 1 Numaralı kategoride kaç ürün vardır..?
select count(*) from products
group by category_id
having category_id = 1

-- 85. Kaç farklı ülkeye ihracat yapıyorum..?
select country, count(*) from customers
group by country