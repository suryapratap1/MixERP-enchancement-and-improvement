DROP VIEW IF EXISTS transactions.party_item_chart_view;

CREATE VIEW transactions.party_item_chart_view
AS
SELECT
    party_id,
    core.items.item_name,
    SUM(base_quantity) AS total
FROM transactions.stock_details
INNER JOIN transactions.stock_master
ON transactions.stock_master.stock_master_id = transactions.stock_details.stock_master_id
INNER JOIN core.items
ON transactions.stock_details.item_id = core.items.item_id
GROUP BY party_id, core.items.item_name
ORDER BY party_id, total DESC;