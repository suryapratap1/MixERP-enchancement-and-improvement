DROP VIEW IF EXISTS transactions.supply_planner_view;

CREATE VIEW transactions.supply_planner_view
AS
SELECT * 
FROM transactions.non_gl_stock_detail_view
WHERE transactions.non_gl_stock_detail_view.non_gl_stock_master_id NOT IN
(
    SELECT non_gl_stock_master_id 
    FROM transactions.stock_master_non_gl_relations
);

--SELECT * FROM transactions.supply_planner_view;
