DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM localization.cultures
        WHERE culture_code = 'ne'
    ) THEN
        INSERT INTO localization.cultures
        SELECT 'ne', 'Nepali';
    END IF;
END
$$
LANGUAGE plpgsql;

SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PercentageSymbol', '%');--%
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RequiredFieldIndicator', '*');-- *
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RequiredFieldIndicator', '*');-- *
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NShippersFound', '{ 0 } shippers फेला परेन');--{0} shippers found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ImportedNItems', '{ 0 } आइटम सफलतापूर्वक आयात भयो।।');--Successfully imported {0} items.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NTaxAuthoritiesFound', '{ 0 } कर अख्तियारहरू भेटिए।');--{0} tax authorities found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NTaxMasterFound', '{ 0 } कर मास्टर(हरू) भेटिए।');--{0} tax master(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NCountySalesTaxesDefined', '{ 0 } काउन्टी बिक्री कर परिभाषित भयो।');--{0} county sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NHours', '{ 0 } घण्टा');--{0} hours
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NumRowsAffected', '{ 0 } पङ्क्तिहरू प्रभावित भए।');--{0} rows affected.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NPartiesFound', '{ 0 } पार्टी भेटिए।');--{0} parties found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PercentCompleted', '{ 0 } प्रतिशत पूरा भयो।');--{0} percent completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NotDefinedForNUsers', 'प्रयोगकर्ता { 0 } का लागि परिभाषित छैन ।');--Not defined for {0} users.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NSalesTaxFormsDefined', '{ 0 } बिक्री करका प्रकार परिभाषित ।');--{0} sales tax forms defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NSalespersonsFound', '{ 0 } बिक्रेता(हरू) भटियो।');--{0} salespersons found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NStateSalesTaxesDefined', '{ 0 } राज्य बिक्री कर परिभाषित भयो।');--{0} state sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NStatesFound', '{ 0 } राज्यहरु भेटिए।');--{0} states found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NItemsFound', '{ 0 } वस्तु (हरू) भेटिए।');--{0} item(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NItemGroupsFound', '{ 0 } वस्तु समूह(हरू) भेटिए।');--{0} item group(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TaskCompletedProgress', '{१} कार्यहरू मध्ये {0} पुरा भयो।');--{0} out of {1} tasks completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'YearOld', '{0} वर्ष पुरानो');--{0} years old
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'EmailSentConfirmation', '{0} लाइ एउटा इमेल पठाइयो ।');--An email was sent to {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'EmailBody', '<h२>नमस्कार,</h२><p>कृपया संलग्न कागजात फेला पार्नु होला.</p><p>धन्यबाद,<br />MixERP</p>');--<h2>Hi,</h2><p>Please find the attached document.</p><p>Thank you.<br />MixERP</p>
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'ageing_slab_id', 'Ageing Slab Id');--Ageing Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'ageing_slab_name', 'Ageing Slab नाम');--Ageing Slab Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AgeingSlabs', 'Ageing Slabs');--Ageing Slabs
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_aphonic', 'Aphonic छ');--Is Aphonic
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'VoucherVerificationPolicyDescription', 'भौचर रूजु (स्वीकृत वा अस्वीकृत) गर्नका लागि प्रशासकहरूले गर्ने नीतिहरू।');--Assisgn voucher verification policies to administrators for approving or rejecting transactions.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_autistic', 'Autistic छ');--Is Autistic
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOMId', 'BOM Id');--BOM Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bom_code', 'BOM कोड');--BOM Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bom_name', 'BOM नाम');--BOM Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOMName', 'BOM नाम');--BOM Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bom_type', 'BOM प्रकार');--BOM Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOMType', 'BOM प्रकार');--BOM Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AssignCashier', 'खजान्ची तोक्नुहोस्');--Assign Cashier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_cognitively_disabled', 'मानसिक असक्षम छ');--Is Cognitively Disabled
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_of_goods_sold_account_id', 'COGS खाता Id');--COGS Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlAltA', 'Ctrl + Alt + A');--Ctrl + Alt + A
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlAltS', 'Ctrl + Alt + S');--Ctrl + Alt + S
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlAltT', 'Ctrl + Alt + T');--Ctrl + Alt + T
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlAltD', 'Ctrl + Alt + D');--Ctrl + Alt + D
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlAltC', 'Ctrl + Alt + C');--Ctrl + Alt + C
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CtrlReturn', 'Ctrl + Return');--Ctrl + Return
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AnalyzeDatabse', 'डेटाबेस विश्लेषण गर्नुहोस');--Analyze Databse
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODRoutineTasks', 'EOD सञ्चालन समयमा, नियमित कार्यहरू ब्याज गणना, भक्तानी र प्रतिवेदन तयार हुन्छन्।');--During EOD operation, routine tasks such as interest calculation, settlements, and report generation are performed.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'FrequencySetupIsComplete', 'बारम्बारता सेटअप पूरा भएको छ।');--Frequency setup is complete.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5913', 'खाता रुजु वा प्रमाणिकरण सीमा नाघेको छ। कारोबार रुजु भएको छैन।');--GL verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'holiding_account', 'Holiding खाता');--Holiding Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'http_action_code', 'HTTP एक्सन कोड');--HTTP Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'hundredth_name', 'सयाैं नाम');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UploadLogoDescription', 'JPEG, GIF, PNG, वा bmp ढाँचामा आफ्नो कार्यालय लोगो अपलोड गर्नुहोस्। यो लोगो रिपोर्ट र पत्रमा देखिने छ।');--Upload your office logo in jpeg, gif, png, or bmp format. This logo will be displayed in reports and letters.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'kanban_id', 'कानबान Id');--Kanban Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'kanban_code', 'कानबान कोड');--Kanban Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'kanban_name', 'कानबान नाम');--Kanban Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lc_credit', 'LC क्रेडिट');--LC Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LCCredit', 'LC क्रेडिट');--LC Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lc_debit', 'LC डेबिट');--LC Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LCDebit', 'LC डेबिट');--LC Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'machinable', 'यन्त्रात्मक');--Machinable
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InstallMixERP', 'MixERP स्थापना गर्नुहोस्।');--Install MixERP
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreatePayslip', 'भुक्तान पर्ची सिर्जना गर्नुहोस्।');--Create Payslip
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreatePayslips', 'भुक्तान पर्चीहरू सिर्जना गर्नुहोस्।');--Create Payslips
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExportToPDF', 'बिक्रेताहरूको बोनस तह विवरण');--Export to PDF
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'poco_type_name', 'Poco प्रकार नाम');--Poco Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BonusSlabDetails', 'बिक्रेताहरूको बोनस तह विवरण');--Bonus Slab Details for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateSalespersons', 'बिक्रेताहरू सिर्जना');--Create Salespersons
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'slab_name', 'तह नाम');--Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_enable_ssl', 'SMTP SSL सक्रिय गर्ने');--SMTP Enable SSL
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SMTPIsDisabled', 'SMTP निष्क्रिय छ।');--SMTP is disabled.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_id', 'SMTP Id');--SMTP Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_password', 'SMTP पासवर्ड');--SMTP Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_port', 'SMTP पोर्ट');--SMTP Port
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_username', 'SMTP प्रयोगकर्ता');--SMTP Username
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'smtp_host', 'SMTP होस्ट');--SMTP Host
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sst_number', 'SST नम्बर');--SST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sys_type', 'sys प्रकार');--Sys Type
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8992', 'Sys प्रयोगकर्ताको पासवर्ड हुन सक्दैन।');--A sys user cannot have a password.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_taxable', 'करयोग्य छ');--Is Taxable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'url', 'Url');--Url
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_vat', 'मु.अ.क. हो?');--Is Vat
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DateFormatYYYYMMDD', 'बर्ष-mm-dd');--yyyy-mm-dd
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'foreground_color', 'अग्रभूमि रंग');--Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Previous', 'अघिल्लो');--Previous
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'previous_period', 'अघिल्लो अवधि');--Previous Period
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreviousPeriod', 'अघिल्लो अवधि');--Previous Period  
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'previous_credit', 'अघिल्लो क्रेडिट');--Previous Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreviousCredit', 'अघिल्लो क्रेडिट');--Previous Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'previous_debit', 'अघिल्लो डेबिट');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreviousDebit', 'अघिल्लो डेबिट');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreviousPage', 'अघिल्लो पृष्ठ');--Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreviousBalance', 'अघिल्लो बक्याैता');--Previous Balance
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5105', 'अझै पनि कारोबार(हरु) रुजु तथा प्रमाणिकरण पङ्क्तिमा छन् ।');--There are still transactions in verification queue.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'audit_ts', 'अडिट समय');--Audit Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'audit_user_id', 'अडिट प्रयोगकर्ता Id');--Audit User Id
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UpdateOperationCompletedSuccessfully', 'अद्यावधिक कार्य सफलतापूर्वक सम्पन्न भयो।');--The update operation completed successfully.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maximum_credit_period', 'अधिकतम क्रेडिट अवधि');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MaximumCreditPeriod', 'अधिकतम क्रेडिट अवधि');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maximum_credit_amount', 'अधिकतम क्रेडिट रकम');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MaximumCreditAmount', 'अधिकतम क्रेडिट रकम');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maximum_daily_work_hours', 'अधिकतम दैनिक कार्य घन्टा');--Maximum Daily Work Hours
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maximum_salary', 'अधिकतम तलब');--Maximum Salary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'max_week_hours', 'अधिकतम हप्ताको घण्टा');--Max Week Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Authorize', 'अधिकार प्रदान गर्ने');--Authorize
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Authorized', 'अधिकार प्रदान गरिएको');--Authorized
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CustomFields', 'अनुकूल फिल्ड');--Custom Fields
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Contracts', 'सम्झौताहरू');--Contracts
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Experiences', 'अनुरोध गर्नुहोस');--Experiences
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Approve', 'अनुमोदन गर्नुहोस');--Approve
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Request', 'अनुरोध गर्नुहोस');--Request
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Last', 'अन्तिम');--Last
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'last_autoanalyze', 'अन्तिम स्वतः विश्लेषण');--Last Autoanalyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'last_autovacuum', 'अन्तिम स्वतः भ्याक्युम');--Last Autovacuum On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastPage', 'अन्तिम पाना');--Last Page
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastPaymentDate', 'अन्तिम भुक्तानी मिति');--Last Payment Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'last_analyze', 'अन्तिम विश्लेषण');--Last Analyze On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OtherDetails', 'अन्य विवरणहरू');--Other Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OtherInformation', 'अन्य जानकारी');--Other Information
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CheckForUpdates', 'अद्यावधिक जाँच गर्नुहोस');--Check for Updates
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5500', 'अपर्याप्त वस्तु मात्रा।');--Insufficient item quantity.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Upload', 'अपलोड गर्नुहोस');--Upload
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'UploadFilesDeleted', 'अपलोड गरिएको फाइल सफलतापूर्वक मेटाइएको छ।');--The uploaded files were successfully deleted.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UploadLogo', 'लोगो अपलोड गर्नुहोस्।');--Upload Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IncompleteTasks', 'पुरा नभएका कार्यहरू');--Incomplete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LateFees', 'बिलम्भ शुल्क');--Late Fees
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_industry_id', 'अभिभावक उद्योग Id');--Parent Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_industry_name', 'अभिभावक उद्योगको नाम');--Parent Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_work_center', 'अभिभावक कार्य केन्द्र');--Parent Work Center
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_work_center_id', 'अभिभावक कार्य केन्द्र Id');--Parent Work Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_work_center_department_id', 'अभिभावक कार्य केन्द्र विभाग Id');--Parent Work Center Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_office', 'अभिभावक कार्यालय');--Parent Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_office_id', 'अभिभावक कार्यालय Id');--Parent Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_account_id', 'अभिभावक खाता Id');--Parent Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_account_number', 'अभिभावक खाता नम्बर');--Parent Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_account_name', 'अभिभावक खाता नाम');--Parent Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_account_master_id', 'अभिभावक खाता मास्टर Id');--Parent Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_cash_flow_heading_id', 'अभिभावक नगद प्रवाह शीर्षक Id');--Parent Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_cash_repository', 'अभिभावक नगद भण्डार');--Parent Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_cash_repository_id', 'अभिभावक नगद भण्डार Id');--Parent Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_plant', 'अभिभावक कारखाना');--Parent Plant
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_plant_id', 'अभिभावक कारखाना Id');--Parent Plant Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_item_group_id', 'अभिभावक वस्तु समूह Id');--Parent Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_department', 'अभिभावक विभाग');--Parent Department
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_cr_code', 'अभिभावक CR कोड');--Parent CR Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent_cr_name', 'अभिभावक CR नाम');--Parent CR Name
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3000', 'गालत तथ्यांक');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidCostCenter', 'गालत लागत केन्द्र');--Invalid cost center.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Next', 'अर्को');--Next
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NextPage', 'अर्को पाना');--Next Page
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DeletedApplicationFiles', 'विद्यमान आवेदन फाइलहरू सफलतापूर्वक मेटाइएको छ।');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DeletingApplicationFilesSucessMessage', 'विद्यमान आवेदन फाइलहरू सफलतापूर्वक मेटाइएको छ।');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidParameterName', 'Npgsql प्यारामिटर नाम { 0 } ठीक छैन। तपाईको प्यारामिटर नाम कमान्ड नाम संग मेल खाएको निश्चित गर्नुहोस।');--Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your command text.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookPurchaseQuotation', 'गलत SubTranBook " खरिद कोटेसन "');--Invalid SubTranBook "Purchase Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookPurchaseDelivery', 'गलत SubTranBook " खरिद वितरण "');--Invalid SubTranBook "Purchase Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookPurchaseSuspense', 'गलत SubTranBook " खरिद सस्पेन्स "');--Invalid SubTranBook "Purchase Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookPurchaseTransfer', 'गलत SubTranBook " खरिद स्थानान्तरण "');--Invalid SubTranBook "Purchase Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookSalesPayment', 'गलत SubTranBook " बिक्री भुक्तानी "');--Invalid SubTranBook "Sales Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookSalesSuspense', 'गलत SubTranBook " बिक्री सस्पेन्स "');--Invalid SubTranBook "Sales Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookSalesTransfer', 'गलत SubTranBook " बिक्री स्थानान्तरण "');--Invalid SubTranBook "Sales Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryOrder', 'गलत SubTranBook " सूची आदेश "');--Invalid SubTranBook "Inventory Order"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryQuotation', 'गलत SubTranBook " सूची कोटेसन "');--Invalid SubTranBook "Inventory Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryReceipt', 'गलत SubTranBook " सूची कोटेसन "');--Invalid SubTranBook "Inventory Receipt"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryInvoice', 'गलत SubTranBook " सूची चलानी "');--Invalid SubTranBook "Inventory Invoice"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryDirect', 'गलत SubTranBook " सूची प्रत्यक्ष "');--Invalid SubTranBook "Inventory Direct"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryPayment', 'गलत SubTranBook " सूची भुक्तानी "');--Invalid SubTranBook "Inventory Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryReturn', 'गलत SubTranBook " सूची रिटर्न "');--Invalid SubTranBook "Inventory Return"
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSubTranBookInventoryDelivery', 'गलत SubTranBook " सूची वितरण "');--Invalid SubTranBook "Inventory Delivery"
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5301', 'गलत अथवा अस्वीकृत कारोबार।');--Invalid or rejected transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3009', 'उल्लेखित अवधि गलत छ।');--Invalid period specified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3052', 'गलत एकाइ।');--Invalid unit.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item_details_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_cost_prices_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_opening_inventory_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_selling_prices_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'non_gl_stock_details_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'stock_details_unit_chk', 'उल्लेखित एकार्इ गलत छ।');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3302', 'गलत कारोबार Id');--Invalid transaction id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3010', 'गलत कार्यालय Id');--Invalid office id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3011', 'गलत कार्यालय Id');--Invalid office.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidAccount', 'गलत खाता ।');--Invalid account.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidData', 'गलत डाटा।');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidShippingCompany', 'गलत ढुवानी कम्पनी ।');--Invalid shipping company.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading_cash_flow_heading_type_chk', 'गलत नगद प्रवाह शीर्षक टाइप । अनुमति मान: O, I, F');--Invalid Cashflow Heading Type. Allowed values: O, I, F.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3013', 'गलत नगद भण्डार ।');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidCashRepository', 'गलत नगद भण्डार ।');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidRequest', 'गलत निवेदन ।');--Invalid Request.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidRequestId', 'गलत निवेदन Id ।');--Invalid Request Id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3050', 'गलत पक्ष ।');--Invalid party.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidParty', 'गलत पार्टी।');--Invalid party.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3001', 'गलत प्रयोगकर्ता ');--Invalid user name.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidUser', 'गलत प्रयोगकर्ता।');--Invalid user.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidFileExtension', 'गलत फाइल विवरण ।');--Invalid file extension.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'InvalidFile', 'गलत फाइल!');--Invalid file!
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidSalesPerson', 'गलत बिक्रेता');--Invalid salesperson.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidPaymentTerm', 'गलत भुक्तानी अवधि ।');--Invalid payment term.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3301', 'गलत मात्रा ।');--Invalid quantity.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidStockTransaction', 'गलत मालसामान वितरण');--Invalid stock transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3008', 'गलत मिति।');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidDate', 'गलत मिति।');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidPriceType', 'गलत मूल्य प्रकार।');--Invalid price type.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidReceiptMode', 'गलत रसिद तरिका ।');--Invalid receipt mode.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3101', 'गलत लग - इन Id');--Invalid LoginId.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3007', 'गलत लागुहुने मिति। ');--Invalid value date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3051', 'गलत वस्तु ।');--Invalid item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3053', 'गलत वा नमिल्ने एकाइ ।');--Invalid or incompatible unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3055', 'गलत विनिमय दर ।');--Invalid exchange rate.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3012', 'गलत स्टोर ।');--Invalid store.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InvalidStore', 'गलत स्टोर ।');--Invalid store.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'with_disabilities', 'अशक्तता');--With Disabilities
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4023', 'असंगत कर प्रकार भएको कारोबार मर्ज गर्न सक्नुहुन्न। फेरि प्रयास गर्नुहोस।');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotMergeIncompatibleTax', 'असंगत करका प्रकारहरु भएका लेनदेन मर्ज गर्न सक्नुहुन्न। फेरि प्रयास गर्नुहोस।');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidSubTranBookPurchaseQuotation', 'अस्विकार SubTranBook '' खरिद कोटेसन।');--Invalid SubTranBook 'Purchase Quotation'.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidSubTranBookPurchaseReceipt', 'अस्विकार SubTranBook '' खरिद रसिद।');--Invalid SubTranBook 'Purchase Receipt'.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidSubTranBookPurchaseDelivery', 'अस्विकार SubTranBook '' खरिद वितरण।');--Invalid SubTranBook 'Purchase Delivery'.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidSubTranBookSalesPayment', 'अस्विकार SubTranBook '' बिक्री भुक्तानी ।');--Invalid SubTranBook 'Sales Payment'.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidUserId', 'अस्विकार प्रयोगकर्ता ।');--Invalid user id.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InvalidFileLocation', 'अस्विकार फाइल स्थान । ');--Invalid file location.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Reject', 'अस्वीकार गर्नुहोस्');--Reject
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RejectedTransactions', 'अस्वीकृत लेनदेनहरु');--Rejected Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HideForNow', 'अहिलेको लागि लुकाउनुहोस्');--Hide for Now
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_id', 'आइटम Id');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Sunday', 'आइतबार');--Sunday
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'id', 'Id');--ID
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'id', 'Id');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_id', 'निकास Id');--Exit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'ip_address', 'IP Address');--IP Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_id', 'अर्डर Id');--Order Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_action_name', 'अर्डर कार्य');--Order Action Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_action_id', 'अर्डर कार्य Id');--Order Action Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_action_code', 'अर्डर कार्य कोड');--Order Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_date', 'अर्डर मिति');--Order Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_type_id', 'अर्डर प्रकार Id');--Order Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_type_code', 'अर्डर प्रकार कोड');--Order Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_type_name', 'अर्डर प्रकार नाम');--Order Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_status_id', 'अर्डर स्थिति Id');--Order Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_status_code', 'अर्डर स्थिति कोड');--Order Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'order_status_name', 'अर्डर स्थिति नाम');--Order Status Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OrderTypes', 'अर्डरका प्रकारहरू');--Order Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OrderType', 'अर्डरको प्रकार');--Order Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OrderStatus', 'अर्डरको स्थिति');--Order Status
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OrderStatuses', 'अर्डरको स्थितिहरु');--Order Statuses
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'base_unit_id', 'आधार एकाइ Id');--Base Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_units_chk', 'आधार एकाइ Id एकाइ Id जस्तै हुनुहुदैन।');--The base unit id cannot same as compare unit id.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'base_unit_name', 'आधार एकाइ नाम');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BaseUnitName', 'आधार एकाइ नाम');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BaseCurrency', 'आधार मुद्रा');--Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FinalDueAmountinBaseCurrency', 'बितरकको नाम');--Final Due Amount in Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ConvertedtoBaseCurrency', 'आधार मुद्रामा रूपान्तरित');--Converted to Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SupplierName', 'बितरकको नाम');--Supplier Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateaUserAccountforYourself', 'आफ्नै प्रयोगकर्ता खाता बनाउनुहोस');--Create a User Account for Yourself
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateEducationLevelsDescription', 'आफ्नो देश र उद्योग अनुसार उचित शिक्षा स्तर बनाउनुहोस।');--Create education levels applicable to your country and industry.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IncomeTax', 'आयकर');--Income Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'income_tax_rate', 'आयकर दर');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IncomeTaxRate', 'आयकर दर');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_rectangular', 'आयतकार छ?');--Is Rectangular
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Import', 'आयात');--Import
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RequestingImport', 'आयात अनुरोध हुदैछ, यस्ले केहि समय लिन सक्छ ।');--Requesting import. This may take several minutes to complete.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'commision_rate', 'कमीशन दर');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'commission_rate', 'कमीशन दर');--Commission Rate

SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'fiscal_year_code', 'आर्थिक वर्ष कोड');--Fiscal Year Code

SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'fiscal_year_name', 'आर्थिक वर्ष नाम');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateFiscalYear', 'आर्थिक वर्ष बनाउने');--Create Fiscal Year
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_duration', 'दोहोरिने अवधि');--Recurring Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_frequency', 'दोहोरिने समय');--Recurring Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_frequency_id', 'दोहोरिने समय Id');--Recurring Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoice', 'दोहोरिने चलानी');--Recurring Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoice_id', 'दोहोरिने चलानी Id');--Recurring Invoice Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoice_code', 'दोहोरिने चलानी कोड');--Recurring Invoice Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoice_name', 'दोहोरिने चलानी नाम');--Recurring Invoice Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RecurringInvoiceSetup', 'दोहोरिने चलानी सेटअप');--Recurring Invoice Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoice_setup_id', 'दोहोरिने चलानी सेटअप Id');--Recurring Invoice Setup Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RecurringInvoices', 'दोहोरिने चलानीहरु');--Recurring Invoices
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_amount', 'दोहोरिने रकम');--Recurring Amount
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'RecurringAmountErrorMessage', 'दोहोरिने रकम 0 भन्दा कम वा बराबर हुनु हुँदैन।');--Recurring amount should not be less than or equal to 0.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency', 'बारम्बारता');--Frequency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Frequencies', 'बारम्बारताहरू');--Frequencies
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency_id', 'बारम्बारता Id');--Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency_code', 'बारम्बारता कोड');--Frequency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_frequency', 'बारम्बारता छ');--Is Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency_name', 'बारम्बारता नाम');--Frequency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateFrequencies', 'बारम्बारता बनाउनुहोस');--Create Frequencies
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency_setup_id', 'बारम्बारता सेटअप Id');--Frequency Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'frequency_setup_code', 'बारम्बारता सेटअप कोड');--Frequency Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_application_id', 'बिदा आवेदन Id');--Leave Application Id
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'CannotDetermineAppDirectoryPath', 'एप्लिकेसनको फोल्डर तय हुन सकेन।');--Cannot determine application directory path.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DeletingApplicationFiles', 'एप्लिकेसन फाइलहरू मेटाउदै');--Deleting application files.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'email_address', 'इमेल ठेगाना');--Email Address
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailAddress', 'इमेल ठेगाना');--Email Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'email', 'इमेल');--Email
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Email', 'इमेल');--Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'from_email_address', 'इमेल ठेगाना बाट');--From Email Address
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotSendEmailSMTPInvalid', 'इमेल पठाउन सकिएन । यो SMTP कन्फिगरेसन गलत छ।');--Cannot send the email. The SMTP configuration is invalid.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisNote', 'यो टिप्पणी इमेल गर्ने');--Email This Note
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'er', 'ER');--ER
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ER', 'ER');--ER
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'height_in_centimeters', 'उचाइ सेन्टिमिटरमा');--Height In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'elevated', 'उच्च');--Elevated
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProductionOrder', 'उत्पादन अर्डर');--Production Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProductionOrders', 'उत्पादन अर्डरहरू');--Production Orders
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProductionOrderProgress', 'उत्पादन अर्डर प्रगति');--Production Order Progress
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProductionOrderVerification', 'उत्पादन अर्डर प्रमाणिकरण');--Production Order Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyProductionOrder', 'उत्पादन अर्डर प्रमाणित गर्नुहोस्');--Verify Production Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyProductionOrders', 'उत्पादन अर्डरहरु प्रमाणित गर्नुहोस्');--Verify Production Orders
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProducedUnit', 'उत्पादन एकाइ');--Produced Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProducedQuantity', 'उत्पादित मात्रा');--Produced Quantity
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SalesQuotationEmailSubject', 'कोटेसन # { 0 } बाट { १ }');--Quotation #{0} from {1}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'QuotationValidDays', 'कोटेसन मान्यहुने दिन');--Quotation Valid Days
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'QuotationDetails', 'कोटेसन विवरण');--Quotation Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'industry_id', 'उद्योग Id');--Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'industry_name', 'उद्योग को नाम');--Industry Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Industries', 'उद्योगहरू');--Industries
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sub_total', 'कुल जम्मा');--Sub Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'nick_name', 'उपनाम');--Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Attendance', 'उपस्थित');--Attendance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'auto_deduction_based_on_attendance', 'उपस्थिति मा आधारित स्वतः कटौती');--Auto Deduction Based On Attendance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'credit', 'क्रेडिट');--Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Credit', 'क्रेडिट');--Credit
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotMergeDifferentPartyTransaction', 'एउटा ब्याच मा विभिन्न पार्टी को लेनदेन मर्ज गर्न सकिदैन। पुनः प्रयास गर्नुहोला।');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5202', 'एउटा वस्तु एक स्टोर मा एक पटक मात्र देखा पर्न सक्छ ।');--An item can appear only once in a store.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddAKanbanList', 'कानबान सूची थप्नुहोस।');--Add a Kanban List
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateBackupFirst', 'पहिले ब्याकअप गर्नुहोस');--Create a Backup First
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'unit', 'एकाइ');--Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Unit', 'एकाइ');--Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'unit_id', 'एकाइ Id');--Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'unit_code', 'एकाइ कोड');--Unit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'unit_name', 'एकाइ नाम');--Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UnitId', 'एकाइ Id');--Unit Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UnitName', 'एकाइको नाम');--Unit Name
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8001', 'फरक फरक मुद्रामा कारोबार भएका कार्यालय हरूको नाफा नोक्सान हिसाब तयार गर्न सकिदैन।');--Cannot produce P/L statement of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8002', 'फरक फरक मुद्रामा कारोबार भएका कार्यालय हरूको सन्तुलन परिक्षण तयार गर्न सकिदैन।');--Cannot produce trial balance of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4021', 'एउटा ब्याच मा विभिन्न पार्टी को लेनदेन मर्ज गर्न सकिदैन। पुनः प्रयास गर्नुहोला।');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExportToExcel', 'API नीति Id');--Export to Excel
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectApi', 'API चयन गर्नुहोस्');--Select API
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'api_access_policy_id', 'API नीति Id');--API Access Policy Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'api_access_policy_uix', 'API नीति दोहोरियो');--Duplicate Entry for API Access Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'overtime_hourly_rate', 'ओभरटाइम दर(प्रतिघण्टा)');--Overtime Hourly Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'overtime_hours', 'ओभरटाइम घण्टा');--Overtime Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OvertimeHours', 'ओभरटाइम घण्टा');--Overtime Hours
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_overtime', 'ओभरटाइम छ');--Is Overtime
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OvertimeWage', 'ओभरटाइम ज्याला');--Overtime Wage
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'overtime_pay_rate', 'ओभरटाइम पे दर');--Overtime Pay Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'overtime_applicable', 'ओभरटाइम लागू');--Overtime Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MAVCO', 'औसत चलायमान लागत ( MAVCO )');--Moving Average Cost (MAVCO)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CollectRawMaterialsFrom', 'कच्चा माल संकलन');--Collect Raw Materials From
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Deduction', 'कटौती');--Deduction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeductionSetups', 'कटौती Setups');--Deduction Setups
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'deduction_applicable', 'कटौती लागू');--Deduction Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeductionSetup', 'कटौती सेटअप');--Deduction Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'deduction_setup_id', 'कटौती सेटअप Id');--Deduction Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'deduction_setup_code', 'कटौती सेटअप कोड');--Deduction Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'deduction_setup_name', 'कटौती सेटअप नाम');--Deduction Setup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Deductions', 'कटौतीहरू');--Deductions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'configuration_name', 'कन्फिगरेसन नाम');--Configuration Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'low_vision', 'दृष्टि कम');--Low Vision
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectCompany', 'कम्पनी चयन गर्नुहोस्');--Select Company
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'company_name', 'कम्पनी नाम');--Company Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_unit_id', 'कम्पाउन्ड एकाइ Id');--Compound Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item_id', 'कम्पाउन्ड वस्तु Id');--Compound Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item_code', 'कम्पाउन्ड वस्तु कोड');--Compound Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item_name', 'कम्पाउन्ड वस्तु नाम');--Compound Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CompoundItemDetails', 'कम्पाउन्ड वस्तु विवरण');--Compound Item Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item_detail_id', 'कम्पाउन्ड वस्तु विवरण Id');--Compound Item Detail Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CompoundItems', 'कम्पाउन्ड वस्तुहरू');--Compound Items
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax', 'कर');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Tax', 'कर');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProfitBeforeTax', 'कर अघिको मुनाफा');--Profit Before Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_id', 'कर Id');--Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_base_amount', 'कर राशि');--Tax Base Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_base_amount_type_code', 'कर राशि प्रकार कोड');--Tax Base Amount Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_base_amount_type_name', 'कर राशि प्रकार नाम');--Tax Base Amount Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectTaxOfficeGL', 'कर कार्यालय खाता चयन गरनुहोस्');--Select Tax Office GL
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_code', 'कर कोड');--Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_rate_type', 'कर दर प्रकार');--Tax Rate Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_rate_type_code', 'कर दर प्रकार कोड');--Tax Rate Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_rate_type_name', 'कर दर प्रकार नाम');--Tax Rate Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_name', 'कर नाम');--Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_type_id', 'कर प्रकार Id');--Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_type_code', 'कर प्रकार कोड');--Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_type_name', 'कर प्रकार नाम');--Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_authority', 'कर कार्यालय');--Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_authority_id', 'कर कार्यालय Id');--Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reporting_tax_authority_id', 'कर कार्यालय(रिपोर्टिङ्ग) Id');--Reporting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'collecting_tax_authority_id', 'कर कार्यालय (संकलक) Id');--Collecting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_authority_code', 'कर कार्यालय कोड');--Tax Authority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_authority_name', 'कर कार्यालय नाम');--Tax Authority Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reporting_tax_authority', 'कर कार्यालय प्रतिवेदन');--Reporting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'collecting_tax_authority', 'कर कार्यालय सङ्कलन');--Collecting Tax Authority
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateTaxAuthority', 'कर कार्यालय सिर्जना');--Create Tax Authority
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxExemptTypes', 'कर ममुक्तिका प्रकारहरू');--Tax Exempt Types
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_master', 'कर मास्टर');--Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_master_id', 'कर मास्टर Id');--Tax Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_master_code', 'कर मास्टर कोड');--Tax Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_master_name', 'कर मास्टर नाम');--Tax Master Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateTaxMaster', 'कर मास्टर सिर्जना');--Create Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_exempt_type', 'करछुट प्रकार');--Tax Exempt Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_exempt_type_id', 'करछुट प्रकार Id');--Tax Exempt Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_exempt_type_code', 'करछुट प्रकार कोड');--Tax Exempt Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tax_exempt_type_name', 'करछुट प्रकार नाम');--Tax Exempt Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'use_tax_collecting_account_id', 'कर सङ्कलन खाता Id प्रयोग');--Use Tax Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'use_tax_collecting_account', 'कर सङ्कलन खाता प्रयोग');--Use Tax Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'includes_tax', 'कर समावेश');--Includes Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxTypes', 'करका प्रकारहरू');--Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxRate', 'करको दर');--Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee', 'कर्मचारी');--Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Employee', 'कर्मचारी');--Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeExperience', 'कर्मचारी अनुभव');--Employee Experience
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_experience_id', 'कर्मचारी अनुभव Id');--Employee Experience Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_id', 'कर्मचारी Id');--Employee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_tax_rate', 'कर्मचारी कर दर');--Employee Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_code', 'कर्मचारी कोड');--Employee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_employee', 'कर्मचारी हो?');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeWage', 'कर्मचारी ज्याला Id');--Employee Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeWages', 'कर्मचारी तलब');--Employee Wages
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_wage_id', 'कर्मचारी ज्याला Id');--Employee Wage Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeSalaries', 'कर्मचारीको नाम');--Employee Salaries
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeSalary', 'कर्मचारी पहिचान विबरण Id');--Employee Salary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_name', 'कर्मचारीको नाम');--Employee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_identification_detail_id', 'कर्मचारी पहिचान विबरण Id');--Employee Identification Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_type', 'कर्मचारी प्रकार');--Employee Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeType', 'कर्मचारी प्रकार Id');--Employee Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeTypes', 'कर्मचारी प्रकार कोड');--Employee Types
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_type_id', 'कर्मचारी प्रकार Id');--Employee Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_type_code', 'कर्मचारी प्रकार कोड');--Employee Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_type_name', 'कर्मचारी प्रकार नाम');--Employee Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_contribution_rate', 'कर्मचारी योगदान दर');--Employee Contribution Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_qualification_id', 'कर्मचारी योग्यता Id');--Employee Qualification Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeSocialNetworkDetails', 'कर्मचारीहरु');--Employee Social Network Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employee_social_network_detail_id', 'कर्मचारी सामाजिक सञ्जाल विवरण Id');--Employee Social Network Detail Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Employees', 'काउन्टर Id');--Employees
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Counters', 'काउन्टरहरू');--Counters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'counter_id', 'काउन्टर Id');--Counter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'counter_code', 'काउन्टर कोड');--Counter Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'counter_name', 'काउन्टर नाम');--Counter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county', 'काउन्टी');--County
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Counties', 'काउन्टीहरू');--Counties
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_id', 'काउन्टी Id');--County Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_code', 'काउन्टी कोड');--County Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_name', 'काउन्टी नाम');--County Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_sales_tax', 'काउन्टी बिक्री कर');--County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CountySalesTax', 'काउन्टी बिक्री कर');--County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CountySalesTaxes', 'काउन्टी बिक्री करहरू');--County Sales Taxes
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_sales_tax_id', 'काउन्टी बिक्री कर Id');--County Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_sales_tax_code', 'काउन्टी बिक्री कर कोड');--County Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'has_county_sales_tax', 'काउन्टी बिक्री कर छ?');--Has County Sales Tax?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'county_sales_tax_name', 'काउन्टी बिक्री कर नाम');--County Sales Tax Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateCountySalesTax', 'काउन्टी बिक्री कर सिर्जना');--Create County Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_legally_recognized_marriage', 'कानुनी तवरमा विवाह मान्यता प्राप्त छ');--Is Legally Recognized Marriage
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center', 'कार्यकेन्द्र');--Work Center
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_id', 'कार्यकेन्द्र Id');--Work Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_code', 'कार्यकेन्द्र कोड');--Work Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_capacity_id', 'कार्यकेन्द्र क्षमता Id');--Work Center Capacity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_name', 'कार्यकेन्द्र नाम');--Work Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_cost_id', 'कार्यकेन्द्र लागत Id');--Work Center Cost Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_cost_code', 'कार्यकेन्द्र लागत कोड');--Work Center Cost Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_cost_name', 'कार्यकेन्द्र लागत नाम');--Work Center Cost Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_department_id', 'कार्यकेन्द्र विभाग Id');--Work Center Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_department_code', 'कार्यकेन्द्र विभाग कोड');--Work Center Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_center_department_name', 'कार्यकेन्द्र विभाग नाम');--Work Center Department Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HoursWorked', 'काम गरेको घण्टा');--Hours Worked
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'job_title', 'काम शीर्षक');--Job Title
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'job_title_id', 'काम शीर्षक Id');--Job Title Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'job_title_code', 'काम शीर्षक कोड');--Job Title Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'job_title_name', 'काम शीर्षक नाम');--Job Title Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'work_time_in_minutes', 'काम समय (मिनेटमा)');--Work Time (In Minutes)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Factor', 'कारण');--Factor
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'factory_address', 'कारखाना ठेगाना');--Factory Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reason', 'कारण');--Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Reason', 'कारण');--Reason
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'due_frequency', 'बक्याैता बारम्बारता');--Due Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'due_frequency_id', 'बक्याैता बारम्बारता Id');--Due Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'due_date', 'बक्याैता मिति');--Due Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DueDate', 'बक्याैता मिति');--Due Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'due_days', 'बक्याैता दिन');--Due Days
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8101', 'EOD प्रक्रियाको सुरुवात भैसकेको छ।');--EOD operation was already initialized.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'transaction_code', 'कारोबार कोड');--Transaction Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'transaction_ts', 'कारोबार समय');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'transaction_ts', 'कारोबार समय');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_transaction_node', 'कारोबार नोड हो?');--Is Transaction Node
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PostTransaction', 'कारोबार पोस्ट गर्नुहोस्');--Post Transaction
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'allow_transaction_posting', 'कारोबार पोस्टिंग गर्न अनुमति छ?');--Allow Transaction Posting
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CannotWithdrawTransaction', 'कारोबार फिर्ता गर्न सकिदैन ।');--Cannot withdraw transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CannotWithdrawNotValidGLTransaction', 'कारोबार फिर्ता गर्न सकिदैन। यो मान्य कारोबार होइन ।');--Cannot withdraw transaction. This is a not a valid GL transaction.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'transaction_master_id', 'कारोबार मास्टर Id');--Transaction Master Id
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5800', 'कारोबार मेटाउने अनुमति छैन। बरु कारोबारलार्इ अस्वीकार गर्नुहोस।');--Deleting a transaction is not allowed. Mark the transaction as rejected instead.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'transaction_start_date', 'कारोबार सुरु मिति');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionStartDate', 'कारोबार सुरु मिति');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TranId', 'कारोबार Id');--Tran Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionTimestamp', 'कारोबारको समय');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionType', 'कारोबारको प्रकार');--Transaction Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionDate', 'कारोबारको मिती');--Transaction Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionDetails', 'कारोबारको विवरण');--Transaction Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionStatement', 'कारोबार कैफियत');--TransactionStatement
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionSummary', 'कारोबारको सारांश');--Transaction Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionStatus', 'कारोबारको स्थिति');--Transaction Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'card_type', 'कार्ड प्रकार');--Card Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'card_type_id', 'कार्ड प्रकार Id');--Card Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'card_type_code', 'कार्ड प्रकार कोड');--Card Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'card_type_name', 'कार्ड प्रकार नाम');--Card Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Action', 'कार्य');--Action
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ConfigurationError', 'कार्य जारी हुन सक्दैन। कृपया कन्फिगुरेसनका समस्याहरू ठीक गर्नुहोस्।');--Cannot continue the task. Please correct configuration issues.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkShifts', 'कार्य पारीहरू');--Work Shifts
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'JobTitle', 'कार्य शीर्षक');--Job Title
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'JobTitles', 'कार्य शीर्षकहरू');--Job Titles
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TaskCompletedSuccessfully', 'कार्य सफलतापूर्वक पूरा भयो।');--Task completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TaskCompletedSuccessfullyRefreshView', 'कार्य सफलतापूर्वक पूरा भयो। तालिकामा अद्यावधिक गर्नुहुन्छ?');--Task completed successfully. Refresh the view?
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TaskCompletedSuccessfullyReturnToView', 'कार्य सफलतापूर्वक पूरा भयो। तालिकामा फर्कनुहुन्छ?');--Task completed successfully. Return to the view?
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaskCompletedSuccessfully', 'कार्य सफलतापूर्वक सम्पन्न भयो।');--The task was completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Workflow', 'कार्यप्रवाह');--Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Actions', 'कार्यहरू');--Actions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Execute', 'कार्यालय');--Execute
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'office', 'कार्यालय');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'office', 'कार्यालय');--Office
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Office', 'कार्यालय');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'office_id', 'कार्यालय Id');--Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'office_code', 'कार्यालय कोड');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'office_hour_id', 'कार्यालय घण्टा Id');--Office Hour Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectOffice', 'कार्यालय चयन गर्नुहोस्');--Select Office
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesByOffice', 'कार्यालय द्वारा बिक्री');--Sales By Office
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesByOfficeInThousands', 'कार्यालय द्वारा बिक्री ( हजारमा )');--Sales By Office (In Thousands)
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'office_name', 'कार्यालय नाम');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeSetup', 'कार्यालय सेटअप');--Office Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeCode', 'कार्यालयको कोड');--Office Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeName', 'कार्यालयको नाम');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeNickName', 'कार्यालयको उपनाम');--Office Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeLogo', 'कार्यालयको लोगो');--Office Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeInformation', 'कार्यालयको सूचना');--Office Information
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenter', 'कार्य केन्द्र');--Work Center
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterCapacity', 'कार्य केन्द्र क्षमता');--Work Center Capacity
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterCost', 'कार्य केन्द्र लागत');--Work Center Cost
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterCosting', 'कार्य केन्द्र लागत');--Work Center Costing
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterCosts', 'कार्य केन्द्र लागतहरु');--Work Center Costs
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterDepartment', 'कार्य केन्द्र विभाग');--Work Center Department
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenterDepartments', 'कार्य केन्द्र विभागहरु');--Work Center Departments
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorkCenters', 'कार्य केन्द्रहरु');--Work Centers
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'WithdrawalReason', 'किन तपाईं यो कारोबार फिर्ता गर्न चाहनुहुन्छ?');--Why do you want to withdraw this transaction?
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WhichBank', 'कुन बैंक हो?');--Which Bank?
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoShipperFound', 'कुनै सिपर फेला परेन।');--No shipper found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoAdditionalUserFound', 'कुनै अतिरिक्त प्रयोगकर्ता फेला परेन।');--No additional user found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoSupplierFound', 'कुनै बितरक फेला परेन।');--No supplier found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoFiscalYearDefined', 'कुनै आर्थिक वर्ष परिभाषित गरिएको छैन ।');--No fiscal year defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoCountySalesTaxDefined', 'कुनै काउन्टी बिक्री कर परिभाषित गरिएको छैन ।');--No county sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoCashRepositoryDefnied', 'कुनै नगद भण्डार परिभाषित गरिएको छैन ।');--No cash repository defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoTaxAuthorityDefined', 'कुनै पनि कर कार्यालय परिभाषित गरिएको छैन ।');--No tax authority defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoTaxMasterDefined', 'कुनै पनि कर मास्टर परिभाषित गरिएको छैन ।');--No tax master defined.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'None', 'कुनै पनि हैन');--None
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoPartyFound', 'कुनै पार्टी फेला परेन।');--No party found.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NoFileSpecified', 'कुनै फाइल तोकिएको छैन।');--No file specified.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoSalesTaxFormDefined', 'कुनै बिक्री कर फारम परिभाषित गरिएको छैन ।');--No sales tax form defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoSalespersonFound', 'कुनै बिक्रेता फेला परेन।');--No salesperson found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoStateFound', 'कुनै राज्य फेला परेन।');--No state found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoStateSalesTaxDefined', 'कुनै राज्य बिक्री कर परिभाषित गरिएन ।');--No state sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoWidgetFound', 'कुनै विजेट फेला परेन।');--No widget found.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoEducationLevelDefined', 'कुनै शिक्षा स्तर परिभाषित गरिएन।');--No education level defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NoStorePresent', 'कुनै स्टोर उपलव्ध छैन।');--No store present.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'score', 'अंक');--Score
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'total', 'कुल');--Total
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Total', 'कुल');--Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'total_duration', 'कुल अवधि');--Total Duration
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxTotal', 'कुल कर');--Tax Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'total_days', 'कुल दिन');--Total Days
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TotalUsersN', 'कुल प्रयोगकर्ता: {0}।');--Total users : {0}.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'total_sales', 'कुल बिक्री');--Total Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TotalSales', 'कुल बिक्री:');--Total Sales :
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'total_years', 'कुल साल');--Total Years
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GrandTotal', 'कूल जम्मा');--Grand Total
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4003', 'कूल भुक्तानी शून्य भन्दा कम भएकोले तलब पोस्ट गर्न सकिदैन।');--Cannot post salary because the net payment is less than zero.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5901', 'कृपया अरू नै प्रयोगकर्ताबाट यो कारोबार रुजु वा प्रमाणीकरण गर्नुहोस।');--Please ask someone else to verify the transaction you posted.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4031', 'कृपया आफ्नो कारोबार अरू नै प्रयोगकर्ताबाट प्रमाणिकरण गराउनुहोस ।');--Please ask someone else to verify your transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'JustAMomentPlease', 'कृपया एकैछिन पर्खनुहोस!');--Just a moment, please!
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'PleaseEnterCurrentPassword', 'कृपया तपाईंको वर्तमान पासवर्ड प्रविष्टि गर्नुहोस्।');--Please enter your current password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'PleaseEnterNewPassword', 'कृपया नयाँ पासवर्ड प्रविष्टि गर्नुहोस्।');--Please enter a new password.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PleaseSelectAFormFirst', 'कृपया पहिले फारम चयन गर्नुहोस्।');--Please select a form first.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODDoNotCloseWindow', 'कृपया यो विन्डो बन्द नगर्नुहोस् वा प्रारम्भ समयमा यो पेजबाट बाहिर नजानुहोस।');--Please do not close this window or navigate away from this page during initialization.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'stores_default_cash_account_id_chk', 'कृपया ठीक नगद वा बैंक खाता चयन गर्नुहोस्।');--Please select a valid Cash or Bank AccountId.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OnlyNumbersAllowed', 'कृपया ठीक नम्बर टाइप गर्नुहोस्।');--Please type a valid number.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'AreYouSure', 'के तपाईँ निश्चित हुनुहुन्छ?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'AreYouSure', 'के तपाईँ निश्चित हुनुहुन्छ?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AreYouSure', 'के तपाईँ निश्चित हुनुहुन्छ?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InsufficientStockWarning', 'केवल {२}  को { 0}{१} स्टक बाँकी छ।');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'InsufficientStockWarning', 'केवल {२}  को { 0}{१} स्टक बाँकी छ।');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NothingSelected', 'केहीपनि चयन गरिएन।');--Nothing selected!
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NothingSelected', 'केहीपनि चयन गरिएन।');--Nothing selected.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'as_of', 'को रूपमा');--As Of
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'fund_holding_account_id', 'कोष आयोजन खाता Id');--Fund Holding Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sequence_number', 'क्रम संख्या');--Sequence Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'serial_number', 'क्रम संख्या');--Serial Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Id', 'Id');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'allow_credit', 'क्रेडिट अनुमति दिने');--Allow Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreditAllowed', 'क्रेडिट अनुमति दिएको छ');--Credit Allowed
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreditTotal', 'क्रेडिट जम्मा');--Credit Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_credit', 'क्रेडिट हो?');--Is Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'capacity_unit_id', 'क्षमता एकाइ Id');--Capacity Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab_details_amounts_chk', 'फाँट "अन्तिम रकम" "सुरू रकम" भन्दा ठूलो हुनुपर्दछ।');--The field "AmountTo" must be greater than "AmountFrom".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempts_price_to_chk', 'फाँट "PriceFrom" "PriceTo" भन्दा कम हुनुपर्छ।');--The field "PriceFrom" must be less than "PriceTo".
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FieldOrder', 'फाँट लेबल');--Field Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FieldName', 'क्षेत्रीय डाटा फाइल भेटिएन।');--Field Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FieldLabel', 'खरिद अनुमति दिने');--Field Label
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'RegionalDataFileNotFound', 'क्षेत्रीय डाटा फाइल भेटिएन।');--The regional data file could not be located.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'allow_purchase', 'खरिद अनुमति दिने');--Allow Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PurchaseOrder', 'खरिद आदेश');--Purchase Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PurchaseInvoice', 'खरिद चलानी');--Purchase Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_purchase', 'खरिद हो?');--Is Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'purchase_discount_account_id', 'खरिद छुट खाता Id');--Purchase Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'purchase_verification_limit', 'खरिद प्रमाणिकरण सीमा');--Purchase Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exclude_from_purchase', 'खरिद बाट निकाल्ने');--Exclude From Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'purchase_date', 'खरिद मिति');--Purchase Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PurchaseReturn', 'खरिद रिटर्न');--Purchase Return
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5912', 'खरिद रुजु वा प्रमाणिकरण सीमा नाघेको छ। कारोबार रुजु वा प्रमाणित भएको छैन।');--Purchase verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verify_purchase_transactions', 'खरिद लेनदेन प्रमाणित गर्नुहोस्');--Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_verify_purchase_transactions', 'खरिद लेनदेन प्रमाणित गर्न सक्नुहुन्छ');--Can Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PurchaseType', 'खरिदको प्रकार');--Purchase Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account', 'खाता');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Account', 'खाता');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountOverview', 'खाता अवलोकन');--Account Overview
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_id', 'खाता Id');--Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountId', 'खाता Id');--Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'purchase_account_id', 'खरिद खाता Id ');--Purchase Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'expense_account_id', 'खर्च खाता Id ');--Expense Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'posting_account_id', 'पोस्टिङ् खाता Id ');--Posting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'collecting_account_id', 'सङ्कलन खाता Id ');--Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_number', 'खाता नम्बर');--Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountNumber', 'खाता नम्बर');--Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_master', 'खाता मास्टर');--Account Master
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountMaster', 'खाता मास्टर');--Account Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_master_id', 'खाता मास्टर Id');--Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_master_code', 'खाता मास्टर कोड');--Account Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_master_name', 'खाता मास्टर नाम');--Account Master Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountStatement', 'खाता विवरण');--Account Statement
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'collecting_account', 'सङ्कलन खाता ');--Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'account_name', 'खाताको नाम');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccountName', 'खाताको नाम');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Search', 'खोज्नुहोस्');--Search
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Disassemble', 'खोल्ने');--Disassemble
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'analyze_count', 'गणना विश्लेषण');--Analyze Count
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DestinationStore', 'गन्तव्य स्टोर');--Destination Store
SELECT * FROM localization.add_localized_resource('CommonResource', 'ne', 'InvalidDate', 'गलत मिति ।');--Invalid date.
SELECT * FROM localization.add_localized_resource('CommonResource', 'ne', 'DateMustBeLessThan', 'गलत मिति, "{0}" भन्दा कम हुनु पर्छ ।');--Invalid date. Must be less than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'ne', 'DateMustBeGreaterThan', 'गलत मिति, "{0}" भन्दा बढी हुनु पर्छ ।');--Invalid date. Must be greater than "{0}".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'confidential', 'गोप्य');--Confidential
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Confidential', 'गोप्य');--Confidential
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'rounding_method', 'पूर्णांकीकरण विधि');--Rounding Method
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'rounding_method_name', 'पूर्णांकीकरण विधिको नाम');--Rounding Method Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'customer_id', 'ग्राहक Id');--Customer Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CustomerCode', 'ग्राहक कोड');--Customer Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectCustomer', 'ग्राहक चयन गर्नुहोस्');--Select Customer
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CustomerPanNumber', 'ग्राहक पैन #');--Customer PAN #
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewCustomerCopy', 'ग्राहकको प्रति हेर्नुहोस्');--View Customer Copy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'customer_pays_fee', 'ग्राहकको भुक्तानि शुल्क');--Customer Pays Fee
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CustomerPaysFees', 'ग्राहकको भुक्तानि शुल्कहरु');--Customer Pays Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CustomerName', 'ग्राहकको नाम');--Customer Name
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'GridViewEmpty', 'ग्रिडभ्यू खाली छ ।');--Gridview is empty.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'grace_period', 'ग्रेस अवधि');--Grace Period
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ComponentObliqueBOM', 'अंश/ BOM');--Component/BOM
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'HoursAbbreviated', 'घण्टा');--hrs
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ConvertedtoHomeCurrency', 'घर मुद्रामा रूपान्तरित गरिएको');--Converted to Home Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cycle_duration_in_hour', 'चक्र अवधि घण्टामा');--Cycle Duration In Hour
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compounding_frequency', 'चक्रवर्धित बारम्बारता');--Compounding Frequency
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'DateErrorMessage', 'चयन गरिएको मिति गलत छ।');--Selected date is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotMergeAlreadyMerged', 'चयन गरिएको लेनदेन पहिले नै मर्ज गरिएको छ । फेरि प्रयास गर्नुहोस।');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4022', 'चयन गरिएको लेनदेन पहिले नै मर्ज गरिएको छ। फेरि प्रयास गर्नुहोस।');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_accounts_account_id_chk', 'चयन गरिएको वस्तु मान्य बैंक खाता होइन्।');--The selected item is not a valid bank account.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectedWidgets', 'चयन गरिएको विजेट');--Selected Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EditSelected', 'चयन गरिएको सम्पादन गर्नुहोस्');--Edit Selected
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'Select', 'चयन गर्नुहोस्');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Select', 'चयन गर्नुहोस्');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeleteSelected', 'चयनगरिएको मेट्नुहोस्');--Delete Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InvoiceAmount', 'चलानी रकम');--Invoice Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InvoiceDetails', 'चलानी विवरण');--Invoice Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RunningTotal', 'चालु कुल');--Running Total
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RunningDatabasePatch', 'डेटाबेस प्याच चलिरहेको छ');--Running Database Patch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'stores_sales_tax_id_chk', 'यो कार्यालय को लागि चुनिएको बिक्री कर Id गालत छ।');--The chosen SalesTaxId is invalid for this office.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Check', 'चेक गर्नुहोस्');--Check
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CheckOutTime', 'चेकआउट समय');--CheckOut Time
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CheckInTime', 'चेकइन समय');--CheckIn Time
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Checklists', 'चेकलिस्ट');--Checklists
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Warning', 'चेतावनी');--Warning
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'width_in_centimeters', 'चौडाइ सेन्टिमिटर मा');--Width In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'has_state_sales_tax', 'राज्य बिक्री कर हो?');--Has State Sales Tax?
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'CouldNotDetermineVirtualPathError', 'प्रतिमा बनाउन भर्चुअल पाथ निर्धारण गर्न सकेन।');--Could not determine virtual path to create an image.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'discount', 'छुट');--Discount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Discount', 'छुट');--Discount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_exemption', 'छुट हो?');--Is Exemption
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Deliver', 'वितरित');--Deliver
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliveredFrom', 'वितरित बाट');--Delivered From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'holiday_id', 'बिदा Id');--Holiday Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyLeaveApplications', 'बिदा आवेदन प्रमाणित गर्नुहोस्');--Verify Leave Applications
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'holiday_name', 'बिदाको नाम');--Holiday Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveApplication', 'बिदाको आवेदन');--Leave Application
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveApplications', 'बिदाको आवेदनहरु');--Leave Applications
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveType', 'बिदाको प्रकार');--Leave Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveTypes', 'बिदाको प्रकारहरु');--Leave Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveBenefit', 'बिदा लाभ');--Leave Benefit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeaveBenefits', 'बिदा लाभहरु');--Leave Benefits
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_benefit_name', 'बिदा लाभको नाम');--Leave Benefit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_type_name', 'बिदा प्रकारको नाम');--Leave Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BackupNow', 'अब ब्याकअप लिनुहोस्');--Backup Now
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BackupConsole', 'ब्याकअप कन्सोल');--Backup Console
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BackupDatabase', 'डेटाबेस ब्याकअप लिनुहोस्');--Backup Database
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EnterBackupName', 'ब्याकअप सिर्जना गर्नुहोस्');--Enter Backup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BackupDirectories', 'ब्याकअप निर्देशिकाहरु');--Backup Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateBackup', 'ब्याकअप सिर्जना गर्नुहोस्');--Create Backup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'semantic_css_class', 'Semantic CSS क्लास');--Semantic Css Class
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'date_of_birth', 'जन्म मिति');--Date Of Birth
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DateOfBirth', 'जन्म मिति');--Date of Birth
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'JournalVoucher', 'जर्नल भौचर');--Journal Voucher
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'checking_frequency', 'बारम्बारता जाँच हुदैछ');--Checking Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'checking_frequency_id', 'जाँच बारम्बारता Id');--Checking Frequency Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Go', 'जानुहोस्');--Go
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'zip_code', 'जिप कोड');--Zip Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'gl_verification_limit', 'खाता प्रमाणिकरण सीमा');--Gl Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verify_gl_transactions', 'खाता लेनदेन प्रमाणित गर्नुहोस्');--Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_verify_gl_transactions', 'खाता लेनदेन प्रमाणित गर्न सक्नुहुन्छ?');--Can Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GLDetails', 'खाता विवरणहरु');--GL Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GLAdvice', 'खाता सुचना');--GL Advice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'gl_head', 'खाता हेड');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GLHead', 'खाता हेड');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Wage', 'ज्याला');--Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Wages', 'ज्यालाहरु');--Wages
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProcessWage', 'ज्यालाको प्रक्रिया');--Process Wage
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'wage_processing_id', 'ज्याला प्रक्रिया Id');--Wage Processing Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WageProcessing', 'ज्याला प्रशोधन');--Wage Processing
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'wage_setup', 'ज्याला सेटअप');--Wage Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'wage_setup_id', 'ज्याला सेटअप Id');--Wage Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'wage_setup_code', 'ज्याला सेटअप कोड');--Wage Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'wage_setup_name', 'ज्याला सेटअपको नाम');--Wage Setup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateAFlag', 'Flag बनाउनुहोस् ');--Create a Flag
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'comment', 'टिप्पणी');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Comment', 'टिप्पणी');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Tel', 'टेलिफोन');--Tel
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tran_code', 'कारोबार कोड');--Tran Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'tran_type', 'कारोबार प्रकार');--Tran Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OK', 'ठिक छ');--OK
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contract_id', 'ठेक्का Id');--Contract Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_contract', 'ठेक्का हो?');--Is Contract
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'address', 'ठेगाना');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Address', 'ठेगाना');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddressAndContactInfo', 'ठेगाना र सम्पर्क सूचना');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddressAndContactInformation', 'ठेगाना र सम्पर्क सूचना');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_address_line_1', 'सम्पर्क ठेगाना १');--Contact Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'address_line_1', 'ठेगाना १');--Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'address_line_2', 'ठेगाना २');--Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_address_line_2', 'सम्पर्क ठेगाना २');--Contact Address Line 2
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddressInformation', 'ठेगानाको  सूचना');--Address Information
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Download', 'डाउनलोड');--Download
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DownloadingUpdate', 'अपडेट डाउनलोड हुदैछ');--Downloading Update
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ClickHereToDownload', 'डाउनलोड गर्न यहाँ क्लिक गर्नुहोस्।');--Click here to download.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ExtractingDownloadedFile', 'डाउनलोड भएको फाइल निकालिदै छ।');--Extracting the downloaded file.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'CannotDetermineFileFromDownloadUrl', 'डाउनलोड URL बाट फ़ाइलको  नाम निर्धारित गर्न सकिदैन्।');--Cannot determine filename from the download URL.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DownloadSuccessful', 'डाउनलोड सफल भयो ।');--Download was successful.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DownloadSourceCode', 'सोर्स कोड डाउनलोड गर्नुहोस्');--Download Source Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DataImport', 'डाटा आयात');--Data Import
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ImportData', 'डाटा आयात');--Import Data
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DataType', 'डाटाको प्रकार');--Data Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DatabaseStatistics', 'डेटाबेस तथ्याङ्क');--Database Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DatabaseParameters', 'डेटाबेस प्यारामिटर');--Database Parameters
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PatchedDatabase', 'डेटाबेस प्याच गरिएको ।');--Patched the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PatchingDatabase', 'डेटाबेस प्याच गरिदै ।');--Patching the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DatabaseBackupSuccessful', 'डेटाबेस ब्याकअप सफल भयो ।');--The database backup was successful.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DatabaseBackups', 'डेटाबेस ब्याकअप');--Database Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AnalyzeDatabase', 'डेटाबेस विश्लेषण');--Analyze Database
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'debit', 'डेबिट');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Debit', 'डेबिट');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DebitTotal', 'कुल डेबिट ');--Debit Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_debit', 'डेबिट हो?');--Is Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingCompany', 'ढुवानी कम्पनी');--Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateShippingCompany', 'ढुवानी कम्पनी बनाउनुहोस्');--Create Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingAddress', 'ढुवानी ठेगाना');--Shipping Address
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingAddresses', 'ढुवानी ठेगाना ( हरू)');--Shipping Address(es)
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_address_id', 'ढुवानी ठेगाना Id');--Shipping Address Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_address_code', 'ढुवानी ठेगाना कोड');--Shipping Address Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'based_on_shipping_address', 'ढुवानी ठेगाना मा आधारित');--Based On Shipping Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_package_shape_id', 'ढुवानी प्याकेज आकार Id');--Shipping Package Shape Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_package_shape_code', 'ढुवानी प्याकेज आकार कोड');--Shipping Package Shape Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_package_shape_name', 'ढुवानी प्याकेज आकारको नाम');--Shipping Package Shape Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_mail_type_code', 'ढुवानी मेल प्रकार कोड');--Shipping Mail Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_mail_type_name', 'ढुवानी मेल प्रकारको नाम');--Shipping Mail Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipping_mail_type_id', 'ढुवानी मेल प्रकार Id');--Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingCharge', 'ढुवानी शुल्क');--Shipping Charge
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'applied_on_shipping_charge', 'ढुवानी शुल्क मा लागू गरियो');--Applied on Shipping Charge
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingInformation', 'ढुवानी सूचना');--Shipping Information
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ProcessingYourCSVFile', 'तपाइको CSV फाइल प्रक्रिया हुदैछ ।');--Processing  your CSV file.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'InstanceIsUpToDate', 'तपाइको MixERP इंस्टेंस अप टू डेट छ ।');--Your instance of MixERP is up to date.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionStartDateDescription', 'कुन निश्चित मिति देखी तपाईं MixERP मा लेन्देन प्रबिष्टि गर्न चाहनुहुन्छ।');--Enter the exact date from when you want to record transactions in MixERP.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UpdateBackupMessage', 'अपडेट गर्नु पूर्व कृपया तपाईं सँग पछिल्लो ब्याकअप भएको सुनिश्चित गर्नुहोस्।');--Before you perform the update operation, please make sure that you have latest backups handy.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODTransactionPosting', 'जब तपार्इँ कुनै मितिको EOD गर्नुहुन्छ, उक्त मिति वा उक्त मिति भन्दा पहिलेको मितिमा कारोबार प्रबिष्टि गर्न, समायोजन गर्न वा मेटाउन मिल्दैन।');--When you perform EOD operation for a particular date, no transaction on that date or before can be altered, changed, or deleted.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODLogsOffUsers', 'जब तपार्इँ EOD शुरू गर्नुहुन्छ, लगइन भर्इरहेका सबै प्रयोगकर्ता हरू(तपार्इ समेत) १२० सेकेण्डको लागि लगअाउट हुनुहुनेछ।');--When you initialize day-end operation, the already logged-in application users including you are logged off on 120 seconds.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5110', 'तपाईं कर नलाग्ने बिक्री को लागि बिक्री करको जानकारी प्रदान गर्न सक्नुहुन्न। ');--You cannot provide sales tax information for non taxable sales.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurring_invoices_item_id_auto_trigger_on_sales_uix', 'यस वस्तुको बिक्रीको लागि एक भन्दा बढी स्वतः ट्रिगर हुन सक्दैन।');--You cannot have more than one auto trigger on sales for this item.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FlagDescription', 'यो कारोबार लार्इ तपार्इ फ्लाग गर्न सक्नुहुन्छ तर अरू प्रयोगकर्ताले गरेको फ्लाग तपार्इ हेर्न सक्नुहुन्न।');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_details_rate_chk', 'राज्य वा काउण्टी कर चयन गरेपछी करदर खाली हुनुहुदैन, त्यसैगरी कुनै एउटा कर चयन गरेर दुबै दर उल्लेख गर्न पनि मिल्दैन।');--Rate should not be empty unless you have selected state or county tax. Similarly, you cannot provide both rate and choose to have state or county tax.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UploadInvalidTryAgain', 'तपाईंको अपलोड फाइल गलत छ "{0}"। फेरि प्रयास गर्नुहोस।');--Your upload is of invalid file type "{0}". Please try again.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionWithdrawalInformation', 'जब तपार्इले कारोबार फिर्ता गर्नुहुन्छ, त्यो कारोबारलार्इ कार्यप्रक्रियामा समाबेश गरिदैन। मतलब फिर्ता भएका कारोबारहरू स्वतः अस्वीकृत कारोबार हुन्छन् त्यसैले यसलार्इ रूजु गरिरहनु पर्दैन तर फिर्ता भर्इसकेका कारोबार पुन कार्य प्रबाहमा सामाबेश गर्न मिल्दैन।');--When you withdraw a transaction, it won't be forwarded to the workflow module. This means that your withdrawn transactions are rejected and require no further verification. However, you won't be able to unwithdraw this transaction later.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'YourOffice', 'तपाईंको कार्यालय');--Your Office
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AboutYourOffice', 'तपाईंको कार्यालयको बारेमा');--About Your Office
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'CannotAccessAccount', 'तपाईंको खातामा पहुँच हुन सकेन?');--Cannot access your account?
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'WhatIsYourHomeCurrency', 'तपाईंको देशको मुद्रा के हो?');--What Is Your Home Currency?
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'YourName', 'तपाईंको नाम');--Your Name
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'YourPasswordWasChanged', 'तपाईंको पासवर्ड परिवर्तन भएको थियो।');--Your password was changed.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SuccessfullyProcessedYourFile', 'तपाईंको फाइल सफलतापूर्वक प्रसोधन भयो।।');--Successfully processed your file.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SetupEmailDescription', 'तपाईंको बहिर्गमन इमेल कन्फिगरेसन असक्षम छ। आफ्नो ग्राहकहरुको इमेल सूचनाहरू पठाउनको लागि SMTP मापदण्डहरु कन्फिगर गर्नुहोस्।');--Your outgoing email configuration is disabled. Configure the SMTP parameters for sending email notifications to your customers.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3105', 'तपाईंको वर्तमान पासवर्ड गलत छ।');--Your current password is incorrect.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectYourBranch', 'तपाईंको शाखा चयन गर्नुहोस्');--Select Your Branch
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NotAuthorized', 'तपाईंलाई यो समयमा यो स्रोतको पहुँच अधिकार छैन।');--You are not authorized to access this resource at this time.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8991', 'तपाईंलाई सिस्टम खाता थप्न अनुमति छैन।');--You are not allowed to add system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8990', 'तपाईंलाई सिस्टम खाता परिवर्तन गर्ने अनुमति छैन। ');--You are not allowed to change system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5106', 'समुह कार्यालयमा नाफा नोक्सान बिनियोजन गर्न मिल्दैन।');--You cannot perform PL appropriation on an office group.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5206', 'तपाईंले यो कारोबारको लागि एक भन्दा बढी वितरण गन्तव्य स्टोर प्रदान गर्नसक्नुहुन्न।');--You cannot provide more than one delivery destination store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5205', 'तपाईंले यो कारोबारको लागि एक भन्दा बढी स्टोर प्रदान गर्न सक्नुहुन्न।');--You cannot provide more than one store for this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ItemErrorMessage', 'तपाईंले वस्तु Id वा मिश्रित वस्तु Id चयन गरनु र्पर्ने छ ।');--You have to select either item id or  compound item id.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Prepare', 'तयारी गर्नुहोस्');--Prepare
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GoToBottom', 'तल जानुहोस्');--Go to Bottom
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Salary', 'तलब');--Salary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_id', 'तलब Id');--Salary Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryFrequencies', 'तलब बारम्बारता');--Salary Frequencies
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_frequency_name', 'तलब बारम्बारता नाम');--Salary Frequency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryDeductions', 'तलब कटौती');--Salary Deductions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_tax', 'तलब कर');--Salary Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryTax', 'तलब कर');--Salary Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_tax_id', 'तलब कर Id');--Salary Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_tax_income_bracket_id', 'तलब कर आय कोष्ठक Id');--Salary Tax Income Bracket Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_tax_code', 'तलब कर कोड');--Salary Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_tax_name', 'तलब करको नाम');--Salary Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_to', 'तलब (सम्म)');--Salary To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_name', 'तलबको नाम');--Salary Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_type', 'तलब प्रकार');--Salary Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_type_id', 'तलब प्रकार Id');--Salary Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_type_code', 'तलब प्रकार कोड');--Salary Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_type_name', 'तलब प्रकार नाम');--Salary Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalarySetup', 'तलब सेटअप');--Salary Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryTaxes', 'तलबका करहरु');--Salary Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryType', 'तलबका प्रकार');--Salary Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryTypes', 'तलबका प्रकारहरु');--Salary Types
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'hot_item', 'ताजा बस्तु');--Hot item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'schedule_date', 'तालिका मिति');--Schedule Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'desired_resign_date', 'इच्छित पदत्याग मिति');--Desired Resign Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'due_on_date', 'बक्याैता मिति');--Due on Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compare_unit_id', 'तुलना एकाइ Id');--Compare Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compare_unit_name', 'तुलना एकाइ नाम');--Compare Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Add', 'थप');--Add
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_added', 'थपिएको हो?');--Is Added
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'last_name', 'थर');--Last Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AboutInitializingDayEnd', 'थालनी दिनको अन्त्य बारे');--About Initializing Day End
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'rate', 'दर');--Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'registration_date', 'दर्ता मिति');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'registration_number', 'दर्ता नम्बर');--Registration Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RegistrationDate', 'दर्ता मिति');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'rounding_decimal_places', 'दशमलव पछिको अंक');--Rounding Decimal Places
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Documentation', 'दस्तावेज');--Documentation
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DaysLowerCase', 'दिनहरु');--days
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Day', 'दिन');--Day
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Days', 'दिनहरु');--Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'from_days', 'दिन देखि');--From Days
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EODBegun', 'EOD प्रक्रिया सुरुभएको छ');--End of Day Processing Has Begun
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'day_of_month', 'महिनाको दिन ');--Day of Month
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EndOfDayOperation', 'सबै पक्ष बराबर छैनन् ।');--End of Day Operation
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODElevatedPriviledgeCanLogIn', 'दैनिक खाता बन्दी प्रक्रिया चलिरहदा उच्च अधिकार प्राप्त प्रयोगकर्ताले मात्र लगइन गर्न सक्नुहुन्छ।');--During the day-end period, only users having elevated privilege are allowed to log-in.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5000', 'सबै पक्ष बराबर छैनन् ।');--Referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'BothSidesCannotHaveValue', 'डेबिट र क्रेडिट दुबैमा रकम हुनुहुदैन।');--Both debit and credit cannot have values.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ReferencingSidesNotEqual', 'दुवै पक्ष्य बराबर छैनन्।');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'country', 'देश');--Country
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Countries', 'देशहरु');--Countries
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Home', 'देश');--Home
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'country_id', 'देश Id');--Country Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'country_name', 'देशको नाम');--Country Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'country_code', 'देश कोड');--Country Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HomeCurrency', 'देशको मुद्रा');--Home Currency
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5104', 'दैनिक कारोबार अन्त्य गर्नु अघि कारोबार(हरु) रुजु तथा प्रमाणिकरण गर्नुहोस।');--Please verify transactions before performing end of day operation.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5102', 'दैनिक कारोबार अन्त्य भैसकेको छ।');--End of day operation was already performed.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'DuplicateEntry', 'प्रबिष्टि दोहोरियो।');--Duplicate entry.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'DuplicateFile', 'दोहोरो फाइल!');--Duplicate File!
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'DuplicateFiles', 'दोहोरो फाइलहरू ।');--Duplicate files.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_accounts_pkey', 'दोहोरो बैंक खाता ।');--Duplicate bank account.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AuthorizedBy', 'प्रमाणीकृत गर्ने');--Authorized By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'supervised_by', 'निरीक्षण गर्ने');--Supervised By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verified_by', 'प्रमाणित गर्ने');--Verified By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'entered_by', 'प्रविष्टि गर्ने');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EnteredBy', 'व्यवस्थित गर्ने');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliveredBy', 'वितरित गर्ने');--Delivered By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'managed_by', 'व्यवस्थित गर्ने');--Managed By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AcknowledgedBy', 'स्वीकार गर्ने');--Acknowledged By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ThankYou', 'धन्यवाद');--Thank You
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_smoker', 'धूम्रपान गर्ने व्यक्ति हो?');--Is Smoker
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5001', 'नकारात्मक स्टकको अनुमति छैन।');--Negative stock is not allowed.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repositories_cash_repository_code_uix', 'दोहोरो नगद भण्डार कोड');--Duplicate Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repositories_cash_repository_name_uix', 'दोहोरो नगद भण्डारको नाम');--Duplicate Cash Repository Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateDuplicate', 'दोहोरो बनाउनुहोस्');--Create a Duplicate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashTransaction', 'नगद कारोबार');--Cash Transaction
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CashTransactionCannotContainBankInfo', 'नगद कारोबारले बैंक कारोबार विवरण समावेश गर्न सक्दैन।');--A cash transaction cannot contain bank transaction details.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_cash', 'नगद हो?');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StatementOfCashFlows', 'नगद प्रवाह को विवरण');--Statement of Cash Flows
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_master_id', 'नगद प्रवाह मास्टर Id');--Cash Flow Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_master_code', 'नगद प्रवाह मास्टर कोड');--Cash Flow Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_master_name', 'नगद प्रवाह मास्टरको नाम');--Cash Flow Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading', 'नगद प्रवाह शीर्षक');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashFlowHeading', 'नगद प्रवाह शीर्षक');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading_id', 'नगद प्रवाह शीर्षक Id');--Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading_code', 'नगद प्रवाह शीर्षक कोड');--Cash Flow Heading Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading_name', 'नगद प्रवाह शीर्षकको नाम');--Cash Flow Heading Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_heading_type', 'नगद प्रवाह शीर्षक प्रकार');--Cashflow Heading Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_flow_setup_id', 'नगद प्रवाह शीर्षक सेटअप Id');--Cashflow Setup Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashFlowHeadings', 'नगद प्रवाह शीर्षकहरु');--Cash Flow Headings
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashFlowSetup', 'नगद प्रवाह सेटअप');--Cash Flow Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repository', 'नगद भण्डार');--Cash Repository
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashRepository', 'नगद भण्डार');--Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repository_id', 'नगद भण्डार Id');--Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repository_code', 'नगद भण्डारको कोड');--Cash Repository Code
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateCashRepositoriesDescription', 'नगद भण्डार तपाईंले आफ्नो नगद र बहुमूल्य वस्तुहरू भण्डारण गर्ने ठाउँ हो । उदाहरण: भल्ट , दराज अादि।');--Cash repository is a place where you store your cash and valuables. Example: Cash in Vault, Cash in Drawers.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cash_repository_name', 'नगद भण्डारको नाम');--Cash Repository Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashRepositoryBalance', 'नगद भण्डार शेष');--Cash Repository Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CashRepositories', 'नगद रिपॉजिटरीहरु');--Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateCashRepositories', 'नगद रिपॉजिटरी बनाउनुहोस्');--Create Cash Repositories
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UserGreeting', 'नमस्ते {0}!');--Hi {0}!
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NewPassword', 'नया पासवर्ड');--New Password
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3006', 'नया पास्वोर्ड राख्नुहोस।');--Please provide a new password.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NewFiscalYear', 'नयाँ आर्थिक वर्ष');--New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateNewFiscalYear', 'नयाँ आर्थिक वर्ष बनाउनुहोस्');--Create New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddNewChecklist', 'नयाँ चेकलिस्ट थप्नुहोस्');--Add New Checklist
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddNew', 'नयाँ थप्नुहोस्');--Add New
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NewPasswordCannotBeOldPassword', 'नयाँ पासवर्ड पुरानो पासवर्ड हुन सक्दैन।');--New password can not be old password.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EnterNewPassword', 'नयाँ रिलिज उपलब्ध छ');--Enter a New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AddNewUsers', 'नयाँ प्रयोगकर्ता थप्नुहोस्');--Add New Users
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NewReleaseAvailable', 'नयाँ रिलिज उपलब्ध छ');--A New Release Is Available
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateNew', 'नयाँ बनाउनुहोस्');--Create New
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Name', 'नाम');--Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'entity_id', 'इन्टिटी Id');--Entity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'entity_name', 'इन्टिटीको नाम');--Entity Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'entity_access_id', 'इन्टिटी पहुँच Id');--Entity Access Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EntityAccessPolicy', 'अवकास प्रकार नाम');--Entity Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExtractingDownload', 'निकाल्ने काम सकियो।');--Extracting Download
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_type_name', 'अवकास प्रकार नाम');--Exit Type Name
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ExtractionCompleted', 'निकाल्ने काम सकियो।');--Extraction completed.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'regular_hours', 'नियमित घण्टा');--Regular Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RegularHours', 'नियमित घण्टा');--Regular Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RegularWage', 'नियमित ज्याला');--Regular Wage
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'regular_pay_rate', 'नियमित भुक्तानी दर');--Regular Pay Rate
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DirectoryBackupCompletedSuccessfully', 'निर्देशिका ब्याकअप सफलतापूर्वक पूरा भयो ।');--Directory backup completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'DirectoryRestoreSuccessful', 'निर्देशिका पुनर्स्थापना सफलतापूर्वक पूरा भयो ।');--Directory restore completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Manufacture', 'निर्माण');--Manufacture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'manufacturer', 'निर्माता');--Manufacturer
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Export', 'नीति Id');--Export
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExportData', 'नेक्सस जाँच गर्नुहोस्');--Export Data
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'policy_id', 'नीति Id');--Policy id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'check_nexus', 'नेक्सस जाँच गर्नुहोस्');--Check Nexus
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lead_status_id', 'लिड स्थिति Id');--Lead Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lead_status_code', 'लिड स्थिति कोड');--Lead Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lead_status_name', 'लिड स्थितिको नाम');--Lead Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lead_source_name', 'लिड स्रोतको नाम');--Lead Source Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'minimum_salary', 'न्यूनतम तलब');--Minimum Salary
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RowNumber', 'पङ्क्ति नम्बर');--Row Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReturnBack', 'पछाडि फर्कनुहोस्');--Return Back
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastLoginOn', 'पछील्लो पटक लगिन गरिएको');--Last Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastWrittenOn', 'पछील्लो पटक लेखिएको');--Last Written On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastLoginIP', 'पछील्लो पटकको लगिन IP');--Last Login IP
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Sent', 'पठाइयो');--Sent
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Send', 'पठाउनुहोस्');--Send
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Definition', 'परिभाषा');--Definition
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RollingBackChanges', 'परिवर्तनहरू फिर्ता गरिदै ।');--Rolling back changes.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'identification_number', 'पहिचान नम्बर');--Identification Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'identification_type', 'पहिचान प्रकार');--Identification Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'identification_type_code', 'पहिचान प्रकार कोड');--Identification Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'identification_type_name', 'पहिचान प्रकारको नाम');--Identification Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'First', 'पहिलो चरण');--First
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FirstTasks', 'पहिलो नाम');--First Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FirstSteps', 'पहिलो पृष्ठ');--First Steps
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'first_name', 'पहिलो नाम');--First Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FirstPage', 'पहुँच अनुमति');--First Page
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Access', 'पहुँच');--Access
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'allow_access', 'पहुँच अनुमति');--Allow Access
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'access_type_id', 'पहुँच प्रकार Id');--Access Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'access_type_name', 'पहुँच प्रकारको नाम');--Access Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pan_number', 'प्यान नम्बर');--Pan Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party', 'पार्टी');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Party', 'पार्टी');--Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_type_code', 'पार्टी प्रकार कोड');--Party Tpye Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_id', 'पार्टी Id');--Party Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_code', 'पार्टी कोड');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectParty', 'पार्टी चयन गर्नुहोस्');--Select Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_party', 'पार्टी हो?');--Is Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_name', 'पार्टीको नाम');--Party Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_type', 'पार्टी प्रकार');--Party Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_type_id', 'पार्टी प्रकार Id');--Party Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'party_type_name', 'पार्टी प्रकारको नाम');--Party Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateParties', 'पार्टी बनाउनुहोस्');--Create Party
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'party', 'पार्टी ');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartyTypes', 'पार्टीका प्रकारहरू');--Party Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartyCode', 'पार्टीको कोड');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartyInformation', 'पार्टीको जानकारी');--Party Information
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartyName', 'पार्टीको नाम');--Party Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartyType', 'पार्टीको प्रकार');--Party Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PartySummary', 'पार्टीको सारांश');--Party Summary
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'PartyDescription', 'पार्टीहरु सामूहिक रुपमा आपूर्तिकर्ता , ग्राहकहरु, एजेन्ट र व्यापारीहरु भनेर बुझिन्छ।');--Parties collectively refer to suppliers, customers, agents, and dealers.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Parties', 'पार्टीहरू');--Parties
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'password', 'पासवर्ड');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Password', 'पासवर्ड ');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PasswordUpdated', 'पासवर्ड अपडेट गरिएको थियो।');--Password was updated.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3005', 'पासवर्ड खाली हुन सक्दैन ।');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'PasswordCannotBeEmpty', 'पासवर्ड खाली हुन सक्दैन ।');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ChangePassword', 'पासवर्ड परिवर्तन');--Change Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_change_password', 'पासवर्ड परिवर्तन गर्न सक्नुहुन्छ');--Can Change Password
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ConfirmPassword', 'पासवर्ड सुनिश्चित गर्नुहोस');--Confirm Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reorder_unit', 'रीअर्डर एकाइ');--Reorder Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reorder_unit_id', 'रीअर्डर एकाइ Id');--Reorder Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reorder_quantity', 'रीअर्डर मात्रा');--Reorder Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reorder_level', 'रीअर्डर स्तर');--Reorder Level
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurrence_type', 'पुनरावृत्ति प्रकार');--Recurrence Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurrence_type_id', 'पुनरावृत्ति प्रकार Id');--Recurrence Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurrence_type_code', 'पुनरावृत्ति प्रकार कोड');--Recurrence Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurrence_type_name', 'पुनरावृत्ति प्रकारको नाम');--Recurrence Type Name
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RestoringDirectory', 'निर्देशिका पुनर्स्थापित हुँदै : { 0 }।');--Restoring directory : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RestoringFile', 'फाइल पुनर्स्थापित हुँदै : { 0 }।');--Restoring file : {0}.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'full_name', 'पुरा नाम');--Full Name
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ConfirmationPasswordDoesNotMatch', 'पुष्टि पासवर्ड नयाँ पासवर्ड संग मेल खाँदैन।');--The confirmation password does not match with the new password.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'book', 'बुक');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Book', 'बुक');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BookIncomeTax', 'बुक आय कर');--Book Income Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'book_date', 'बुक मिति');--Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BookDate', 'बुक मिति');--Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_complete', 'पूरा हो?');--Is Complete
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CompleteTasks', 'पूर्ण कार्यहरु');--Complete Tasks
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_default', 'पूर्वनिर्धारित हो?');--Is Default
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_default_admin', 'पूर्वनिर्धारित (व्यवस्थापक) हो?');--Is Default (Admin)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DefaultAddress', 'पूर्वनिर्धारित ठेगाना');--Default Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_cash_account', 'पूर्वनिर्धारित नगद खाता');--Default Cash Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_cash_account_id', 'पूर्वनिर्धारित नगद खाता Id');--Default Cash Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_cash_repository', 'पूर्वनिर्धारित नगद भण्डार');--Default Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_cash_repository_id', 'पूर्वनिर्धारित नगद भण्डार Id');--Default Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_entity_access_id', 'पूर्वनिर्धारित इन्टिटी पहुँच Id');--Default Entity Access Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DefaultEntityAccessPolicy', 'पूर्वनिर्धारित इन्टिटी पहुँच नीति');--Default Entity Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DefaultReorderQuantityAbbreviated', 'पूर्वनिर्धारित रीअर्डर मात्रा');--Default Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DefaultCurrency', 'पूर्वनिर्धारित मुद्रा');--Default Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MakeAsDefault', 'पूर्वनिर्धारित रूपमा बनाउनुहोस्');--Make As Default
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'default_employment_status_code_id', 'पूर्वनिर्धारित रोजगार स्थिति कोड Id');--Default Employment Status Code Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Preview', 'पूर्वावलोकन गर्नुहोस्');--Preview
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PageN', 'पृष्ठ { 0 }');--Page {0}
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'background_color', 'पृष्ठभूमि रंग');--Background Color
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FlagBackgroundColor', 'पृष्ठभूमिको रंग फ्लाग् गर्नुहोस्');--Flag Background Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pay_grade', 'भुक्तानी ग्रेड');--Pay Grade
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pay_grade_id', 'भुक्तानी ग्रेड Id');--Pay Grade Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pay_grade_code', 'भुक्तानी ग्रेड कोड');--Pay Grade Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pay_grade_name', 'भुक्तानी ग्रेडको नाम');--Pay Grade Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pension_fund', 'पेन्सन कोष');--Pension Fund
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PensionFund', 'पेन्सन कोष');--Pension Fund
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PensionFunds', 'पेन्सन कोषहरु');--Pension Funds
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pension_fund_id', 'पेन्सन कोष Id');--Pension Fund Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pension_fund_code', 'पेन्सन कोष कोड');--Pension Fund Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pension_fund_name', 'पेन्सन कोषको नाम');--Pension Fund Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'pension_fund_expense_account_id', 'पेन्सन कोष व्यय खाता Id');--Pension Fund Expense Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payroll_account_id', 'पेरोल खाता Id');--Payroll Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PANNumber', 'प्यान नम्बर');--PAN Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'po_box', 'पोष्ट बक्स');--Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'posted_by', 'पोस्ट गर्ने व्यक्ति');--Posted By
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NoTransactionToPost', 'पोस्ट गर्न कुनै कारोबार छैन ।');--No transaction to post.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'posting_account', 'पोस्ट गर्ने खाता');--Posting Account
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PostedDate', 'पोस्ट गरिएको मिती');--Posted Date
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'NoTransactionToPost', 'पोस्टगर्न कुनै लेनदेन छैन ।');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Type', 'प्रकार');--Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_type_id', 'बिदा प्रकार Id');--Leave Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_type_id', 'अवकाश प्रकार Id ');--Exit Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_type_code', 'बिदा प्रकार कोड');--Leave Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_type', 'अवकाश प्रकार');--Exit Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_type_code', 'अवकाश प्रकार कोड');--Exit Type Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Progress', 'प्रगति');--Progress
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IsSystemAccount', 'प्रणाली खाता हो?');--Is System Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_system', 'प्रणाली हो?');--Is System
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'capacity_per_cycle', 'प्रति चक्र क्षमता');--Capacity Per Cycle
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'hourly_rate', 'प्रतिघण्टा दर');--Hourly Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'hourly_cost', 'प्रतिघण्टा लागत');--Hourly Cost
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5101', 'प्रतिबन्धित कारोबार समयमा कारोबार पोस्ट गर्न सक्नुहुन्न।');--Cannot post transaction during restricted transaction mode.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CopyNewApplication', 'नयाँ आवेदन प्रतिलिपि गर्नुहोस्');--Copy New Application
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DirectPurchase', 'प्रत्यक्ष खरिद');--Direct Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DirectSales', 'प्रत्यक्ष बिक्री');--Direct Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_supplier', 'बितरक हो?');--Is Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'effective_termination_date', 'प्रभावकारी निलम्बन मिति');--Effective Termination Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'effective_resignation_date', 'प्रभावकारी राजीनामा मिति');--Effective Resignation Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Verification', 'प्रमाणिकरण ');--Verification
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verification_reason', 'प्रमाणिकरणको कारण');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerificationReason', 'प्रमाणिकरणको कारण');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Verify', 'प्रमाणित गर्नुहोस्');--Verify
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifiedBy', 'प्रमाणित गर्ने व्यक्ति');--Verified By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verified_on', 'मा प्रमाणित ');--Verified On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InVerificationStack', 'प्रमाणीकरण थाक मा छ');--In Verification Stack
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verification_status', 'प्रमाणीकरण स्थिति');--Verification Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verification_status_id', 'प्रमाणीकरण स्थिति Id');--Verification Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verification_status_name', 'प्रमाणीकरण स्थितिको नाम');--Verification Status Name
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'user', 'प्रयोगकर्ता');--User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'user', 'प्रयोगकर्ता');--User
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Use', 'प्रयोग');--Use
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'User', 'प्रयोगकर्ता');--User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'user_id', 'प्रयोगकर्ता ID');--User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maintained_by_user_id', 'ब्यबस्थित गर्ने प्रयोगकर्ता Id');--Maintained By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verified_by_user_id', 'प्रमाणितगर्ने प्रयोगकर्ताको Id ');--Verified By User Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectUser', 'प्रयोगकर्ता चयन गर्नुहोस्');--Select User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'user_name', 'प्रयोगकर्ताको नाम');--User Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UserManagement', 'प्रयोगकर्ता व्यवस्थापन');--User Management
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'UserIdOrPasswordIncorrect', 'प्रयोगकर्ता Id या पासवर्ड गलत छ ।');--User id or password incorrect.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UserId', 'प्रयोगकर्ता Id');--User Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Username', 'प्रयोगकर्ताको नाम');--Username
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Users', 'प्रयोगकर्ताहरु');--Users
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'BackingUpForMigration', 'माइग्रेशनको लागि फाइल {0}  ब्याकअप गरिदै');--Backing up file {0} for migration.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'entry_ts', 'प्रवेश समय');--Entry Ts
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9001', 'प्रवेश निषेध।');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9012', 'प्रवेश निषेध! एउटा स्टक समायोजन कारोबार धेरै कार्यालयमा सम्बन्धित हुदैन।');--Access is denied! A stock adjustment transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AccessIsDenied', 'प्रवेश निषेध।');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9011', 'प्रवेश निषेध। गलत तथ्यांक राखियो।');--Access is denied. Invalid values supplied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9014', 'प्रवेश निषेद। तपाईं अन्य कार्यालयको लेनदेन प्रमाणित गर्न सक्नुहुन्न।');--Access is denied. You cannot verify a transaction of another office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9017', 'प्रवेश निषेद। तपाईंलाइ कारोबार फिर्ता गर्ने अधिकार छैन।');--Access is denied. You don''t have the right to withdraw the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9010', 'प्रवेश निषेद। तपाईंलाई यो कारोबार पोस्ट गर्ने अधिकार छैन ।');--Access is denied. You are not authorized to post this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9015', 'प्रवेश निषेध। बिगतको वा भविष्यको कारोबार लार्इ रूजु गर्न मिल्दैन।');--Access is denied. You cannot verify past or futuer dated transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9250', 'प्रवेश निषेध। यो कारोबार ब्यबस्थापकले अस्वीकार गर्नुभएको छ।');--Access is denied. This transaction was rejected by administrator.
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'actions', 'कार्यहरू');--Actions
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9016', 'प्रवेश निषेद। तपाईंलाइ  कारोबार प्रमाणित गर्ने  अधिकार्  छैन।');--Access is denied. You don''t have the right to verify the transaction.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'primary_sales_tax_is_vat', 'प्राथमिक बिक्री कर भ्याट हो?');--Primary Sales Tax Is Vat?
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PrimarySalesTaxType', 'प्राथमिक बिक्री करका प्रकार');--Primary Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'priority', 'प्राथमिकता');--Priority
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Priority', 'प्राथमिकता');--Priority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'priority_id', 'प्राथमिकता Id');--Priority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'priority_code', 'प्राथमिकता कोड');--Priority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'priority_name', 'प्राथमिकताको नाम');--Priority Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Priorities', 'प्राथमिकताहरु');--Priorities
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Receive', 'प्राप्त गरिएको');--Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Received', 'प्राप्त गरिएको');--Received
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceivedOn', 'प्राप्त मिती');--Received On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceivedCurrency', 'प्राप्त मुद्रा');--Received Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Print', 'प्रिन्ट');--Print
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ManageProfile', 'प्रोफाइल व्यवस्थापन');--Manage Profile
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'plant', 'प्लान्ट');--Plant
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'plant_id', 'प्लान्ट Id');--Plant Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'plant_code', 'प्लान्ट कोड');--Plant Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'plant_name', 'प्लान्टको नाम');--Plant Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Difference', 'फरक');--Difference
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Return', 'फर्कनुहोस');--Return
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5203', 'फर्काइएको मात्रा वास्तविक मात्रा भन्दा बढी हुन सक्दैन।');--The returned quantity cannot be greater than actual quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5204', 'फर्काइएको रकम वास्तविक रकम भन्दा बढी हुन सक्दैन।');--The returned amount cannot be greater than actual amount.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FilePath', 'अघिल्लो पेजमा जानुहोस्');--File Path
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Back', 'पछाडि');--Back
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BackToPreviousPage', 'अघिल्लो पेजमा जानुहोस्');--Back to Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Filter', 'फिल्टर अवस्था');--Filter
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'filter_condition', 'फिल्टर अवस्था');--Filter Condition
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FilterCondition', 'फिल्टर चयन गर्नुहोस्');--Filter Condition
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'filter_id', 'फिल्टर Id');--Filter Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectAFilter', 'फिल्टर चयन गर्नुहोस्');--Select a Filter
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'filter_name', 'फिल्टरको नाम');--Filter Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FilterName', 'फिल्टर "र" मान');--Filter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'filter_value', 'फिल्टर मान');--Filter Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'filter_and_value', 'फिल्टर "र" मान');--Filter And Value
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FilterStatement', 'फिल्टर: { 0 }');--Filter Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ManageFilters', 'फिल्टर व्यवस्थापन');--Manage Filters
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NamedFilter', 'फिल्टर: { 0 }');--Filter: {0}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RequiredFieldDetails', 'फुली ( * ) चिनो लगाइएको क्षेत्र आवश्यक छ।');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MixERPOnFacebook', 'फेसबुकमा MixERP');--MixERP on Facebook
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'photo', 'फोटो');--Photo
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone', 'फोन');--Phone
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Phone', 'फोन');--Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone_emergency', 'फोन आपतकालीन');--Phone Emergency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone_emergency2', 'फोन आपतकालीन२');--Phone Emergency2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone_office_extension', 'फोन कार्यालय एक्सटेन्सन');--Phone Office Extension
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone_home', 'घरको फोन');--Phone Home
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'phone_cell', 'सेल फोन');--Phone Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'fax', 'फ्याक्स');--Fax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Fax', 'फ्लाग् चयन गर्नुहोस्।');--Fax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'flag_id', 'फ्लाग् Id');--Flag Id
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SelectAFlag', 'फ्लाग् चयन गर्नुहोस्।');--Select a flag.
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'flag_background_color', 'फ्लाग् पृष्ठभूमि रङ');--Flag Background Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'flag_foreground_color', 'फ्लाग् पृष्ठभूमि रङ');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'flag_type_id', 'फ्लाग् प्रकार Id');--Flag Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'flag_type_name', 'फ्लाग् प्रकारको नाम');--Flag Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Flag', 'फ्लाग् लगाउनुहोस');--Flag
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'FlagSaved', 'फ्लाग् सेव गरियो।');--Flag saved.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'FlagRemoved', 'फ्लाग् हटाइएको।');--Flag removed.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_flat_amount', 'फ्लेट रकम हो?');--Is Flat Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'flagged_on', 'फ्ल्याग गरिएको');--Flagged On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Close', 'बन्द');--Close
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'closing_credit', 'अन्तिम क्रेडिट');--Closing Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ClosingCredit', 'अन्तिम क्रेडिट');--Closing Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'closing_debit', 'अन्तिम डेडिट');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ClosingDebit', 'अन्तिम डेडिट');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ClosedTransactions', 'बन्द कारोबारहरू');--Closed Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ClosingBalance', 'अन्तिम माैज्दात');--Closing Balance
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'statement_reference', 'विवरण सन्दर्भ');--Statement Reference
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'DueFrequencyErrorMessage', 'बाँकी बारम्बारता Id चयन गरिएको छ भने बाँकी दिन 0 हुनुपर्छ।');--Due days should be 0 if due frequency id is selected.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'From', 'बाट');--From
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliverFrom', 'बाट वितरण');--Deliver From
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DownloadingFrom', 'बाट डाउनलोड');--Downloading From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'from_display_name', '"बाट" देखाउने नाम');--From Display Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'effective_from', 'बाट प्रभावकारी');--Effective From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'begins_from', 'बाट सुरु');--Begins From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'starts_from', 'बाट सुरु हुन्छ');--Starts From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'has_child', 'चाइल्ड छ?');--Has Child
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'external_code', 'बाह्य कोड');--External Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExternalCode', 'बिक्री अनुमति');--External Code
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3201', 'बिक्रिवस्तु / एकाइ बेमेल।');--Item/unit mismatch.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'allow_sales', 'बिक्री अनुमति');--Allow Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesOrder', 'बिक्री आदेश');--Sales Order
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_order_id', 'बिक्री आदेश Id');--Sales Order Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesQuotation', 'बिक्री कोटेसन');--Sales Quotation
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_quotation_valid_duration', 'बिक्री कोटेसन मान्य अवधि');--Sales Quotation Valid Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax', 'बिक्री कर');--Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_id', 'बिक्री कर Id');--Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_code', 'बिक्री कर कोड');--Sales Tax Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTaxExempts', 'बिक्री कर छूट');--Sales Tax Exempts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_name', 'बिक्री करको नाम');--Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_type', 'बिक्री कर प्रकार');--Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_type_id', 'बिक्री कर प्रकार Id');--Sales Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_type_code', 'बिक्री कर प्रकार कोड');--Sales Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_type_name', 'बिक्री कर प्रकारको नाम');--Sales Tax Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTaxTypes', 'बिक्री कर प्रकारहरु');--Sales Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateSalesTaxForm', 'बिक्री कर फारम बनाउनुहोस्');--Create Sales Tax Form
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempt', 'बिक्री करछुट');--Sales Tax Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempt_id', 'बिक्री करछुट Id');--Sales Tax Exempt Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempt_code', 'बिक्री करछुट कोड');--Sales Tax Exempt Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempt_name', 'बिक्री करछुटको नाम');--Sales Tax Exempt Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTaxExemptDetails', 'बिक्री करछुट विवरण');--Sales Tax Exempt Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_exempt_detail_id', 'बिक्री करछुट विवरण Id');--Sales Tax Exempt Detail Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTaxDetails', 'बिक्री कर विवरण');--Sales Tax Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_detail_id', 'बिक्री कर विवरण Id');--Sales Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_detail_code', 'बिक्री कर विवरण कोड');--Sales Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_tax_detail_name', 'बिक्री कर विवरणको नाम');--Sales Tax Detail Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTaxes', 'बिक्री करहरु');--Sales Taxes
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_account_id', 'बिक्री खाता Id');--Sales Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesInvoice', 'बिक्री चलानी');--Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewSalesInovice', 'बिक्री चलानी हेर्नुहोस्');--View Sales Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_sales', 'बिक्री हो?');--Is Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_discount_account_id', 'बिक्री छुट खाता Id');--Sales Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_team_code', 'बिक्री टोली कोड');--Sales Team Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_team', 'बिक्री टोली');--Sales Team
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_team_id', 'बिक्री टोली Id');--Sales Team Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_team_name', 'बिक्री टोलीको नाम');--Sales Team Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesTeams', 'बिक्री टोलीहरु');--Sales Teams
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P1302', 'बिक्री पोस्ट गर्न सक्नुहुन्न। गालत नगद खाता स्टोरमा मिलान गरिएको छ ।');--Cannot post sales. Invalid cash account mapping on store.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesType', 'बिक्री प्रकार');--Sales Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_verification_limit', 'बिक्री प्रमाणिकरण सीमा');--Sales Verification Limit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesReturn', 'बिक्री फिर्ता');--Sales Return
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exclude_from_sales', 'बिक्री बाट अलग गर्नुहोस् ');--Exclude From Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'selling_price', 'बिक्री मूल्य');--Selling Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'selling_price_includes_tax', 'बिक्री मूल्यमा कर समावेश');--Selling Price Includes Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesReceipt', 'बिक्री रसिद');--Sales Receipt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sales_return_account_id', 'बिक्री रिटर्न खाता Id');--Sales Return Account Id
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5911', 'बिक्री रुजु वा प्रमाणिकरण सीमा नाघेको छ। कारोबार रुजु वा प्रमाणित भएको छैन।');--Sales verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'verify_sales_transactions', 'बिक्री लेनदेन प्रमाणित गर्नुहोस्');--Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_verify_sales_transactions', 'बिक्री लेनदेन प्रमाणित गर्न सक्नुहुन्छ');--Can Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesDelivery', 'बिक्री वितरण');--Sales Delivery
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SalesDeliveryEmailSubject', 'बिक्री वितरण # { 0 } पुष्टि, { १ }');--Sales delivery #{0} confirmation, {1}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Holiday', 'बिदा');--Holiday
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_type', 'बिदा प्रकार');--Leave Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_benefit', 'बिदा लाभ');--Leave Benefit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HolidaySetup', 'बिदा सेटअप');--Holiday Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Holidays', 'बिदाहरू');--Holidays
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Thursday', 'बिहीबार');--Thursday
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'middle_name', 'बीचको नाम');--Middle Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Wednesday', 'बुधवार');--Wednesday
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'CompoundUnitOfMeasureErrorMessage', 'बेस इकाई Id र तुलना इकाई Id एउटै हुन् सक्दैन।');--Base unit id and compare unit id cannot be same.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_account_number', 'बैँक खाता नम्बर');--Bank Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BankTransactionCode', 'बैंक कारोबार कोड');--Bank Transaction Code
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5111', 'बैंक कारोबारको गलत जानकारी दिनुभयो।');--Invalid bank transaction information provided.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BankAccounts', 'बैंक खाता');--Bank Accounts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_account_type', 'बैंक खाता प्रकार');--Bank Account Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BankDetails', 'बैंक विवरण');--Bank Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_branch_name', 'बैंक शाखाको नाम');--Bank Branch Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_address', 'बैंकको ठेगाना');--Bank Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_name', 'बैंकको नाम');--Bank Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_branch', 'बैंकको शाखा');--Bank Branch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_contact_number', 'बैंकको संपर्क नम्बर');--Bank Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bank_reference_number', 'बैंकको Ref. No.');--Bank Reference Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab', 'बोनस Slab');--Bonus Slab
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab_id', 'बोनस Slab Id');--Bonus Slab Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AgentBonusSlabAssignment', 'बोनस Slab कार्यभार');--Bonus Slab Assignment
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab_code', 'बोनस Slab कोड');--Bonus Slab Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab_name', 'बोनस Slab को नाम');--Bonus Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_slab_detail_id', 'बोनस Slab विवरण Id');--Bonus Slab Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bonus_rate', 'बोनस दर');--Bonus Rate
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'BackingUp', 'ब्याक अप {0} ।');--Backing up {0}.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewBackups', 'ब्याकअपहरु हेर्नुहोस्');--View Backups
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P1301', 'ब्याज गणना गर्न असमर्थ छ । वर्षका दिनहरूका जानकारी प्रदान गरिएको छैन ।');--Cannot calculate interest. The number of days in a year was not provided.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InterestApplicable', 'ब्याज लागू हुनेछ');--Interest Applicable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'interest_compounding_frequency_id', 'ब्याज समझौता बारम्बारता Id');--Interest Compounding Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'interest_rate', 'ब्याजदर');--Interest Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Browse', 'ब्राउज गर्नुहोस्');--Browse
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'browser', 'ब्राउजर');--Browser
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'brand', 'ब्रान्ड');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Brand', 'ब्रान्ड');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Brands', 'ब्रान्ड');--Brands
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'brand_id', 'ब्रान्ड Id');--Brand Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'brand_code', 'ब्रान्ड कोड');--Brand Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'brand_name', 'ब्रान्डको नाम');--Brand Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'blog', 'ब्लग');--Blog
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'repository', 'भण्डार');--Repository
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectLanguage', 'भाषा चयन गर्नुहोस्');--Select Language
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_term', 'भुक्तानी अवधि');--Payment Term
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_term_id', 'भुक्तानी अवधि Id');--Payment Term Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_term_code', 'भुक्तानी अवधि कोड');--Payment Term Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_term_name', 'भुक्तानी अवधिको नाम');--Payment Term Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_card', 'भुक्तानी कार्ड');--Payment Card
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_card_id', 'भुक्तानी कार्ड Id');--Payment Card Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_card_code', 'भुक्तानी कार्ड कोड');--Payment Card Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectPaymentCard', 'भुक्तानी कार्ड चयन गर्नुहोस्');--Select Payment Card
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'payment_card_name', 'भुक्तानी कार्डको नाम');--Payment Card Name
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5112', 'भुक्तानी कार्डको गलत जानकारी दिनुभयो।');--Invalid payment card information.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PayGrade', 'भुक्तानी ग्रेड');--Pay Grade
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PayGrades', 'भुक्तानी ग्रेडहरु');--Pay Grades
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PayHours', 'भुक्तानी घण्टा');--Pay Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PayRate', 'भुक्तानी दर');--Pay Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PaySlip', 'भुक्तानी पर्ची');--Pay Slip
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PaymentCards', 'भुक्तानीको कार्डहरू');--Payment Cards
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PaymentTerms', 'भुक्तानीको सर्तहरू');--Payment Terms
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'role', 'भूमिका');--Role
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Role', 'भूमिका');--Role
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'role_code', 'भूमिका कोड');--Role Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'role_name', 'भूमिकाको नाम');--Role Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Roles', 'भूमिकाहरु');--Roles
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VoucherVerification', 'भौचर प्रमाणिकरण');--Voucher Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VoucherVerificationPolicy', 'भौचर प्रमाणिकरण नीति');--Voucher Verification Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'vacuum_count', 'भ्याक्युम गणना');--Vacuum Count
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VAT', 'भ्याट');--VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Tuesday', 'मंगलवार');--Tuesday
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RememberMe', 'सम्झनुहोस्');--Remember Me
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Month', 'महिना');--Month
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'last_vacuum', 'अन्तिममा भ्याक्युम');--Last Vacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'completed_on', 'मा पूरा');--Completed On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliveredOn', 'मा वितरित');--Delivered On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'expires_on', 'मा समाप्त हुन्छ');--Expires On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'started_on', 'मा सुरु');--Started On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'occurs_on', 'तब हुन्छ');--Occurs On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'quantity', 'मात्रा');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Quantity', 'मात्रा');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'QuantityAbbreviated', 'मात्रा');--Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'QuantityOnHandAbbreviated', 'मात्रा (  )');--Qty (On Hand)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GoToTop', 'माथि जानुहोस्');--GoToTop
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'GoToTop', 'माथि जानुहोस्।');--Go to top.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_alcoholic', 'मादक पद्दार्थ सेवन गर्न व्यक्ति हो ?');--Is Alcoholic
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'standard_deduction', 'स्टैंडर्ड कटौती');--Standard Deduction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HumanResourceManagement', 'मानव संसाधन व्यवस्थापन');--Human Resource Management
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UnitsOfMeasure', 'मापन को एकाइ');--Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CompoundUnitsOfMeasure', 'मापन को कम्पाउन्ड यूनिट्स');--Compound Units of Measure
SELECT * FROM localization.add_localized_resource('CommonResource', 'ne', 'NoRecordFound', 'माफ गर्नुहोस्, कुनै पनि तथ्यांक फेला परेन।');--Sorry, no record found.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotCreateABackup', 'माफ गर्नुहोस्, यो समयमा Database Backup लिन सक्नुहुन्न।');--Sorry, cannot create a database backup at this time.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Date', 'मिति');--Date
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'MinutesAbbreviate', 'मिनेट');--mins
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_machine', 'मिसिन हो?');--Is Machine
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'machine_name', 'मिसिनको नाम');--Machine Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'machine_cost', 'मिसिन लागत');--Machine Cost
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MachineInformation', 'मिसिनको सूचना');--Machine Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_exempt', 'मुक्त हो?');--Is Exempt
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'currency', 'मुद्रा');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'currency', 'मुद्रा');--Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Currency', 'मुद्रा');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'currency_code', 'मुद्रा कोड');--Currency Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrencyCode', 'मुद्रा कोड');--Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'currency_name', 'मुद्राको नाम');--Currency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrencyName', 'मुद्राको नाम');--Currency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'currency_symbol', 'मुद्रा प्रतीक');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrencySymbol', 'मुद्रा प्रतीक');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Currencies', 'मुद्राहरू');--Currencies
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4010', 'मुद्राहरू बीचको विनिमय दर फेला परेन।');--Exchange rate between the currencies was not found.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price', 'मूल्य');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_to', 'मूल्य सम्म');--Price To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Price', 'मूल्य');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_from', 'मूल्य देखि');--Price From
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ComparePriceErrorMessage', 'मूल्य देखि मूल्य सम्म भन्दा कम हुनुपर्छ।');--Price from should be less than price to.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_type', 'मूल्य प्रकार');--Price Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_type_id', 'मूल्य प्रकार Id');--Price Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_type_code', 'मूल्य प्रकार कोड');--Price Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'price_type_name', 'मूल्य प्रकारको नाम');--Price Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PriceDetails', 'मूल्य विवरणहरु');--Price Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PriceType', 'मूल्यका प्रकार');--Price Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'majors', 'मेजर');--Majors
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Delete', 'मेटाउन');--Delete
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MenuCode', 'मेनु कोड');--Menu Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MenuId', 'मेनु Id');--Menu Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MenuAccessPolicy', 'मेनु पहुँच नीति');--Menu Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MyLeaveApplications', 'मेरो बिदा आवेदन');--My Leave Applications
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MyResignation', 'मेरो राजीनामा');--My Resignation
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'model_number', 'मोडेल नम्बर');--Model Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'opportunity_stage_id', 'मौका स्टेज Id');--Opportunity Stage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'opportunity_stage_code', 'मौका स्टेज कोड');--Opportunity Stage Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'opportunity_stage_name', 'मौका स्टेज नाम');--Opportunity Stage Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OpportunityStages', 'मौकाको चरणहरु');--Opportunity Stages
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_expire', 'म्याद समाप्त हुनसक्छ');--Can Expire
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NCashRepositoriesInThisOffice', 'यस कार्यालयमा { 0 } नगद भण्डारहरू छन् ।');--There are {0} cash repositories in this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'forward_to', 'यसलाई पठाउनुहोस्');--Forward To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliverTo', 'यसलाई हस्तान्तरण गर्नुहोस्');--Deliver To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectUnit', 'यूनिट चयन गरनुहोस्');--Select Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisRequest', 'यो अनुरोध हेर्नुहोस्');--View This Request
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'TempDirectoryNullError', 'यो अस्थायी निर्देशिका शून्य हुँदा छवि बनाउन सक्दैन।');--Cannot create an image when the temp directory is null.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisOrder', 'यो अर्डर इमेल गर्नुहोस');--Email This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisOrder', 'यो अर्डर हेर्नुहोस्');--View This Order
SELECT * FROM localization.add_localized_resource('CommonResource', 'ne', 'RequiredField', 'यो आवश्यक क्षेत्र हो ।');--This is a required field.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RequiredField', 'यो आवश्यक क्षेत्र हो ।');--This is a required field.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RequiredField', 'यो आवश्यक क्षेत्र हो ।');--This is a required field.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SalesQuotationExpired', 'यो कोटेसन { 0 } मा समाप्त भयो।');--This quotation expired on {0}.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisQuotation', 'यो कोटेसन इमेल गर्नुहोस');--Email This Quotation
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SalesQuotationAlreadyAccepted', 'यो कोटेसन पहिले नै { 0 }  मा स्वीकार गरिएको थियो।');--This quotation was already accepted on {0}.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisQuotation', 'यो कोटेसन हेर्नुहोस्');--View This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ApproveThisTransaction', 'यो कारोबार अनुमोदन गर्नुहोस');--Approve This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RejectThisTransaction', 'यो कारोबार अस्वीकार गर्नुहोस्');--Reject This Transaction
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionRejectedDetails', 'यो कारोबार {0} द्वारा {१} मा अस्वीकार गरिएको थियो। कारण: "{२}"।');--This transaction was rejected by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5002', 'यो कारोबार पोस्ट गर्दा नकारात्मक नगद ब्यालेन्स हुनेछ ।');--Posting this transaction would produce a negative cash balance.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionAwaitingVerification', 'यो कारोबार उच्च अधिकार प्राप्त प्रयोगकर्ताद्वरा प्रमाणिकरणको पर्खाइमा छ।');--This transaction is awaiting verification from an administrator.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'InsufficientBalanceInCashRepository', 'यो कारोबार प्रशोधन गर्न नगद भण्डारमा पर्याप्त रकम छैन ।');--There is no sufficient balance in the cash repository to process this transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionWithdrawnDetails', 'यो कारोबार {0}  द्वारा {१} मा  फिर्ता गरिएको थियो। कारण: "{२}"।');--This transaction was withdrawn by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionClosedDetails', 'यो कारोबार {0} द्वारा {१}  मा  बन्द भएको थियो। कारण: "{२}"।');--This transaction was closed by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionApprovedDetails', 'यो कारोबार {0} द्वारा {१}  मा स्वीकृत भएको थियो।');--This transaction was approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionAutoApprovedDetails', 'यो कारोबार {0} द्वारा {१}  मा स्वतः स्वीकृत भएको थियो।');--This transaction was automatically approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'ConfirmAnalyze', 'यो कार्यान्वयन समयमा ग्राहक डेटाबेसको पहुँच बन्द हुनेछ। तपाईं अहिले यो कार्य कार्यान्वयन गर्न चाहनुहुन्छ?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'ConfirmVacuum', 'यो कार्यान्वयन समयमा ग्राहक डेटाबेसको पहुँच बन्द हुनेछ। तपाईं अहिले यो कार्य कार्यान्वयन गर्न चाहनुहुन्छ?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ne', 'ConfirmVacuumFull', 'यो कार्यान्वयन समयमा ग्राहक डेटाबेसको पहुँच बन्द हुनेछ। तपाईं अहिले यो कार्य कार्यान्वयन गर्न चाहनुहुन्छ?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'NStoresInThisOffice', 'यो कार्यालयमा { 0 } स्टोरहरु छन् ।');--There are {0} stores in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ThisFieldIsRequired', 'यो क्षेत्र आवश्यक छ।');--This field is required.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisInvoice', 'यो चलानी इमेल गर्नुहोस');--Email This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisInvoice', 'यो चलानी हेर्नुहोस्');--View This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeleteThisChecklist', 'यो चेकलिस्ट मेटाउनुहोस्');--Delete This Checklist
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EditThisChecklist', 'यो चेकलिस्ट सम्पादन गर्नुहोस');--Edit This Checklist
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ReleaseContainsNoUpdates', 'यो रिलीजमा कुनै पनि अपडेट समावेश गर्दैन ।');--This release does not contain any update.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisNote', 'यो टिप्पणी हेर्नुहोस्');--View This Note
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3054', 'यो पुनक्रम एकाइ आधारएकाइसंग मिल्दैन।');--The reorder unit is incompatible with the base unit.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'items_reorder_quantity_chk', 'यो पुनक्रम मात्रा पुनक्रम स्तर भन्दा ठूलो वा बराबर हुनुपर्छ।');--The reorder quantity must be great than or equal to the reorder level.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ConfirmedPasswordDoesNotMatch', 'यो पुष्टि पासवर्ड मेल खाँदैन ।');--The confirmed password does not match.
SELECT * FROM localization.add_localized_resource('Messages', 'ne', 'EODProcessIsIrreversible', 'यो प्रक्रिया अपरिवर्तनीय छ।');--This process is irreversible.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4030', 'यो प्रयोगकर्ताको लागि कुनै प्रमाणिकरण नीति फेला परेन ।');--No verification policy found for this user.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'ReturnButtonUrlNull', 'यो प्रविष्टि फिर्ता गर्न सकिँदैन। फिर्ती URL प्रदान गरिएको छैन ।');--Cannot return this entry. The return url was not provided.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisAuthorization', 'यो प्राधिकरण हेर्नुहोस्');--View This Authorization
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'RequiredFieldDetails', 'यो फुली ( * ) चिनो लगाइएका फील्डहरु आवश्यक छन्।');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisReceipt', 'यो रसिद इमेल गर्नुहोस');--Email This Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisReturn', 'यो रिटर्न इमेल गर्नुहोस');--Email This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisReturn', 'यो रिटर्न हेर्नुहोस्');--View This Return
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4020', 'यो वस्तु यो कारोबार सँग सम्बन्धित छैन ।');--This item is not associated with this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotCreateVariantHavingMultipleAttributes', 'यो वस्तु बनाउन सकिँदैन किनभने तपाईंले " { 0 } " अत्ट्रिबुत को एकल संस्करण निर्दिष्ट गर्नुपर्छ ।');--Cannot create this item because you must specify a single variant of "{0}" attribute.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmailThisDelivery', 'यो वितरण इमेल गर्नुहोस');--Email This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisDelivery', 'यो वितरण हेर्नुहोस्');--View This Delivery
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'ReferencingSidesNotEqual', 'यो सन्दर्भ पक्ष बराबर छैन ।');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisAdjustment', 'यो समायोजन हेर्नुहोस्');--View This Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisTransfer', 'यो स्थानान्तरण हेर्नुहोस्');--View This Transfer
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'RestrictedTransactionMode', 'यो स्थापनाले कारोबार पोस्टको अनुमति दिएको छैन।');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Qualifications', 'योग्यता');--Qualifications
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Planning', 'योजना');--Planning
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'planned_quantity', 'योजना गरिएको मात्रा');--Planned Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'And', 'र');--And
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'amount', 'रकम');--Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'amount', 'रकम');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Amount', 'रकम');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AmountInBaseCurrency', 'रकम (बेस मुद्रा मा)');--Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'amount_from', 'रकम बाट ');--Amount From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'amount_to', 'रकम सम्म');--Amount To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Cancel', 'रद्द गर्नुहोस');--Cancel
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Receipt', 'रसिद');--Receipt
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ReceiptEmailSubject', 'रसिद # { 0 } सूचना , { १ }');--Receipt #{0} notification, {1}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PrintReceipt', 'रसिद प्रिन्ट गर्नुहोस');--Print Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceiptType', 'रसिदको प्रकार');--Receipt Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceiptCurrency', 'रसिदको मुद्रा');--Receipt Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceiptAmount', 'रसिदको रकम');--Receipt Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Resignation', 'राजीनामा');--Resignation
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'resignation_id', 'राजीनामा Id');--Resignation Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyResignations', 'राजीनामा प्रमाणित गर्नुहोस्');--Verify Resignations
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Resignations', 'राजीनामाहरु');--Resignations
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state', 'राज्य');--State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_id', 'राज्य Id');--State Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_code', 'राज्य कोड');--State Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_name', 'राज्यको नाम');--State Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateState', 'राज्य बनाउनुहोस्');--Create State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_sales_tax', 'राज्य बिक्री कर');--State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StateSalesTax', 'राज्य बिक्री कर');--State Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_sales_tax_id', 'राज्य बिक्री कर Id');--State Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_sales_tax_code', 'राज्य बिक्री कर कोड');--State Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'state_sales_tax_name', 'राज्य बिक्री करको नाम');--State Sales Tax Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateStateSalesTax', 'राज्य बिक्री कर बनाउनुहोस्');--Create State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StateSalesTaxes', 'राज्य बिक्री करहरु');--State Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'States', 'राज्यहरु');--States
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'finished_good_store', 'पूर्ण मालको स्टोर');--Finished Good Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'nationality', 'राष्ट्रियता');--Nationality
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Nationalities', 'राष्ट्रियता');--Nationalities
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Nationality', 'राष्ट्रियता');--Nationality
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'nationality_code', 'राष्ट्रियता कोड');--Nationality Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'nationality_name', 'राष्ट्रियताको नाम');--Nationality Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'remote_user', 'रिमोट प्रयोगकर्ता');--Remote User
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Reset', 'रिसेट गर्नुहोस्');--Reset
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'preferred_shipping_package_shape', 'रुचाइएका ढुवानी प्याकेज आकृति');--Preferred Shipping Package Shape
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'preferred_shipping_mail_type', 'रुचाइएका ढुवानी मेल टाइप');--Preferred Shipping Mail Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'preferred_shipping_mail_type_id', 'रुचाइएका ढुवानी मेल प्रकार Id');--Preferred Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'preferred_supplier', 'रुचाइएको बितरक');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreferredSupplier', 'रुचाइएको बितरक');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'preferred_supplier_id', 'रुचाइएको बितरक Id');--Preferred Supplier Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreferredSupplierIdAbbreviated', 'रुचाइएको बितरक Id');--Pref SupId
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax', 'रोजगार कर');--Employment Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentTax', 'रोजगार कर Id');--Employment Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentTaxes', 'रोजगार कर कोड');--Employment Taxes
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_id', 'रोजगार कर Id');--Employment Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_code', 'रोजगार कर कोड');--Employment Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_name', 'रोजगार करको नाम');--Employment Tax Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentTaxDetails', 'रोजगार कर विवरण कोड');--Employment Tax Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_detail_id', 'रोजगार कर विवरण Id');--Employment Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_detail_code', 'रोजगार कर विवरण कोड');--Employment Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_tax_detail_name', 'रोजगार कर विवरणको नाम');--Employment Tax Detail Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentInformation', 'रोजगार स्थिति कोड');--Employment Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_status_id', 'रोजगार स्थिति Id');--Employment Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_status_code', 'रोजगार स्थिति कोड');--Employment Status Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentStatusCodes', 'रोजगार स्थितिको नाम');--Employment Status Codes
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_status_code_id', 'रोजगार स्थिति कोड Id');--Employment Status Code Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_status_name', 'रोजगार स्थितिको नाम');--Employment Status Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentStatuses', 'रोजगारदाता योगदान दर');--Employment Statuses
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employer_tax_rate', 'रोजगारदाता कर दर');--Employer Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employer_contribution_rate', 'रोजगारदाता योगदान दर');--Employer Contribution Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'employment_status', 'रोजगारी अवस्था');--Employment Status
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmploymentStatus', 'लगिन Id');--Employment Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'login_date_time', 'लगइन मिति समय');--Login Date Time
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'login_id', 'लगिन Id');--Login Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LunchDeduction', 'लन्च कटौती');--Lunch Deduction
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'length_in_centimeters', 'लम्बाइ (सेन्टिमिटर मा)');--Length In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lifetime_capacity', 'लाइफटाइम क्षमता');--Lifetime Capacity
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CostCenter', 'लागत केन्द्र');--Cost Center
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CostCenters', 'लागत केन्द्र');--Cost Centers
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_center_id', 'लागत केन्द्र Id');--Cost Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_center_code', 'लागत केन्द्र कोड');--Cost Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_center_name', 'लागत केन्द्रको नाम');--Cost Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_price', 'लागत मूल्य');--Cost Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cost_price_includes_tax', 'लागत मूल्यमा कर समावेश');--Cost Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'applied_on', 'मा लागू ');--Applied On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_benefit_id', 'बिदा लाभ Id');--Leave Benefit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'leave_benefit_code', 'बिदा लाभ कोड');--Leave Benefit Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProfitOrLoss', 'नाफा वा नोक्सान ');--Profit or Loss
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'gender_code', 'लिङ्ग कोड');--Gender Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'gender_name', 'लिङ्ग नाम');--Gender Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Gender', 'लिङ्ग');--Gender
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Genders', 'लिङ्ग');--Genders
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ChartOfAccounts', 'खाता को चार्ट');--Chart of Accounts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee', 'लेट शुल्क');--Late Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee_id', 'लेट शुल्क Id');--Late Fee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee_code', 'लेट शुल्क कोड');--Late Fee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee_name', 'लेट शुल्कको नाम');--Late Fee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee_posting_frequency', 'लेट शुल्क पोस्टिंग बारम्बारता');--Late Fee Posting Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'late_fee_posting_frequency_id', 'लेट शुल्क पोस्टिंग बारम्बारता Id');--Late Fee Posting Frequency Id
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotMergeUrlNull', 'लेनदेन मर्ज गर्न सक्नुहुन्न। मर्ज URL प्रदान गरिएको छैन ।');--Cannot merge transactions. The merge url was not provided.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionPostedSuccessfully', 'लेनदेन सफलतापूर्वक पोस्ट भएको थियो।');--The transaction was posted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'TransactionWithdrawnMessage', 'लेनदेन सफलतापूर्वक फिर्ता भएको थियो। यसबाहेक, यो कार्यले  "{0}"  मा र पछि निकालिएको सबै रिपोर्टमा असर गर्नेछ।');--The transaction was withdrawn successfully. Moreover, this action will affect the all the reports produced on and after "{0}".
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'UploadLogo', 'लोगो अपलोड गर्नुहोस्।');--Upload logo.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'logo_file', 'लोगो फाइल');--Logo File
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Load', 'लोड');--Load
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Loading', 'लोड हुदैछ');--Loading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'weight_in_grams', 'वजन (ग्राम मा)');--Weight In Grams
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_period', 'वर्तमान अवधि');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrentPeriod', 'वर्तमान अवधि');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrentIP', 'वर्तमान IP');--Current IP
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_job_title_id', 'वर्तमान कार्य शीर्षक Id');--Current Job Title Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrentPassword', 'वर्तमान पासवर्ड');--Current Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_pay_grade_id', 'वर्तमान भुक्तनी ग्रेड Id');--Current Pay Grade Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrentBookDate', 'वर्तमान बुक मिति');--Current Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_role_id', 'वर्तमान भूमिका Id');--Current Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_employment_status_id', 'वर्तमान रोजगार स्थिति Id');--Current Employment Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_employment_status_code_id', 'वर्तमान रोजगार स्थिति कोड Id');--Current Employment Status Code Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CurrentLoginOn', 'वर्तमान लगइनमा ');--Current Login On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_department', 'वर्तमान विभाग');--Current Department
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_department_id', 'वर्तमान विभाग Id');--Current Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'current_shift_id', 'वर्तमान सिफ्ट Id');--Current Shift Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Year', 'वर्ष');--Year
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EndOfYearProcessing', 'वस्तु अवलोकन');--End of Year Processing
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item', 'वस्तु');--Item
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemOverview', 'वस्तु अवलोकन');--Item Overview
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'produced_item', 'उत्पादित वस्तु');--Produced Item
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProducedItem', 'उत्पादित वस्तु');--Produced Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'compound_item', ' कम्पाउन्ड वस्तु');--Compound Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_code', 'वस्तु कोड');--Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'items_item_code_uix', 'दोहोरो वस्तु कोड ।');--Duplicate item code.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_variant_id', 'वस्तु चल Id');--Item Variant Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_variant_code', 'वस्तु चल कोड');--Item Variant Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_variant_name', 'वस्तु चल नाम');--Item Variant Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_variant_detail_id', 'वस्तु चल विवरण Id');--Item Variant Detail Id
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ItemDuplicated', 'वस्तु दोहोरो थियो ।');--Item was duplicated.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_name', 'वस्तुको नाम');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_type_id', 'वस्तु प्रकार Id');--Item Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_type_code', 'वस्तु प्रकार कोड');--Item Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_type_name', 'वस्तु प्रकारको नाम');--Item Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemSellingPrices', 'वस्तु बिक्री मूल्य');--Item Selling Prices
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_selling_price_id', 'वस्तु बिक्री मूल्य Id');--Item Selling Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_cost_price_id', 'वस्तु लागत मूल्य Id');--Item Cost Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_group', 'वस्तु समूह');--Item Group
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_group_id', 'वस्तु समूह Id');--Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_group_code', 'वस्तु समूह कोड');--Item Group Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'item_group_name', 'वस्तु समूहको नाम');--Item Group Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateItemGroups', 'वस्तु समूह बनाउनुहोस्');--Create Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemTypes', 'वस्तुका प्रकारहरू');--Item Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemGroups', 'वस्तुका समूहहरू');--Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemCode', 'वस्तुको कोड');--Item Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemId', 'वस्तुको Id');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemInformation', 'वस्तुको जानकारी');--Item Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'object_name', 'वस्तुको नाम');--Object Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemName', 'वस्तुको नाम');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'items_item_name_uix', 'दोहोरो वस्तुको नाम।');--Duplicate item name.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemType', 'वस्तुको प्रकार');--Item Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemCostPrices', 'वस्तुको लागत मूल्य');--Item Cost Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemGroup', 'वस्तुको समूह');--Item Group
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Items', 'वस्तुहरू');--Items
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ListItems', 'वस्तुहरूको सूची');--List Items
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Actual', 'वास्तविक');--Actual
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5010', 'विगत दिनांकित लेनदेनको अनुमति छैन।');--Past dated transactions are not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5103', 'विगत मितिका कारोबार(हरु) रुजु तथा प्रमाणिकरण पङ्क्तिमा छन् ।');--Past dated transactions in verification queue.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Widget', 'विजेट');--Widget
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Widgets', 'विजेटहरु');--Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WidgetManager', 'विजेट प्रबन्धक');--Widget Manager
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesDeliveryNote', 'वितरण टिप्पणी');--Delivery Note
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Delivered', 'वितरित');--Delivered
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'DeliveredTo', 'को लागि वितरित');--Delivered To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FiscalYear', 'पूर्णांकीकरण विधि कोड');--Fiscal Year
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'foreign_currency_code', 'विदेशी मुद्रा कोड');--Foreign Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'rounding_method_code', 'पूर्णांकीकरण विधि कोड');--Rounding Method Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exchange_rate', 'विनिमय दर');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExchangeRate', 'विनिमय दर (देश मुद्रामा)');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExchangeRates', 'विनिमय दर (बेस मुद्रामा)');--Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ERToHomeCurrency', 'विनिमय दर (देश मुद्रामा)');--Exchange Rate (To Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ERToBaseCurrency', 'विनिमय दर (बेस मुद्रामा)');--Exchange Rate (To Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UpdatedExchangeRates', 'विनिमय दर अपडेट गर्नुहोस्');--Update Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Manufacturing', 'विनिर्माण');--Manufacturing
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ManufacturingVerification', 'विनिर्माण प्रमाणिकरण');--Manufacturing Verification
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'GoToChecklistWindow', 'चेकलिस्ट विन्डोमा जानुहोस्।');--Go to checklist window.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'department', 'विभाग');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Department', 'विभाग');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Departments', 'विभागहरु');--Departments
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'department_id', 'विभाग Id');--Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'department_code', 'विभाग कोड');--Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'department_name', 'विभागको नाम');--Department Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_variant', 'विमत हो?');--Is Variant
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_variant_of', 'को विमत हो');--Is Variant Of
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'description', 'विवरण');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'details', 'विवरण');--Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Description', 'विवरण');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'statement_reference', 'विवरण सन्दर्भ');--Statement Reference
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4001', 'विविध तलब कर गणना हुने कर्मचारीको तलब प्रक्रिया अघि बढ्न सक्दैन ।');--Cannot process salary when the employee has multiple salary taxes.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P4002', 'विविध रोजगार कर गणना हुने कर्मचारीको तलब प्रक्रिया अघि बढ्न सक्दैन।');--Cannot process salary when the employee has multiple employment taxes.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WorldSalesStatistics', 'विश्व बिक्री तथ्याङ्क');--World Sales Statistics
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'website', 'वेबसाइट');--Website
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'relationship_officer_name', 'सम्बन्धित अधिकारीको नाम');--Relationship Officer Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'marital_status', 'वैवाहिक स्थिति');--Marital Status
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MaritalStatus', 'वैवाहिक स्थिति');--Marital Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'marital_status_id', 'वैवाहिक स्थिति Id');--Marital Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'marital_status_code', 'वैवाहिक स्थिति कोड');--Marital Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'marital_status_name', 'वैवाहिक स्थितिको नाम');--Marital Status Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MaritalStatuses', 'वैवाहिक स्थितिहरु');--Marital Statuses
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'personal_exemption', 'व्यक्तिगत छुट');--Personal Exemption
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PersonalInformation', 'व्यक्तिगत जानकारी');--Personal Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'expense_account', 'व्यय खाता');--Expense Account
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'ThankYouForYourBusiness', 'व्यवसाय को लागि तपाईंलाइ धन्यवाद।');--Thank you for your business.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_admin', 'व्यवस्थापक हो?');--Is Admin
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'merchant_account', 'व्यापारी खाता');--Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'merchant_account_id', 'व्यापारी खाता Id');--Merchant Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_merchant_account', 'व्यापारी खाता हो?');--Is Merchant Account
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MerchantFeeInPercent', 'व्यापारी शुल्क ( प्रतिशत मा )');--Merchant Fee (In percent)
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5113', 'व्यापारी शुल्क खर्च पोस्ट गर्न को लागि कुनै खाता फेला परेन।');--Could not find an account to post merchant fee expenses.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MerchantFeeSetup', 'व्यापारी शुल्क सेटअप');--Merchant Fee Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'merchant_fee_setup_id', 'व्यापारी शुल्क सेटअप Id');--Merchant Fee Setup Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Saturday', 'शनिबार');--Saturday
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'city', 'शहर');--City
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EducationLevel', 'शिक्षा स्तर');--Education Level
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EducationLevels', 'शिक्षा स्तर');--Education Levels
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'education_level_id', 'शिक्षा स्तर Id');--Education Level Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'education_level_name', 'शिक्षा स्तरको नाम');--Education Level Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateEducationLevels', 'शिक्षा स्तर बनाउनुहोस्');--Create Education Levels
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cst_number', 'CST नम्बर');--CST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CSTNumber', 'CST नम्बर');--CST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'title', 'शीर्षक');--Title
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Untitled', 'शीर्षक नभएको');--Untitled
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Friday', 'शुक्रवार');--Friday
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'charge_interest', 'ब्याज लाग्ने');--Charge Interest
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IncludeZeroBalanceAccounts', 'शून्य शेष खाताहरू समावेश छ');--Include Zero Balance Accounts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'balance', 'शेष');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Balance', 'शेष');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BalanceSheet', 'वासलात');--Balance Sheet
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'hard_of_hearing', 'कम सुन्ने');--Hard Of Hearing
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_country', 'संपर्क देश');--Contact Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_state', 'संपर्क राज्य');--Contact State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_city', 'संपर्क शहर');--Contact City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_street', 'संपर्क सडक');--Contact Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_cell', 'संपर्क सेल');--Contact Cell
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AttachmentParameters', 'संलग्नको मापदण्ड');--Attachment Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AttachmentsPlus', 'संलग्नहरू (+)');--Attachments (+)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UploadAttachments', 'संलग्नहरू अपलोड गर्नुहोस्');--Upload Attachments
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'revision_code', 'संशोधन कोड');--Revision Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'revision_number', 'संशोधन नम्बर');--Revision Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VersionName', 'संस्करणको नाम');--Version Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'culture', 'संस्कृति');--Culture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'institution', 'संस्था');--Institution
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'organization_name', 'संस्थाको नाम');--Organization Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Entities', 'सडक');--Entities
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_active', 'सक्रिय हो?');--Is Active
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'street', 'सडक');--Street
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Alerts', 'सतर्कता');--Alerts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'reference_number', 'सन्दर्भ संख्या');--Reference Number
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'reference_number', 'सन्दर्व अंक् ');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Message', 'सन्देश');--Message
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SuccessfullyUpdated', 'सफलतापूर्वक अपडेट भयो');--Successfully Updated
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'AllFieldsRequired', 'सबै क्षेत्रहरू आवश्यक छन् ।');--All fields are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CheckAll', 'सबै छनोट गर्नुहोस्');--Check All
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'lead_time_in_days', 'मुख्य समय(दिनमा)');--Lead Time In Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cool_down_time_in_minutes', 'चिसो हुने समय(मिनेटमा)');--Cool Down Time In Minutes

SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'recurs_on_same_calendar_date', 'सोही क्यालेण्डर मितिमा पुनरावृत्ति हुन्छ');--Recurs on Same Calendar Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'termination_id', 'निलम्बन Id');--Termination Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'finished_good_store_id', 'पूर्ण मालको स्टोर Id');--Finished Good Store Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FinishedGoodsStore', 'सम्झौता प्रमाणित गर्नुहोस्');--Finished Goods Store
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Adjustment', 'समायोजन');--Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyContracts', 'सम्झौता प्रमाणित गर्नुहोस्');--Verify Contracts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_po_box', 'सम्पर्क PO Box');--Contact Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_email', 'सम्पर्क इमेल');--Contact Email
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ContactInformation', 'सम्पर्क जानकारी');--Contact Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_number', 'सम्पर्क नम्बर');--Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_phone', 'सम्पर्क फोन');--Contact Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'contact_person', 'सम्पर्क व्यक्ति');--Contact Person
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Edit', 'सम्पादन गर्नुहोस्');--Edit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EditAndSend', 'सम्पादनगर्नुहोस् र पठाउनुहोस्');--Edit & Send
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EditAndReceive', 'सम्पादनगर्नुहोस् र प्राप्तगर्नुहोस्');--Edit & Receive
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'relname', 'सम्बन्धको नाम');--Relation Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'sort', 'क्रमबद्ध गर्नुहोस्');--Sort
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ChangeSideWhenNegative', 'नकारात्मकहुँदा साइड परिवर्तन गर्नुहोस्');--Change Side When Negative
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'exit_interview_details', 'अवकाश साक्षात्कार विवरण');--Exit Interview Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InstrumentCode', 'साधन कोड');--Instrument Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOM', 'सामानको बिल');--Bill of Materials
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BillOfMaterials', 'सामानको बिल');--Bill of Materials
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOMVerification', 'सामानको बिल रूजु');--Bill of Materials Verification
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'material_store', 'सामाग्री स्टोर');--Material Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'material_store_id', 'सामाग्री स्टोर Id');--Material Store Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SocialNetworks', 'सामाजिक संजालहरु');--Social Networks
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'social_network_id', 'सामाजिक सञ्जाल Id');--Social Network Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'social_network_name', 'सामाजिक सञ्जालको नाम');--Social Network Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SocialNetworkDetails', 'सामाजिक सञ्जालको विवरण');--Social Network Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GoodsReceiptNote', 'सामानको रसिद नोट');--Goods Receipt Note
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GeneralInformation', 'सामान्य जानकारी');--General Information
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'normally_debit', 'सामान्यतया डेबिट');--Normally Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'is_summary', 'सारांश हो?');--Is Summary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shift', 'सिफ्ट');--Shift
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shift_id', 'सिफ्ट Id');--Shift Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shift_code', 'सिफ्ट कोड');--Shift Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shift_name', 'सिफ्टको नाम');--Shift Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreatedOn', 'सिर्जना भएको');--Created On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateItemOrService', 'वस्तु वा सेवा बनाउनुहोस्');--Create Item or Service
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotCreateFlagTransactionTableNull', 'फ्लाग बनाउन वा अध्यावधिक गर्न सकिदैन। कारोबार तालिका प्रदान गरिएको छैन ।');--Cannot create or update flag. Transaction table was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CannotCreateFlagTransactionTablePrimaryKeyNull', 'फ्लाग बनाउन वा अध्यावधिक गर्न सकिदैन। कारोबार तालिकाको मुख्य  प्रदान गरिएको छैन ।');--Cannot create or update flag. Transaction table primary key was not provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5208', 'सुरवात मिति अन्तिम मिति भन्दा ठूलो हुन सक्दैन।');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Start', 'सुरु');--Start
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'StartDateGreaterThanEndDate', 'सुरुवात मिति अन्तिम मिति भन्दा ठूलो हुन सक्दैन।');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'start_date', 'सुरूवात मिति');--Start Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'notice_date', 'सूचना मिति');--Notice Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Notifications', 'सूचनाहरू');--Notifications
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'inventory_account_id', 'सूची खाता Id');--Inventory Account Id
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'OpeningInventoryAlreadyEntered', 'यो कार्यालयको मालसामान अ.ल्या. हिसाब प्रबिष्टि भर्इसकेको छ।');--Opening inventory has already been entered for this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'cell', 'सेल');--Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'service_end_date', 'सेवा समाप्ति मिति');--Service End Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Monday', 'सोमवार');--Monday
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'maintain_stock', 'स्टक कायम गर्छ');--Maintain Stock
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransaction', 'स्टक कारोबार');--Stock Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockDetails', 'स्टक विवरण');--Stock Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockAdjustment', 'स्टक समायोजन');--Stock Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransferRequest', 'स्टक स्थानान्तरण अनुरोध');--Stock Transfer Request
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5003', 'स्टक स्थानान्तरण अनुरोधले डेबिट प्रविष्टिहरू मात्र समावेश गर्न सक्छ।');--Stock transfer request can only contain debit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5005', 'स्टक स्थानान्तरण गर्न सक्नुहुन्न किनभने वितरणमा बिक्रिबस्तुको जानकारी फेला परेन।');--Cannot receive a stock transfer because the delivery contains no item.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransferJournal', 'स्टक स्थानान्तरण जर्नल');--Stock Transfer Journal
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransferAuthorization', 'स्टक स्थानान्तरण प्रमाणीकरण');--Stock Transfer Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransferDelivery', 'स्टक स्थानान्तरण वितरण');--Stock Transfer Delivery
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5004', 'स्टक स्थानान्तरण वितरणले क्रेडिट प्रविष्टिहरू मात्र समावेश गर्न सक्छ।');--Stock transfer delivery can only contain credit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5201', 'स्टक समायोजन प्रविष्टिले डेबिट बस्तुहरु समावेश गर्न सक्दैन ।');--A stock adjustment entry can not contain debit item(s).
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store', 'स्टोर');--Store
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Store', 'स्टोर');--Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_id', 'स्टोर Id');--Store Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_code', 'स्टोर कोड');--Store Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectStore', 'स्टोर चयन गर्नुहोस्');--Select Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_name', 'स्टोरको नाम');--Store Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_type', 'स्टोर प्रकार');--Store Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_type_id', 'स्टोर प्रकार Id');--Store Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_type_code', 'स्टोर प्रकार कोड');--Store Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'store_type_name', 'स्टोर प्रकारको नाम');--Store Type Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'CreateStores', 'स्टोर बनाउनुहोस्');--Create Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StoreName', 'स्टोरको नाम');--Store Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StoreTypes', 'स्टोरको प्रकार');--Store Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Stores', 'स्टोरहरु');--Stores
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'column_name', 'स्तम्भको नाम');--Column Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ColumnName', 'स्तम्भको नाम');--Column Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Termination', 'निलम्बन');--Termination
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Terminations', 'निलम्बनहरू');--Terminations
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyTerminations', 'निलम्बनहरू प्रमाणित गर्नुहोस्');--Verify Terminations
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MigratingFiles', 'स्थानन्तरण फाइलहरू');--Migrating Files
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransferDetails', 'स्थानान्तरण विवरण');--Transfer Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'installation_date', 'स्थापना मिति');--Installation Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'status', 'स्थिति');--Status
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Condition', 'स्थिति');--Condition
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Status', 'स्थिति');--Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'status_code', 'स्थिति कोड');--Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'status_code_name', 'स्थिति कोडको नाम');--Status Code Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'change_status_code_to', 'स्थिति कोडलाई परिवर्तन कोड गर्नुहोस्');--Change Status Code To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'change_status_to', 'स्थिति परिवर्तन गर्नुहोस्');--Change Status To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Clear', 'स्पष्ट');--Clear
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'resource', 'स्रोत');--Resource
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'resource_id', 'स्रोत Id');--Resource Id



SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5207', 'स्रोत र गन्तव्य स्टोर एउटै हुन सक्दैनन्।');--The source and the destination stores cannot be the same.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SourceStore', 'स्टोरस्रोत');--Source Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'self_verification_limit', 'स्वयम प्रमाणिकरण सीमा');--Self Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'can_self_verify', 'स्वयम प्रमाणित गर्न सक्नुहुन्छ');--Can Self Verify
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5910', 'स्वयम रुजु वा प्रमाणिकरण सीमा नाघेको छ। कारोबार रुजु वा प्रमाणित भएको छैन।');--Self verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AutomaticallyApprovedByWorkflow', 'स्वचालित रूपमा कार्यप्रवाह द्वारा स्वीकृत');--Automatically Approved by Workflow
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'autoanalyze_count', 'स्वतः विश्लेषण गणना');--Autoanalyze Count
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Accept', 'स्वीकार');--Accept
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Acknowledged', 'अनुमोदन गरिएको');--Acknowledged
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ApprovedTransactions', 'स्वीकृत कारोबार');--Approved Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WeekStartsOn', 'हप्ता सुरू');--Week Starts On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'week_day', 'हप्ताको दिन');--Week Day
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'week_day_id', 'हप्ताको दिन Id');--Week Day Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'week_start_day', 'हप्ताको सुरु दिन');--Week Start Day
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'day_of_week', 'हप्ताको दिन');--Day of Week
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'SalesOrderEmailSubject', 'हामीले तपाईंको PO  प्राप्त गर्यौ # { 0 }, { १ } ');--We received your PO #{0}, {1}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Yes', 'हो');--Yes
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'No', 'होइन');--No
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'uses_wheelchair', 'ह्वीलचेयर प्रयोग गर्छ?');--Uses Wheelchair
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3202', 'कर फारम मिलेन।');--Tax form mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P3501', 'स्तम्भ खाता Id खाली हुन हुदैन।');--The column account_id cannot be null.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P5100', 'यो स्थापनाले कारोबार पोस्टको अनुमति छैन।');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P6010', 'गलत कन्फिगरेसन: COGS विधि।');--Invalid configuration: COGS method.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8003', 'तपाईंले  म्याप गरिएको  जीएल खातामा फरक मुद्रा राख्न सक्नुहुन्न ।');--You cannot have a different currency on the mapped GL account.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8501', 'केवल एक स्तम्भ आवश्यक छ।');--Only one column is required.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P8502', 'स्तम्भ अद्यावधिक गर्न सक्नुहुन्न ।');--Cannot update column.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9013', 'प्रवेश निषेद! स्टॉक जर्नल कारोबारले धेरै शाखाहरू सन्दर्भ गर्न सक्दैन।');--Access is denied! A stock journal transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ne', 'P9201', 'प्रवेश निषेद। के तपाईं "transaction_details" तालिका अद्यावधिक गर्न सक्नुहुन्न।');--Acess is denied. You cannot update the "transaction_details" table.
SELECT * FROM localization.add_localized_resource('DbResource', 'ne', 'value_date', 'लागुहुने मिति');--Value Date
SELECT * FROM localization.add_localized_resource('Errors', 'ne', 'KeyValueMismatch', 'यो ListControl मा key/value वस्तुहरूको बेमेल गणना छ।');--There is a mismatching count of key/value items in this ListControl.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'AddNewUsersDescription', 'प्रयोगकर्ताहरु  बनाउनुहोस  र विभिन्न नीतिहरू जस्तै  मेनु पहुँच नीति र प्रमाणिकरण नीति परिभाषित गर्नुहोस्  ।');--Create users and define various policies such as menu access policy and verification policy.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateCountySalesTaxDescription', 'काउन्टी बिक्री कर तपाईंले  खरीद वा बिक्री गर्दा तपाईंलको काउन्टी सरकारले लगाएको प्रत्यक्ष खपत कर हो ।');--County sales tax is the direct consumption tax imposed by your county government when you make purchase or sales.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateFiscalYearDescription', 'आर्थिक वर्ष १२  महिनाको एक लेखा अवधि हो जुन्  वित्तीय विवरण तयार गर्न प्रयोग हुन्छ ।');--Fiscal year is an accounting period of 12 months, used to prepare financial statements.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateFrequenciesDescription', 'यो आर्थिक वर्ष थप १२ बारम्बारताहरुमा विभाजित गरिएको छ र  महिना, चौथाई, आर्थिक आधा वर्ष र आर्थिक वर्षको  रूपमा वर्गीकृत गरिएको छ ।');--The fiscal year is further divided into 12 frequencies, categorized as months, quarters, fiscal half, and fiscal year.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateItemGroupsDescription', 'वस्तु समुहले उस्तै सामान(वस्तु) हरू लार्इ अर्थपुर्ण रूपमा समुह, वर्गमा ब्यवस्थापन गर्छ।');--An item group allows you to manage similar inventory items into meaningful groups and categories.

SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreatePartiesDescription', '"पार्टी" भन्नाले तपाँर्इले कारोबार गर्ने ग्राहक, बिक्रेता वा एजेन्ट भन्ने बुझिन्छ।');--The term "party" collectively refers to customer, supplier, or agent you have business with.
SELECT * FROM localization.add_localized_resource('Labels', 'ne', 'CreateSalesTaxFormDescription', 'बिक्रिकर फारम प्रदेश कर, राज्य कर, कर छुट अादिको संयोजन हो।');--Sales tax form is a combination of various entities such as State Tax, County Tax, Exemption, etc.





















SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'auto_trigger_on_sales', 'स्वचालित रूपमा बिक्री मा ट्रिगर गर्नुहोस');--Automatically Trigger on Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'autovacuum_count', 'अटो भ्याकुम गणना');--Autovacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'began_on', 'सुरु भएको');--Began On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'bom_id', 'BOM Id');--BOM Id

SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'end_date', 'अन्त मिति');--End Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'ended_on', 'अन्त भएको मिति ');--Ended On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'ends_on', 'अन्त हुने मिति');--Ends On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'joined_on', 'कार्यरत हुने मिति');--Joined On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'key', 'प्रमुख');--Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'parent', 'अभिभावक');--Parent
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'role_id', 'भूमिका Id');--Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing', 'राउटिङ');--Routing
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_code', 'राउटिङ कोड्');--Routing Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_id', 'राउटिङ Id');--Routing Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_name', 'राउटिङको नाम');--Routing Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_sequence_code', 'राउटिङ अनुक्रम कोड');--Routing Sequence Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_sequence_id', 'राउटिङ अनुक्रम Id');--Routing Sequence Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_sequence_name', 'राउटिङ अनुक्रमको नाम');--Routing Sequence Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_type_code', 'राउटिङ प्रकार कोड');--Routing Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_type_id', 'राउटिङ प्रकार Id');--Routing Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'routing_type_name', 'राउटिङ प्रकारको नाम');--Routing Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_deduction_id', 'तलब कटौती Id');--Salary Deduction Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_frequency_id', 'तलब बारम्बारता Id');--Salary Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salary_from', 'तलब सुरु मिति');--Salary From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salesperson', 'बिक्रेता');--Salesperson
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salesperson_bonus_setup_id', 'बिक्रेता बोनस सेटअप Id');--Salesperson Bonus Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salesperson_code', 'बिक्रेता कोड');--Salesperson Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salesperson_id', 'बिक्रेता Id');--Salesperson Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'salesperson_name', 'बिक्रेताको नाम ');--Salesperson Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipper', 'सिपर');--Shipper
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipper_code', 'सिपर कोड');--Shipper Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipper_id', 'सिपर Id');--Shipper Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'shipper_name', 'सिपरको नाम');--Shipper Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'to_days', 'दिन सम्म');--To Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'valid_from', 'मान्य हुने बाट');--Valid From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'valid_till', 'मान्य हुने सम्म');--Valid Till
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'value', 'मान');--Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'value_date', 'लागुहुने मिति');--Value Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'variant_code', 'भेरियेन्ट कोड');--Variant Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'variant_id', 'भेरियेन्ट Id');--Variant Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'variant_name', 'भेरियेन्ट को नाम');--Variant Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ne', 'warm_up_time_in_minutes', 'तात्न लाग्ने समय(मिनेटमा)');--Warm Up Time In Minutes
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AgentBonusSlabs', 'बिक्रि गर्ने ब्यक्तिको लागि बोनस तह');--Bonus Slab for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AllTasks', 'सबै कार्यहरु');--All Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AmountInHomeCurrency', 'रकम ( देश मुद्रा मा)');--Amount (In Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Attendances', 'उपस्थित');--Attendances
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Attribute', 'विशेषता');--Attribute
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Attributes', 'विशेषताहरू');--Attributes
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'AutoVerificationPolicy', 'स्वतः प्रमाणिकरण नीति');--Autoverification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'BOMCode', 'BOM कोड');--BOMCode



SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EODConsole', 'EOD कंसोल');--EOD Console
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeExits', 'कर्मचारी अवकास');--Employee Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeIdentificationDetails', 'कर्मचारी पहिचान विवरण');--Employee Identification Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'EmployeeQualification', 'कर्मचारी योग्यता');--Employee Qualification
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Exit', 'अवकास');--Exit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExitType', 'अवकास प्रकार');--Exit Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExitTypes', 'अवकास प्रकारहरु');--Exit Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Exits', 'अवकास');--Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExportThisDocument', 'यो कागजात लैजानुहोस');--Export This Document
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ExportToDoc', 'Doc मा लैजानुहोस');--Export to Doc
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FIFO', 'First In, First Out (FIFO)');--First In, First Out (FIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FlagForegroundColor', 'अग्रभूमि रंग फ्लाग गर्नुहोस');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FlagThisTransaction', 'यो कारोबार फ्लाग गर्नुहोस');--Flag This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'FlaggedTransactions', 'फ्लाग गरिएको कारोबारहरु');--Flagged Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Flags', 'फ्लागहरु');--Flags
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ForDate', 'मितिको लागि');--For Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GlobalParameters', 'विश्व मापदंड');--Global Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GridView', 'ग्रिड दृश्य');--Grid View
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'GrossEarnings', 'कुल आय');--Gross Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'HundredthName', 'सयाैं नाम');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IdentificationDetails', 'पहिचान विवरण');--Identification Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IdentificationTypes', 'पहिचान प्रकार');--Identification Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InitializeDayEnd', 'दिन अन्त्य सुरु गर्नुहोस्');--Initialize Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InvalidDate', 'यो मान्य मिति होइन।');--This is not a valid date.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InvalidImage', 'यो मान्य प्रतिमा होइन।');--This is not a valid image.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InventoryAccountingSystem', 'सूची लेखा प्रणाली');--Inventory Accounting System
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InventoryAdvice', 'सूची सल्लाह');--Inventory Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'InventoryValuationMethod', 'सूची मूल्यांकन विधि');--Inventory Valuation Method
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IsCash', 'नगद हो?');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IsEmployee', 'कर्मचारी हो?');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IsParty', 'पार्टी हो?');--Is Party
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IsPresent', 'उपस्थित हो?');--Is Present
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'IssueMethod', 'मुद्दा विधि');--Issue Method
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemVariant', '');--Item Variant
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemVariantDetails', '');--Item Variant Details
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemVariants', '');--Item Variants
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ItemsBelowReorderLevel', '');--Items Below Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'JournalVoucherEntry', 'जर्नल भौचर प्रविष्टि');--Journal Voucher Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Kanban', 'कानबान');--Kanban
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'KanbanId', 'कानबान Id');--Kanban Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'KanbanName', 'कानबानको नाम');--Kanban Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'KanbanView', 'कानबान दृश्य');--Kanban View
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Kanbans', 'कानबानहरु');--Kanbans
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'KeyColumnEmptyExceptionMessage', '"KeyColumn" खाली हुन हुदैन।');--The property 'KeyColumn' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LIFO', 'Last In, First Out (LIFO)');--Last In, First Out (LIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LastAccessedOn', 'पछिल्लो पहुँच भएको मिति');--Last Accessed On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeadSources', '');--Lead Sources
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeadStatuses', '');--Lead Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LeadTime', '');--Lead Time
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LoggedInTo', 'लगइन मा');--Logged in to
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'LoginView', 'लगइन दृश्य');--Login View
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MenuText', 'मेनू टेक्स्ट');--Menu Text
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MergeBatchToGRN', 'ब्याचलाइ GRN मा मर्ज गर्नुहोस');--Merge Batch to GRN
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MergeBatchToSalesDelivery', 'ब्याचलाइ बिक्री वितरण मा मर्ज गर्नुहोस');--Merge Batch to Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MergeBatchToSalesOrder', 'ब्याचलाइ बिक्री आदेश मा मर्ज गर्नुहोस');--Merge Batch to Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MixERPDocumentation', 'MixERP दस्तावेज');--MixERP Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MixERPLinks', 'MixERP लिंक');--MixERP Links
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'MixERPParameters', 'MixERP मापदन्ड');--MixERP Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NewBookDate', 'नयाँ बुक मिति');--New Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NewJournalEntry', 'नयाँ जर्नल प्रविष्टि');--New Journal Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NonTaxableEarning', 'गैर करयोग्य कमाई');--Non Taxable Earning
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NonTaxableSales', 'गैर करयोग्य बिक्री');--Nontaxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NonVAT', 'गैर भ्याट');--Non VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'NormallyDebit', 'सामान्यतया डेबिट');--Normally Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeHour', 'कार्यालय समय');--Office Hour
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OfficeHours', 'कार्यालय समय');--Office Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OpenExchangeRatesParameters', 'खुला विनिमय दरको मापदण्डहरू');--OpenExchangeRates Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OpeningInventory', 'प्रारंभिक वस्तु सूची');--Opening Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'OtherWidgets', 'अन्य विजेट');--Other Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PLAppropriation', 'नाफा नोक्सान्  विनियोजन');--PL Appropriation
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ParentAccount', 'अभिभावक खाता');--Parent Account
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PerformEOD', 'EOD कार्य गर्नुहोस्');--Perform EOD
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PerformEODOperation', 'EOD अपरेसन गर्नुहोस्');--Perform EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PerformingEODOperation', 'EOD कार्य हुदैछ');--Performing EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PeriodicInventory', 'आवधिक सूची');--Periodic Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PerpetualInventory', 'स्थायी वस्तु सुची');--Perpetual Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PlaceReorderRequests', 'रिअर्डर अनुरोध गर्नुहोस');--Place Reorder Request(s)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Plant', 'प्लान्ट');--Plant
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Plants', 'प्लान्टहरु');--Plants
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PostedBy', 'पोस्टगर्ने व्यक्ति');--Posted By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PreparedOn', 'तयार गरिएको मिति');--Prepared On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PrintGlEntry', 'जीएल प्रविष्टि प्रिन्ट गर्नुहोस्');--Print GL Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ProfitAndLossStatement', 'नाफा र नोक्सान्  विवरण');--Profit & Loss Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'PublishedOn', 'प्रकाशित भएको मिति');--Published On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Rate', 'दर');--Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Rating', 'मूल्यांकन');--Rating
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceivedAmountInaboveCurrency', 'प्राप्त रकम (माथिको मुद्रा मा)');--Received Amount (In above Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReceivedBy', 'प्राप्त गर्ने व्यक्ति');--Received By
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Reconcile', 'मिलान');--Reconcile
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReferenceNumber', 'उल्लेख संख्या');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReferenceNumberAbbreviated', 'Ref#');--Ref#
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RefererenceNumberAbbreviated', 'Ref#');--Ref #
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RegionalDataIncludingCOA', 'क्षेत्रीय डाटा (खाता को चार्ट सहित)');--Regional Data (Including Chart of Accounts)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReleaseId', 'जारी Id');--Release Id
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RemoveAsDefault', 'पूर्वनिर्धारित रूपमा हटाउनुहोस्');--Remove As Default
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RemovingApplication', 'आवेदन हटाउँदै');--Removing Application
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReorderLevel', 'रिअर्डर चरण');--Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReorderQuantityAbbreviated', 'रिअर्डर मात्रा');--Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReorderUnitName', 'रिअर्डर एकार्इ नाम');--Reorder Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RestoringDirectories', 'निर्देशिकाहरु पुनर्स्थापित गर्दै');--Restoring Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RestoringMigrationFiles', 'माइग्रेसन फाइलहरू पुनर्स्थापित गर्दै');--Restoring Migration Files
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RestrictedTransactionMode', 'प्रतिबन्धित कारोबार मोड');--Restricted Transaction Mode
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RetainedEarnings', 'Retained Earnings');--Retained Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReturnHome', 'गृह पृष्ठमा फर्कनुहोस्');--Return Home
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ReturnToView', 'दृश्यमा फर्कनुहोस्');--Return to View
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Revision', 'संशोधन');--Revision
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Routing', 'राउटिङ');--Routing
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RoutingSequence', 'राउटिङ क्रम');--Routing Sequence
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RoutingSequences', 'राउटिङ क्रमहरु');--Routing Sequences
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RoutingType', 'राउटिङ प्रकार');--Routing Type
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'RoutingTypes', 'राउटिङ प्रकारहरु');--Routing Types
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SMTPConfiguration', 'SMTP कन्फिगरेसन');--SMTP Configuration
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SSTNumber', 'SST नम्बर');--SST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Salaries', 'तलब');--Salaries
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryTaxIncomeBracket', 'तलब कर आय ब्रैकेट');--Salary Tax Income Bracket
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalaryTaxIncomeBrackets', 'तलब कर आय ब्रैकेटहरु');--Salary Tax Income Brackets
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesByMonthInThousands', 'महिनामा बिक्री (हजार मा)');--Sales By Month (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SalesPersons', 'बिक्रेताहरू');--Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Salesperson', 'बिक्रेता');--Salesperson
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Save', 'सुरक्षित गर्नुहोस् ');--Save
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SaveOrder', 'अर्डर सुरक्षित गर्नुहोस् ');--Save Order
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SaveThisFilter', 'फिल्टर सुरक्षित गर्नुहोस् ');--Save this Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Saving', 'सुरक्षित गर्दै');--Saving
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ScrudFactoryParameters', 'ScrudFactory को मानदण्डहरू');--ScrudFactory Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectAColumn', 'एक स्तम्भ चयन गर्नुहोस् ');--Select a Column
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectBOM', 'BOM चयन गर्नुहोस् ');--Select BOM
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectExpensesGL', 'व्यय GL चयन गर्नुहोस् ');--Select Expenses GL
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectFlag', 'फ्ल्याग चयन गर्नुहोस्');--Select a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectForm', 'फारम चयन गर्नुहोस्');--Select a Form
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectGroup', 'समूह चयन गर्नुहोस्');--Select a Group
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectPLAppropriationAccount', 'नाफा नोक्सान विनियोजन खाता चयन गर्नुहोस्');--Select PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SelectSupplier', 'आपूर्तिकर्ता चयन गर्नुहोस्');--Select Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SetupEmail', 'इमेल सेटअप गर्नुहोस्');--Setup Email
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Shift', 'सिफ्ट');--Shift
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Shifts', 'सिफ्टहरु');--Shifts
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Shipper', 'ढुवानीकर्ता');--Shipper
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Shippers', 'ढुवानीकर्ताहरु');--Shippers
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShippingAddressMaintenance', 'ढुवानी ठेगाना बनाउनुहोस्');--Shipping Address Maintenance
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Show', 'देखाउने');--Show
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShowAll', 'सबै देखाऊने');--Show All
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ShowCompact', 'संकुचित देखाऊने');--Show Compact
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SignIn', 'साइन इन गर्नुहोस्');--Sign In
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SignOut', 'साइन आउट गर्नुहोस्');--Sign Out
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SigningIn', 'साइन इन हुँदैछ');--Signing In
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StatementReference', 'विवरण सन्दर्भ');--Statement Reference
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'StockTransferAcknowledgement', 'स्टक स्थानान्तरण अनुमोदन');--Stock Transfer Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SubTotal', 'जम्मा कुल');--Sub Total
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'SubmitBugs', 'बगहरू पेश गर्नुहोस्');--Submit Bugs
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Support', 'समर्थन गर्नुहोस्');--Support
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Switches', 'स्विच गर्नुहोस्');--Switches
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TableEmptyExceptionMessage', 'प्रोपर्टी ''तालिका'' खाली छोड्न सक्नुहुन्न।');--The property 'Table' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TableSchemaEmptyExceptionMessage', 'प्रोपर्टी ''तालिका स्कीमा'' खाली छोड्न सक्नुहुन्न।');--The property 'TableSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TagName', 'ट्यागको नाम');--Tag Name
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxAuthorities', 'कर अधिकारीहरु');--Tax Authorities
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxForm', 'कर फारम');--Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxMaster', 'कर मास्टर');--Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxSetup', 'कर सेटअप');--Tax Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxableEarning', 'कर योग्य कमाई');--Taxable Earning
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TaxableSales', 'कर योग्य बिक्री');--Taxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'To', 'लार्इ');--To
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ToPLAppropriationAC', 'नाफा नोक्सान विनियोजन खातामा');--To PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TopSellingProductsOfAllTime', 'अहिले सम्मको शीर्ष बिक्रि उत्पादन ');--Top Selling Products of All Time
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TotalDueAmount', 'कुल बक्याैता राशि');--Total Due Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TotalDueAmountCurrentOffice', 'कुल बक्याैता राशि (वर्तमान कार्यालय)');--Total Due Amount (Current Office)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TotalDueAmountInBaseCurrency', 'कुल बक्याैता राशि (आधार मुद्रा मा)');--Total Due Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TranCode', 'कारोबार कोड');--Tran Code
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TranIdParameter', 'कारोबार Id: #{0}');--TranId: #{0}
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TransactionValue', 'कारोबारको मान');--Transaction Value
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'TrialBalance', 'सन्तुलन परिक्षण');--Trial Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UncheckAll', 'सबै टिक हटाउनुहोस्');--Uncheck All
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Undo', 'अवस्था अनडू गर्नुहोस्');--Undo
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UnknownError', 'अज्ञात त्रुटिको करण सञ्चालन असफल भयो।');--Operation failed due to an unknown error.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Update', 'अद्यावधिक गर्नुहोस्');--Update
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UpdateAll', 'सम्पूर्णलाई अद्यावधिक गर्नुहोस्');--Update All
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UpdateConsole', 'कन्सोल अद्यावधिक गर्नुहोस्');--Update Console
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UpdatedOn', 'अद्यावधिक गरिएको मिति');--Updated On
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'UploadAttachmentsForThisTransaction', 'यो कारोबारको लागि संलग्नहरू अपलोड गर्नुहोस्');--Upload Attachments for This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Url', 'Url');--Url
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VATOrGST', 'VAT/GST');--VAT/GST
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VacuumDatabase', 'डाटाबेस भ्याक्युम गर्नुहोस्');--Vacuum Database
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VacuumFullDatabase', 'डाटाबेस भ्याक्युम गर्नुहोस् (पूर्ण)');--Vacuum Database (Full)
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Value', 'मान');--Value
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ValueDate', 'लागुहुने मिति');--Value Date
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Variant', 'चल');--Variant
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Variants', 'चल');--Variants
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifiedOn', 'प्रमाणित भएको मिति');--VerifiedOn
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyBOM', 'सामानको बिल रूजु गर्नुहोस');--Verify Bill of Materials
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyDisassemble', '');--Verify Disassemble
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyExits', 'अवकास प्रमाणित गर्नुहोस्');--Verify Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyManufacture', 'विनिर्माण प्रमाणित गर्नुहोस्');--Verify Manufacture
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'VerifyRouting', 'Verify Routing');--Verify Routing
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'View', 'दृश्य');--View
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewAttachments', 'संलग्नकहरु हेर्नुहोस्');--View Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewEmptyExceptionMessage', 'प्रोपर्टी ''दृश्य'' खाली छोड्न सक्नुहुन्न।');--The property 'View' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewSchemaEmptyExceptionMessage', 'प्रोपर्टी ''दृश्य स्कीमा'' खाली छोड्न सक्नुहुन्न।');--The property 'ViewSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'ViewThisAcknowledgement', 'यो अनुमोदन हेर्नुहोस् ');--View This Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WageSetups', 'ज्याला सेटअप');--Wage Setups
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WasPresent', 'उपस्थिति थियो?');--Was Present
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Withdraw', 'फिर्ता');--Withdraw
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WithdrawTransaction', 'कारोबार फिर्ता गर्नुहोस्');--Withdraw Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'Withdrawn', 'फिर्ता');--Withdrawn
SELECT * FROM localization.add_localized_resource('Titles', 'ne', 'WithdrawnTransactions', 'कारोबारहरु फिर्ता गर्नुहोस्');--Withdrawn Transactions
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'AccessIsDenied', 'प्रवेश निषेद।');--Access is denied.

SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CompareAmountErrorMessage', 'रकम बाट भन्दा रकम सम्म ठूलो हुन गर्नुपर्छ।');--The amount to should be greater than the amount from.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CompareDaysErrorMessage', 'दिन सम्म भन्दा दिन बाट कम हुन गर्नुपर्छ।');--From days should be less than to days.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CouldNotDetermineEmailImageParserType', 'इमेलको लागि प्रतिमा पार्सर प्रकार निर्धारण गर्न सकिएन।');--Could not determine image parser type for email.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'CouldNotRegisterJavascript', 'Could not register JavaScript on this page because the page instance was invalid or empty.');--Could not register JavaScript on this page because the page instance was invalid or empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'LateFeeErrorMessage', 'लेट शुल्क Id र लेट शुल्क पोस्टिङ बारम्बारता Id या त दुवै चयन गर्नुहोस् या दुवै चयन नगरनुहोस्।');--Late fee id and late fee posting frequency id both should be either selected or not.
SELECT * FROM localization.add_localized_resource('Warnings', 'ne', 'NegativeValueSupplied', 'नकारात्मक मान आपूर्ति गर्नुभयो।');--Negative value supplied.
