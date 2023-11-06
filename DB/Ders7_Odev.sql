--86. a.Bu ülkeler hangileri..?

select distinct country from customers

--87. En Pahalı 5 ürün

select * from products
order by unit_price desc limit 5

--88. ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?

select count(order_id) from orders
where customer_id='ALFKI'

--89. Ürünlerimin toplam maliyeti

select sum(unit_price*units_in_stock) as total_cost from products

--90. Şirketim, şimdiye kadar ne kadar ciro yapmış..?

select sum((unit_price*quantity)*(1-discount)) as total_amount from order_details

--91. Ortalama Ürün Fiyatım

select avg(unit_price) from products

--92. En Pahalı Ürünün Adı

select product_name, unit_price from products
order by unit_price desc limit 1

--93. En az kazandıran sipariş

select sum((unit_price*quantity)*(1-discount)) as total,order_id from order_details
group by order_id
order by total limit 1

--94. Müşterilerimin içinde en uzun isimli müşteri

select length(contact_name) as length_name, contact_name from customers
order by length_name desc,contact_name limit 1

--95. Çalışanlarımın Ad, Soyad ve Yaşları

select first_name, last_name, age(current_date,birth_date) from employees

--96. Hangi üründen toplam kaç adet alınmış..?

select product_id, sum(quantity) as q from order_details
group by product_id
order by product_id

--97. Hangi siparişte toplam ne kadar kazanmışım..?

select sum((unit_price*quantity)*(1-discount)) as total,order_id from order_details
group by order_id
order by order_id

--98. Hangi kategoride toplam kaç adet ürün bulunuyor..?

select category_id , count(category_id) as category_count from products 
group by category_id

--99. 1000 Adetten fazla satılan ürünler?

select product_id, sum(quantity) from order_details
group by product_id
having sum(quantity)>1000

--100. Hangi Müşterilerim hiç sipariş vermemiş..?

select * from customers c
left join orders o on c.customer_id=o.customer_id
where order_id is null

--101. Hangi tedarikçi hangi ürünü sağlıyor ?

select p.supplier_id, s.company_name, product_name from products p
inner join suppliers s on p.supplier_id=s.supplier_id
order by s.company_name

--102. Hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş..?

select o.order_id, o.shipped_date, s.company_name from orders o 
inner join shippers s on o.ship_via=s.shipper_id

--103. Hangi siparişi hangi müşteri verir..?

select o.order_id, c.contact_name from orders o
inner join customers c on o.customer_id=c.customer_id

--104. Hangi çalışan, toplam kaç sipariş almış..?

select count(o.order_id), o.employee_id, e.first_name, e.last_name  from orders o
inner join employees e on o.employee_id=e.employee_id
group by o.employee_id,e.first_name, e.last_name
order by o.employee_id  

--105. En fazla siparişi kim almış..?

select e.employee_id, e.first_name, sum(od.quantity) as order_count from employees e
inner join orders o on o.employee_id=e.employee_id
inner join order_details od on o.order_id=od.order_id
group by e.employee_id
order by order_count desc limit 1

--106. Hangi siparişi, hangi çalışan, hangi müşteri vermiştir..?

select order_id, e.first_name||' '||e.last_name as employee_name, c.contact_name from orders o
inner join employees e on e.employee_id=o.employee_id
inner join customers c on c.customer_id=o.customer_id

--107. Hangi ürün, hangi kategoride bulunmaktadır..? Bu ürünü kim tedarik etmektedir..?

select p.product_name, c.category_name, s.company_name from products p
inner join categories c on p.category_id=c.category_id
inner join suppliers s on p.supplier_id=s.supplier_id

--108. Hangi siparişi hangi müşteri vermiş, hangi çalışan almış, hangi tarihte, hangi kargo şirketi tarafından gönderilmiş 
--     hangi üründen kaç adet alınmış, hangi fiyattan alınmış, ürün hangi kategorideymiş bu ürünü hangi tedarikçi sağlamış

select od.order_id, cu.contact_name, e.first_name||' '||e.last_name as employee_name, o.order_date, sh.company_name, 
p.product_name, od.quantity, od.unit_price, c.category_name,s.company_name from order_details od
inner join orders o on od.order_id=o.order_id
inner join products p on od.product_id=p.product_id
inner join categories c on c.category_id=p.category_id
inner join suppliers s on s.supplier_id=p.supplier_id
inner join shippers sh on o.ship_via=sh.shipper_id
inner join customers cu on o.customer_id=cu.customer_id
inner join employees e on o.employee_id=e.employee_id

--109. Altında ürün bulunmayan kategoriler

select c.category_name, p.product_name from products p
right join categories c on c.category_id=p.category_id
where p.category_id is null

--110. Manager ünvanına sahip tüm müşterileri listeleyiniz.

select * from customers
where contact_title like '%Manager%'

--111. FR ile başlayan 5 karekter olan tüm müşterileri listeleyiniz.

select * from customers
where lower(company_name) like 'fr___'

--112. (171) alan kodlu telefon numarasına sahip müşterileri listeleyiniz.

select * from customers
where phone like '(171)%'

--113. BirimdekiMiktar alanında boxes geçen tüm ürünleri listeleyiniz.

select * from products
where quantity_per_unit like '%boxes%'

--114. Fransa ve Almanyadaki (France,Germany) Müdürlerin (Manager) Adını ve Telefonunu listeleyiniz.(MusteriAdi,Telefon)

select contact_name, phone from customers
where country in ('France','Germany') and lower(contact_title) like '%manager%'

--115. En yüksek birim fiyata sahip 10 ürünü listeleyiniz.

select * from products
order by unit_price desc limit 10

--116. Müşterileri ülke ve şehir bilgisine göre sıralayıp listeleyiniz.

select * from customers
order by country,city

--117. Personellerin ad,soyad ve yaş bilgilerini listeleyiniz.

select first_name||' '||last_name, age(current_date,birth_date) from employees

--118. 35 gün içinde sevk edilmeyen satışları listeleyiniz.

select * from orders
WHERE shipped_date IS NULL or (shipped_date - order_date) > 35;

--119. Birim fiyatı en yüksek olan ürünün kategori adını listeleyiniz. (Alt Sorgu)

select category_name from categories
where category_id=(select category_id from products
				  order by unit_price desc limit 1)

--120. Kategori adında 'on' geçen kategorilerin ürünlerini listeleyiniz. (Alt Sorgu)

select product_name from products
where category_id in (select category_id from categories
					 where category_name like '%on%' )

--121. Konbu adlı üründen kaç adet satılmıştır.

select sum(quantity) from order_details
where product_id = (select product_id from products
				   where product_name='Konbu')

--122. Japonyadan kaç farklı ürün tedarik edilmektedir.

select count(distinct product_id) from products
where supplier_id in (select supplier_id from suppliers
					 where country='Japan')
					 
--123. 1997 yılında yapılmış satışların en yüksek, en düşük ve ortalama nakliye ücretlisi ne kadardır?

select max(freight), min(freight), avg(freight) from orders
where extract(year from order_date)=1997

--124. Faks numarası olan tüm müşterileri listeleyiniz.

select company_name,fax
from customers
where Fax is not NULL
order by company_name asc

--125. 1996-07-16 ile 1996-07-30 arasında sevk edilen satışları listeleyiniz. 

select * from orders
where shipped_date between '1996-07-16' and '1996-07-30'
