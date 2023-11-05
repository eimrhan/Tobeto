-- join
select * from products p
inner join categories c on p.category_id = c.category_id;

--hangi ürün hangi kategoride
select p.product_name, c.category_name from products p
inner join categories c on p.category_id = c.category_id;

--hangi sipariş hangi kargo sirketi ile ne zaman gönderilmiş
select o.order_id, s.company_name, o.order_date from orders o
inner join shippers s on o.ship_via=s.shipper_id;

--multiple join
--hangi siparişi hangi çalışan hangi müşteri vermiştir
select o.order_id, e.first_name|| ' ' ||e.last_name as "Ad Soyad", c.company_name
from orders o
inner join employees e on o.employee_id=e.employee_id
inner join customers c on o.customer_id=c.customer_id;

--left join
--hiç sipariş almamış
select e.first_name||' '||e.last_name as "Ad Soyad", o.order_id, o.order_date
from employees e
left join orders o on e.employee_id = o.employee_id;

--sorgumuzda tüm müşteriler ve verdikleri sipraişlerin tarhileri listelensin
select c.company_name, o.order_date from customers c
right join orders o on c.customer_id=o.customer_id
order by order_date desc;

--full join
select c.company_name, o.order_date from customers c
full outer join orders o on c.customer_id=o.customer_id
order by order_date desc;


--group by
--belirtilen sütun yada sütunlardaki aynı değere sahip satırları gruplar

--sipariş detayları tablosundan product_id alanına göre gruplandıralım ve her grubun
--toplam sipariş miktarını belirterek listeleyelim
select product_id,sum(quantity) from order_details
group by product_id;

--hangi category toplam kaç ürün var
select c.category_name,count(p.category_id) from products p
inner join categories c on p.category_id=c.category_id
group by c.category_name;

--hangi ülkeye ne kadarlık satış yapılmış
select o.ship_country, sum(od.unit_price*od.quantity) from orders o
inner join order_details od on o.order_id = od.order_id
group by ship_country


--having
--where gibi görev ve işlev benzer
--group by kullandığımız zaman

--toplam sipariş miktarı 1300 adetten fazla olan ürün kodlarını listele
select product_id, sum(quantity) from order_details
group by product_id
having sum(quantity)>1300;

--stok sayısı 20den fazla, toplam ürün sayısı 1den fazla olan kategoriler
select category_id, units_in_stock from products
where units_in_stock>20
group by category_id, units_in_stock
having count(*)>1;

--içerisinde en az 10 ürün olan kategorilerin ürün sayısı
select category_id, count(*) from products
group by category_id
having count(*) >= 10

select category_name, count(*) as "kategorideki ürün" from products
inner join categories on categories.category_id=products.category_id
group by category_name
having count(*) >=10;

--100 adetten fazla satılan ürünler
select product_name, sum(quantity) from products p
inner join order_details o on p.product_id=o.product_id
group by p.product_name,o.quantity
having o.quantity>100;

-- select od.product_id, od.quantity from orders o
-- inner join order_details od on o.order_id = od.order_id
-- group by od.product_id, od.quantity
-- having od.quantity > 100








/*********************************/