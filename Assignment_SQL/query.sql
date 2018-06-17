SELECT DISTINCT Clients.client_name
FROM Clients
LEFT JOIN Orders on Clients.client_id = Orders.client_id
WHERE Orders.order_sum > 50

SELECT Clients.client_name
FROM Orders
INNER JOIN Clients on Orders.client_id = Clients.client_id
GROUP BY Clients.client_name
HAVING SUM(Orders.order_sum) > 100