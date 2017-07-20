select clients.name from clients
where exists(select * from sales where clients.id = sales.client_id and sales.name = 'milk')
except
select clients.name from clients
where exists(select * from sales where clients.id = sales.client_id and sales.name = 'smetana' and date'today' - sales.date < interval '1 month')
