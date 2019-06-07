INSERT INTO core.attachment_lookup(book, resource, resource_key)
SELECT 'transaction',           'transactions.transaction_master',  'transaction_master_id' UNION ALL
SELECT 'non-gl-transaction',    'transactions.non_gl_stock_master', 'non_gl_stock_master_id';
