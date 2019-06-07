--This table should not be localized.
SELECT * FROM core.create_menu('Attributes', '~/Modules/Inventory/Setup/Attributes.mix', 'ATTR', 2, core.get_menu_id('ISM'));
SELECT * FROM core.create_menu('Variants', '~/Modules/Inventory/Setup/Variants.mix', 'VARIANT', 2, core.get_menu_id('ISM'));
SELECT * FROM core.create_menu('Item Variants', '~/Modules/Inventory/Setup/ItemVariants.mix', 'ITMVAR', 2, core.get_menu_id('ISM'));
