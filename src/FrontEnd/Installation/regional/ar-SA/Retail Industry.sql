DO
$$
    DECLARE _country_id integer = 0;
BEGIN
    INSERT INTO core.countries(country_code, country_name)

SELECT 'AF', 'أفغانستان' UNION ALL 
SELECT 'AX', 'جزر آلاند' UNION ALL 
SELECT 'AL', 'ألبانيا' UNION ALL 
SELECT 'DZ', 'الجزائر' UNION ALL 
SELECT 'AS', 'ساموا الأمريكية' UNION ALL 
SELECT 'AD', 'أندورا' UNION ALL 
SELECT 'AO', 'أنغولا' UNION ALL 
SELECT 'AI', 'أنغيلا' UNION ALL 
SELECT 'AQ', 'القارة القطبية الجنوبية' UNION ALL 
SELECT 'AG', 'أنتيغوا وبربودا' UNION ALL 
SELECT 'AR', 'الأرجنتين' UNION ALL 
SELECT 'AM', 'أرمينيا' UNION ALL 
SELECT 'AW', 'أروبا' UNION ALL 
SELECT 'AU', 'أستراليا' UNION ALL 
SELECT 'AT', 'النمسا' UNION ALL 
SELECT 'AZ', 'أذربيجان' UNION ALL 
SELECT 'BS', 'جزر البهاما' UNION ALL 
SELECT 'BH', 'البحرين' UNION ALL 
SELECT 'BD', 'بنغلاديش' UNION ALL 
SELECT 'BB', 'بربادوس' UNION ALL 
SELECT 'BY', 'روسيا البيضاء' UNION ALL 
SELECT 'BE', 'بلجيكا' UNION ALL 
SELECT 'BZ', 'بليز' UNION ALL 
SELECT 'BJ', 'بنين' UNION ALL 
SELECT 'BM', 'برمودا' UNION ALL 
SELECT 'BT', 'بوتان' UNION ALL 
SELECT 'BO', 'بوليفيا' UNION ALL 
SELECT 'BA', 'البوسنة والهرسك' UNION ALL 
SELECT 'BW', 'بوتسوانا' UNION ALL 
SELECT 'BV', 'جزيرة بوفيت' UNION ALL 
SELECT 'BR', 'البرازيل' UNION ALL 
SELECT 'IO', 'إقليم المحيط الهندي البريطاني' UNION ALL 
SELECT 'BN', 'بروناي دار السلام' UNION ALL 
SELECT 'BG', 'بلغاريا' UNION ALL 
SELECT 'BF', 'بوركينا فاسو' UNION ALL 
SELECT 'BI', 'بوروندي' UNION ALL 
SELECT 'KH', 'كمبوديا' UNION ALL 
SELECT 'CM', 'الكاميرون' UNION ALL 
SELECT 'CA', 'كندا' UNION ALL 
SELECT 'CV', 'الرأس الأخضر' UNION ALL 
SELECT 'BQ', 'منطقة البحر الكاريبي هولندا' UNION ALL 
SELECT 'KY', 'جزر كايمان' UNION ALL 
SELECT 'CF', 'جمهورية افريقيا الوسطى' UNION ALL 
SELECT 'TD', 'تشاد' UNION ALL 
SELECT 'CL', 'تشيلي' UNION ALL 
SELECT 'CN', 'الصين' UNION ALL 
SELECT 'CX', 'جزيرة الكريسماس' UNION ALL 
SELECT 'CC', 'جزر كوكوس (كيلينغ)' UNION ALL 
SELECT 'CO', 'كولومبيا' UNION ALL 
SELECT 'KM', 'جزر القمر' UNION ALL 
SELECT 'CG', 'الكونغو' UNION ALL 
SELECT 'CD', 'الكونغو، جمهورية الكونغو الديمقراطية' UNION ALL 
SELECT 'CK', 'جزر كوك' UNION ALL 
SELECT 'CR', 'كوستا ريكا' UNION ALL 
SELECT 'CI', 'كوت ديفوار' UNION ALL 
SELECT 'HR', 'كرواتيا' UNION ALL 
SELECT 'CU', 'كوبا' UNION ALL 
SELECT 'CW', 'كوراساو' UNION ALL 
SELECT 'CY', 'قبرص' UNION ALL 
SELECT 'CZ', 'الجمهورية التشيكية' UNION ALL 
SELECT 'DK', 'الدنمارك' UNION ALL 
SELECT 'DJ', 'جيبوتي' UNION ALL 
SELECT 'DM', 'دومينيكا' UNION ALL 
SELECT 'DO', 'جمهورية الدومينيكان' UNION ALL 
SELECT 'EC', 'الإكوادور' UNION ALL 
SELECT 'EG', 'مصر' UNION ALL 
SELECT 'SV', 'السلفادور' UNION ALL 
SELECT 'GQ', 'غينيا الاستوائية' UNION ALL 
SELECT 'ER', 'إريتريا' UNION ALL 
SELECT 'EE', 'استونيا' UNION ALL 
SELECT 'ET', 'أثيوبيا' UNION ALL 
SELECT 'FK', 'جزر فوكلاند' UNION ALL 
SELECT 'FO', 'جزر فارو' UNION ALL 
SELECT 'FJ', 'فيجي' UNION ALL 
SELECT 'FI', 'فنلندا' UNION ALL 
SELECT 'FR', 'فرنسا' UNION ALL 
SELECT 'GF', 'غيانا الفرنسية' UNION ALL 
SELECT 'PF', 'بولينيزيا الفرنسية' UNION ALL 
SELECT 'TF', 'الاقاليم الجنوبية الفرنسية' UNION ALL 
SELECT 'GA', 'الغابون' UNION ALL 
SELECT 'GM', 'غامبيا' UNION ALL 
SELECT 'GE', 'جورجيا' UNION ALL 
SELECT 'DE', 'ألمانيا' UNION ALL 
SELECT 'GH', 'غانا' UNION ALL 
SELECT 'GI', 'جبل طارق' UNION ALL 
SELECT 'GR', 'اليونان' UNION ALL 
SELECT 'GL', 'غرينلاند' UNION ALL 
SELECT 'GD', 'غرينادا' UNION ALL 
SELECT 'GP', 'غوادلوب' UNION ALL 
SELECT 'GU', 'غوام' UNION ALL 
SELECT 'GT', 'غواتيمالا' UNION ALL 
SELECT 'GG', 'غيرنسي' UNION ALL 
SELECT 'GN', 'غينيا' UNION ALL 
SELECT 'GW', 'غينيا بيساو' UNION ALL 
SELECT 'GY', 'غيانا' UNION ALL 
SELECT 'HT', 'هايتي' UNION ALL 
SELECT 'HM', 'سمعت وجزر ماكدونالد' UNION ALL 
SELECT 'HN', 'هندوراس' UNION ALL 
SELECT 'HK', 'هونج كونج' UNION ALL 
SELECT 'HU', 'هنغاريا' UNION ALL 
SELECT 'IS', 'أيسلندا' UNION ALL 
SELECT 'IN', 'الهند' UNION ALL 
SELECT 'ID', 'أندونيسيا' UNION ALL 
SELECT 'IR', 'إيران' UNION ALL 
SELECT 'IQ', 'العراق' UNION ALL 
SELECT 'IE', 'أيرلندا' UNION ALL 
SELECT 'IM', 'جزيرة مان' UNION ALL 
SELECT 'IL', 'إسرائيل' UNION ALL 
SELECT 'IT', 'إيطاليا' UNION ALL 
SELECT 'JM', 'جامايكا' UNION ALL 
SELECT 'JP', 'اليابان' UNION ALL 
SELECT 'JE', 'جيرسي' UNION ALL 
SELECT 'JO', 'الأردن' UNION ALL 
SELECT 'KZ', 'كازاخستان' UNION ALL 
SELECT 'KE', 'كينيا' UNION ALL 
SELECT 'KI', 'كيريباس' UNION ALL 
SELECT 'KW', 'الكويت' UNION ALL 
SELECT 'KG', 'قيرغيزستان' UNION ALL 
SELECT 'LA', 'جمهورية لاو الديمقراطية الشعبية' UNION ALL 
SELECT 'LV', 'لاتفيا' UNION ALL 
SELECT 'LB', 'لبنان' UNION ALL 
SELECT 'LS', 'ليسوتو' UNION ALL 
SELECT 'LR', 'ليبيريا' UNION ALL 
SELECT 'LY', 'ليبيا' UNION ALL 
SELECT 'LI', 'ليشتنشتاين' UNION ALL 
SELECT 'LT', 'ليتوانيا' UNION ALL 
SELECT 'LU', 'لوكسمبورغ' UNION ALL 
SELECT 'MO', 'ماكاو' UNION ALL 
SELECT 'MK', 'مقدونيا' UNION ALL 
SELECT 'MG', 'مدغشقر' UNION ALL 
SELECT 'MW', 'ملاوي' UNION ALL 
SELECT 'MY', 'ماليزيا' UNION ALL 
SELECT 'MV', 'جزر المالديف' UNION ALL 
SELECT 'ML', 'مالي' UNION ALL 
SELECT 'MT', 'مالطا' UNION ALL 
SELECT 'MH', 'جزر مارشال' UNION ALL 
SELECT 'MQ', 'مارتينيك' UNION ALL 
SELECT 'MR', 'موريتانيا' UNION ALL 
SELECT 'MU', 'موريشيوس' UNION ALL 
SELECT 'YT', 'مايوت' UNION ALL 
SELECT 'MX', 'المكسيك' UNION ALL 
SELECT 'FM', 'ولايات ميكرونيزيا الموحدة من' UNION ALL 
SELECT 'MD', 'مولدوفا' UNION ALL 
SELECT 'MC', 'موناكو' UNION ALL 
SELECT 'MN', 'منغوليا' UNION ALL 
SELECT 'ME', 'الجبل الأسود' UNION ALL 
SELECT 'MS', 'مونتسيرات' UNION ALL 
SELECT 'MA', 'المغرب' UNION ALL 
SELECT 'MZ', 'موزمبيق' UNION ALL 
SELECT 'MM', 'ميانمار' UNION ALL 
SELECT 'NA', 'ناميبيا' UNION ALL 
SELECT 'NR', 'ناورو' UNION ALL 
SELECT 'NP', 'نيبال' UNION ALL 
SELECT 'NC', 'كاليدونيا الجديدة' UNION ALL 
SELECT 'NZ', 'نيوزيلندا' UNION ALL 
SELECT 'NI', 'نيكاراغوا' UNION ALL 
SELECT 'NE', 'النيجر' UNION ALL 
SELECT 'NG', 'نيجيريا' UNION ALL 
SELECT 'NU', 'نيوي' UNION ALL 
SELECT 'NF', 'جزيرة نورفولك' UNION ALL 
SELECT 'KP', 'كوريا الشمالية' UNION ALL 
SELECT 'MP', 'جزر ماريانا الشمالية' UNION ALL 
SELECT 'NO', 'النرويج' UNION ALL 
SELECT 'OM', 'يا شيخ' UNION ALL 
SELECT 'PK', 'باكستان' UNION ALL 
SELECT 'PW', 'بالاو' UNION ALL 
SELECT 'PS', 'فلسطين، دولة' UNION ALL 
SELECT 'PA', 'بناما' UNION ALL 
SELECT 'PG', 'بابوا غينيا الجديدة' UNION ALL 
SELECT 'PY', 'باراغواي' UNION ALL 
SELECT 'PE', 'بيرو' UNION ALL 
SELECT 'PH', 'الفلبين' UNION ALL 
SELECT 'PN', 'بيتكيرن' UNION ALL 
SELECT 'PL', 'بولندا' UNION ALL 
SELECT 'PT', 'البرتغال' UNION ALL 
SELECT 'PR', 'بورتوريكو' UNION ALL 
SELECT 'QA', 'قطر' UNION ALL 
SELECT 'RE', 'ريونيون' UNION ALL 
SELECT 'RO', 'رومانيا' UNION ALL 
SELECT 'RU', 'الفيدرالية الروسية' UNION ALL 
SELECT 'RW', 'رواندا' UNION ALL 
SELECT 'BL', 'سانت بارتيليمي' UNION ALL 
SELECT 'SH', 'سانت هيلانة' UNION ALL 
SELECT 'KN', 'سانت كيتس ونيفيس' UNION ALL 
SELECT 'LC', 'سانت لوسيا' UNION ALL 
SELECT 'VC', 'سانت فنسنت وجزر غرينادين' UNION ALL 
SELECT 'MF', 'سانت مارتن (فرنسا)' UNION ALL 
SELECT 'WS', 'ساموا' UNION ALL 
SELECT 'SM', 'سان مارينو' UNION ALL 
SELECT 'ST', 'ساو تومي وبرينسيبي' UNION ALL 
SELECT 'SA', 'المملكة العربية السعودية' UNION ALL 
SELECT 'SN', 'السنغال' UNION ALL 
SELECT 'RS', 'صربيا' UNION ALL 
SELECT 'SC', 'سيشيل' UNION ALL 
SELECT 'SL', 'سيرا ليون' UNION ALL 
SELECT 'SG', 'سنغافورة' UNION ALL 
SELECT 'SX', 'سانت مارتن (الجزء الهولندي)' UNION ALL 
SELECT 'SK', 'سلوفاكيا' UNION ALL 
SELECT 'SI', 'سلوفينيا' UNION ALL 
SELECT 'SB', 'جزر سليمان' UNION ALL 
SELECT 'SO', 'الصومال' UNION ALL 
SELECT 'ZA', 'جنوب افريقيا' UNION ALL 
SELECT 'GS', 'جورجيا الجنوبية وجزر ساندويتش الجنوبية' UNION ALL 
SELECT 'KR', 'كوريا الجنوبية' UNION ALL 
SELECT 'SS', 'جنوب السودان' UNION ALL 
SELECT 'ES', 'إسبانيا' UNION ALL 
SELECT 'LK', 'سيريلانكا' UNION ALL 
SELECT 'PM', 'سانت بيير وميكولون' UNION ALL 
SELECT 'SD', 'سودان' UNION ALL 
SELECT 'SR', 'سورينام' UNION ALL 
SELECT 'SJ', 'جزر سفالبارد وجان ماين' UNION ALL 
SELECT 'SZ', 'سوازيلاند' UNION ALL 
SELECT 'SE', 'السويد' UNION ALL 
SELECT 'CH', 'سويسرا' UNION ALL 
SELECT 'SY', 'سوريا' UNION ALL 
SELECT 'TW', 'تايوان' UNION ALL 
SELECT 'TJ', 'طاجيكستان' UNION ALL 
SELECT 'TZ', 'تنزانيا' UNION ALL 
SELECT 'TH', 'تايلاند' UNION ALL 
SELECT 'NL', 'هولندا' UNION ALL 
SELECT 'TL', 'تيمور الشرقية' UNION ALL 
SELECT 'TG', 'توغو' UNION ALL 
SELECT 'TK', 'توكيلاو' UNION ALL 
SELECT 'TO', 'تونغا' UNION ALL 
SELECT 'TT', 'ترينداد وتوباغو' UNION ALL 
SELECT 'TN', 'تونس' UNION ALL 
SELECT 'TR', 'ديك رومي' UNION ALL 
SELECT 'TM', 'تركمانستان' UNION ALL 
SELECT 'TC', 'جزر تركس وكايكوس' UNION ALL 
SELECT 'TV', 'توفالو' UNION ALL 
SELECT 'UG', 'أوغندا' UNION ALL 
SELECT 'UA', 'أوكرانيا' UNION ALL 
SELECT 'AE', 'الإمارات العربية المتحدة' UNION ALL 
SELECT 'GB', 'المملكة المتحدة' UNION ALL 
SELECT 'US', 'الولايات المتحدة' UNION ALL 
SELECT 'UM', 'جزر الولايات المتحدة البعيدة الصغيرة' UNION ALL 
SELECT 'UY', 'أوروغواي' UNION ALL 
SELECT 'UZ', 'أوزبكستان' UNION ALL 
SELECT 'VU', 'فانواتو' UNION ALL 
SELECT 'VA', 'الفاتيكان' UNION ALL 
SELECT 'VE', 'فنزويلا' UNION ALL 
SELECT 'VN', 'فيتنام' UNION ALL 
SELECT 'VG', 'جزر فيرجن (البريطانية)' UNION ALL 
SELECT 'VI', 'جزر العذراء (الولايات المتحدة)' UNION ALL 
SELECT 'WF', 'واليس وفوتونا' UNION ALL 
SELECT 'EH', 'الصحراء الغربية' UNION ALL 
SELECT 'YE', 'اليمن' UNION ALL 
SELECT 'ZM', 'زامبيا' UNION ALL 
SELECT 'ZW', 'زيمبابوي';

    


/*****************************************************************************************************
Saudi Arabian Kingdum Cities and cities by nubiancc
*****************************************************************************************************/  

      SELECT country_id INTO _country_id
    FROM core.countries WHERE country_code='sa';

    INSERT INTO core.states(state_code, state_name, country_id)
SELECT 'RI', 'الرياض', _country_id UNION ALL
SELECT 'MK', 'مكة', _country_id UNION ALL
SELECT 'MD', 'المدينة', _country_id UNION ALL
SELECT 'TB', 'تبوك', _country_id UNION ALL
SELECT 'HA', 'حائل', _country_id UNION ALL
SELECT 'SH', 'الشرقية', _country_id UNION ALL
SELECT 'AS', 'عسير', _country_id UNION ALL
SELECT 'NJ', 'نجران', _country_id UNION ALL
SELECT 'HS', 'الحدود الشمالية', _country_id UNION ALL
SELECT 'QS', 'القصيم', _country_id UNION ALL
SELECT 'JF', 'الجوف', _country_id UNION ALL
SELECT 'JZ', 'جيزان', _country_id UNION ALL
SELECT 'BA', 'الباحة', _country_id ;


 INSERT INTO core.counties(county_code, county_name, state_id) VALUES
('1', 'االرياض', core.get_state_id_by_state_name('الرياض')),
('2', 'اجدة', core.get_state_id_by_state_name('مكة')),
('3', 'امكة', core.get_state_id_by_state_name('مكة')),
('4', 'االمدينة المنورة', core.get_state_id_by_state_name('المدينة')),
('5', 'اتبوك', core.get_state_id_by_state_name('تبوك')),
('6', 'االدمام', core.get_state_id_by_state_name('شرقية')),
('7', 'االاحساء', core.get_state_id_by_state_name('الشرقية')),
('8', 'االقطيف', core.get_state_id_by_state_name('الشرقية')),
('9', 'اخميس مشيط', core.get_state_id_by_state_name('عسير')),
('10', 'االمظيلف', core.get_state_id_by_state_name('مكة')),
('11', 'االهفوف', core.get_state_id_by_state_name('الشرقية')),
('12', 'االمبرز', core.get_state_id_by_state_name('الشرقية')),
('13', 'االطائف', core.get_state_id_by_state_name('مكة')),
('14', 'انجران', core.get_state_id_by_state_name('نجران')),
('15', 'احفر الباطن', core.get_state_id_by_state_name('الشرقية')),
('16', 'االجبيل', core.get_state_id_by_state_name('الشرقية')),
('17', 'اضباء', core.get_state_id_by_state_name('تبوك')),
('18', 'االخرج', core.get_state_id_by_state_name('الرياض')),
('19', 'االثقبة', core.get_state_id_by_state_name('الشرقية')),
('20', 'اينبع البحر', core.get_state_id_by_state_name('المدينة')),
('21', 'االخبر', core.get_state_id_by_state_name('الشرقية')),
('22', 'اعرعر', core.get_state_id_by_state_name('الحدود الشمالية')),
('23', 'االحوية', core.get_state_id_by_state_name('مكة')),
('24', 'اعنيزة', core.get_state_id_by_state_name('القصيم')),
('25', 'اسكاكا', core.get_state_id_by_state_name('الجوف')),
('26', 'اجيزان', core.get_state_id_by_state_name('جيزان')),
('27', 'االقريات', core.get_state_id_by_state_name('الجوف')),
('29', 'االظهران', core.get_state_id_by_state_name('الشرقية')),
('30', 'االباحة', core.get_state_id_by_state_name('الباحة')),
('31', 'االزلفي', core.get_state_id_by_state_name('الرياض')),
('32', 'االرس', core.get_state_id_by_state_name('منطقة القصيم')),
('33', 'اوادي الدواسر', core.get_state_id_by_state_name('الرياض')),
('34', 'ابيشه', core.get_state_id_by_state_name('عسير')),
('35', 'اسيهات', core.get_state_id_by_state_name('الشرقية')),
('36', 'اشروره', core.get_state_id_by_state_name('نجران')),
('37', 'ابحره', core.get_state_id_by_state_name('مكة')),
('38', 'اتاروت', core.get_state_id_by_state_name('الشرقية')),
('39', 'االدوادمي', core.get_state_id_by_state_name('الرياض')),
('40', 'اصبياء', core.get_state_id_by_state_name('جيزان')),
('41', 'ابيش', core.get_state_id_by_state_name('جيزان')),
('42', 'اأحد رفيدة', core.get_state_id_by_state_name('عسير')),
('43', 'االفريش', core.get_state_id_by_state_name('المدينة')),
('44', 'ابارق', core.get_state_id_by_state_name('عسير')),
('45', 'االحوطة', core.get_state_id_by_state_name('الرياض')),
('46', 'االأفلاج', core.get_state_id_by_state_name('الرياض'));



/*****************************************************************************************************/  
END
$$
LANGUAGE plpgsql;



/*****************************************************************************************************
WARNING

     The following tables are meant to be used internally by MixERP.
     These tables should only be translated without changing the original meaning.
     You should not translate the code fields.

BEGIN
*****************************************************************************************************/
INSERT INTO core.verification_statuses
SELECT -3,  'رفض'                              UNION ALL
SELECT -2,  'مغلق'                                UNION ALL
SELECT -1,  'سحب'                             UNION ALL
SELECT 0,   'لم يتم التحقق'                            UNION ALL
SELECT 1,   'وافق تلقائيا بواسطة سير العمل'    UNION ALL
SELECT 2,   'وافق';

INSERT INTO core.frequencies(frequency_id, frequency_code, frequency_name)
SELECT 2, 'EOM', 'نهاية الشهر'                 UNION ALL
SELECT 3, 'EOQ', 'نهاية ربع الفترة'               UNION ALL
SELECT 4, 'EOH', 'نهاية نصف الفترة'                  UNION ALL
SELECT 5, 'EOY', 'نهاية العام';

INSERT INTO core.account_masters(account_master_id, account_master_code, account_master_name)
SELECT 1, 'BSA', 'حساب الميزانية العمومية ' UNION ALL
SELECT 2, 'PLA', 'حساب الارباح والخسائر' UNION ALL
SELECT 3, 'OBS', 'حساب خارج الميزانية العمومية';

INSERT INTO core.account_masters(account_master_id, account_master_code, account_master_name, parent_account_master_id, normally_debit)
SELECT 10100, 'CRA', 'الاصول المتداولة',                      1,      true    UNION ALL
SELECT 10101, 'CAS', 'حساب النقدية',                            10100,  true    UNION ALL
SELECT 10102, 'CAB', 'حساب البنك',                            10100,  true    UNION ALL
SELECT 10110, 'ACR', 'حساب اوراق القبض',                 10100,  true    UNION ALL
SELECT 10200, 'FIA', 'اصول ثابتة',                        1,      true    UNION ALL
SELECT 10201, 'PPE', 'اراضي وعقارات ومعدات',    1,      true    UNION ALL
SELECT 10300, 'OTA', 'اصول اخري',                        1,      true    UNION ALL
SELECT 15000, 'CRL', 'الخصوم المتداولة',                 1,      false   UNION ALL
SELECT 15010, 'ACP', 'حسابات الدائنين',                    15000,  false   UNION ALL
SELECT 15011, 'SAP', 'المرتبات',                      15000,  false   UNION ALL
SELECT 15100, 'LTL', 'خصوم طويلة الاجل',               1,      false   UNION ALL
SELECT 15200, 'SHE', 'حقوق المساهمين',               1,      false   UNION ALL
SELECT 15300, 'RET', 'الأرباح المحتجزة',                   15200,  false   UNION ALL
SELECT 15400, 'DIP', 'أرباح الأسهم المدفوعة',                      15300,  false;


INSERT INTO core.account_masters(account_master_id, account_master_code, account_master_name, parent_account_master_id, normally_debit)
SELECT 20100, 'REV', 'الإيرادات',                           2,        false   UNION ALL
SELECT 20200, 'NOI', 'الايراد غير التشغيلي',              2,        false   UNION ALL
SELECT 20300, 'FII', 'ايراد النشاط المالي',                 2,        false   UNION ALL
SELECT 20301, 'DIR', 'توزيعات أرباح مستلمة',                20300,    false   UNION ALL
SELECT 20400, 'COS', 'تكلفة المبيعات',                     2,        true    UNION ALL
SELECT 20500, 'DRC', 'التكاليف المباشرة',                      2,        true    UNION ALL
SELECT 20600, 'ORX', 'مصاريف التشغيل',                2,        true    UNION ALL
SELECT 20700, 'FIX', 'مصاريف النشاط المالي',                2,        true    UNION ALL
SELECT 20701, 'INT', 'مصاريف الفوائد',                 20700,    true    UNION ALL
SELECT 20800, 'ITX', 'مصاريف ضريبة الدخل',               2,        true;

INSERT INTO core.cash_flow_headings(cash_flow_heading_id, cash_flow_heading_code, cash_flow_heading_name, cash_flow_heading_type, is_debit)
SELECT 20001, 'CRC',    'المتحصلات النقدية من العملاء',                 'O',   true    UNION ALL
SELECT 20002, 'CPS',    'المدفوعات النقدية للموردين',                       'O',   false   UNION ALL
SELECT 20003, 'CPE',    'المدفوعات النقدية للعاملين',                       'O',   false   UNION ALL
SELECT 20004, 'IP',     'الفائدة المدفوعة',                                'O',   false   UNION ALL
SELECT 20005, 'ITP',    'ضرائب الدخل المدفوعة',                            'O',   false   UNION ALL
SELECT 20006, 'SUS',    'حسابات ضد التعليق',                    'O',   true   UNION ALL
SELECT 30001, 'PSE',    'العائدات من بيع المعدات',          'I',   true    UNION ALL
SELECT 30002, 'DR',     'توزيعات أرباح مستلمة',                           'I',   true    UNION ALL
SELECT 40001, 'DP',     'أرباح الأسهم المدفوعة',                               'F',   false;

UPDATE core.cash_flow_headings SET is_sales=true WHERE cash_flow_heading_code='CRC';
UPDATE core.cash_flow_headings SET is_purchase=true WHERE cash_flow_heading_code='CPS';

INSERT INTO core.cash_flow_setup(cash_flow_heading_id, account_master_id)
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('CRC'), core.get_account_master_id_by_account_master_code('ACR') UNION ALL --Cash Receipts from Customers/Accounts Receivable
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('CPS'), core.get_account_master_id_by_account_master_code('ACP') UNION ALL --Cash Paid to Suppliers/Accounts Payable
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('CPE'), core.get_account_master_id_by_account_master_code('SAP') UNION ALL --Cash Paid to Employees/Salary Payable
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('IP'),  core.get_account_master_id_by_account_master_code('INT') UNION ALL --Interest Paid/Interest المصروفات
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('ITP'), core.get_account_master_id_by_account_master_code('ITX') UNION ALL --Income Taxes Paid/Income Tax المصروفات
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('PSE'), core.get_account_master_id_by_account_master_code('PPE') UNION ALL --Proceeds from the Sale of Equipment/Property, Plants, and Equipments
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('DR'),  core.get_account_master_id_by_account_master_code('DIR') UNION ALL --Dividends Received/Dividends Received
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('DP'),  core.get_account_master_id_by_account_master_code('DIP') UNION ALL --Dividends Paid/Dividends Paid

--We cannot guarantee that every transactions posted is 100% correct and falls under the above-mentioned categories.
--The following is the list of suspense accounts, cash entries posted directly against all "other account masters".
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('BSA') UNION ALL --Against Suspense Accounts/الميزانية العمومية
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('PLA') UNION ALL --Against Suspense Accounts/Profit & Loss A/C
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('CRA') UNION ALL --Against Suspense Accounts/الاصول المتداولة
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('FIA') UNION ALL --Against Suspense Accounts/Fixed Assets
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('OTA') UNION ALL --Against Suspense Accounts/Other Assets
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('CRL') UNION ALL --Against Suspense Accounts/الخصوم المتداولة
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('LTL') UNION ALL --Against Suspense Accounts/Long-Term Liabilities
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('SHE') UNION ALL --Against Suspense Accounts/Shareholders' الأسهم
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('RET') UNION ALL --Against Suspense Accounts/Retained Earning
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('REV') UNION ALL --Against Suspense Accounts/Revenue
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('NOI') UNION ALL --Against Suspense Accounts/Non Operating Income
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('FII') UNION ALL --Against Suspense Accounts/Financial Incomes
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('COS') UNION ALL --Against Suspense Accounts/Cost of Sales
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('DRC') UNION ALL --Against Suspense Accounts/Direct Costs
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('ORX') UNION ALL --Against Suspense Accounts/Operating المصروفات
SELECT core.get_cash_flow_heading_id_by_cash_flow_heading_code('SUS'), core.get_account_master_id_by_account_master_code('FIX');          --Against Suspense Accounts/Financial المصروفات


INSERT INTO core.tax_base_amount_types(tax_base_amount_type_code, tax_base_amount_type_name)
SELECT 'P', 'سعر الصنف'            UNION ALL
SELECT 'L', 'سعر الصنف + الضرائب';

INSERT INTO core.tax_rate_types(tax_rate_type_code, tax_rate_type_name)
SELECT 'P', 'نسبة مئوية'    UNION ALL
SELECT 'F', 'مبلغ مقطوع';

INSERT INTO core.rounding_methods(rounding_method_code, rounding_method_name)
SELECT 'R', 'الدول حول موضع العلامة العشرية' UNION ALL
SELECT 'F', 'ارضي' UNION ALL
SELECT 'C', 'سقف';

/*****************************************************************************************************
WARNING

     The above tables are meant to be used internally by MixERP.
     These tables should only be translated without changing the original meaning.
     You should not translate the code fields.

END
*****************************************************************************************************/

DO
$$
BEGIN
    INSERT INTO core.flag_types(flag_type_name, background_color, foreground_color)
    SELECT 'حرج',      '#FA5882', '#FFFFFF'    UNION ALL
    SELECT 'مهم',     '#F6CEF5', '#000000'    UNION ALL
    SELECT 'مراجعة',        '#CEECF5', '#000000'    UNION ALL
    SELECT 'للعمل',          '#F7F8E0', '#000000'    UNION ALL
    SELECT 'حسنا',            '#D0F5A9', '#000000';

    INSERT INTO office.departments(department_code, department_name)
    SELECT 'SAL', 'المبيعات والفواتير'         UNION ALL
    SELECT 'MKT', 'التسويق والترويج'   UNION ALL
    SELECT 'SUP', 'الدعم الفني'                 UNION ALL
    SELECT 'CC', 'خدمة العملاء';

    INSERT INTO office.roles(role_code,role_name, is_system)
    SELECT 'SYST', 'النظام', true;

    INSERT INTO office.roles(role_code,role_name, is_admin)
    SELECT 'ADMN', 'مديرين النظام', true;

    INSERT INTO office.roles(role_code,role_name)
    SELECT 'USER', 'مستخدم'                  UNION ALL
    SELECT 'EXEC', 'تنفيذي'              UNION ALL
    SELECT 'MNGR', 'مدير'                UNION ALL
    SELECT 'SALE', 'مبيعات'                  UNION ALL
    SELECT 'MARK', 'تسويق'              UNION ALL
    SELECT 'LEGL', 'الشئون القانونية والشكاوي'     UNION ALL
    SELECT 'FINC', 'الادارة المالية'                UNION ALL
    SELECT 'HUMR', 'الموارد البشرية'        UNION ALL
    SELECT 'INFO', 'تكنولوجيا المعلومات' UNION ALL
    SELECT 'CUST', 'خدمة العملاء';

    INSERT INTO core.sales_teams(sales_team_code, sales_team_name)
    SELECT 'DEF', 'افتراضي'                 UNION ALL
    SELECT 'CST', 'فريق المبيعات التجاري'    UNION ALL
    SELECT 'RST', 'فريق مبيعات التجزئة';

    INSERT INTO core.currencies
    SELECT 'NPR', 'रू.',    'روبية نيبالي',        'بيسا'     UNION ALL
    SELECT 'USD', '$',      'دولار امريكي', 'سنت'     UNION ALL
    SELECT 'GBP', '£',      'جنية استرليني',       'بيني'     UNION ALL
    SELECT 'EUR', '€',      'يورو',                 'سنت'     UNION ALL
    SELECT 'JPY', '¥',      'ين ياباني',         'سن'       UNION ALL
    SELECT 'CHF', 'CHF',    'فرنك سويسري',          'سنتيم'   UNION ALL
    SELECT 'CAD', '¢',      'دولار كندي',      'سنت'      UNION ALL
    SELECT 'AUD', 'AU$',    'دولار استرالي',    'سنت'      UNION ALL
    SELECT 'HKD', 'HK$',    'هونج كونج دولار',     'سنت'      UNION ALL
    SELECT 'INR', '₹',      'روبية هندي',        'بيسا'     UNION ALL
    SELECT 'SEK', 'kr',     'كورونا سويدي',        'اور'       UNION ALL
    SELECT 'EGP', 'جنية',    'جنية مصري',            'قرش'       UNION ALL
    SELECT 'SAR', 'ر.س',    'ريال سعودي',   'هلله'  UNION ALL
    SELECT 'QAR', 'ر.ق',    'ريال قطري',   'درهم'  UNION ALL
    SELECT 'AED', 'د.إ',    'درهم اماراتي',   'فلس'  UNION ALL
    SELECT 'KWD', 'د.ك',    'دينار كويتي',   'فلس'  UNION ALL
    SELECT 'SYP', 'ل.س',    'ليرة سورية',   'قرش'  UNION ALL
    SELECT 'IQD', 'ع.د',    'دينار عراقي',   'فلس'  UNION ALL
    SELECT 'IRR', 'ریال',    'ريال إيراني',   'دينار'  UNION ALL
    SELECT 'LBP', 'ل.ل',    'ليرة لبنانية',   'قرش'  UNION ALL
    SELECT 'LYD', 'ل.د',    'دينار ليبي',   'درهم'  UNION ALL
    SELECT 'OMR', 'ر.ع.',    'ريال عماني',   'بيسا'  UNION ALL
    SELECT 'TRY', 'TL',    'ليرة تركية',   'kuruş'  UNION ALL
    SELECT 'SDG', '£',    'جنية سوداني',   'قرش';



    INSERT INTO core.entities(entity_name)
    SELECT 'الحكومة الاتحادية'                         UNION
    SELECT 'شركة فردية'                        UNION
    SELECT 'شركة تضامن'                        UNION
    SELECT 'شراكة محدودة'                        UNION
    SELECT 'شراكة ذات مسؤولية محدودة'              UNION
    SELECT 'شركة تضامن ذات المسؤولية المحدودة '      UNION
    SELECT 'شركة ذات مسؤولية محدودة'                  UNION
    SELECT 'شركة ذات مسؤولية محدودة مهنية'     UNION
    SELECT 'شركة المنافع'                        UNION
    SELECT 'شركة ج'                              UNION
    SELECT 'سلسلة شركة ذات مسؤولية محدودة'           UNION
    SELECT 'شركة S'                              UNION
    SELECT 'شركة ديلاوير'                       UNION
    SELECT 'الثقة القانونية ديلاوير'                   UNION
    SELECT 'الثقة التجارية ماساتشوستس'               UNION
    SELECT 'شركة نيفادا';

    INSERT INTO core.industries(industry_name)
    SELECT 'المحاسبة'                                 UNION
    SELECT 'الدعاية والاعلان'                                UNION
    SELECT 'الفضاء'                                  UNION
    SELECT 'الطيران'                                   UNION
    SELECT 'شركات الطيران'                                    UNION
    SELECT 'ملابس واكسسوارات'                      UNION
    SELECT 'سيارات'                                 UNION
    SELECT 'بنوك'                                    UNION
    SELECT 'اذاعة'                               UNION
    SELECT 'سمسرة'                                  UNION
    SELECT 'التكنولوجيا الحيوية'                              UNION
    SELECT 'مراكز اتصالات'                               UNION
    SELECT 'مناولة البضائع'                             UNION
    SELECT 'كيماويات'                                   UNION
    SELECT 'كمبيوتر'                                   UNION
    SELECT 'استشارات'                                 UNION
    SELECT 'منتجات المستهلك'                          UNION
    SELECT 'مستحضرات التجميل'                                  UNION
    SELECT 'الدفاع'                                    UNION
    SELECT 'المتاجر'                          UNION
    SELECT 'التعليم'                                  UNION
    SELECT 'الكترونيات'                                UNION
    SELECT 'الطاقة'                                     UNION
    SELECT 'الترفيه والترويح'                    UNION
    SELECT 'البحث التنفيذي'                           UNION
    SELECT 'خدمات مالية'                         UNION
    SELECT 'مأكولات ومشروبات وسجائر'                   UNION
    SELECT 'بقالة'                                    UNION
    SELECT 'عناية صحية'                                UNION
    SELECT 'النشر على شبكة الإنترنت'                        UNION
    SELECT 'الخدمات المصرفية الإستثمارية'                         UNION
    SELECT 'قانوني'                                      UNION
    SELECT 'تصنيع'                              UNION
    SELECT 'الحركة صور والفيديو'                     UNION
    SELECT 'موسيقي'                                      UNION
    SELECT 'ناشري الصحف'                       UNION
    SELECT 'مزادات على الانترنت'                           UNION
    SELECT 'صناديق المعاشات'                              UNION
    SELECT 'الصيدلة'                            UNION
    SELECT 'الملكية الخاصة'                             UNION
    SELECT 'النشر'                                 UNION
    SELECT 'العقارات'                                UNION
    SELECT 'تجارة التجزئة والجملة'                         UNION
    SELECT 'الأوراق المالية والبورصات'           UNION
    SELECT 'لخدمات'                                    UNION
    SELECT 'الصابون والمنظفات'                           UNION
    SELECT 'البرامج'                                   UNION
    SELECT 'الرياضة'                                     UNION
    SELECT 'التكنولوجيا'                                 UNION
    SELECT 'الاتصالات'                         UNION
    SELECT 'التليفزيون'                                 UNION
    SELECT 'النقل'                             UNION
    SELECT 'النقل بالشاحنات'                                   UNION
    SELECT 'رأس المال المغامر';


    INSERT INTO core.zip_code_types(type) 
    VALUES('عادي'),('صندوق بريد'),('فريد من نوعه');    

    INSERT INTO core.tax_master(tax_master_code, tax_master_name)
    SELECT 'DZIT', 'مصلحة الذاكة والدخل السعودية';

    INSERT INTO core.tax_authorities(tax_master_id, tax_authority_code, tax_authority_name, country_id, state_id, zip_code, address_line_1, address_line_2, street, city, phone, fax, email, url)
    SELECT core.get_tax_master_id_by_tax_master_code('DZIT'), 'IRS', 'ادارة الإيرادات الداخلية', core.get_country_id_by_country_code('SA'), core.get_state_id_by_state_code('RI'), '', 'الرياض', '', '', 'الرياض', '33434445', '', '', 'https://dzit.gov.sa/';

    INSERT INTO core.sales_tax_types(sales_tax_type_code, sales_tax_type_name, is_vat)
    SELECT 'SAT',   'ضريبة المبيعات',            false   UNION ALL
    SELECT 'VAT',   'ضريبة القيمة المضافة',      true;

    INSERT INTO core.tax_exempt_types(tax_exempt_type_code, tax_exempt_type_name)
    SELECT 'EXI', 'اعفاء (صنف)' UNION ALL
    SELECT 'EXP', 'اعفاء (طرف)' UNION ALL
    SELECT 'EXS', 'اعفاء (صناعة)' UNION ALL
    SELECT 'EXE', 'اعفاء (قطاع)';

    PERFORM core.create_card_type(1, 'CRC', 'بطاقة ائتمان');
    PERFORM core.create_card_type(2, 'DRC', 'بطاقة مدين');
    PERFORM core.create_card_type(3, 'CHC', 'بطاقة شحن');
    PERFORM core.create_card_type(4, 'ATM', 'ATM بطاقة');
    PERFORM core.create_card_type(5, 'SVC', 'بطاقة تخزين القيمة');
    PERFORM core.create_card_type(6, 'FLC', 'Fleet بطاقة');
    PERFORM core.create_card_type(7, 'GFC', 'بطاقة هدايا');
    PERFORM core.create_card_type(8, 'SCR', 'سهم');
    PERFORM core.create_card_type(9, 'ELP', 'المحفظة الإلكترونية');


    PERFORM core.create_payment_card('CR-VSA', 'فيزا',                1);
    PERFORM core.create_payment_card('CR-AME', 'امريكان اكسبريس',    1);
    PERFORM core.create_payment_card('CR-MAS', 'ماستر كارد',          1);
    PERFORM core.create_payment_card('DR-MAE', 'ميسترو',             2);
    PERFORM core.create_payment_card('DR-MAS', 'ماستر كارد مدين',    2);
    PERFORM core.create_payment_card('DR-VSE', 'فيزا الكترون',       2);
    PERFORM core.create_payment_card('DR-VSD', 'فيزا مدين',          2);
    PERFORM core.create_payment_card('DR-DEL', 'دلتا',               2);

    INSERT INTO core.brands(brand_code, brand_name)
    SELECT 'DEF', 'افتراضي';

    INSERT INTO core.price_types(price_type_code, price_type_name)
    SELECT 'RET', 'تجزئة'      UNION ALL
    SELECT 'WHO', 'جملة';

    INSERT INTO core.units(unit_code, unit_name)
    SELECT 'EA', 'الكل'        UNION ALL
    SELECT 'FT', 'قدم'         UNION ALL
    SELECT 'MTR', 'متر'       UNION ALL
    SELECT 'LTR', 'ليتر'       UNION ALL
    SELECT 'GM', 'جرام'         UNION ALL
    SELECT 'KG', 'كيلو جرام'     UNION ALL
    SELECT 'DZ', 'دستة'        UNION ALL
    SELECT 'BX', 'صندوق';

    INSERT INTO core.compound_units(base_unit_id, compare_unit_id, value)
    SELECT core.get_unit_id_by_unit_code('EA'), core.get_unit_id_by_unit_code('DZ'), 12;

    INSERT INTO core.item_types(item_type_code, item_type_name)
    SELECT 'GEN', 'عام'         UNION ALL
    SELECT 'COM', 'مكون'       UNION ALL
    SELECT 'MAF', 'تصنيع';

    INSERT INTO core.shipping_mail_types(shipping_mail_type_code, shipping_mail_type_name)
    SELECT 'FCM',   'بريد درجة اولي'      UNION ALL
    SELECT 'PM',    'بريد ذو اولوية'         UNION ALL
    SELECT 'PP',    'طرد بريدي'           UNION ALL
    SELECT 'EM',    'البريد السريع'          UNION ALL
    SELECT 'MM',    'البريد الدعائي';

    INSERT INTO core.shipping_package_shapes(shipping_package_shape_code, is_rectangular, shipping_package_shape_name)
    SELECT 'REC',   true,   'صندوق مستطيل التعبئة والتغليف'         UNION ALL
    SELECT 'IRR',   false,  'التعبئة والتغليف غير النظامية';

    INSERT INTO office.store_types(store_type_code,store_type_name)
    SELECT 'GOD', 'مستودع بضائع'                              UNION ALL
    SELECT 'SAL', 'مركز مبيعات'                        UNION ALL
    SELECT 'WAR', 'مخزن'                           UNION ALL
    SELECT 'PRO', 'الإنتاج';

    INSERT INTO office.cost_centers(cost_center_code, cost_center_name)
    SELECT 'DEF', 'افتراضي'                             UNION ALL
    SELECT 'GEN', 'ادارة عامة'              UNION ALL
    SELECT 'HUM', 'الموارد البشرية'                     UNION ALL
    SELECT 'SCC', 'دعم وخدمة العملاء'             UNION ALL
    SELECT 'GAE', 'سكن الزائرين والترفية'  UNION ALL
    SELECT 'MKT', 'التسويق والترويج'               UNION ALL
    SELECT 'SAL', 'المبيعات والفواتير'                     UNION ALL
    SELECT 'FIN', 'محاسبة مالية';

    ALTER TABLE core.accounts
    ALTER column currency_code DROP NOT NULL;

    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 1,     '10000', 'الاصول',                                                      TRUE,  core.get_account_id_by_account_name('الميزانية العمومية');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10001', 'الاصول المتداولة',                                              TRUE,  core.get_account_id_by_account_name('الأصول');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10102, '10100', 'حساب النقدية بالبنك',                                            TRUE,  core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10102, '10110', 'حساب جاري الشيكات',                                    FALSE, core.get_account_id_by_account_name('حساب النقدية بالبنك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10102, '10120', 'حساب جاري الأجور',                                    FALSE, core.get_account_id_by_account_name('حساب النقدية بالبنك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10102, '10130', 'حساب توفير',                                             FALSE, core.get_account_id_by_account_name('حساب النقدية بالبنك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10102, '10140', 'حساب خاص',                                             FALSE, core.get_account_id_by_account_name('حساب النقدية بالبنك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10101, '10200', 'حساب النقدية بالخزينة',                                            TRUE,  core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10300', 'الاستثمارات',                                                 FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10310', 'استثمارات قصيرة الاجل',                                       FALSE, core.get_account_id_by_account_name('الاستثمارات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10320', 'استثمارات اخري',                                           FALSE, core.get_account_id_by_account_name('الاستثمارات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10321', 'حساب شهادات الاستثمار',                                    FALSE, core.get_account_id_by_account_name('استثمارات اخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10322', 'الودائع المصرفية بالعقد (الوديعة الثابتة)',                       FALSE, core.get_account_id_by_account_name('استثمارات اخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10323', 'الاستثمارات شهادات الإيداع',                         FALSE, core.get_account_id_by_account_name('استثمارات اخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10110, '10400', 'حسابات المدينين',                                         FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10500', 'حسابات مدينة أخرى',                                           FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10501', 'مردودات المشتريات (ذمم مدينة)',                               FALSE, core.get_account_id_by_account_name('حسابات مدينة أخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10600', 'مخصص الديون المشكوك فيها',                             FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10700', 'المخزون',                                                   TRUE,  core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10720', 'مخزون المواد الخام',                                     TRUE,  core.get_account_id_by_account_name('المخزون');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10730', 'مخزون الامدادات',                                          TRUE,  core.get_account_id_by_account_name('المخزون');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10740', 'مخزون عمليات تحت التشغيل',                                  TRUE,  core.get_account_id_by_account_name('المخزون');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10750', 'مخزون الانتاج التام',                                    TRUE,  core.get_account_id_by_account_name('المخزون');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10800', 'المصاريف المدفوعة مقدما',                                            FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '10900', 'دفعات مقدمة للموظفين',                                           FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '11000', 'أوراق القبض',                                    FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '11100', 'الفوائد المدفوعة مقدما',                                            FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '11200', 'الايرادات المستحقة (الاصول)',                                    FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '11300', 'المدينين الآخرين',                                               FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10100, '11400', 'أصول متداولة أخرى',                                        FALSE, core.get_account_id_by_account_name('الاصول المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12001', 'الأصول غير المتداولة الأخرى',                                           TRUE,  core.get_account_id_by_account_name('الأصول');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12100', 'الأثاث والتجهيزات',                                      FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10201, '12200', 'المعدات أو الآلات',                                         FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12300', 'ايجار العقارات',                                             FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12400', 'سيارات',                                                    FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12500', 'الأصول غير الملموسة',                                                 FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12600', 'اصول ثابتة اخري قابلة للاهلاك',                                FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12700', 'تحسينات المباني المستأجرة',                                      FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12800', 'المباني',                                                   FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '12900', 'تحسينات المباني المملوكة',                                       FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13000', 'الديكورات الداخلية',                                        FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13100', 'اراضي',                                                        FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13200', 'استثمارات طويلة الاجل',                                       FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13300', 'Trade Debtors',                                               FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13400', 'Rental Debtors',                                              FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13500', 'Staff Debtors',                                               FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13600', 'Other Noncurrent Debtors',                                    FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13700', 'اصول مالية أخرى',                                      FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13710', 'الودائع',                                               FALSE, core.get_account_id_by_account_name('اصول مالية أخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13800', 'مجمع الاهلاك',                                   FALSE, core.get_account_id_by_account_name('الأصول غير المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13810', 'مجمع اهلاك الاثاث والتركيبات',             FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13820', 'مجمع اهلاك المعدات',                          FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13830', 'مجمع اهلاك السيارات',                           FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13840', 'مجمع اهلاك عقارات أخرى القابلة للاستهلاك',       FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13850', 'مجمع اهلاك الايجار',                          FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13860', 'مجمع اهلاك المباني',                          FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13870', 'مجمع اهلاك تحسينات المباني المملوكة',              FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10200, '13880', 'مجمع اهلاك الديكورات الداخلية',               FALSE, core.get_account_id_by_account_name('مجمع الاهلاك');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14001', 'أصول أخري',                                                TRUE,  core.get_account_id_by_account_name('الأصول');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14100', 'الأصول الأخرى-الودائع لأجل',                                       FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14200', 'تكاليف تنظيم الأصول الأخرى',                             FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14300', 'الأصول الأخرى-تكاليف تنظيم الاستهلاك المتراكم',    FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14400', 'اوراق القبض (غير الحالية)',                                FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14500', 'اخري غير -الاصول المتداولة',                                    FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 10300, '14600', 'الأصول غير المالية',                                        FALSE, core.get_account_id_by_account_name('أصول أخري');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 1,     '20000', 'الخصوم',                                                 TRUE,  core.get_account_id_by_account_name('الميزانية العمومية');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20001', 'الخصوم المتداولة',                                         TRUE,  core.get_account_id_by_account_name('الخصوم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15010, '20100', 'الحسابات الدائنة',                                            FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20110', 'رسوم الشحن المستحقة',                                     FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20200', 'المصروفات المستحقة',                                            FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20300', 'الاجور المستحقة',                                               FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20400', 'الخصومات المستحقة الدفع',                                          FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20500', 'التأمين الصحي المستحق الدفع',                                    FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20600', 'المعاشات المستحقة الدفع',                                      FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20700', 'الضرائب المستحقة الدفع',                                                FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20701', 'مردودات المبيعات (المبالغ المستحقة الدفع)',                                     FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20710', 'ضريبة المبيعات المستحقة الدفع',                                           FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20720', 'ضرائب الرواتب الاتحادية المستحقة الدقع',                               FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20730', 'ضريبة البطالة الاتحادية المستحقة الدفع',                                            FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20740', 'ضرائب الرواتب الحكومية المستحقة الدفع',                                 FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20750', 'ضريبة البطالة للولاية المستحقة الدفع',                                                FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20760', 'ضريبة الرواتب المحلية المستحقة الدفع',                                 FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20770', 'ضرائب الدخل المستحقة',                                        FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20780', 'ضرائب اخري مستحقة',                                         FALSE, core.get_account_id_by_account_name('الضرائب المستحقة الدفع');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20800', 'استحقاقات الموظفين المستحقة',                                   FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20810', 'توفير للإجازة السنوية',                                  FALSE, core.get_account_id_by_account_name('استحقاقات الموظفين المستحقة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20820', 'توفير إجازة الخدمة الطويلة',                            FALSE, core.get_account_id_by_account_name('استحقاقات الموظفين المستحقة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20830', 'توفير إجازة شخصية',                                FALSE, core.get_account_id_by_account_name('استحقاقات الموظفين المستحقة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20840', 'الاعتماد المخصص للاجازات الصحية',                                  FALSE, core.get_account_id_by_account_name('استحقاقات الموظفين المستحقة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '20900', 'الجزء الحالي من الديون الطويلة الأجل',                           FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21000', 'الايرادات المقدمة',                                             FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21010', 'ايرادات المبيعات المقدمة',                                        FALSE, core.get_account_id_by_account_name('الايرادات المقدمة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21020', 'المنح المقبوضة مقدما',                                   FALSE, core.get_account_id_by_account_name('الايرادات المقدمة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21100', 'الودائع من العملاء',                                     FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21200', 'الخصوم المتداولة الأخرى',                                   FALSE, core.get_account_id_by_account_name('الخصوم المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21210', 'القروض قصيرة الأجل المستحقة',                                    FALSE, core.get_account_id_by_account_name('الخصوم المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21220', 'التاجير التمويلي قصير الاجل المستحق',                           FALSE, core.get_account_id_by_account_name('الخصوم المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21230', 'التاجير التمويلي قصير الاجل للخصوم',                                  FALSE, core.get_account_id_by_account_name('الخصوم المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15000, '21240', 'المنح قابلة للسداد',                                            FALSE, core.get_account_id_by_account_name('الخصوم المتداولة الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24001', 'الخصوم غير المتداولة',                                      TRUE,  core.get_account_id_by_account_name('الخصوم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24100', 'اوراق الدفع',                                               FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24200', 'اراضي مستحقة الدفع',                                                FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24300', 'معدات والات مستحقة الدفع',                                           FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24400', 'سيارات مستحقة الدفع',                                            FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24500', 'ايجار مستحق الدفع',                                             FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24600', 'قروض مستحقة الدفع',                                                FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24700', 'الايجار التمويلي المستحق الدفع',                                       FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24800', 'قروض البنك المستحقة',                                          FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '24900', 'الإيرادات المؤجلة',                                            FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '25000', 'الخصوم طويلة الأجل الأخرى',                                 FALSE, core.get_account_id_by_account_name('الخصوم غير المتداولة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15100, '25010', 'توفير استحقاقات الموظف طويلة الأجل',                        FALSE, core.get_account_id_by_account_name('الخصوم طويلة الأجل الأخرى');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28001', 'الأسهم',                                                      TRUE,  core.get_account_id_by_account_name('الخصوم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28100', 'راس المال المصرح به',                                              FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28110', 'راس المال المدفوع',                                             FALSE, core.get_account_id_by_account_name('راس المال المصرح به');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28120', 'راس المال المصدر',                                            FALSE, core.get_account_id_by_account_name('راس المال المصرح به');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28130', 'راس مال المؤسسين',                                              FALSE, core.get_account_id_by_account_name('راس المال المصرح به');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28200', 'فائض رأس المال',                                             FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28210', 'اسهم ممتازة',                                               FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28220', ' احتياطي استهلاك رأس المال',                                 FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28230', 'الاحتياطي النظامي',                                          FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28240', 'احتياطي إعادة تقييم الأصول',                                  FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28250', 'احتياطي تقلبات سعر الصرف',                          FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28260', 'احتياطي رأس المال الناشئة عن الاندماج',                        FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28270', 'الاحتياطيات الرأسمالية الناتجة عن شراء',                    FALSE, core.get_account_id_by_account_name('فائض رأس المال');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15300, '28300', 'الفائض المحتجز',                                            TRUE,  core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15300, '28310', 'ارباح مرحلة',                                         FALSE, core.get_account_id_by_account_name('الفائض المحتجز');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15300, '28320', 'خسائر مرحلة',                                          FALSE, core.get_account_id_by_account_name('الفائض المحتجز');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15400, '28330', 'الأرباح المعلنة (الأسهم العادية)',                           FALSE, core.get_account_id_by_account_name('الفائض المحتجز');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15400, '28340', 'الأرباح المعلنة ( الاسهم المفضلة )',                        FALSE, core.get_account_id_by_account_name('الفائض المحتجز');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28400', 'Treasury Stock',                                              FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28500', 'فائض العام الحالي',                                        FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28600', 'احتياطي عام',                                            FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28700', 'احتياطيات اخري',                                              FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28800', 'أرباح مستحقة الدفع (الأسهم العادية)',                            FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 15200, '28900', 'أرباح مستحقة الدفع (الاسهم المفضلة)',                         FALSE, core.get_account_id_by_account_name('الأسهم');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 2,     '30000', 'الايرادات',                                                    TRUE,  core.get_account_id_by_account_name('حساب الأرباح والخسائر');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30100', 'حساب المبيعات',                                                  FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30200', 'إيرادات الفوائد',                                            FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30300', 'ايرادات اخري',                                               FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30400', 'إيرادات رسوم التمويل',                                      FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30500', 'رسوم الشحن المسددة',                                FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30600', 'مردودات المبيعات و المسموحات',                               FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20100,  '30700', 'خصومات المشتريات',                                         FALSE, core.get_account_id_by_account_name('الإيرادات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 2,     '40000', 'المصروفات',                                                    TRUE,  core.get_account_id_by_account_name('حساب الأرباح والخسائر');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 2,     '40100', 'حساب المشتريات',                                                FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20400,  '40200', 'تكلفة البضاعة المباعة',                                         FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40205', 'تكلفة المنتجات',                                               FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40210', 'مشتريات المواد الخام',                                     FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40215', 'تكالبف اجور مباشرة',                                         FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40220', 'تكالبف اجور غير مباشرة',                                       FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40225', 'كهرباء وطاقة',                                             FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40230', 'عمولات',                                                FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40235', 'تكاليف مصنع متنوعة',                                FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40240', 'تكاليف البضاعة المباعة - اجور ومرتبات',                      FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40245', 'تكلفة البضاعة المباعة- العمل',                          FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40250', 'تكاليف البضاعة المباعة - شحن',                                 FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40255', 'تكاليف البضاعة المباعة - اخري',                                   FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40260', 'تسويات المخزون',                                      FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40265', 'مردودات المشتريات و مسموحات',                            FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20500,  '40270', 'خصومات المبيعات',                                            FALSE, core.get_account_id_by_account_name('تكلفة البضاعة المباعة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40300', 'مصاريف مشتريات عامة',                                  FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40400', 'مصاريف دعاية واعلان',                                       FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40500', 'مصاريف اهلاك الدين',                                      FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40600', 'مصاريف سيارات',                                              FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40700', 'مصاريف ديون معدومة',                                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20700,  '40800', 'رسوم بنكية',                                                  FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '40900', 'زيادة نقص النقدية',                                        FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41000', 'مصاريف هبات وتبرعات',                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20700,  '41100', 'مصاريف العمولات والرسوم',                              FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41200', 'مصاريف اهلاك',                                      FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41300', 'رسوم ومصاريف الاشتراكات',                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41400', 'مصروفات مزايا للعاملين',                                  FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41410', 'تأمين صحي',                 FALSE, core.get_account_id_by_account_name('مصروفات مزايا للعاملين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41420', 'معاشات',                    FALSE, core.get_account_id_by_account_name('مصروفات مزايا للعاملين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41430', 'خطة مشاركة العاملين في الارباح والمصروفات',              FALSE, core.get_account_id_by_account_name('مصروفات مزايا للعاملين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41440', 'اخري',                            FALSE, core.get_account_id_by_account_name('مصروفات مزايا للعاملين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41500', 'مصاريف شحن',                                           FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41600', 'مصاريف هدايا',                                             FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20800,  '41700', 'مصروفات ضريبة الدخل',                                        FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20800,  '41710', 'اتحادي - عام',                                FALSE, core.get_account_id_by_account_name('مصروفات ضريبة الدخل');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20800,  '41720', 'ولاية - محافظة',                                  FALSE, core.get_account_id_by_account_name('مصروفات ضريبة الدخل');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20800,  '41730', 'محلي',                                  FALSE, core.get_account_id_by_account_name('مصروفات ضريبة الدخل');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41800', 'مصاريف التأمين',                                         FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41810', 'تأمين بضاعة',                       FALSE, core.get_account_id_by_account_name('مصاريف التأمين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '41820', 'تأمين سيارات',                                 FALSE, core.get_account_id_by_account_name('مصاريف التأمين');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20701,  '41900', 'مصاريف الفائدة',                                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42000', 'مصروفات الغسيل والتنظيف الجاف',                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42100', 'المصروفات القانونية والمهنية',                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42200', 'مصروفات التراخيص',                                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42300', 'خسائر شيكات بدون رصيد',                                         FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42400', 'مصاريف صيانة',                                       FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42500', 'مصاريف الوجباتا لغذائية والترفيه',                           FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42600', 'مصروفات مكتبية',                                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42700', 'مصروفات ضريبة المرتبات',                                       FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20700,  '42800', 'مصروفات عقوبات وغرامات',                               FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '42900', 'مصاريف ضرائب اخري',                                        FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43000', 'مصروفات البريد',                                           FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43100', 'مصاريف التأجير أو الإيجار',                                     FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43200', 'مصروفات الاصلاح والصيانة',                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43210', 'مصاريف الاصلاح والصيانة - الشركة',                     FALSE, core.get_account_id_by_account_name('مصروفات الاصلاح والصيانة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43220', 'مصاريف الاصلاح والصيانة - السيارات',                    FALSE, core.get_account_id_by_account_name('مصروفات الاصلاح والصيانة');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43300', 'مصروفات اللوازم - الشركة',                                   FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43400', 'مصاريف تليفون وبريد',                                         FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43500', 'مصاريف تدريب',                                          FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43600', 'مصاريف سفر',                                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43700', 'مصاريف مرتبات',                                            FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43800', 'مصاريف اجور',                                             FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '43900', 'مصاريف خدمات',                                         FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '44000', 'مصاريف اخري',                                             FALSE, core.get_account_id_by_account_name('المصروفات');
    INSERT INTO core.accounts(account_master_id,account_number,account_name, sys_type, parent_account_id) 
    SELECT 20600,  '44100', 'الربح/الخسارة في بيع الأصول',                                FALSE, core.get_account_id_by_account_name('المصروفات');

    UPDATE core.accounts
    SET currency_code='SAR';


    ALTER TABLE core.accounts
    ALTER column currency_code SET NOT NULL;




    INSERT INTO core.party_types(party_type_code, party_type_name, account_id) 
    SELECT 'A', 'وكيل', core.get_account_id_by_account_number('20100') UNION ALL
    SELECT 'C', 'عميل', core.get_account_id_by_account_number('10400') UNION ALL
    SELECT 'D', 'تاجر', core.get_account_id_by_account_number('10400');
    
    INSERT INTO core.party_types(party_type_code, party_type_name, is_supplier, account_id)
    SELECT 'S', 'مورد', true, core.get_account_id_by_account_number('20100');

    INSERT INTO core.shippers(company_name, account_id)
    SELECT 'افتراضي', core.get_account_id_by_account_number('20110');

    INSERT INTO crm.lead_sources(lead_source_code, lead_source_name)
    SELECT 'AG', 'وكيل'                UNION ALL
    SELECT 'CC', 'محاولة اقناعة'            UNION ALL
    SELECT 'CR', 'مرجع العميل'   UNION ALL
    SELECT 'DI', 'استفسار مباشر'       UNION ALL
    SELECT 'EV', 'احداث'               UNION ALL
    SELECT 'PR', 'شريك';


    INSERT INTO crm.lead_statuses(lead_status_code, lead_status_name)
    SELECT 'CL', 'هادئ'                 UNION ALL
    SELECT 'CF', 'الاتصال مستقبلا'    UNION ALL
    SELECT 'LO', 'فقد'                 UNION ALL
    SELECT 'IP', 'جار العمل'           UNION ALL
    SELECT 'QF', 'مؤهل';


    INSERT INTO crm.opportunity_stages(opportunity_stage_code, opportunity_stage_name)
    SELECT 'PRO', 'البحث عن العملاء'         UNION ALL
    SELECT 'QUA', 'المؤهلين'       UNION ALL
    SELECT 'NEG', 'جاري التفاوض'         UNION ALL
    SELECT 'VER', 'شفوي'              UNION ALL
    SELECT 'CLW', 'مغلف فوز'          UNION ALL
    SELECT 'CLL', 'مغلق خسارة';
END
$$
LANGUAGE plpgsql;