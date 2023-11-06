--exist - not exist -> mevcut mu?
select company_name from suppliers
where exists (select product_name from products
			where products.supplier_id=suppliers.supplier_id
			and unit_price<20);
			
--iki tarih arasında sipariş almış çalışanlar
select e.employee_id, first_name, last_name from employees e
where exists (select * from orders o
			 where e.employee_id=o.employee_id
			 and o.order_date between '3/5/1998' and '4/5/1998');

--all
--tüm alt sorgu değerleri koşulumuzu sağlıyorsa true (AND benzer)
select product_name from products
where product_id=ALL(select distinct product_id from order_details od
					 where od.quantity=10);
					 
--any
--alt sorgu değerlerinden herhangi biri koşulu sağlıyorsa true (OR benzer)
select product_name from products
where product_id=ANY(select distinct product_id from order_details od
					 where od.quantity>99);
					 
