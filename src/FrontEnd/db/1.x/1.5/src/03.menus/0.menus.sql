--This table should not be localized.
SELECT * FROM core.create_menu('Other Setup', NULL, 'OTHR', 1, core.get_menu_id('SET'));
SELECT * FROM core.create_menu('Genders', '~/Modules/BackOffice/Other/Genders.mix', 'GENDR', 2, core.get_menu_id('OTHR'));
SELECT * FROM core.create_menu('Identification Types', '~/Modules/BackOffice/Other/IdentificationTypes.mix', 'IDNTYP', 2, core.get_menu_id('OTHR'));
SELECT * FROM core.create_menu('Nationalities', '~/Modules/BackOffice/Other/Nationalities.mix', 'NTNALY', 2, core.get_menu_id('OTHR'));
SELECT * FROM core.create_menu('Marital Statuses', '~/Modules/BackOffice/Other/MaritalStatuses.mix', 'MATSTS', 2, core.get_menu_id('OTHR'));

SELECT * FROM core.create_menu('Default Entity Access Policy', '~/Modules/BackOffice/Policy/DefaultEntityAccess.mix', 'DEFEAPOL', 2, core.get_menu_id('SPM'));
SELECT * FROM core.create_menu('Entity Access Policy', '~/Modules/BackOffice/Policy/EntityAccess.mix', 'EAPOL', 2, core.get_menu_id('SPM'));
SELECT * FROM core.create_menu('Holiday Setup', '~/Modules/BackOffice/Other/HolidaySetup.mix', 'HOLIDAY', 2, core.get_menu_id('OTHR'));


UPDATE core.menus SET menu_text = 'Inventory' WHERE menu_code = 'ITM';
UPDATE core.menus SET sort = 100 WHERE menu_code = 'ITM';
UPDATE core.menus SET sort = 200 WHERE menu_code = 'SA';
UPDATE core.menus SET sort = 300 WHERE menu_code = 'PU';
UPDATE core.menus SET sort = 400 WHERE menu_code = 'FI';
UPDATE core.menus SET sort = 500 WHERE menu_code = 'BO';
UPDATE core.menus SET sort = 10000 WHERE menu_code = 'SET';


UPDATE core.menus SET sort= 2000, icon = 'line chart' WHERE menu_code = 'ITM';
UPDATE core.menus SET sort= 3000, icon = 'shop' WHERE menu_code = 'SA';
UPDATE core.menus SET sort= 4000, icon = 'payment' WHERE menu_code = 'PU';
UPDATE core.menus SET sort= 5000, icon = 'area chart' WHERE menu_code = 'FI';
UPDATE core.menus SET sort= 6000, icon = 'building' WHERE menu_code = 'BO';
UPDATE core.menus SET sort= 7000, icon = 'settings' WHERE menu_code IN('SET', 'SSM', 'ISM', 'FSM');

UPDATE core.menus SET sort = 0, icon = 'bar chart' WHERE parent_menu_id IN 
(
    SELECT menu_id 
    FROM core.menus
    WHERE menu_code IN 
    ('SAR', 'PUR', 'SPR', 'IR', 'FIR', 'SEAR', 'RW')
);


UPDATE core.menus SET sort = 2, icon = 'shipping' WHERE menu_code ='IIM';
UPDATE core.menus SET sort = 0, icon = 'shipping' WHERE menu_code ='STR';
UPDATE core.menus SET sort = 1, icon = 'thumbs up' WHERE menu_code ='STP';
UPDATE core.menus SET sort = 2, icon = 'rocket' WHERE menu_code ='STD';
UPDATE core.menus SET sort = 3, icon = 'flipped rocket' WHERE menu_code ='STK';
UPDATE core.menus SET sort = 4, icon = 'shipping' WHERE menu_code ='STJ';
UPDATE core.menus SET sort = 5, icon = 'desktop' WHERE menu_code ='STA';

DELETE FROM policy.menu_access WHERE menu_id = core.get_menu_id_by_menu_code('SAA');
DELETE FROM core.menu_locale WHERE menu_id = core.get_menu_id_by_menu_code('SAA');
DELETE FROM core.menus WHERE menu_code = 'SAA';

DELETE FROM policy.menu_access WHERE menu_id = core.get_menu_id_by_menu_code('OTSSFP');
DELETE FROM core.menu_locale WHERE menu_id = core.get_menu_id_by_menu_code('OTSSFP');
DELETE FROM core.menus WHERE menu_code = 'OTSSFP';
