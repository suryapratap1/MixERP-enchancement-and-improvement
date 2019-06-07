/********************************************************************************************************************************************************
Contributors for this translation:
Nubiancc https://github.com/nubiancc

Arabic   ar  العربية
********************************************************************************************************************************************************/
DO
$$
BEGIN
    IF NOT EXISTS
    (
        SELECT 1
        FROM localization.cultures
        WHERE culture_code = 'ar'
    ) THEN
        INSERT INTO localization.cultures
        SELECT 'ar', 'Arabic';
    END IF;
END
$$
LANGUAGE plpgsql;

SELECT * FROM localization.add_localized_resource('CommonResource', 'ar', 'RequiredField', 'هذا حقل مطلوب.');--This is a required field.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P1301', 'لا يمكن حساب الفائدة. لم يتم توفير عدد الأيام في سنة.');--Cannot calculate interest. The number of days in a year was not provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P1302', 'لا يمكن ترحيل المبيعات. تعيين الحساب النقدي غير صالح في المخزن.');--Cannot post sales. Invalid cash account mapping on store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3000', 'بيانات غير صحيحة.');--Invalid data.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3001', 'اسم المستخدم غير صحيح.');--Invalid user name.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3005', 'لا يمكن أن تكون كلمة المرور فارغة.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3006', 'يرجى كتابة كلمة مرور جديدة.');--Please provide a new password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3007', 'قيمة تاريخ غير صالح.');--Invalid value date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3008', 'تاريخ غير صالح.');--Invalid date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3009', 'الفترة المحدد غير صالحة.');--Invalid period specified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3010', ' معرف الشركة غير صالح.');--Invalid office id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3011', 'شركة غير صالحة.');--Invalid office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3012', 'مخزن غير صالح.');--Invalid store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3013', 'خزينة غير صالحة.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3050', 'الطرف غير صالح.');--Invalid party.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3051', 'صنف غير صالح.');--Invalid item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3052', 'وحدة غير صالحة.');--Invalid unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3053', 'وحدة غير صالح أو غير متناسقة.');--Invalid or incompatible unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3054', 'وحدة اعادة الطلب غير متوافق مع وحدة الأساس.');--The reorder unit is incompatible with the base unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3055', 'سعر الصرف غير صالح.');--Invalid exchange rate.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3101', 'معرف المستخدم غير صالح.');--Invalid LoginId.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3105', 'كلمة المرور الحالية غير صحيحة.');--Your current password is incorrect.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3201', 'صنف/وحدة غير متطابق.');--Item/unit mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3202', 'نموذج ضريبة غير متطابق.');--Tax form mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3301', 'الكمية غير صالحة.');--Invalid quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3302', 'معرف المعاملة غير صالح.');--Invalid transaction id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P3501', 'عمود معرف _ الحساب لا يمكن أن يكون فارغ.');--The column account_id cannot be null.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4001', 'لا يمكن معالجة الراتب عندlما يكون الموظف له ضرائب متعددة.');--Cannot process salary when the employee has multiple salary taxes.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4002', 'لا يمكن معالجة الراتب عندما يكون للموظف ضرائب كسب عمل متعددة.');--Cannot process salary when the employee has multiple employment taxes.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4003', 'لا تستطيع ترحيل المرتب عندما يكون صافي المرتب أقل من الصفر.');--Cannot post salary because the net payment is less than zero.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4010', 'لم يتم العثور على سعر الصرف بين العملات.');--Exchange rate between the currencies was not found.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4020', 'لا يرتبط هذا الصنف مع هذه المعاملة.');--This item is not associated with this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4021', 'لا يمكن دمج معاملات أطراف مختلفة دفعة واحدة. حاول مرة اخرى.');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4022', 'المعاملات المحددة تحتوي علي اصناف تم دمجها من قبل. حاول مرة اخرى.');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4023', 'لا يمكن دمج المعاملات التي تحتوي علي أنواع  ضرائب غير المتوافقة. حاول مرة اخرى.');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4030', 'لا توجد سياسة التدقيق لهذا المستخدم.');--No verification policy found for this user.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P4031', ' يرجى الطلب من شخص ما للتحقق من المعاملات الخاصة بك.');--Please ask someone else to verify your transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5000', 'مراجع الجانبين ليست متساوية.');--Referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5001', 'غير مسموح بمخزون سالب.');--Negative stock is not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5002', 'يؤدي عرض هذه المعاملة رصيداً نقديا سلبيا.');--Posting this transaction would produce a negative cash balance.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5003', 'يمكن أن يتضمن طلب تحويل المخزون فقط إدخالات المدين.');--Stock transfer request can only contain debit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5004', 'يمكن أن يتضمن طلب تحويل المخزون فقط إدخالات الدائن.');--Stock transfer delivery can only contain credit entries.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5005', 'لا يمكن تلقي تحويل المخزون لان التسليم لا يحتوي على أي صنف.');--Cannot receive a stock transfer because the delivery contains no item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5010', 'غير مسموح بمعاملات بتاريخ سابق.');--Past dated transactions are not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5100', 'لا يسمح بترحيل الحركات في هذه الشركة.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5101', 'لا يمكن ترحيل حركة أثناء وضع الحركة مقيدة.');--Cannot post transaction during restricted transaction mode.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5102', 'عملية نهاية اليوم تم تنفيذها بالفعل.');--End of day operation was already performed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5103', 'المعاملات بتاريخ سابق في انتظار التحقق.');--Past dated transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5104', 'الرجاء التحقق من المعاملات قبل القيام بعملية نهاية اليوم.');--Please verify transactions before performing end of day operation.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5105', 'لا تزال هناك حركات في انتظار التحقق.');--There are still transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5106', 'لا يمكنك القيام بتخصيص الربح والخسارة في مجموعة الشركة');--You cannot perform PL appropriation on an office group.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5110', 'لا يمكن توفير معلومات ضريبة المبيعات للمبيعات غير الخاضعة للضريبة.');--You cannot provide sales tax information for non taxable sales.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5111', 'المعلومات المقدمة للمعاملة البنكية غير صالحة.');--Invalid bank transaction information provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5112', 'معلومات بطاقة الدفع غير صالحة.');--Invalid payment card information.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5113', 'تعذر العثور على حساب رسوم تاخير تاجر.');--Could not find an account to post merchant fee expenses.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5201', 'لا يمكن أن يحتوي على إدخال تسوية المخزون علي صنف مدين (اصناف).');--A stock adjustment entry can not contain debit item(s).
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5202', 'يمكن أن يظهر الصنف مرة واحدة فقط في المخزن.');--An item can appear only once in a store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5203', 'لا يمكن أن تكون الكمية التي تم إرجاعها أكبر من الكمية الفعلية.');--The returned quantity cannot be greater than actual quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5204', 'لا يمكن أن يكون المبلغ الذي تم إرجاعه أكبر من المبلغ الفعلي.');--The returned amount cannot be greater than actual amount.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5205', 'لا يمكن توفير  أكثر من مخزن واحد لهذه الحركة.');--You cannot provide more than one store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5206', 'لا يمكن اختيار أكثر من مخزن واحد لهذه الحركة.');--You cannot provide more than one delivery destination store for this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5207', 'المخزن المصدر والمخزن والوجهة لا يمكن أن تكون هي نفسها.');--The source and the destination stores cannot be the same.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5208', 'لا يمكن أن يكون تاريخ البدء أكبر من تاريخ الانتهاء.');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5301', 'المعاملات غير صالحة أو المرفوضة.');--Invalid or rejected transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5500', 'كمية الصنف غير كافية.');--Insufficient item quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5800', 'غير مسموح بحذف حركة. اجعل الحركة مرفوضة بدلاً من ذلك.');--Deleting a transaction is not allowed. Mark the transaction as rejected instead.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5901', 'الرجاء أطلب من شخص آخر للتحقق من المعاملات التي قمت بنشرها.');--Please ask someone else to verify the transaction you posted.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5910', 'تم تجاوز حد التحقق الذاتي. عدم التحقق من المعاملة.');--Self verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5911', 'تم تجاوز حد تحقق المبيعات. عدم التحقق من المعاملة.');--Sales verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5912', 'تم تجاوز حد تحقق الشراء. عدم التحقق من المعاملة.');--Purchase verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P5913', 'تم تجاوز حد تحقق الاستذ العام. عدم التحقق من المعاملة.');--GL verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P6010', 'اعدادات غير صالحة: أسلوب COGS.');--Invalid configuration: COGS method.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8001', 'لا يمكن إصدار بيان الارباح والخسائر للشركة (الشركات) التي لها قاعدة بيانات مختلفة.');--Cannot produce P/L statement of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8002', 'لا يمكن اصدار ميزان المراجعة للشركة (الشركات) التي لها قاعدة بيانات مختلفة.');--Cannot produce trial balance of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8003', 'لا يمكن أن يكون هناك عمله مختلفة عن عملة حساب الاستاذ العام المعينة.');--You cannot have a different currency on the mapped GL account.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8101', 'تم بالفعل تهيئة عملية نهاية اليوم.');--EOD operation was already initialized.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8501', 'مطلوب عمود واحد فقط.');--Only one column is required.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8502', 'لا يمكن تحديث عمود.');--Cannot update column.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8990', 'غير مسموح لك بتغيير حساب النظام Sys.');--You are not allowed to change system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8991', 'غير مسموح لك إضافة حساب النظام Sys.');--You are not allowed to add system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P8992', 'لا يمكن أن يكون للمستخدم sys كلمة مرور.');--A sys user cannot have a password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9001', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9010', 'تم رفض الوصول. غير مسموح لك بترحيل هذه الحركة.');--Access is denied. You are not authorized to post this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9011', 'تم رفض الوصول. قمت بادخال قيم غير صالحة.');--Access is denied. Invalid values supplied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9012', 'تم رفض الوصول! حركة تسوية مخزون لا يمكن مراجعتها لفروع متعددة.');--Access is denied! A stock adjustment transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9013', 'تم رفض الوصول! حركة دفتر يومية المخزون لا يمكن مراجعتها لفروع متعددة..');--Access is denied! A stock journal transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9014', 'تم رفض الوصول. لا يمكنك التحقق من صفقة شركة او فرع آخر.');--Access is denied. You cannot verify a transaction of another office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9015', 'تم رفض الوصول. لا يمكنك تحقق الحركات بتاريخ سابق او لاحق.');--Access is denied. You cannot verify past or futuer dated transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9016', 'تم رفض الوصول. ليس لك صلاحيات لتحقق هذه الحركة.');--Access is denied. You don''t have the right to verify the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9017', 'تم رفض الوصول. ليس لك صلاحيات لسحب هذه الحركة.');--Access is denied. You don''t have the right to withdraw the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9201', 'وصول مرفوض. لا يمكنك تحديث الجدول "transaction_details".');--Acess is denied. You cannot update the "transaction_details" table.
SELECT * FROM localization.add_localized_resource('DbErrors', 'ar', 'P9250', 'تم رفض الوصول. تم رفض هذه الحركة بواسطة المسؤول .');--Access is denied. This transaction was rejected by administrator.
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'actions', 'الإجراءات');--Actions
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'amount', 'المبلغ');--Amount
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'currency', 'عملة');--Currency
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'flag_background_color', 'لون خلفية العلامة');--Flag Background Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'flag_foreground_color', ' اللون الأمامي للعلامة');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'id', 'معرف');--ID
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'office', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'party', 'الطرف');--Party
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'reference_number', 'رقم مرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'statement_reference', 'مرجع البيان');--Statement Reference
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'transaction_ts', 'الطابع الزمني للحركة');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'user', 'المستخدم');--User
SELECT * FROM localization.add_localized_resource('DbResource', 'ar', 'value_date', 'قيمة التاريخ');--Value Date
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'BothSidesCannotHaveValue', 'كلا الدائن والمدين ليس له قيمة.');--Both debit and credit cannot have values.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CannotDetermineAppDirectoryPath', 'لا يمكن تحديد مسار دليل التطبيق.');--Cannot determine application directory path.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CannotDetermineFileFromDownloadUrl', 'لا يمكن تحديد اسم الملف من عنوان url التحميل.');--Cannot determine filename from the download URL.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'CompoundUnitOfMeasureErrorMessage', 'لا يمكن أن يكون معرف وحدة الأساس هو معرف وحدة المقارنة.');--Base unit id and compare unit id cannot be same.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InsufficientStockWarning', 'فقط {0} {1} من {2} متبقي في المخزن.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidFileLocation', 'موقع ملف غير صالح.');--Invalid file location.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseDelivery', 'دفتر حركة فرعي غير صالح "تسليم المشتريات".');--Invalid SubTranBook 'Purchase Delivery'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseQuotation', 'دفتر حركة فرعي غير صالح "تسعير المشتريات".');--Invalid SubTranBook 'Purchase Quotation'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookPurchaseReceipt', 'دفتر حركة فرعي غير صالح "استلام الشراء".');--Invalid SubTranBook 'Purchase Receipt'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidSubTranBookSalesPayment', 'دفتر حركة فرعي غير صالح "ايراد المبيعات".');--Invalid SubTranBook 'Sales Payment'.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'InvalidUserId', 'معرف المستخدم غير صالح.');--Invalid user id.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'KeyValueMismatch', 'يوجد عدم تطابق من مفتاح/قيمة للاصناف في ListControl.');--There is a mismatching count of key/value items in this ListControl.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'NoTransactionToPost', 'لا توجد حركات للترحيل.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'ReferencingSidesNotEqual', 'كلا مراجع الجانبين ليست متساوية.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Errors', 'ar', 'RegionalDataFileNotFound', 'تعذر تحديد موقع ملف البيانات الإقليمي.');--The regional data file could not be located.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'AddNewUsersDescription', 'إنشاء المستخدمين وتحديد سياسات مختلفة مثل سياسة الوصول إلى القائمة وسياسة التحقق.');--Create users and define various policies such as menu access policy and verification policy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'AllFieldsRequired', 'جميع الحقول مطلوبة.');--All fields are required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'BackingUp', 'النسخ الاحتياطي {0}.');--Backing up {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'BackingUpForMigration', 'إجراء النسخ الاحتياطي للملف {0} للترحيل.');--Backing up file {0} for migration.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CannotWithdrawNotValidGLTransaction', 'لا يمكن سحب الحركة. هذه ليست حركة استاذ عام صالحة.');--Cannot withdraw transaction. This is a not a valid GL transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CannotWithdrawTransaction', 'لا يمكن سحب الحركة.');--Cannot withdraw transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ClickHereToDownload', 'اضغط هنا لتحميل.');--Click here to download.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ConfirmedPasswordDoesNotMatch', 'تأكيد كلمة المرور غير متطابق.');--The confirmed password does not match.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateCashRepositoriesDescription', 'الخزينة هو مكان حيث يمكنك تخزين الخاص بك النقدية والأشياء الثمينة. على سبيل المثال: النقدية بالخزينة،النقدية في الصندوق.');--Cash repository is a place where you store your cash and valuables. Example: Cash in Vault, Cash in Drawers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateCountySalesTaxDescription', ' ضريبة المبيعات المقاطعة او الولاية هي ضريبة الاستهلاك المباشر تفرضها حكومة المحافظة الخاصة بك عندما تقوم بالشراء أوالتوريد.');--County sales tax is the direct consumption tax imposed by your county government when you make purchase or sales.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateEducationLevelsDescription', 'انشاء المؤهلات العلمية المعمول بها في بلدكم .');--Create education levels applicable to your country and industry.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateFiscalYearDescription', 'السنة المالية فترة محاسبية لمدة 12 شهرا، المستخدمة في إعداد البيانات المالية.');--Fiscal year is an accounting period of 12 months, used to prepare financial statements.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateFrequenciesDescription', 'كذلك تنقسم السنة المالية  12 فترة، مصنفة حسب الأشهر وارباع ونصف المالية والسنة المالية.');--The fiscal year is further divided into 12 frequencies, categorized as months, quarters, fiscal half, and fiscal year.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateItemGroupsDescription', 'مجموعة الصنف يسمح لك لإدارة مماثلة من أصناف المخزون إلى مجموعات ذات مغزى والفئات.');--An item group allows you to manage similar inventory items into meaningful groups and categories.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateItemOrServiceDescription', 'أصناف المخزون قد تشير إلى المنتجات قابلة للتخزين أو اصناف غير قابلة للتخزين كالخدمات التي يمكنك شرائها و/أو بيعها.');--Inventory items may refer to the stockable products or nonstockable services that you buy and/or sell.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreatePartiesDescription', 'يشير مصطلح "الطرف" للعملاء والموردين والوكلاء التجاريين الذين يتعاملوا معك في الأعمال التجارية.');--The term "party" collectively refers to customer, supplier, or agent you have business with.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateSalesTaxFormDescription', 'نموذج ضريبة المبيعات مزيج من مختلف الكيانات مثل ضريبة العامة للدولة، ضريبة مقاطعة، الإعفاء، إلخ.');--Sales tax form is a combination of various entities such as State Tax, County Tax, Exemption, etc.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateSalespersonsDescription', 'مندوبي المبيعات هم رجال  المبيعات الذين يقومون ببيع المنتجات الخاصة بك ويجلبوا الأعمال التجارية للشركة الخاصة بك.');--Salespersons are the sales guys who sell your products and bring business to your company.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateShippingCompanyDescription', 'شركات الشحن  تقوم بنقل البضائع عبر البر والبحر، و/أو الجو إلى عملائك.');--Shipping companies transfer the goods through land, sea, and/or air to your customers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateStateDescription', 'إنشاء قائمة الدول التي موظفيك والعملاء والموردين.');--Create a list of states where your employees, customers, and suppliers are.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateStateSalesTaxDescription', 'ضريبة المبيعات هي ضريبة الاستهلاك المباشر تفرضها حكومة الدولة الخاص بك عندما تقوم بالشراء أوالتوريد.');--State sales tax is the direct consumption tax imposed by your state government when you make purchase or sales.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateStoresDescription', 'المخزن هو مكان حيث يمكنك الاحتفاظ بالبضائع الخاصة بك. على سبيل المثال: متجر، بدروم، او مخازن.');--Store is a place where you keep your goods. Example: Shop, Go-down, Warehouse.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateTaxAuthorityDescription', 'مصلحة الضرائب هو الهيئة الحكومية التي تقدم لها تقرير بالاعمال من ربح او خسارة سنويا.');--Tax authority is the government body or agency to whom you file your periodic tax reports to.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'CreateTaxMasterDescription', 'الضرائب الرئيسية فئة لمجموعة الضرائب الخاصة بك منطقياً. على سبيل المثال: الضريبة العامة للدولة.');--Tax master is a category to group your taxes logically. Example: [Country] Taxation.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DatabaseBackupSuccessful', 'النسخ الاحتياطي قاعدة بيانات تمت بنجاح.');--The database backup was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DateFormatYYYYMMDD', 'يوم/شهر/سنة');--yyyy-mm-dd
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DaysLowerCase', 'أيام');--days
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DefaultEntityAccessPolicy', 'إنشاء  نهج الوصول الكيان على أساس أدوار المستخدمين. افتراضيا، يكون لدى المستخدمين حق الوصول إلى كيان إذا تم منح نهج وصول القائمة. سياسة سلبية المحدد هنا ينطبق على جميع مستخدمي دور المحدد. سياسة صريحة الوصول كيان <a href="{0}"> </A> الأسبقية على هذه السياسة.');--Create default entity access policy based on user roles. By default, users have right to access an entity if a menu acesss policy is granted. A negative policy defined here is applicable for all users of the selected role. The explicit <a href="{0}">entity access policy</a> takes precedence over this policy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletedApplicationFiles', 'تم حذف ملفات التطبيق بنجاح.');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletingApplicationFiles', 'حذف ملفات التطبيق.');--Deleting application files.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DeletingApplicationFilesSucessMessage', 'تم حذف ملفات التطبيق بنجاح.');--Existing application files were deleted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DirectoryBackupCompletedSuccessfully', 'النسخ الاحتياطي للدليل تم بنجاح.');--Directory backup completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DirectoryRestoreSuccessful', 'استعادة النسخ الاحتياطي للدليل تم بنجاح.');--Directory restore completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DownloadSuccessful', 'تم التحميل بنجاح.');--Download was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'DownloadingUpdateFrom', 'جاري تحميل التحديث من {0}.');--Downloading update from {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EODBegunSaveYourWork', 'الرجاء إغلاق هذه النافذة وحفظ العمل الحالي الخاص بك قبل ان يتم خروجك تلقائياً.');--Please close this window and save your existing work before you will be signed off automatically.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EmailBody', '<h2>مرحبا،</h2> <p>الرجاء الاطلاع علي الوثيقة المرفقة.</p> <p>شكرا لك. < br/> MixERP</p>');--<h2>Hi,</h2><p>Please find the attached document.</p><p>Thank you.<br />MixERP</p>
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EmailSentConfirmation', 'تم إرسال بريد إلكتروني إلى {0}.');--An email was sent to {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'EntityAccessPolicy', 'إنشاء نهج الوصول كيان للمستخدمين الفرديين. افتراضيا، يكون لدى المستخدمين حق الوصول إلى كيان إذا تم منح نهج وصول القائمة. إذا تم إنشاء <a href="{0}"> الكيان الافتراضي </A> نهج الوصول لتقييد الوصول إلى مجموعة من المستخدمين، فلا يزال بإمكانك تجاوز هذه السياسة وتوفير إذن الوصول إلى مستخدم معين.');--Create entity access policy for individual users. By default, users have right to access an entity if a menu acesss policy is granted. If a <a href="{0}">default entity access policy</a> was created to restrict access to a group of users, you can still override that policy and provide access permission to a particular user.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ExtractingDownloadedFile', 'فك ضغط الملف الذي تم تنزيله.');--Extracting the downloaded file.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ExtractionCompleted', 'فك ضغط الملف اكتمل بنجاح.');--Extraction completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FlagDescription', 'يمكنك وضع علامة على هذا البند مع علم، ولكن سوف لا تكون قادراً على رؤية العلامات تم إنشاؤها بواسطة مستخدمين آخرين.');--You can mark this item with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FlagLabel', 'يمكنك وضع علامة على هذه الصفقة، ولكن سوف لا تكون قادراً على رؤية العلامات التي تم إنشاؤها بواسطة مستخدمين آخرين.');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FlagRemoved', 'تم إزالة العلامة.');--Flag removed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FlagSaved', 'تم حفظ العلامة.');--Flag saved.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'FrequencySetupIsComplete', 'يتم إكمال اعداد الفترات المالية.');--Frequency setup is complete.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'GoToChecklistWindow', 'انتقل إلى نافذة قائمة الاختيار.');--Go to checklist window.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'GoToTop', 'الانتقال إلى أعلى.');--Go to top.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'HoursAbbreviated', 'ساعة');--hrs
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ImportedNItems', 'تم بنجاح استيراد {0} صنف.');--Successfully imported {0} items.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'InstanceIsUpToDate', 'نسختك من MixERP محدث باخر تحديث.');--Your instance of MixERP is up to date.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'JustAMomentPlease', 'لحظةمن فضلك جاري تسجيل الدخول!');--Just a moment, please!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'MenuAccessPolicyDescription', 'سياسة الوصول إلى قائمة تمكنك من تعريف الصلاحيات لمستخدم للوصول إلى عناصر القائمة.');--Menu access policy enables you to define permission for a user to access menu item(s).
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'MinutesAbbreviate', 'دقائق');--mins
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NCashRepositoriesInThisOffice', 'هناك {0} خزينة نقدية في هذه الشركة.');--There are {0} cash repositories in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NCountySalesTaxesDefined', 'هناك {0}  ضرائب المبيعات المقاطعات في هذه الشركة.');--{0} county sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NHours', '{0} ساعات');--{0} hours
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NItemGroupsFound', 'هناك {0} مجموعة اصناف في هذه الشركة.');--{0} item group(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NItemsFound', 'هناك {0} اصناف في هذه الشركة.');--{0} item(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NOutOfNFrequenciesDefined', '  هناك {0} من أصل 12فترة محددة في هذه الشركة.');--{0} out of 12 frequencies defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NPartiesFound', 'هناك {0} اطراف في هذه الشركة.');--{0} parties found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NSalesTaxFormsDefined', 'هناك {0} من نماذج ضريبة المبيعات محددة في هذه الشركة.');--{0} sales tax forms defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NSalespersonsFound', 'هناك {0} من رجال البيع هذه الشركة.');--{0} salespersons found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NShippersFound', 'هناك {0} من شركات الشحن هذه الشركة.');--{0} shippers found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NStateSalesTaxesDefined', 'هناك {0} من نماذج ضريبة المبيعات المقاطعات محددة في هذه الشركة.');--{0} state sales taxes defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NStatesFound', '{0} وجدت الدول.');--{0} states found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NStoresInThisOffice', 'هناك {0} من المخازن هذه في الشركة.');--There are {0} stores in this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NTaxAuthoritiesFound', 'هناك {0} من مصالح الضرائب في هذه الشركة.');--{0} tax authorities found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NTaxMasterFound', 'هناك {0} من الضرائب العامة ( الرئيسية) في هذه الشركة.');--{0} tax master(s) found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NamedFilter', 'عامل التصفية: {0}');--Filter: {0}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoAdditionalUserFound', 'لم يتم اعداد مستخدم إضافي.');--No additional user found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoCashRepositoryDefnied', 'لم يتم اعداد  خزينة النقدية.');--No cash repository defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoCountySalesTaxDefined', 'لم يتم اعداد  ضريبة المبيعات للمقاطعة.');--No county sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoEducationLevelDefined', 'لا يوجد تعريف لمستوى التعليم .');--No education level defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoFiscalYearDefined', 'لم يتم اعداد  سنة مالية.');--No fiscal year defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoFormFound', 'لم يتم العثور على مثيل النموذج.');--No instance of form was found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoPartyFound', 'لم يتم اعداد الاطراف.');--No party found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSalesTaxFormDefined', 'لم يتم اعداد  نموذج ضريبة المبيعات.');--No sales tax form defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSalespersonFound', 'لم يتم اعداد مندوبي مبيعات.');--No salesperson found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoShipperFound', 'لم يتم اعداد شركات الشحن.');--No shipper found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoStateFound', 'لم يتم العثور على الدولة.');--No state found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoStateSalesTaxDefined', 'لم يتم اعداد ضريبة المبيعات الدولة.');--No state sales tax defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoStorePresent', 'لم يتم اعداد المخزن الحالي.');--No store present.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoSupplierFound', 'لم يتم اعداد الموردين.');--No supplier found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoTaxAuthorityDefined', 'لم يتم اعداد مصلحة الضرائب.');--No tax authority defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoTaxMasterDefined', 'لم يتم اعداد  الضريبة العامة.');--No tax master defined.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NoWidgetFound', 'لا توجد ادوات');--No widget found.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NotDefinedForNUsers', 'غير معرف لعدد {0} مستخدم.');--Not defined for {0} users.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'NumRowsAffected', '{0} الصفوف المتأثرة.');--{0} rows affected.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'OpeningInventoryAlreadyEntered', 'الارصدة الافتتاحية للمخزون تم ادخالها من قبل لهذه الشركة.');--Opening inventory has already been entered for this office.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PartyDescription', 'الأطراف مجتمعة تشير إلى الموردين والعملاء والوكلاء وتجار.');--Parties collectively refer to suppliers, customers, agents, and dealers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PatchedDatabase', 'تصحيح قاعدة البيانات.');--Patched the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PatchingDatabase', 'جاري التصحيح في قاعدة البيانات.');--Patching the database.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PercentCompleted', ' %{0}تم اكتمال ');--{0} percent completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PercentageSymbol', '%');--%
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'PleaseSelectAFormFirst', 'الرجاء اختيار نموذج أولاً.');--Please select a form first.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ProcessingYourCSVFile', 'تجهيز ملف CSV الخاص بك.');--Processing  your CSV file.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ReceiptEmailSubject', 'تم تسليم #{0} اشعار , {1}');--Receipt #{0} notification, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ReleaseContainsNoUpdates', 'لا يحتوي هذا الإصدار على أي تحديث.');--This release does not contain any update.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RequestingImport', 'طلب الاستيراد. قد يستغرق هذا عدة دقائق لإتمام.');--Requesting import. This may take several minutes to complete.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RequiredField', 'هذا الحقل مطلوب.');--This is a required field.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RequiredFieldDetails', ' الحقول التي تحمل علامة النجمة (*) مطلوبة.');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RequiredFieldIndicator', ' *');-- *
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RestoringDirectory', 'استعادة الدليل: {0}.');--Restoring directory : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RestoringFile', 'استعادة الملف: {0}.');--Restoring file : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'RollingBackChanges', 'التراجع عن التغييرات.');--Rolling back changes.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SMTPIsDisabled', 'SMTP غير مفعل.');--SMTP is disabled.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesDeliveryEmailSubject', 'تسليم المبيعات #{0} تأكيد , {1}');--Sales delivery #{0} confirmation, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesOrderEmailSubject', 'تم استلام امر الشراء #{0}, {1}');--We received your PO #{0}, {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesQuotationAlreadyAccepted', 'التسعير تم قبوله بالفعل في {0}.');--This quotation was already accepted on {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesQuotationEmailSubject', 'التسعير #{0} من {1}');--Quotation #{0} from {1}
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SalesQuotationExpired', 'انتهت هذا الاقتباس على {0}.');--This quotation expired on {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SelectAFlag', 'حدد علامة.');--Select a flag.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SetupEmailDescription', ' اعدادات البريد الصادر غير مفعل. قم بضبط اعدادات البريد الصادر SMTP لارسال التنبيهات الي عملائك.');--Your outgoing email configuration is disabled. Configure the SMTP parameters for sending email notifications to your customers.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'SuccessfullyProcessedYourFile', 'تم معالجة الملف الخاص بك بنجاح.');--Successfully processed your file.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedProgress', '{0} من {1} المهام المكتملة.');--{0} out of {1} tasks completed.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedSuccessfully', 'تمت المهمة بنجاح.');--Task completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedSuccessfullyRefreshView', 'تمت المهمة بنجاح. تحديث طريقة العرض؟');--Task completed successfully. Refresh the view?
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TaskCompletedSuccessfullyReturnToView', 'تمت المهمة بنجاح. العودة إلى طريقة العرض؟');--Task completed successfully. Return to the view?
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ThankYouForYourBusiness', 'شكرا لجهودك.');--Thank you for your business.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'ThisFieldIsRequired', 'هذا الحقل مطلوب.');--This field is required.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TotalUsersN', 'إجمالي المستخدمين: {0}.');--Total users : {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionApprovedDetails', 'هذه الحركة تم الموافقة بواسطة {0} في {1}.');--This transaction was approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionAutoApprovedDetails', 'هذه الحركة تمت الموافقة تلقائياً {0} في {1}.');--This transaction was automatically approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionAwaitingVerification', '. هذه المعاملات تنتظر التحقق من مسؤول.');--This transaction is awaiting verification from an administrator.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionClosedDetails', 'هذه الحركة اقفلت بواسطة {0} فى {1}. والسبب: "{2}".');--This transaction was closed by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionPostedSuccessfully', 'تم ترحيل الحركة بنجاح.');--The transaction was posted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionRejectedDetails', 'تم رفض هذه الحركة من قبل {0} في {1}. والسبب: "{2}".');--This transaction was rejected by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionStartDateDescription', ' ادخل التاريخ الذي تريد بدء تسجيل المعاملات به في نظام MixERP.');--Enter the exact date from when you want to record transactions in MixERP.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawalInformation', 'عندما سحب معاملة، لن يحال إلى الوحدة النمطية لسير العمل. وهذا يعني أن سحب معاملتك مرفوضة، وتتطلب مزيد من التحقق. ومع ذلك، لن تتمكن من الغاء سحب هذه الحركة في وقت لاحق.');--When you withdraw a transaction, it won't be forwarded to the workflow module. This means that your withdrawn transactions are rejected and require no further verification. However, you won't be able to unwithdraw this transaction later.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawnDetails', 'هذه الحركة سحبت بواسطة {0} فى {1}. والسبب: "{2}".');--This transaction was withdrawn by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'TransactionWithdrawnMessage', 'هذه الحركة سحبت بنجاح. وعلاوة على ذلك، هذا الإجراء سوف يؤثر على جميع التقارير التي تنتجها في وبعد "{0}".');--The transaction was withdrawn successfully. Moreover, this action will affect the all the reports produced on and after "{0}".
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UpdateBackupMessage', 'قبل القيام بعملية التحديث، الرجاء التأكد من أن لديك أحدث النسخ الاحتياطي.');--Before you perform the update operation, please make sure that you have latest backups handy.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UpdateOperationCompletedSuccessfully', 'عملية التحديث تمت بنجاح.');--The update operation completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UploadInvalidTryAgain', 'تحميل الخاص بك من نوع ملف غير صالح "{0}". الرجاء المحاولة مرة أخرى.');--Your upload is of invalid file type "{0}". Please try again.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UploadLogo', ' تحميل الشعار.');--Upload logo.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UploadLogoDescription', '   jpeg, gif, png, او bmp. هذا الشعار سيظهرعلي التقارير والمستندات الخاصة بالشركة.');--Upload your office logo in jpeg, gif, png, or bmp format. This logo will be displayed in reports and letters.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'UserGreeting', 'مرحبا {0}!');--Hi {0}!
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'VoucherVerificationPolicyDescription', 'تعيين سياسات  تحقق مستندات القيد للمسؤولين عن الموافقة أو رفض صفقة.');--Assisgn voucher verification policies to administrators for approving or rejecting transactions.
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'YearOld', '{0} سنة');--{0} years old
SELECT * FROM localization.add_localized_resource('Labels', 'ar', 'YourPasswordWasChanged', 'تم تغيير كلمة المرور الخاصة بك.');--Your password was changed.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'AreYouSure', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'CouldNotDetermineVirtualPathError', 'لا يمكن تحديد المسار الظاهري لإنشاء صورة.');--Could not determine virtual path to create an image.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'DuplicateFile', 'ملفات مكررة!');--Duplicate File!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODDoNotCloseWindow', 'الرجاء عدم إغلاق هذه النافذة أو التنقل بعيداً عن هذه الصفحة أثناء التهيئة.');--Please do not close this window or navigate away from this page during initialization.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODElevatedPriviledgeCanLogIn', 'خلال فترة نهاية اليوم، يسمح فقط للمستخدمين المصرح لهم فقط لتسجيل الدخول.');--During the day-end period, only users having elevated privilege are allowed to log-in.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODLogsOffUsers', 'عند تهيئة عملية نهاية اليوم، يتم تسجيل خروج المستخدمين الذين تم تسجيل دخولهم في النظام خلال 120 ثانية.');--When you initialize day-end operation, the already logged-in application users including you are logged off on 120 seconds.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODProcessIsIrreversible', 'هذه العملية لا رجعة فيها.');--This process is irreversible.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODRoutineTasks', 'خلال عملية نهاية اليوم، يتم تنفيذ المهام الروتينية مثل حساب الفائدة، والتسويات، واستخراج التقارير.');--During EOD operation, routine tasks such as interest calculation, settlements, and report generation are performed.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'EODTransactionPosting', 'عند تنفيذ عملية نهاية اليوم  لتاريخ معين،الحركات في ذلك التاريخ أو قبله لا يمكنك تحديثها، تغييرها، أوحذفها.');--When you perform EOD operation for a particular date, no transaction on that date or before can be altered, changed, or deleted.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'InvalidFile', 'ملف غير صالح!');--Invalid file!
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'TempDirectoryNullError', 'لا يمكن إنشاء صورة عندما يكون الدليل temp فارغة.');--Cannot create an image when the temp directory is null.
SELECT * FROM localization.add_localized_resource('Messages', 'ar', 'UploadFilesDeleted', 'تم حذف الملفات التي تم تحميلها بنجاح.');--The uploaded files were successfully deleted.
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'AreYouSure', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'CannotAccessAccount', 'لا يمكن الوصول إلى الحساب الخاص بك؟');--Cannot access your account?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ColumnInvalidAreYouSure', 'العمود "{0}" غير موجود أو غير صحيح. هل أنت متأكد من أنك تريد المتابعة؟');--The column "{0}" does not exist or is invalid. Are you sure you want to continue?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmAnalyze', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmVacuum', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'ConfirmVacuumFull', 'سيتم تأمين الوصول إلى قاعدة بيانات العمل أثناء التنفيذ. هل أنت متأكد من أنك تريد تنفيذ هذا الإجراء الآن؟');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'WhatIsYourHomeCurrency', 'ما هي العملة الرئيسية الخاصة بك؟');--What Is Your Home Currency?
SELECT * FROM localization.add_localized_resource('Questions', 'ar', 'WithdrawalReason', 'لماذا تريد أن تسحب هذه المعاملة؟');--Why do you want to withdraw this transaction?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'Select', 'حدد');--Select
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'access_type_id', 'معرف نوع الوصول');--Access Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'access_type_name', 'اسم نوع الوصول');--Access Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account', 'حساب');--Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_id', 'معرف الحساب');--Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master', 'الحساب الرئيسي');--Account Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_code', 'كود الحساب الرئيسي');--Account Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_id', 'معرف الحساب الرئيسي');--Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_master_name', 'اسم الحساب الرئيسي');--Account Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_name', 'اسم الحساب');--Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'account_number', 'رقم الحساب');--Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address', 'العنوان');--Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address_line_1', 'سطر العنوان 1');--Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'address_line_2', 'سطر العنوان 2');--Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ageing_slab_id', 'معرف الشريحة التصاعدية');--Ageing Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ageing_slab_name', 'اسم الشريحة التصاعدية');--Ageing Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_access', 'السماح بالوصول');--Allow Access
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_credit', 'السماح للائتمان');--Allow Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_sales', 'السماح بالبيع');--Allow Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'allow_transaction_posting', 'السماح بترحيل المعاملات');--Allow Transaction Posting
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount', 'المبلغ');--Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount_from', 'قيمة من');--Amount From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'amount_to', 'تصل إلى');--Amount To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'analyze_count', 'تحليل العدد لقاعدة البيانات');--Analyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'api_access_policy_id', 'معرف سياسة الوصول إلى API');--API Access Policy Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'api_access_policy_uix', 'إدخال مكرر لسياسة الوصول إلى API');--Duplicate Entry for API Access Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'applied_on', 'تطبق في');--Applied On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'applied_on_shipping_charge', 'تطبق على رسوم الشحن');--Applied on Shipping Charge
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'as_of', 'اعتبارا من');--As Of
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'audit_ts', 'مراجع الطابع الزمني');--Audit Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'audit_user_id', 'معرف المراجع');--Audit User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'auto_deduction_based_on_attendance', 'خصم تلقائي استناداً إلى الحضور');--Auto Deduction Based On Attendance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'auto_trigger_on_sales', 'المشغل تلقائياً على المبيعات');--Automatically Trigger on Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'autoanalyze_count', 'تحليل العدد تلقائي لقاعدة البيانات');--Autoanalyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'autovacuum_count', 'تفريغ تلقائي لقاعدة البيانات');--Autovacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'background_color', 'لون الخلفية');--Background Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'balance', 'الرصيد');--Balance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_account_number', 'رقم الحساب البنكي');--Bank Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_account_type', 'نوع الحساب البنكي');--Bank Account Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_accounts_account_id_chk', 'الصنف المحدد غير صالح كحساب بنكي.');--The selected item is not a valid bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_accounts_pkey', 'تكرار الحساب البنكي.');--Duplicate bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_address', 'عنوان البنك');--Bank Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_branch', 'فرع البنك');--Bank Branch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_contact_number', 'رقم الاتصال بالبنك');--Bank Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bank_name', 'اسم البنك');--Bank Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'base_unit_id', 'معرف الوحدة الأساسية');--Base Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'base_unit_name', 'اسم الوحدة الأساسية');--Base Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'based_on_shipping_address', 'استناداً إلى عنوان الشحن');--Based On Shipping Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'began_on', 'بدأت في');--Began On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'begins_from', 'يبدأ من');--Begins From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'blog', 'بلوج');--Blog
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_rate', 'معدل مكافأة');--Bonus Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab', 'مكافأة بلاطة');--Bonus Slab
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_code', 'رمز شريحة المكافأة');--Bonus Slab Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_detail_id', 'معرف تفاصيل شريحة مكافأة');--Bonus Slab Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_details_amounts_chk', 'يجب أن يكون الحقل "القيمة من" أكبر من "الي القيمة".');--The field "AmountTo" must be greater than "AmountFrom".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_id', 'معرف شريحة مكافأة');--Bonus Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'bonus_slab_name', 'اسم شريحة مكافأة');--Bonus Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'book', 'دفتر');--Book
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'book_date', 'تاريخ الدفتر');--Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand', 'العلامة التجارية');--Brand
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_code', 'رمز العلامة التجارية');--Brand Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_id', 'معرف العلامة التجارية');--Brand Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'brand_name', 'اسم العلامة التجارية');--Brand Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'browser', 'المتصفح');--Browser
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_change_password', 'يمكن تغيير كلمة المرور');--Can Change Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_expire', 'يمكن أن تنتهي');--Can Expire
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_self_verify', 'يمكنك التحقق من النفس');--Can Self Verify
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_gl_transactions', 'يمكن التحقق من المعاملات الاستاذ العام');--Can Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_purchase_transactions', 'يمكن التحقق من معاملات المشتريات');--Can Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'can_verify_sales_transactions', 'يمكن التحقق من معاملات المبيعات');--Can Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type', 'نوع البطاقة');--Card Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_code', 'رمز نوع البطاقة');--Card Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_id', 'معرف نوع البطاقة');--Card Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'card_type_name', 'اسم نوع البطاقة');--Card Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading', 'عنوان التدفق النقدي');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_cash_flow_heading_type_chk', 'نوع عنوان التدفق النقدي غير صالح. يسمح بالقيم: O,I,F.');--Invalid Cashflow Heading Type. Allowed values: O, I, F.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_code', 'رمز العنوان التدفق النقدي');--Cash Flow Heading Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_id', 'معرف عنوان التدفق النقدي');--Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_name', 'اسم العنوان التدفق النقدي');--Cash Flow Heading Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_heading_type', 'نوع عنوان التدفق النقدي');--Cashflow Heading Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_code', 'كود التدفق النقدي الرئيسي');--Cash Flow Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_id', 'معرف التدفق النقدي الرئيسي');--Cash Flow Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_master_name', 'اسم التدفق النقدي الرئيسي');--Cash Flow Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_flow_setup_id', 'معرف إعداد التدفق النقدي');--Cashflow Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repositories_cash_repository_code_uix', 'كود الخزينة النقدية مكرر.');--Duplicate Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repositories_cash_repository_name_uix', 'اسم الخزينة النقدية مكرر.');--Duplicate Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository', 'خزينة النقدية');--Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_code', 'كود الخزينة النقدية');--Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_id', 'معرف الخزينة النقدية');--Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cash_repository_name', 'اسم الخزينة النقدية');--Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cell', 'موبايل');--Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'change_status_code_to', 'تغيير رمز الحالة إلى');--Change Status Code To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'change_status_to', 'تغيير الحالة الي');--Change Status To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'charge_interest', 'رسوم الفائدة');--Charge Interest
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'check_nexus', 'فحص الترابط');--Check Nexus
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'checking_frequency', 'مراجعة الفترة');--Checking Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'checking_frequency_id', 'معرف مراجعة الفترة');--Checking Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'city', 'مدينة');--City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'closing_credit', 'إغلاق الدائن');--Closing Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'closing_debit', 'إغلاق المدين');--Closing Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_account', 'مجمع الحساب');--Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_account_id', ' معرف مجمع الحساب');--Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_tax_authority', 'مجمع مصلحة الضرائب');--Collecting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'collecting_tax_authority_id', 'معرف مجمع مصلحة الضرائب');--Collecting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'column_name', 'اسم العمود');--Column Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'comment', 'التعليق');--Comment
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'commision_rate', 'معدل العمولة');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'commission_rate', 'معدل العمولة');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'company_name', 'اسم الشركة');--Company Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compare_unit_id', 'معرف وحدة المقارنة');--Compare Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compare_unit_name', 'اسم وحدة المقارنة');--Compare Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'completed_on', 'الانتهاء في');--Completed On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item', ' مجمع الصنف');--Compound Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_code', 'كود مجمع الصنف');--Compound Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_detail_id', 'معرف تفاصيل مجمع الصنف');--Compound Item Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_details_unit_chk', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_id', 'معرف مجمع الصنف');--Compound Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_item_name', 'اسم  مجمع الصنف');--Compound Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_unit_id', 'معرف مجمع الوحدة ');--Compound Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compound_units_chk', 'معرف الوحدة الاساس لايجب ان تكون نفس وحدة المقارنة.');--The base unit id cannot same as compare unit id.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'compounding_frequency', 'مجمع الفترات المالية');--Compounding Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'confidential', 'سري');--Confidential
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'configuration_name', 'اسم الاعدادات');--Configuration Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_address_line_1', 'الاتصال سطر العنوان 1');--Contact Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_address_line_2', 'الاتصال سطر العنوان 2');--Contact Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_cell', 'موبايل');--Contact Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_city', 'المدينة');--Contact City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_country', 'الدولة');--Contact Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_email', 'البريد الإلكتروني ');--Contact Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_number', 'رقم');--Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_person', 'الشخص المسئول');--Contact Person
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_phone', 'رقم التليفون');--Contact Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_po_box', 'صندوق البريد');--Contact Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_state', 'الحالة');--Contact State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contact_street', 'الشارع');--Contact Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'contract_id', 'معرف العقد');--Contract Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_code', 'رمز مركز التكلفة');--Cost Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_id', 'معرف مركز تكلفة');--Cost Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_center_name', 'اسم مركز التكلفة');--Cost Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_of_goods_sold_account_id', 'معرف الحساب COGS');--COGS Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_price', 'سعر التكلفة');--Cost Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cost_price_includes_tax', 'سعر التكلفة تشمل الضرائب');--Cost Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_code', 'كود منفذ البيع');--Counter Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_id', 'معرف منفذ البيع');--Counter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'counter_name', 'اسم منفذ البيع');--Counter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country', 'الدولة');--Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_code', 'معرف المحافظة');--Country Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_id', 'معرف الدولة');--Country Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'country_name', 'اسم الدولة');--Country Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county', 'مقاطعة');--County
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_code', 'رمز مقاطعة');--County Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_id', 'معرف مقاطعة');--County Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_name', 'اسم مقاطعة');--County Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax', 'مقاطعة ضريبة المبيعات');--County Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_code', 'كود ضريبة المبيعات في مقاطعة');--County Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_id', 'معرف ضريبة المبيعات في مقاطعة');--County Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'county_sales_tax_name', 'اسم مقاطعة ضريبة المبيعات');--County Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'credit', 'دائن');--Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'cst_number', 'رقم CST');--CST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'culture', 'الثقافة');--Culture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency', 'العملة');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_code', 'كود العملة');--Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_name', 'اسم العملة');--Currency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'currency_symbol', 'رمز العملة');--Currency Symbol
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_department', 'الإدارة الحالية');--Current Department
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_department_id', 'معرف الإدارة الحالية');--Current Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_employment_status_code_id', 'معرف رمز حالة العمالة الحالية');--Current Employment Status Code Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_employment_status_id', 'معرف حالة العمالة الحالية');--Current Employment Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_job_title_id', 'معرف عنوان الوظيفة الحالية');--Current Job Title Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_pay_grade_id', 'معرف الصف الأجر الحالي');--Current Pay Grade Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_period', 'الفترة الحالية');--Current Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_role_id', 'معرف الدور الحالي');--Current Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'current_shift_id', 'معرف التحول الحالي');--Current Shift Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'customer_pays_fee', 'يدفع العميل رسوم');--Customer Pays Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'date_of_birth', 'تاريخ الميلاد');--Date Of Birth
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'day_of_month', 'يوم من شهر');--Day of Month
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'day_of_week', 'يوم من الأسبوع');--Day of Week
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'debit', 'مدين');--Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'deduction_applicable', 'الخصم المطبق');--Deduction Applicable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'deduction_setup_code', 'كود اعداد الخصم');--Deduction Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'deduction_setup_id', 'معرف اعداد الخصم ');--Deduction Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'deduction_setup_name', 'اسم اعداد الخصم ');--Deduction Setup Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_account', 'الحساب النقدي الافتراضي');--Default Cash Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_account_id', 'معرف الحساب النقدي الافتراضي');--Default Cash Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_repository', 'افتراضي مستودع النقدية');--Default Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_cash_repository_id', 'معرف الخزينة النقدية الافتراضي');--Default Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_employment_status_code_id', 'معرف رمز حالة العمل الافتراضي');--Default Employment Status Code Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'default_entity_access_id', 'معرف الوصول إلى الكيان الافتراضي');--Default Entity Access Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_code', 'كود الادارة');--Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_id', 'معرف إدارة');--Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'department_name', 'اسم الإدارة');--Department Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'description', 'الوصف');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'desired_resign_date', 'تاريخ الاستقالة المطلوب');--Desired Resign Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'details', 'تفاصيل');--Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'discount', 'خصم');--Discount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_days', 'أيام الاستحقاق');--Due Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_frequency', 'فترة الاستحقاق');--Due Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_frequency_id', 'معرف فترة الاستحقاق');--Due Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'due_on_date', 'المستحقة في تاريخ');--Due on Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'education_level_id', 'معرف مستوى التعليم');--Education Level Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'education_level_name', 'اسم مستوى التعليم');--Education Level Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'effective_from', 'اعتبارا من');--Effective From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'effective_resignation_date', 'تاريخ استقالة الفعلي');--Effective Resignation Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'effective_termination_date', 'تاريخ الإنهاء الفعلي');--Effective Termination Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'elevated', 'مؤثر');--Elevated
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'email', 'البريد الإلكتروني');--Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'email_address', 'عنوان البريد الإلكتروني');--Email Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee', 'الموظف');--Employee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_code', 'كود موظف');--Employee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_contribution_rate', 'معدل مساهمة الموظف');--Employee Contribution Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_experience_id', 'معرف الموظف خبرة');--Employee Experience Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_id', 'معرف الموظف');--Employee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_identification_detail_id', 'معرف تفاصيل هوية الموظف');--Employee Identification Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_name', 'اسم الموظف');--Employee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_qualification_id', 'معرف الموظف المؤهل');--Employee Qualification Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_social_network_detail_id', 'معرف تفاصيل الموظف الشبكة الاجتماعية');--Employee Social Network Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_tax_rate', 'معدل الضريبة للموظف');--Employee Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_type', 'فئة الموظف');--Employee Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_type_code', 'رمز نوع الموظف');--Employee Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_type_id', 'معرف نوع الموظف');--Employee Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_type_name', 'اسم نوع الموظف');--Employee Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employee_wage_id', 'معرف أجور الموظفين');--Employee Wage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employer_contribution_rate', 'معدل مساهمة أصحاب العمل');--Employer Contribution Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employer_tax_rate', 'معدل الضريبة صاحب العمل ');--Employer Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_status', 'نظام العمل');--Employment Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_status_code', 'رمز حالة العمالة');--Employment Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_status_code_id', 'معرف رمز حالة العمالة');--Employment Status Code Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_status_id', 'معرف حالة العمالة');--Employment Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_status_name', 'اسم حالة العمالة');--Employment Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax', 'ضريبة العمل');--Employment Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_code', 'كود ضريبة العمل');--Employment Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_detail_code', 'كود تفاصيل ضريبة العمل');--Employment Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_detail_id', 'معرف تفاصيل ضريبة العمل');--Employment Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_detail_name', 'اسم تفاصيل ضريبة العمل');--Employment Tax Detail Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_id', 'معرف ضريبة العمل');--Employment Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'employment_tax_name', 'اسم ضريبة العمل');--Employment Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'enabled', 'مفعل');--Enabled
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'end_date', 'تاريخ الانتهاء');--End Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ended_on', 'وانتهت في');--Ended On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ends_on', 'وينتهي في');--Ends On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entered_by', 'ادخلت بواسطة');--Entered By
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entity_access_id', 'معرف الوصول إلى الكيان');--Entity Access Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entity_id', 'معرف الكيان');--Entity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entity_name', 'اسم الكيان');--Entity Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'entry_ts', 'الطابع الزمني للادخال');--Entry Ts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'er', 'سعر الصرف');--ER
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exchange_rate', 'سعر الصرف');--Exchange Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exclude_from_purchase', 'استبعاد من الشراء');--Exclude From Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exclude_from_sales', 'استبعاد من المبيعات');--Exclude From Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_id', 'معرف الخروج');--Exit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_interview_details', 'تفاصيل مقابلة الخروج');--Exit Interview Details
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_type', 'انواع الخروج');--Exit Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_type_code', 'رمز نوع الإنهاء');--Exit Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_type_id', 'معرف نوع الخروج');--Exit Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'exit_type_name', 'اسم نوع الخروج');--Exit Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'expense_account', 'حساب المصاريف');--Expense Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'expense_account_id', 'معرف حساب المصاريف');--Expense Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'expires_on', 'وتنتهي في');--Expires On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'external_code', 'الكود الخارجي');--External Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'factory_address', 'عنوان المصنع');--Factory Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fax', 'فاكس');--Fax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'filter_and_value', 'تصفية والقيمة');--Filter And Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'filter_condition', 'حالة عامل التصفية');--Filter Condition
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'filter_id', 'معرف عامل التصفية');--Filter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'filter_name', 'اسم عامل التصفية');--Filter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'filter_value', 'قيمة عامل التصفية');--Filter Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'first_name', 'الاسم الأول');--First Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fiscal_year_code', 'رمز السنة المالية');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fiscal_year_name', 'اسم السنة المالية');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_id', 'معرف العلامة');--Flag Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_type_id', 'معرف نوع العلامة');--Flag Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flag_type_name', 'اسم نوع العلامة');--Flag Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'flagged_on', 'تم وضع علامة على');--Flagged On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'foreground_color', 'اللون الأمامي');--Foreground Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'foreign_currency_code', 'رمز العملة الأجنبية');--Foreign Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'forward_to', 'إلى الأمام إلى');--Forward To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency', 'فترة');--Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_code', 'كود الفترة');--Frequency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_id', 'معرف الفترة');--Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_name', 'اسم الفترة');--Frequency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_setup_code', 'رمز الإعداد الفترة');--Frequency Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'frequency_setup_id', 'معرف الإعداد الفترة');--Frequency Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'from_days', 'من أيام');--From Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'from_display_name', 'اسم المرسل');--From Display Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'from_email_address', 'البريد الالكتروني للمرسل');--From Email Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'full_name', 'الاسم الكامل');--Full Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'fund_holding_account_id', 'معرف حساب صندوق القبض');--Fund Holding Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gender_code', 'رمز نوع الجنس');--Gender Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gender_name', 'اسم نوع الجنس');--Gender Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gl_head', 'عنوان الاستاذ العام');--GL Head
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'gl_verification_limit', 'حد التحقق للاستاذ العام');--Gl Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'grace_period', 'فترة سماح');--Grace Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hard_of_hearing', 'صعوبة السمع');--Hard Of Hearing
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'has_child', 'له فرعي');--Has Child
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'has_county_sales_tax', 'هل يوجد ضريبة مبيعات المقاطعة؟');--Has County Sales Tax?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'has_state_sales_tax', 'هل يوجد ضريبة مبيعات عامة (دولة)؟');--Has State Sales Tax?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'height_in_centimeters', 'الطول بالسنتيمتر');--Height In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'holiday_id', 'معرف عطلة');--Holiday Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'holiday_name', 'اسم العطلة');--Holiday Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'holiding_account', 'حساب Holiding');--Holiding Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hot_item', 'البند رائج');--Hot item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hourly_rate', 'معدل سعر الساعة');--Hourly Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'http_action_code', 'رمز عمل HTTP');--HTTP Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'hundredth_name', 'اسم المائتين');--Hundredth Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'id', 'معرف');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'identification_number', 'رقم التعريف');--Identification Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'identification_type', 'نوع الهوية');--Identification Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'identification_type_code', 'تحديد نوع التعليمات البرمجية');--Identification Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'identification_type_name', 'تحديد نوع الاسم');--Identification Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'includes_tax', 'تشمل الضرائب');--Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'income_tax_rate', 'معدل ضريبة الدخل');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'industry_id', 'معرف الصناعة');--Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'industry_name', 'اسم الصناعة');--Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'institution', 'مؤسسة');--Institution
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'interest_compounding_frequency_id', 'معرف فائدة مجمع الفترات');--Interest Compounding Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'interest_rate', 'معدل الفائدة');--Interest Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'inventory_account_id', 'معرف حساب المخزون');--Inventory Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'ip_address', 'عنوان IP');--IP Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_active', 'نشط');--Is Active
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_added', 'يتم إضافة');--Is Added
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_admin', 'مشرف');--Is Admin
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_alcoholic', 'مدمن كحوليات');--Is Alcoholic
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_aphonic', 'ضعيف السمع');--Is Aphonic
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_autistic', 'متوحد');--Is Autistic
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_cash', 'نقدي');--Is Cash
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_cognitively_disabled', 'متعطل معرفيا');--Is Cognitively Disabled
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_contract', 'هو العقد');--Is Contract
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_credit', 'هو دائن');--Is Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_debit', 'مدين');--Is Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_default', 'هو افتراضي؟');--Is Default
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_default_admin', 'هو الافتراضي (Admin)');--Is Default (Admin)
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_employee', 'موظف');--Is Employee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_exempt', 'معفي');--Is Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_exemption', 'اعفاء');--Is Exemption
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_flat_amount', 'مبلغ ثابت');--Is Flat Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_frequency', 'هو التردد');--Is Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_legally_recognized_marriage', 'والمعترف بها قانونا الزواج');--Is Legally Recognized Marriage
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_merchant_account', 'حساب التاجر');--Is Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_overtime', ' العمل الإضافي');--Is Overtime
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_party', 'هو طرف');--Is Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_purchase', 'مشتريات');--Is Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_rectangular', 'متعامد');--Is Rectangular
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_sales', 'مبيعات');--Is Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_smoker', 'مدخن');--Is Smoker
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_summary', 'موجز');--Is Summary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_supplier', 'مورد');--Is Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_system', 'نظام');--Is System
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_taxable', 'غير الخاضعة للضريبة');--Is Taxable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_transaction_node', 'عنصر معاملة');--Is Transaction Node
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'is_vat', 'ضريبة القيمة المضافة');--Is Vat
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item', 'الصنف');--Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_code', 'كود الصنف');--Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_cost_price_id', 'معرف سعر تكلفة الصنف');--Item Cost Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_cost_prices_unit_chk', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group', 'مجموعة الأصناف');--Item Group
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_code', 'كود مجموعة الأصناف');--Item Group Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_id', 'معرف مجموعة الصنف');--Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_group_name', 'اسم مجموعة الصنف');--Item Group Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_id', 'معرف الصنف');--Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_name', 'اسم الصنف');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_opening_inventory_unit_chk', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_selling_price_id', 'معرف سعر بيع الصنف');--Item Selling Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_selling_prices_unit_chk', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_code', 'رمز نوع الصنف');--Item Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_id', 'معرف نوع الصنف');--Item Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'item_type_name', 'اسم نوع الصنف');--Item Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_item_code_uix', ' كود الصنف مكرر');--Duplicate item code.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_item_name_uix', ' اسم الصنف مكرر');--Duplicate item name.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'items_reorder_quantity_chk', 'يجب أن تكون كمية اعادة الطلب اكبر من أو مساوية لمستوى إعادة الطلب.');--The reorder quantity must be great than or equal to the reorder level.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'job_title', 'المسمى الوظيفي');--Job Title
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'job_title_code', 'كود عنوان الوظيفة');--Job Title Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'job_title_id', 'معرف عنوان الوظيفة');--Job Title Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'job_title_name', 'اسم عنوان الوظيفة');--Job Title Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'joined_on', 'وانضم إلى في');--Joined On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'key', 'مفتاح');--Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_analyze', 'اخر تحليل لقاعدة البيانات في');--Last Analyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_autoanalyze', 'اخر تحليل تلقائي لقاعدة البيانات في');--Last Autoanalyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_autovacuum', 'اخر تفريغ تلقائي لقاعدة البيانات في');--Last Autovacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_name', 'الاسم الأخير');--Last Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'last_vacuum', 'اخر تفريغ لقاعدة البيانات في');--Last Vacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee', 'الرسوم المتأخرة');--Late Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_code', 'كود الرسوم المتأخرة');--Late Fee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_id', 'معرف الرسوم المتأخرة');--Late Fee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_name', 'اسم الرسوم المتأخرة');--Late Fee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_posting_frequency', 'فترة ترحيل الرسوم المتأخرة');--Late Fee Posting Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'late_fee_posting_frequency_id', 'معرف فترة ترحيل الرسوم المتأخرة');--Late Fee Posting Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lc_credit', 'الدائن بالعملة المحلية');--LC Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lc_debit', 'المدين بالعملة المحلية');--LC Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_code', 'كود مصدر العملاء المحتملين');--Lead Source Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_id', 'معرف مصدر العملاء المحتملين');--Lead Source Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_source_name', 'اسم مصدر العملاء المحتملين');--Lead Source Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_code', 'كود حالة العميل المحتمل');--Lead Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_id', 'معرف حالة العميل المحتمل');--Lead Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_status_name', 'اسم حالة العميل المحتمل');--Lead Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'lead_time_in_days', 'المهلة الزمنية في الأيام');--Lead Time In Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_application_id', 'ترك معرف التطبيق');--Leave Application Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_benefit', 'إجازة المنافع');--Leave Benefit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_benefit_code', 'ترك مدونة فائدة');--Leave Benefit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_benefit_id', 'ترك معرف صالح');--Leave Benefit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_benefit_name', 'ترك اسم صالح');--Leave Benefit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_type', 'نوع الإجازة');--Leave Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_type_code', 'ترك نوع التعليمات البرمجية');--Leave Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_type_id', 'ترك نوع معرف');--Leave Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'leave_type_name', 'ترك اسم النوع');--Leave Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'length_in_centimeters', 'الطول بالسنتيمتر');--Length In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'login_date_time', 'تاريخ ووقت الدخول');--Login Date Time
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'login_id', 'اسم المستخدم');--Login Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'logo_file', 'ملف الشعار');--Logo File
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'low_vision', 'ضعيف البصر');--Low Vision
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'machinable', 'ألي');--Machinable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maintain_stock', 'صيانة المخزون');--Maintain Stock
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maintained_by_user_id', 'تمت الصيانة بواسطة');--Maintained By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'majors', 'التخصصات');--Majors
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'marital_status', 'الحالة الاجتماعية');--Marital Status
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'marital_status_code', 'كود الحالة الاجتماعية');--Marital Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'marital_status_id', 'معرف الحالة الاجتماعية');--Marital Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'marital_status_name', 'اسم الحالة الاجتماعية');--Marital Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'max_week_hours', 'اعلي ساعات الاسبوع');--Max Week Hours
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maximum_credit_amount', 'المبلغ الأقصى للائتمان');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maximum_credit_period', 'فترة الائتمان كحد أقصى');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'maximum_salary', 'الحد الأقصى للمرتبات');--Maximum Salary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_account', 'حساب التاجر');--Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_account_id', 'معرف حساب التاجر');--Merchant Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'merchant_fee_setup_id', 'معرف الإعداد الرسوم  لحساب التاجر');--Merchant Fee Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'middle_name', 'الاسم الأوسط');--Middle Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'minimum_salary', 'الحد الأدنى للراتب');--Minimum Salary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'nationality', 'الجنسية');--Nationality
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'nationality_code', 'قانون الجنسية');--Nationality Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'nationality_name', 'اسم الجنسية');--Nationality Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'nick_name', 'الكنية');--Nick Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'non_gl_stock_details_unit_chk', 'قدمت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'normally_debit', 'عادة مدين');--Normally Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'notice_date', 'تاريخ الإشعار');--Notice Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'object_name', 'اسم الكائن');--Object Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'occurs_on', 'يحدث في');--Occurs On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_code', 'كود الشركة');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_hour_id', 'معرف ساعات العمل');--Office Hour Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_id', 'معرف الشركة');--Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'office_name', 'اسم الشركة');--Office Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_code', 'رمز المرحلة الفرصة');--Opportunity Stage Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_id', 'معرف المرحلة الفرصة');--Opportunity Stage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'opportunity_stage_name', 'اسم المرحلة الفرصة');--Opportunity Stage Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'organization_name', 'اسم المؤسسة');--Organization Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'overtime', 'عمل اضافي');--Overtime
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'overtime_applicable', 'العمل الاضافي المطبق');--Overtime Applicable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'overtime_hourly_rate', 'معدل ساعة العمل الاضافي');--Overtime Hourly Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'overtime_hours', 'ساعات العمل الإضافي ');--Overtime Hours
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'overtime_pay_rate', 'معدل دفع العمل الإضافي');--Overtime Pay Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pan_number', 'رقم PAN');--Pan Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent', 'الأصل');--Parent
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_id', 'معرف الحساب الرئيسي');--Parent Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_master_id', 'المعرف  الحساب الرئيسي');--Parent Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_name', 'اسم الحساب الرئيسي');--Parent Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_account_number', 'رقم الحساب الرئيسي');--Parent Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_flow_heading_id', 'معرف عنوان التدفق النقدي الرئيسي');--Parent Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_repository', 'الخزينة النقدية الرئيسية');--Parent Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cash_repository_id', 'معرف الخزينة النقدية الرئيسية ');--Parent Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cr_code', 'كود السجل التحاري الرئيسي');--Parent CR Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_cr_name', 'اسم السجل التحاري الرئيسي');--Parent CR Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_industry_id', 'معرف الصناعة الرئيسي');--Parent Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_industry_name', 'اسم  للصناعة الرئيسية');--Parent Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_item_group_id', 'معرف المجموعة الصنف الرئيسي');--Parent Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_office', 'الشركة الرئيسية');--Parent Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'parent_office_id', 'معرف الشركة الرئيسية');--Parent Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party', 'الطرف');--Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_code', 'كود الطرف');--Party Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_id', 'معرف الطرف');--Party Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_name', 'اسم الطرف');--Party Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type', 'نوع الطرف');--Party Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_code', 'كود نوع الطرف');--Party Tpye Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_id', 'معرف نوع الطرف');--Party Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'party_type_name', 'اسم نوع الطرف');--Party Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'password', 'كلمة المرور');--Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pay_grade', 'الدرجة الوظيفية');--Pay Grade
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pay_grade_code', 'دفع رمز الصف');--Pay Grade Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pay_grade_id', 'دفع معرف الصف');--Pay Grade Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pay_grade_name', 'دفع اسم الصف');--Pay Grade Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card', 'بطاقة الدفع');--Payment Card
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_code', 'كود بطاقة الدفع');--Payment Card Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_id', 'معرف بطاقة الدفع');--Payment Card Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_card_name', 'اسم بطاقة الدفع');--Payment Card Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term', 'مصطلح الدفع');--Payment Term
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_code', 'كود مصطلح الدفع');--Payment Term Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_id', 'معرف مصطلح الدفع');--Payment Term Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'payment_term_name', 'اسم مصطلح الدفع');--Payment Term Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pension_fund', 'صندوق التقاعد');--Pension Fund
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pension_fund_code', 'كود صندوق التقاعد');--Pension Fund Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pension_fund_expense_account_id', 'معرف حساب  نفقات صندوق التقاعد');--Pension Fund Expense Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pension_fund_id', 'معرف صندوق التقاعد');--Pension Fund Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'pension_fund_name', 'اسم صندوق التقاعد');--Pension Fund Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'personal_exemption', 'الإعفاء الشخصي');--Personal Exemption
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone', 'التليفون');--Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone_cell', 'الهاتف الخليوي');--Phone Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone_emergency', 'هاتف الطوارئ');--Phone Emergency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone_emergency2', 'هاتف Emergency2');--Phone Emergency2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone_home', 'هاتف المنزل');--Phone Home
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'phone_office_extension', 'هاتف مكتب الإرشاد');--Phone Office Extension
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'photo', 'صورة');--Photo
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'po_box', 'ص. ب.');--Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'poco_type_name', 'اسم نوع Poco');--Poco Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'policy_id', 'معرف السياسة');--Policy id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'posting_account', 'حساب الترحيل');--Posting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'posting_account_id', 'معرف حساب الترحيل');--Posting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_mail_type', 'نوع الشحن بالبريد المفضل');--Preferred Shipping Mail Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_mail_type_id', 'معرف نوع الشحن بالبريد المفضل');--Preferred Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_shipping_package_shape', 'شكل التغليف المفضل');--Preferred Shipping Package Shape
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_supplier', 'المورد المفضل');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'preferred_supplier_id', 'معرف المورد المفضل');--Preferred Supplier Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_credit', 'الدائن السابق');--Previous Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_debit', 'المدين السابق');--Previous Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'previous_period', 'الفترة السابقة');--Previous Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price', 'الأسعار');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_from', 'السعر من');--Price From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_to', 'السعر إلى');--Price To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type', 'نوع السعر');--Price Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_code', 'رمز نوع السعر');--Price Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_id', 'معرف نوع السعر');--Price Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'price_type_name', 'اسم نوع السعر');--Price Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'primary_sales_tax_is_vat', 'ضريبة المبيعات الرئيسية ( ضريبة القيمة المضافة)؟');--Primary Sales Tax Is Vat?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'priority', 'الأولوية');--Priority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_account_id', 'معرف حساب المشتريات');--Purchase Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_discount_account_id', 'معرف حساب خصم المشتريات');--Purchase Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'purchase_verification_limit', 'حد تحقق المشتريات');--Purchase Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'quantity', 'الكمية');--Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rate', 'معدل');--Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reason', 'السبب');--Reason
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurrence_type', 'نوع تكرار');--Recurrence Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurrence_type_code', 'تكرار اكتب الرمز');--Recurrence Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurrence_type_id', 'معرف نوع التكرار');--Recurrence Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurrence_type_name', 'تكرار النوع الاسم');--Recurrence Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_amount', 'مبلغ متكرر');--Recurring Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_duration', 'المدة المتكررة');--Recurring Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_frequency', 'الفترة المتكرر');--Recurring Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_frequency_id', 'معرف الفترة المتكرر');--Recurring Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice', 'فاتورة المتكررة');--Recurring Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_code', 'كود الفاتورة المتكررة');--Recurring Invoice Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_id', 'معرف الفاتورة المتكررة');--Recurring Invoice Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_name', 'اسم الفاتورة المتكررة');--Recurring Invoice Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoice_setup_id', 'معرف إعداد فاتورة المتكررة');--Recurring Invoice Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurring_invoices_item_id_auto_trigger_on_sales_uix', 'لا يمكن أن يكون هناك Triger الي  على المبيعات لهذا الصنف.');--You cannot have more than one auto trigger on sales for this item.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'recurs_on_same_calendar_date', 'يتكرر في نفس التاريخ');--Recurs on Same Calendar Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reference_number', 'الرقم المرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'registration_date', 'تاريخ التسجيل');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'registration_number', 'رقم التسجيل');--Registration Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'regular_hours', 'الساعات العادية');--Regular Hours
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'regular_pay_rate', 'معدل سعر الساعة العادية');--Regular Pay Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'relationship_officer_name', 'اسم موظف العلاقات العامة');--Relationship Officer Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'relname', 'اسم العلاقة');--Relation Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'remote_user', 'المستخدم  عن بعد');--Remote User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_level', 'مستوى اعادة الطلب');--Reorder Level
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_quantity', 'كمية اعادة الطلب');--Reorder Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_unit', 'وحدة إعادة الطلب');--Reorder Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reorder_unit_id', 'معرف وحدة إعادة الطلب');--Reorder Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reporting_tax_authority', 'إبلاغ مصلحة الضرائب');--Reporting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'reporting_tax_authority_id', 'معرف الإبلاغ مصلحة الضرائب');--Reporting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'repository', 'خزينة');--Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resignation_id', 'معرف استقالة');--Resignation Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource', 'مورد');--Resource
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource_id', 'معرف المورد');--Resource Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'resource_key', 'مفتاح الموارد');--Resource Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role', 'وظيفة');--Role
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_code', 'كود الوظيفة');--Role Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_id', 'معرفالوظيفة');--Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'role_name', 'اسم الوظيفة');--Role Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_decimal_places', 'تقريب المنازل العشرية');--Rounding Decimal Places
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method', 'طريقة التقريب');--Rounding Method
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method_code', 'كود طريقة التقريب');--Rounding Method Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'rounding_method_name', 'اسم طريقة التقريب');--Rounding Method Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_deduction_id', 'معرف الاستقطاع');--Salary Deduction Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_frequency_id', 'معرف التردد المرتب');--Salary Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_frequency_name', 'اسم فترة المرتب');--Salary Frequency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_from', 'المرتب من');--Salary From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_id', 'معرف المرتب');--Salary Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_name', 'اسم الراتب');--Salary Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_tax', 'ضريبة المرتبات');--Salary Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_tax_code', 'كود ضريبة المرتبات');--Salary Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_tax_id', 'معرف ضريبة المرتبات');--Salary Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_tax_income_bracket_id', 'معرف ضريبة الدخل ( المرتب)');--Salary Tax Income Bracket Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_tax_name', 'اسم ضريبة المرتبات');--Salary Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_to', 'المرتب الي');--Salary To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_type', 'نوع المرتب');--Salary Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_type_code', 'رمز نوع الراتب');--Salary Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_type_id', 'معرف نوع الراتب');--Salary Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salary_type_name', 'اسم نوع الراتب');--Salary Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_account_id', 'معرف حساب المبيعات');--Sales Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_discount_account_id', 'معرف حساب خصم المبيعات');--Sales Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_quotation_valid_duration', 'تسعير المبيعات ساري لمدة');--Sales Quotation Valid Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_return_account_id', 'معرف حساب مردودات المبيعات');--Sales Return Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax', 'ضريبة المبيعات');--Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_code', 'كود ضريبة المبيعات');--Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_code', 'كود تفاصيل ضريبة المبيعات');--Sales Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_id', 'معرف تفاصيل ضريبة المبيعات');--Sales Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_detail_name', 'اسم تفاصيل ضريبة المبيعات');--Sales Tax Detail Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_details_rate_chk', 'معدل الضريبة لا ينبغي أن يكون فارغا إذا قمت بتحديد  ضريبة الولاية أو المقاطعة . وبالمثل، لا تستطيع ادخال معدل واخترت ضريبة الدولة أو المقاطعة .');--Rate should not be empty unless you have selected state or county tax. Similarly, you cannot provide both rate and choose to have state or county tax.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt', 'اعفاء ضريبة المبيعات');--Sales Tax Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_code', 'كود اعفاء ضريبة المبيعات');--Sales Tax Exempt Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_detail_id', 'معرف تفاصيل اعفاء ضريبة المبيعات');--Sales Tax Exempt Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_id', 'معرف اعفاء ضريبة المبيعات');--Sales Tax Exempt Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempt_name', 'اسم اعفاء ضريبة المبيعات');--Sales Tax Exempt Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_exempts_price_to_chk', 'يجب أن يكون حقل "PriceFrom" أقل من "PriceTo".');--The field "PriceFrom" must be less than "PriceTo".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_id', 'معرف ضريبة المبيعات');--Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_name', 'اسم ضريبة المبيعات');--Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type', 'نوع ضريبة المبيعات');--Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_code', 'كود نوع ضريبة المبيعات');--Sales Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_id', 'معرف نوع ضريبة المبيعات');--Sales Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_tax_type_name', 'اسم نوع ضريبة المبيعات');--Sales Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team', 'فريق المبيعات');--Sales Team
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_code', 'كود فريق المبيعات');--Sales Team Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_id', 'معرف فريق المبيعات');--Sales Team Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_team_name', 'اسم فريق المبيعات');--Sales Team Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sales_verification_limit', 'حد تحقق المبيعات');--Sales Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson', 'مندوب مبيعات');--Salesperson
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_bonus_setup_id', 'معرف إعداد مكافأة مندوب المبيعات');--Salesperson Bonus Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_code', 'كود مندوب المبيعات');--Salesperson Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_id', 'معرف مندوب المبيعات');--Salesperson Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'salesperson_name', 'اسم مندوب المبيعات');--Salesperson Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'score', 'نقاط');--Score
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'self_verification_limit', 'حد التحقق للنفس');--Self Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'selling_price', 'سعر البيع');--Selling Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'selling_price_includes_tax', 'سعر البيع يشمل الضرائب');--Selling Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'semantic_css_class', 'فئة Css الدلالية');--Semantic Css Class
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'service_end_date', 'تاريخ انهاء الخدمة');--Service End Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shift', 'فترة عمل');--Shift
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shift_code', 'رمز المفتاح shift');--Shift Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shift_id', 'معرف المفتاح shift');--Shift Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shift_name', 'اسم المفتاح shift');--Shift Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper', 'شاحن');--Shipper
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_code', 'كود شركة الشحن');--Shipper Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_id', 'معرف شركة الشحن');--Shipper Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipper_name', 'اسم شركة الشحن');--Shipper Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_address_code', 'كود عنوان الشحن');--Shipping Address Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_address_id', 'معرف عنوان الشحن');--Shipping Address Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_code', 'كود نوع الشحن بالبريد');--Shipping Mail Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_id', 'معرف نوع الشحن بالبريد');--Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_mail_type_name', 'اسم نوع الشحن بالبريد');--Shipping Mail Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_code', 'كود شكل التغليف الشحن');--Shipping Package Shape Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_id', 'معرف شكل التغليف');--Shipping Package Shape Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'shipping_package_shape_name', 'اسم شكل التغليف');--Shipping Package Shape Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'slab_name', 'اسم الشريحة');--Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_enable_ssl', 'SMTP Enable SSL');--SMTP Enable SSL
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_host', 'SMTP المضيف');--SMTP Host
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_id', 'SMTP ID');--SMTP Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_password', 'SMTP Password');--SMTP Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_port', 'SMTP Port');--SMTP Port
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'smtp_username', 'SMTP Username');--SMTP Username
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'social_network_id', 'معرف الشبكة الاجتماعية');--Social Network Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'social_network_name', 'اسم الشبكة الاجتماعية');--Social Network Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sst_number', 'رقم SST');--SST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'standard_deduction', 'استقطاع عادي');--Standard Deduction
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'start_date', 'تاريخ البدء');--Start Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'started_on', 'وبدأت في');--Started On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'starts_from', 'يبدأ من');--Starts From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state', 'الدولة');--State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_code', 'كود الدولة');--State Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_id', 'معرف المحافظة');--State Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_name', 'اسم الدولة');--State Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax', 'ضريبة المبيعات الدولة');--State Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_code', 'كود ضريبة المبيعات الدولة');--State Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_id', 'معرف ضريبة المبيعات الدولة');--State Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'state_sales_tax_name', 'اسم ضريبة المبيعات الدولة');--State Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'statement_reference', 'مرجع البيان');--Statement Reference
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'status_code', 'رمز الحالة');--Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'status_code_name', 'اسم رمز الحالة');--Status Code Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stock_details_unit_chk', 'ادخلت وحدة غير صالحة.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store', 'مخزن');--Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_code', 'كود المخزن');--Store Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_id', 'معرف المخزن');--Store Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_name', 'اسم المخزن');--Store Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type', 'نوع المخزن');--Store Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_code', 'كود نوع المخزن');--Store Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_id', 'معرف نوع المخزن');--Store Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'store_type_name', 'اسم نوع المخزن');--Store Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stores_default_cash_account_id_chk', 'يرجى اختيار معرف حساب نقدية أو  بنك صالح.');--Please select a valid Cash or Bank AccountId.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'stores_sales_tax_id_chk', 'معرف ضريبة المبيعات المختارة غيراصالحة لهذه الشركة.');--The chosen SalesTaxId is invalid for this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'street', 'شارع');--Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sub_total', 'اجمالي فرعي');--Sub Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'sys_type', 'SYS نوع');--Sys Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax', 'الضريبة');--Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority', 'مصلحة الضرائب');--Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_code', 'كود مصلحة الضرائب');--Tax Authority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_id', 'معرف مصلحة الضرائب');--Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_authority_name', 'اسم مصلحة الضرائب');--Tax Authority Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount', 'المبلغ الاساسي للضريبة');--Tax Base Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount_type_code', 'كود نوع المبلغ الاساسي للضريبة');--Tax Base Amount Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_base_amount_type_name', 'اسم نوع المبلغ الاساسي للضريبة');--Tax Base Amount Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_code', 'كود الضريبة');--Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type', 'نوع الاعفاء الضريبي');--Tax Exempt Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_code', 'كود نوع الاعفاء الضريبي');--Tax Exempt Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_id', 'معرف نوع الاعفاء الضريبي');--Tax Exempt Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_exempt_type_name', 'اسم نوع الاعفاء الضريبي');--Tax Exempt Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_id', 'معرف الضريبة');--Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master', 'الضريبة الرئيسية');--Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_code', 'كود الضريبة الرئيسية');--Tax Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_id', 'معرف الضريبة الرئيسية');--Tax Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_master_name', 'اسم الضريبة الرئيسية');--Tax Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_name', 'اسم الضريبة');--Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type', 'نوع معدل الضريبة');--Tax Rate Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type_code', 'كود نوع معدل الضريبة');--Tax Rate Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_rate_type_name', 'اسم نوع معدل الضريبة');--Tax Rate Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_code', 'كود نوع الضريبة');--Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_id', 'معرف نوع الضريبة');--Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tax_type_name', 'اسم نوع الضريبة');--Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'termination_id', 'معرف الإنهاء');--Termination Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'title', 'العنوان');--Title
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'to_days', 'لايام');--To Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total', 'الاجمالي');--Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_days', 'مجموع أيام');--Total Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_duration', 'اجمالي المدة');--Total Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_sales', 'إجمالي المبيعات');--Total Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'total_years', 'مجموع سنوات');--Total Years
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tran_code', 'كود الحركة');--Tran Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'tran_type', 'نوع الحركة');--Tran Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'transaction_start_date', 'تاريخ بدأ تسجيل المعاملات');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'transaction_ts', 'عملية الطابع الزمني');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit', 'وحدة');--Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_code', 'كود الوحدة');--Unit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_id', 'معرف الوحدة');--Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'unit_name', 'اسم الوحدة');--Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'url', 'رابط');--Url
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'use_tax_collecting_account', 'استخدام حساب الضريبة المجمع');--Use Tax Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'use_tax_collecting_account_id', 'استخدام معرف حساب الضريبة المجمع');--Use Tax Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'user', 'المستخدم');--User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'user_id', 'معرف المستخدم');--User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'user_name', 'اسم المستخدم');--User Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'uses_wheelchair', 'يستخدم كرسي متحرك');--Uses Wheelchair
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'vacuum_count', 'عدد الفراغات في قاعدة البيانات');--Vacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'valid_from', 'صالحة من');--Valid From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'valid_till', 'سارية حتى');--Valid Till
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'value', 'القيمة');--Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'value_date', 'تاريخ القيمة');--Value Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verification_status_id', 'معرف حالة التحقق');--Verification Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verified_by_user_id', 'التحقق من معرف المستخدم');--Verified By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verified_on', 'التحقق منها في');--Verified On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_gl_transactions', 'التحقق من معاملاتالاستاذ العام');--Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_purchase_transactions', 'تحقق معاملات المشتريات');--Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'verify_sales_transactions', 'التحقق من معاملات المبيعات');--Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'wage_processing_id', 'معرف معالجة الاجور');--Wage Processing Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'wage_setup', 'أعدادات الاجور');--Wage Setup
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'wage_setup_code', 'كود اعداد الاجور');--Wage Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'wage_setup_id', 'معرف اعداد الاجور');--Wage Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'wage_setup_name', 'اسم اعداد الاجور');--Wage Setup Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'website', 'موقع على شبكة الإنترنت');--Website
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'week_day', 'ايام الاسبوع');--Week Day
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'week_day_id', 'معرف يوم الأسبوع');--Week Day Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'week_start_day', 'يبدأ الاسبوع في');--Week Start Day
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'weight_in_grams', 'الوزن بالجرام');--Weight In Grams
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'width_in_centimeters', 'عرض في السنتيمتر');--Width In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'with_disabilities', 'ذوي الإعاقة');--With Disabilities
SELECT * FROM localization.add_localized_resource('ScrudResource', 'ar', 'zip_code', 'الرمز البريدي');--Zip Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AboutInitializingDayEnd', 'حول تهيئة نهاية اليوم');--About Initializing Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AboutYourOffice', 'حول شركتك');--About Your Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Accept', 'قبول');--Accept
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Access', 'وصول');--Access
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccessIsDenied', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Account', 'حساب');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountId', 'رقم الحساب');--Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountMaster', 'حساب رئيسي');--Account Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountName', 'أسم الحساب');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountNumber', 'رقم الحساب');--Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountOverview', 'نظرة عامة على الحساب');--Account Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AccountStatement', 'كشف حساب');--Account Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Acknowledged', 'تم العلم');--Acknowledged
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AcknowledgedBy', 'تم العلم بواسطة');--Acknowledged By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Action', 'تاثير');--Action
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Actions', 'تأثيرات');--Actions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Actual', 'فعلي');--Actual
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Add', 'إضافة');--Add
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddAKanbanList', 'إضافة قائمة Kanban');--Add a Kanban List
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddNew', 'اضف جديد');--Add New
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddNewChecklist', 'إضافة قائمة جديدة');--Add New Checklist
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddNewUsers', 'إضافة مستخدمين جدد');--Add New Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Address', 'عنوان');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AddressAndContactInfo', 'العنوان ومعلومات الاتصال');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Adjustment', 'تسوية');--Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgeingSlabs', 'شرائح تصاعدية');--Ageing Slabs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgentBonusSlabAssignment', 'تعيين شرائح المكأفاة');--Bonus Slab Assignment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AgentBonusSlabs', 'شرائح المكافأة لمندوبي المبيعات');--Bonus Slab for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Alerts', 'التنبيهات');--Alerts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AllTasks', 'كافة المهام');--All Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Amount', 'قيمة');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AmountInBaseCurrency', 'المبلغ (العملة الأساسية)');--Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AmountInHomeCurrency', 'المبلغ (بالعملة المحلية)');--Amount (In Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AnalyzeDatabase', 'تحليل قاعدة البيانات');--Analyze Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AnalyzeDatabse', 'تحليل قاعدة البيانات');--Analyze Databse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'And', 'و');--And
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Approve', 'موافق');--Approve
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ApproveThisTransaction', 'الموافقة على هذه الصفقة');--Approve This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ApprovedTransactions', 'المعاملات التي تم الموافقة عليها');--Approved Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AreYouSure', 'هل أنت متأكد؟');--Are you sure?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AssignCashier', 'تعيين أمين الصندوق');--Assign Cashier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AttachmentParameters', 'معلمات المرفقات');--Attachment Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AttachmentsPlus', 'المرفقات (+)');--Attachments (+)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Attendance', 'الحضور');--Attendance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Attendances', 'الحضور');--Attendances
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Authorize', 'فوض');--Authorize
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Authorized', 'مفوض');--Authorized
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AuthorizedBy', 'مفوض من');--Authorized By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AutoVerificationPolicy', 'سياسة التحقق التلقائي');--Autoverification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'AutomaticallyApprovedByWorkflow', 'وافق تلقائيا بواسطة سير العمل');--Automatically Approved by Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Back', 'رجوع');--Back
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackToPreviousPage', 'العودة إلى الصفحة السابقة');--Back to Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupConsole', 'وحدة التحكم النسخ الاحتياطي');--Backup Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupDatabase', 'النسخ الاحتياطي لقاعدة بيانات');--Backup Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupDirectories', 'النسخ الاحتياطي للدليل');--Backup Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BackupNow', 'ابدأ النسخ الاحتياطي الآن');--Backup Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Balance', 'الرصيد');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BalanceSheet', 'ميزان المراجعة');--Balance Sheet
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BankAccounts', 'حسابات بنكية');--Bank Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BankTransactionCode', 'كود المعاملة البنكية');--Bank Transaction Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BaseCurrency', 'العملة الأساسية');--Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BaseUnitName', 'اسم الوحدة الاساسية');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BonusSlabDetails', 'متفاصيل شرائح المكافأة لمندوبي المبيعات ');--Bonus Slab Details for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Book', 'دفتر');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BookDate', 'تاريخ الدفتر');--Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'BookIncomeTax', 'دفتر ضريبة الدخل');--Book Income Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Brand', 'علامة تجارية');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Brands', 'العلامات التجارية');--Brands
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Browse', 'تصفح');--Browse
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CSTNumber', 'رقم CST');--CST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Cancel', 'إلغاء');--Cancel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowHeading', 'عنوان التدفق النقدي');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowHeadings', 'عناوين التدفق النقدي');--Cash Flow Headings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashFlowSetup', 'إعداد التدفقات النقدية');--Cash Flow Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepositories', 'الخزائن النقدية');--Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepository', 'الخزينة النقدية');--Cash Repository
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashRepositoryBalance', 'رصيد الخزينة النقدية');--Cash Repository Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CashTransaction', 'عملية نقدية');--Cash Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChangePassword', 'تغيير كلمة المرور');--Change Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChangeSideWhenNegative', 'تغيير جانب عندما يكون القيمة سالبة');--Change Side When Negative
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ChartOfAccounts', 'شجرة الحسابات');--Chart of Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Check', 'اختر');--Check
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckAll', 'اختيار الكل');--Check All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckForUpdates', 'تحقق من التحديثات');--Check for Updates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckInTime', 'وقت الدخةل');--CheckIn Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CheckOutTime', 'وقت الخروج');--CheckOut Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Checklists', 'قوائم الاختيار');--Checklists
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Clear', 'مسح');--Clear
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Close', 'غلق');--Close
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosedTransactions', 'المعاملات المغلقة');--Closed Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingBalance', 'الرصيد الختامي');--Closing Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingCredit', 'اغلاق الدائن');--Closing Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ClosingDebit', 'اغلاق المدين');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ColumnName', 'اسم العمود');--Column Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Comment', 'تعليق');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompleteTasks', 'اكمل المهام');--Complete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundItemDetails', 'تفاصيل الصنف المركب');--Compound Item Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundItems', 'الاصناف المركبة');--Compound Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CompoundUnitsOfMeasure', 'وحدة قياس الاصناف المركبة');--Compound Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Condition', 'الشرط');--Condition
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Confidential', 'سري');--Confidential
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConfirmPassword', 'تأكيد كلمة السر');--Confirm Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Contracts', 'العقود');--Contracts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConvertedtoBaseCurrency', 'تم تحويله إلى العملة الرئيسية');--Converted to Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ConvertedtoHomeCurrency', 'تم تحويله إلى العملة المحلية');--Converted to Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CopyNewApplication', 'نسخة تطبيق جديد');--Copy New Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CostCenter', 'مركز التكلفة');--Cost Center
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CostCenters', 'مراكز التكلفة');--Cost Centers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Counters', 'منافذ البيع');--Counters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Counties', 'المقاطعات');--Counties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Countries', 'الدول');--Countries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CountySalesTax', 'ضريبة مبيعات المقاطعة');--County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CountySalesTaxes', 'ضرائب مبيعات الدولة');--County Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateAFlag', 'إنشاء علامة');--Create a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateBackup', 'إنشاء النسخ الاحتياطي');--Create Backup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateBackupFirst', 'إنشاء نسخة احتياطية من قاعدة البيانات اولا');--Create a Backup First
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateCashRepositories', 'إنشاء الخزينة النقدية');--Create Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateCountySalesTax', 'إنشاء ضرائب مبيعات المقاطعة');--Create County Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateEducationLevels', 'إنشاء مستويات التعليم');--Create Education Levels
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateFiscalYear', 'إنشاء السنة المالية');--Create Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateFrequencies', 'إنشاء الفترات المالية');--Create Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateItemGroups', 'إنشاء مجموعات الاصناف');--Create Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateItemOrService', 'إنشاء الصنف أو الخدمة');--Create Item or Service
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateNew', 'إنشاء جديد');--Create New
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateNewFiscalYear', 'إنشاء سنة مالية جديدة');--Create New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateParties', 'إنشاء الاطراف');--Create Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreatePayslip', 'إنشاء قسيمة الدفع');--Create Payslip
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreatePayslips', 'إنشاء إشعارات تسليم الراتب');--Create Payslips
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateSalesTaxForm', 'إنشاء نموذج ضريبة المبيعات');--Create Sales Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateSalespersons', 'إنشاء مندوبي المبيعات');--Create Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateShippingCompany', 'إنشاء شركة الشحن');--Create Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateState', 'إنشاء الدولة');--Create State
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateStateSalesTax', 'إنشاء ضريبة المبيعات العامة');--Create State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateStores', 'إنشاء المخازن');--Create Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateTaxAuthority', 'إنشاء مصلحة الضرائب');--Create Tax Authority
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateTaxMaster', 'إنشاء الضرائب الرئيسية');--Create Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreateaUserAccountforYourself', 'إنشاء حساب مستخدم لنفسك');--Create a User Account for Yourself
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreatedOn', 'تم إنشاؤها في');--Created On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Credit', 'دائن');--Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreditAllowed', 'مسموح الائتمان');--Credit Allowed
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CreditTotal', 'إجمالي الدائن');--Credit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltA', 'Ctrl + Alt + A');--Ctrl + Alt + A
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltC', 'Ctrl + Alt + C');--Ctrl + Alt + C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltD', 'Ctrl + Alt + D');--Ctrl + Alt + D
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltS', 'Ctrl + Alt + S');--Ctrl + Alt + S
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlAltT', 'Ctrl + Alt + T');--Ctrl + Alt + T
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CtrlReturn', 'Ctrl + Return');--Ctrl + Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Currencies', 'العملات');--Currencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Currency', 'عملة');--Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencyCode', 'معرف العملة');--Currency Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencyName', 'اسم العملة');--Currency Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencySymbol', 'رمز العملة');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrencylayerParameters', 'Currencylayer معلمات');--Currencylayer Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentBookDate', 'التاريخ الحالي للدفتر');--Current Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentIP', 'العنوان IP الحالي');--Current IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentLoginOn', 'الدخول الحالي في');--Current Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentPassword', 'كلمة السر الحالية');--Current Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CurrentPeriod', 'الفترة الحالية');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomFields', 'الحقول المخصصة');--Custom Fields
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerCode', 'كود العميل');--Customer Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerName', 'اسم العميل');--Customer Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerPanNumber', 'رقم PAN للعميل');--Customer PAN #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'CustomerPaysFees', 'يدفع العميل رسوم');--Customer Pays Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DataImport', 'استيراد البيانات');--Data Import
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DataType', 'نوع البيانات');--Data Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseBackups', 'النسخ الاحتياطي لقاعدة بيانات ');--Database Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseParameters', 'معلمات قاعدة البيانات');--Database Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DatabaseStatistics', 'احصائيات قاعدة البيانات');--Database Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Date', 'تاريخ');--Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DateOfBirth', 'تاريخ الميلاد');--Date of Birth
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Day', 'يوم');--Day
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Days', 'أيام');--Days
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Debit', 'مدين');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DebitTotal', 'إجمالي المدين');--Debit Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Deduction', 'استقطاع');--Deduction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeductionSetup', 'إعداد الاستقطاع');--Deduction Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeductionSetups', 'اعدادات الاستقطاعات');--Deduction Setups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Deductions', 'الاستقطاعات');--Deductions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultAddress', 'العنوان الاافتراضي ');--Default Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultCurrency', 'العملة الاافتراضية ');--Default Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultEntityAccessPolicy', 'نهج الوصول الافتراضي للكيان');--Default Entity Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DefaultReorderQuantityAbbreviated', 'كمية اعادة الطلب الاافتراضية ');--Default Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Definition', 'تعريف');--Definition
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Delete', 'حذف');--Delete
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeleteSelected', 'حذف الاختيار');--Delete Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeleteThisChecklist', 'حذف هذه القائمة المرجعية');--Delete This Checklist
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Deliver', 'تسليم');--Deliver
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliverFrom', 'تسليم من');--Deliver From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliverTo', 'تسليم الي ');--Deliver To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Delivered', 'تم التسليم');--Delivered
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredBy', 'سلمت بواسطة');--Delivered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredFrom', 'سلمت من');--Delivered From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredOn', 'تم التسليم في');--Delivered On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DeliveredTo', 'سلمت الي');--Delivered To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Department', 'ادارة');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Departments', 'الإدارات');--Departments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Description', 'وصف');--Description
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DestinationStore', ' الي مخزن');--Destination Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Difference', 'فرق');--Difference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DirectPurchase', 'الشراء المباشر');--Direct Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DirectSales', 'مبيعات مباشرة');--Direct Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Discount', 'خصم');--Discount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Documentation', 'توثيق');--Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Download', 'تحميل');--Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadSourceCode', 'تحميل برنامج اكود المصدر');--Download Source Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadingFrom', 'تحميل من');--Downloading From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DownloadingUpdate', 'تحميل التحديث');--Downloading Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'DueDate', 'تاريخ الاستحقاق');--Due Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EODBegun', 'عملية نهاية يوم قد بدأت');--End of Day Processing Has Begun
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EODConsole', 'وحدة التحكم عملية نهاية اليوم ');--EOD Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ER', 'ER');--ER
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ERToBaseCurrency', 'سعر الصرف (العملة الاساسية)');--Exchange Rate (To Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ERToHomeCurrency', 'سعر الصرف (العملة المحلية)');--Exchange Rate (To Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Edit', 'تحرير');--Edit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditAndReceive', 'تعديل واستقبال');--Edit & Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditAndSend', 'تعديل وإرسال');--Edit & Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditSelected', 'تحرير الاختيار');--Edit Selected
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EditThisChecklist', 'تحرير هذه القائمة المرجعية');--Edit This Checklist
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EducationLevel', 'مستوى التعليم');--Education Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EducationLevels', 'مستويات التعليم');--Education Levels
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Email', 'البريد الإلكتروني');--Email
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailAddress', 'عنوان البريد الإلكتروني');--Email Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisDelivery', 'أرسل هذا التسليم');--Email This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisInvoice', 'أرسل هذه الفاتورة');--Email This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisNote', 'أرسل هذه المذكرة');--Email This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisOrder', 'أرسل هذا الأمر');--Email This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisQuotation', 'أرسل هذا التسعير');--Email This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisReceipt', 'أرسل هذه المدفعات');--Email This Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmailThisReturn', 'أرسل هذه المردودات');--Email This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Employee', 'الموظف');--Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeExits', 'تخارج موظف');--Employee Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeExperience', 'خبرة الموظف');--Employee Experience
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeIdentificationDetails', 'تفاصيل هوية الموظف');--Employee Identification Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeQualification', 'تأهيل الموظف');--Employee Qualification
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeSalaries', 'مرتبات الموظف');--Employee Salaries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeSalary', 'مرتب الموظف');--Employee Salary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeSocialNetworkDetails', 'تفاصيل الموظف الشبكة الاجتماعية');--Employee Social Network Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeType', 'نوع الموظف');--Employee Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeTypes', 'أنواع الموظفين');--Employee Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeWage', 'اجر الموظف');--Employee Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmployeeWages', 'أجور الموظفين');--Employee Wages
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Employees', 'الموظفين');--Employees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentStatus', 'الوضع الوظيفي');--Employment Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentStatusCodes', 'رموز حالة العمالة');--Employment Status Codes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentStatuses', 'حالات الاستخدام');--Employment Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentTax', 'ضريبة العمل');--Employment Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentTaxDetails', 'تفاصيل الضريبة العمل');--Employment Tax Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EmploymentTaxes', 'ضرائب العمل');--Employment Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EndOfDayOperation', 'عملية نهاية اليوم ');--End of Day Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EndOfYearProcessing', 'معالجة نهاية السنة المالية');--End of Year Processing
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnterBackupName', 'أدخل اسم النسخ الاحتياطي');--Enter Backup Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnterNewPassword', 'ادخل كلمة مرور جديدة');--Enter a New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EnteredBy', 'تم إدخاله من قبل');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Entities', 'الكيانات');--Entities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'EntityAccessPolicy', 'كيان نهج الوصول');--Entity Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExchangeRate', 'سعر الصرف');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExchangeRates', 'اسعار العملات');--Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Execute', 'تنفيذ');--Execute
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Exit', 'خروج');--Exit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExitType', 'انواع الخروج');--Exit Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExitTypes', 'أنواع الخروج');--Exit Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Exits', 'مخارج');--Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Experiences', 'الخبرات');--Experiences
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Export', 'تصدير');--Export
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportData', 'تصدير البيانات');--Export Data
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportThisDocument', 'تصدير هذه الوثيقة');--Export This Document
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToDoc', 'التصدير إلى Word');--Export to Doc
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToExcel', 'تصدير إلى Excel');--Export to Excel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExportToPDF', 'تصدير إلى PDF');--Export to PDF
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExternalCode', 'الكود الخارجي');--External Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ExtractingDownload', 'استخراج تحميل');--Extracting Download
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FIFO', ' طريقة الوارد أولاَ صادر أولاَ  (FIFO)');--First In, First Out (FIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Factor', 'عامل');--Factor
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Fax', 'فاكس');--Fax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldLabel', 'تسمية الحقل');--Field Label
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldName', 'اسم الحقل');--Field Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FieldOrder', 'ترتيب الحقول');--Field Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FilePath', 'مسار الملف');--File Path
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Filter', 'تصفية');--Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FilterCondition', 'حالة عامل التصفية');--Filter Condition
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FilterName', 'اسم عامل التصفية');--Filter Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FilterStatement', 'بيان التصفية');--Filter Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FinalDueAmountinBaseCurrency', 'المبلغ المستحق النهائي باعلملة الاساسية');--Final Due Amount in Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'First', 'الاول');--First
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstPage', 'الصفحة الاولى');--First Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstSteps', 'الخطوات الأولى');--First Steps
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FirstTasks', 'المهام الأولى');--First Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FiscalYear', 'السنة المالية');--Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FiscalYearCode', 'كود السنة المالية');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FiscalYearName', 'اسم السنة المالية');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Flag', 'علامة');--Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagBackgroundColor', 'لون الخلفية للعلامة');--Flag Background Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagDescription', 'يمكنك وضع علامة هذه الصفقة مع العلم، ومع ذلك فلن تكون قادرا على رؤية الأعلام إنشاؤها من قبل المستخدمين الآخرين.');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagForegroundColor', 'اللون الامامي للعلامة');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlagThisTransaction', 'ضع علامة لهذا عملية');--Flag This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'FlaggedTransactions', 'المعاملات التي تم تعليمها');--Flagged Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Flags', 'العلامات');--Flags
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ForDate', 'الي تاريخ');--For Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Frequencies', 'الفترات');--Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Friday', ' الجمعة');--Friday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'From', 'من');--From
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLAdvice', 'نصيحة الاستاذ العام');--GL Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLDetails', 'تفاصيل الاستاذ العام');--GL Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GLHead', 'عنوان الاستاذ العام');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Gender', 'جنس');--Gender
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Genders', 'الجنسين');--Genders
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GlobalParameters', ' اعدادات عامة');--Global Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Go', 'اذهب');--Go
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoToBottom', 'اذهب للاسفل');--Go to Bottom
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoToTop', 'اذهب للاعلي');--GoToTop
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GoodsReceiptNote', 'مذكرة استلام البضائع');--Goods Receipt Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GrandTotal', 'المجموع الإجمالي');--Grand Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GridView', 'عرض الشبكة');--Grid View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'GrossEarnings', 'إجماليالأرباح');--Gross Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HideForNow', 'إخفاء الآن');--Hide for Now
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Holiday', 'عطلة');--Holiday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HolidaySetup', 'إعداد عطلة');--Holiday Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Holidays', 'أيام العطل');--Holidays
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Home', 'الصفحة الرئيسية');--Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HomeCurrency', 'العملة المحلية');--Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HoursWorked', 'ساعات العمل');--Hours Worked
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HumanResourceManagement', 'إدارة الموارد البشرية');--Human Resource Management
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'HundredthName', 'اسم المئة');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Id', 'معرف');--Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IdentificationDetails', 'تحديد تفاصيل');--Identification Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IdentificationTypes', 'أنواع الهوية');--Identification Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Import', 'استيراد');--Import
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ImportData', 'استيراد البيانات');--Import Data
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InVerificationStack', 'في انتظام التحقق');--In Verification Stack
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncludeZeroBalanceAccounts', 'تشمل رصيد الحسابات صفر');--Include Zero Balance Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncomeTax', 'ضريبة الدخل');--Income Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncomeTaxRate', ' معدل ضريبة الدخل');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IncompleteTasks', 'مهام غير مكتملة');--Incomplete Tasks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Industries', 'الصناعات');--Industries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InitializeDayEnd', 'تهيئة نهاية اليوم');--Initialize Day End
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InstallMixERP', 'تثبيت MixERP');--Install MixERP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InstrumentCode', 'كود الأداة');--Instrument Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InterestApplicable', 'الفائدة المطبقة');--Interest Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvalidDate', 'هذا ليس تاريخا صالحا.');--This is not a valid date.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvalidImage', 'هذه ليست صورة صالحة.');--This is not a valid image.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InventoryAccountingSystem', ' المعالجة المحاسبية للمخزون');--Inventory Accounting System
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InventoryAdvice', 'نصيحة المخزون');--Inventory Advice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InventoryValuationMethod', ' طريقة تقييم المخزون');--Inventory Valuation Method
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvoiceAmount', 'قيمة الفاتورة');--Invoice Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'InvoiceDetails', 'تفاصيل الفاتورة');--Invoice Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsCash', 'نقدي');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsEmployee', 'موظف');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsParty', 'طرف');--Is Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsPresent', 'حاضر');--Is Present
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'IsSystemAccount', 'حساب النظام');--Is System Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemCode', 'كود الصنف');--Item Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemCostPrices', 'أسعار التكلفة للصنف');--Item Cost Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemGroup', 'مجموعة الصنف');--Item Group
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemGroups', 'مجموعات الصنف');--Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemId', 'معرف الصنف');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemName', 'اسم الصنف');--Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemOverview', 'نظرة عامة على الصنف');--Item Overview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemSellingPrices', 'اسعار بيع الصنف');--Item Selling Prices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemType', 'نوع الصنف');--Item Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemTypes', 'انواع الصنف');--Item Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Items', 'الاصناف');--Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ItemsBelowReorderLevel', 'الاصناف التالية وصلت لمستوي اعادة الطلب');--Items Below Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JobTitle', 'المسمى الوظيفي');--Job Title
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JobTitles', 'المسميات الوظيفية');--Job Titles
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JournalVoucher', 'سند قيد يومية');--Journal Voucher
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'JournalVoucherEntry', 'ادخال سند قيد بومية');--Journal Voucher Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Kanban', 'Kanban');--Kanban
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'KanbanId', 'معرف Kanban');--Kanban Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'KanbanName', 'اسم Kanban');--Kanban Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'KanbanView', 'عرض Kanban');--Kanban View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'KeyColumnEmptyExceptionMessage', 'الخاصية "KeyColumn" لا يمكن أن تترك فارغة.');--The property 'KeyColumn' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LCCredit', 'دائن ( بالعملة المحلية )');--LC Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LCDebit', 'مدين ( بالعملة المحلية )');--LC Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LIFO', ' طريقة الوارد أخيراَ صادر أولاَ (LIFO)');--Last In, First Out (LIFO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Last', 'الاخير');--Last
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastAccessedOn', 'اخر وصول في');--Last Accessed On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastLoginIP', 'آخر تسجيل دخول عنوان IP');--Last Login IP
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastLoginOn', 'آخر تسجيل دخول في');--Last Login On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastPage', 'آخر صفحة');--Last Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastPaymentDate', 'اخر تاريخ دفع');--Last Payment Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LastWrittenOn', 'اخر كتابة في');--Last Written On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LateFees', 'الرسوم المتأخرة');--Late Fees
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadSources', 'مصدر العملاء المحتملين');--Lead Sources
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadStatuses', 'مصادر العملاء المحتملين');--Lead Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeadTime', 'مهلة العملاء المحتملين');--Lead Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveApplication', 'ترك التطبيق');--Leave Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveApplications', 'طلب اجازة');--Leave Applications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveBenefit', 'استحقاقا إجازة ');--Leave Benefit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveBenefits', 'استحقاقات الإجازة');--Leave Benefits
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveType', 'نوع الإجازة');--Leave Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LeaveTypes', 'أنواع الإجازات');--Leave Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ListItems', 'قائمة الاصناف');--List Items
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Load', 'حمل');--Load
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Loading', 'تحميل');--Loading
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LoggedInTo', 'تسجيل الدخول إلى حسابك');--Logged in to
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LoginView', 'عرض تسجيل الدخول');--Login View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'LunchDeduction', 'وقت الغداء');--Lunch Deduction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MAVCO', ' طريقة متوسط التكلفة (MAVCO)');--Moving Average Cost (MAVCO)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MakeAsDefault', 'جعل كافتراضي');--Make As Default
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ManageFilters', 'إدارة عوامل التصفية');--Manage Filters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ManageProfile', 'إدارة الملف الشخصي');--Manage Profile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaritalStatus', 'الحالة الاجتماعية');--Marital Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaritalStatuses', 'الحالات الاجتماعية');--Marital Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaximumCreditAmount', 'الحد الأقصى لمبلغ الائتمان');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MaximumCreditPeriod', 'الحد الاقصيأ لفترة الائتمان');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuAccessPolicy', 'سياسة الوصول القائمة');--Menu Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuCode', 'كود القائمة');--Menu Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuId', 'معرف القائمة');--Menu Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MenuText', 'نص القائمة');--Menu Text
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MerchantFeeInPercent', 'رسوم التاجر (في المائة)');--Merchant Fee (In percent)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MerchantFeeSetup', 'إعداد الرسوم التاجر');--Merchant Fee Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToGRN', 'دمج دفعة لGRN');--Merge Batch to GRN
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToSalesDelivery', 'دمج دفعة لتسليم المبيعات');--Merge Batch to Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MergeBatchToSalesOrder', 'دمج دفعة لاوامر المبيعات');--Merge Batch to Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Message', 'رسالة');--Message
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MigratingFiles', 'تحديث الملفات');--Migrating Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPDocumentation', 'MixERP وثائق');--MixERP Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPLinks', 'MixERP روابط سريعة');--MixERP Links
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPOnFacebook', 'MixERP في الفيسبوك');--MixERP on Facebook
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MixERPParameters', 'MixERP معلمات');--MixERP Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Monday', ' الاثنين');--Monday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Month', 'شهر');--Month
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MyLeaveApplications', 'طلبات اجازاتي');--My Leave Applications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'MyResignation', 'استقالتي');--My Resignation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Name', 'اسم');--Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Nationalities', 'الجنسيات');--Nationalities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Nationality', 'الجنسية');--Nationality
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewBookDate', 'تاريخ دفتر جديد');--New Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewFiscalYear', 'سنة مالية جديدة');--New Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewJournalEntry', 'إدخال دفتر اليومية جديد');--New Journal Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewPassword', 'كلمة المرور الجديدة');--New Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NewReleaseAvailable', 'الإصدار الجديد متوفر الان');--A New Release Is Available
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Next', 'التالي');--Next
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NextPage', 'الصفحة التالية');--Next Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'No', 'لا');--No
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NonTaxableEarning', 'ارباح غير خاضعة للضريبة');--Non Taxable Earning
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NonTaxableSales', 'مبيعات غير خاضع للضريبة');--Nontaxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NonVAT', ' لا يخضع لضريبة القيمة المضافة');--Non VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'None', 'لا شيء');--None
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NormallyDebit', 'عادة مدين');--Normally Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'NothingSelected', 'لم يتم اختيار شي!');--Nothing selected!
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Notifications', 'التنويهات');--Notifications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OK', 'موافق');--OK
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Office', 'شركة');--Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeCode', 'معرف الشركة');--Office Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeHour', 'ساعات العمل');--Office Hour
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeHours', 'ساعات العمل');--Office Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeInformation', 'معلومات عن الشركة');--Office Information
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeLogo', ' شعار الشركة');--Office Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeName', 'اسم الشركة');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeNickName', 'كنية الشركة');--Office Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OfficeSetup', 'اعدادات الشركة');--Office Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OnlyNumbersAllowed', 'يرجى كتابة رقم صالح.');--Please type a valid number.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpenExchangeRatesParameters', 'OpenExchangeRates معلمات');--OpenExchangeRates Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpeningInventory', 'الارصدة الافتتاحية للمخزون');--Opening Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OpportunityStages', 'مراحل فرصة');--Opportunity Stages
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OtherDetails', 'تفاصيل أخرى');--Other Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OtherWidgets', 'ادوات اخري');--Other Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OvertimeHours', 'ساعات العمل الاضافي');--Overtime Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'OvertimeWage', 'اجر العمل الاضافي');--Overtime Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PANNumber', 'PAN رقم');--PAN Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PLAppropriation', 'احتياطي الأرباح والخسائر');--PL Appropriation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PageN', 'الصفحة {0}');--Page {0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ParentAccount', 'حساب الأصل');--Parent Account
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Parties', 'الأطراف');--Parties
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Party', 'طرف');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyCode', 'طود الطرف');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyName', 'اسم الطرف');--Party Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartySummary', 'ملخص الطرف');--Party Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyType', 'نوع الطرف');--Party Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PartyTypes', 'أنواع الاطراف');--Party Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Password', 'كلمة السر');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PasswordUpdated', 'تم تحديث كلمة السر.');--Password was updated.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PayGrade', 'دفع الصف');--Pay Grade
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PayGrades', 'دفع الدرجات');--Pay Grades
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PayHours', 'ساعات العمل');--Pay Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PayRate', 'معدل ساعات العمل');--Pay Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PaySlip', 'اشعار ساعات العمل');--Pay Slip
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PaymentCards', 'بطاقات الدفع');--Payment Cards
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PaymentTerms', 'شروط الدفع');--Payment Terms
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PensionFund', 'صندوق التقاعد');--Pension Fund
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PensionFunds', 'صناديق التقاعد');--Pension Funds
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerformEOD', 'تنفيذ عملية نهاية اليوم');--Perform EOD
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerformEODOperation', 'تنفيذ عملية نهاية اليوم ');--Perform EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerformingEODOperation', 'جاري تنفيذ عملية نهاية اليوم ');--Performing EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PeriodicInventory', ' الجرد الدوري');--Periodic Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PerpetualInventory', ' الجرد المستمر');--Perpetual Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Phone', 'تليفون');--Phone
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PlaceReorderRequests', 'ضع طلبات اعادة الطلب');--Place Reorder Request(s)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostTransaction', 'ترحيل حركة');--Post Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostedBy', 'رحلت بواسطة');--Posted By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PostedDate', 'تاريخ الترحيل');--Posted Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreferredSupplier', 'المورد المفضل');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreferredSupplierIdAbbreviated', 'المفضل SupId');--Pref SupId
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Prepare', 'إعداد');--Prepare
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreparedOn', 'أعد في');--Prepared On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Preview', 'معاينة');--Preview
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Previous', 'السابق');--Previous
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousBalance', 'الرصيد السابق');--Previous Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousCredit', 'دائن سابق');--Previous Credit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousDebit', 'مدين السابق');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousPage', 'الصفحة السابقة');--Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PreviousPeriod', 'الفترة السابقة');--Previous Period  
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Price', 'السعر');--Price
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PriceType', 'نوع سعر');--Price Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PrimarySalesTaxType', ' نوع ضريبة المبيعات الرئيسية');--Primary Sales Tax Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Print', 'طباعة');--Print
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PrintGlEntry', 'طباعة قيود يومية الاستاذ العام');--Print GL Entry
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PrintReceipt', 'طباعة الإيصال');--Print Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ProcessWage', 'أجور العملية');--Process Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ProfitAndLossStatement', 'بيان الربح والخسارة');--Profit & Loss Statement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ProfitBeforeTax', 'الارباح قبل الضرائب');--Profit Before Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ProfitOrLoss', 'الارباح والخسائر');--Profit or Loss
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Progress', 'تقدم');--Progress
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PublishedOn', 'نشرت في يوم');--Published On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseInvoice', 'فاتورة الشراء');--Purchase Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseOrder', 'أمر شراء');--Purchase Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseReturn', 'مردودات المشتريات');--Purchase Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'PurchaseType', 'نوع شراء');--Purchase Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Qualifications', 'المؤهلات');--Qualifications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Quantity', 'كمية');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuantityAbbreviated', 'الكمية');--Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuantityOnHandAbbreviated', 'الكمية (الفعلية)');--Qty (On Hand)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuotationDetails', 'تفاصيل التسعير');--Quotation Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'QuotationValidDays', ' مهلة طلب التسعير');--Quotation Valid Days
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Rate', 'معدل');--Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Rating', 'تصنيف');--Rating
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reason', 'سبب');--Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Receipt', 'إيصال');--Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptAmount', 'مبلغ الايصال');--Receipt Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptCurrency', 'عملة الايصال');--Receipt Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceiptType', 'نوع الايصال');--Receipt Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Receive', 'تسليم');--Receive
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Received', 'تم التسليم');--Received
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedAmountInaboveCurrency', 'المبلغ المستلم (بالعملة المذكورة أعلاه)');--Received Amount (In above Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedBy', 'تم التسليم بواسطة');--Received By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedCurrency', 'عملة التسليم');--Received Currency
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReceivedOn', 'تم السليم في');--Received On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reconcile', 'توفيق');--Reconcile
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RecurringInvoiceSetup', 'إعداد فاتورة متكررة');--Recurring Invoice Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RecurringInvoices', 'الفواتير المتكررة');--Recurring Invoices
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReferenceNumber', 'الرقم المرجعي');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReferenceNumberAbbreviated', 'المرجع #');--Ref#
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RefererenceNumberAbbreviated', 'المرجع #');--Ref #
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RegionalDataIncludingCOA', 'البيانات الإقليمية (بما في ذلك دليل الحسابات)');--Regional Data (Including Chart of Accounts)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RegistrationDate', 'تاريخ التسجيل');--Registration Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RegularHours', 'الساعات العادية');--Regular Hours
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RegularWage', 'الاجر العادي');--Regular Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reject', 'رفض');--Reject
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RejectThisTransaction', 'رفض هذه الحركة');--Reject This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RejectedTransactions', 'الحركات المرفوضة');--Rejected Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReleaseId', 'معرف الاصدار');--Release Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RememberMe', 'تذكر بياناتي');--Remember Me
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RemoveAsDefault', 'إزالة كافتراضي');--Remove As Default
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RemovingApplication', 'إزالة التطبيق');--Removing Application
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderLevel', 'مستوي اعادة الطلب');--Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderQuantityAbbreviated', 'كمية اعادة الطلب');--Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReorderUnitName', 'اسم وحدة إعادة الطلب');--Reorder Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Request', 'طلب');--Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredField', 'هذا الحقل مطلوب.');--This is a required field.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredFieldDetails', 'مطلوبة الحقول التي تحمل علامة النجمة (*).');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RequiredFieldIndicator', '  *');-- *
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Reset', 'إعادة تعيين');--Reset
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Resignation', 'استقالة');--Resignation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Resignations', 'استقالة');--Resignations
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestoringDirectories', 'استعادة الملفات');--Restoring Directories
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestoringMigrationFiles', 'استعادة الملفات المحدثة');--Restoring Migration Files
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RestrictedTransactionMode', 'وضع الحركات مقيدة');--Restricted Transaction Mode
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RetainedEarnings', 'الأرباح المحتجزة');--Retained Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Return', 'عودة');--Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnBack', 'العودة للخلف');--Return Back
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnHome', 'العودة للصفحة الرئيسية');--Return Home
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ReturnToView', 'العودة للعرض');--Return to View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Role', 'وظيفة');--Role
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Roles', 'وظائف');--Roles
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RowNumber', 'عدد الصفوف');--Row Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RunningDatabasePatch', 'تشغيل تصحيح قاعدة البيانات');--Running Database Patch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'RunningTotal', 'الاجمالي التشغيلي');--Running Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SMTPConfiguration', 'SMTP اعدادات');--SMTP Configuration
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SSTNumber', 'رقم SST');--SST Number
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Salaries', 'المرتبات');--Salaries
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Salary', 'المرتب');--Salary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryDeductions', 'خصومات الراتب');--Salary Deductions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryFrequencies', 'فترات المرتب');--Salary Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalarySetup', 'إعداد المرتبات');--Salary Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryTax', 'ضريبة المرتبات');--Salary Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryTaxIncomeBracket', 'القوس ضريبة الدخل الراتب');--Salary Tax Income Bracket
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryTaxIncomeBrackets', 'ضريبة الدخل (المرتبات)');--Salary Tax Income Brackets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryTaxes', 'ضرائب المرتبات');--Salary Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryType', 'نوع المرتب');--Salary Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalaryTypes', 'أنواع الراتب');--Salary Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByMonthInThousands', 'مبيعات حسب الشهر (بالآلاف)');--Sales By Month (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByOffice', 'المبيعات حسب الشركة');--Sales By Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesByOfficeInThousands', 'المبيعات حسب شركة (بالآلاف)');--Sales By Office (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesDelivery', 'تلسليم المبيعات');--Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesDeliveryNote', 'مذكرة تسليم المبيعات');--Delivery Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesInvoice', 'فاتورة المبيعات');--Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesOrder', 'طلب المبيعات');--Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesPersons', 'مندوبي المبيعات');--Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesQuotation', 'تسعير المبيعات');--Sales Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesReceipt', 'تسليم المبيعات');--Sales Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesReturn', 'مردودات المبيعات');--Sales Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxDetails', 'تفاصيل ضريبة المبيعات');--Sales Tax Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxExemptDetails', 'تفاصيل اعفاء ضريبة المبيعات');--Sales Tax Exempt Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxExempts', 'اعفاءات ضريبة المبيعات');--Sales Tax Exempts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxTypes', 'أنواع ضريبة المبيعات');--Sales Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTaxes', 'الضرائب على المبيعات');--Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesTeams', 'فرق المبيعات');--Sales Teams
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SalesType', 'نوع المبيعات');--Sales Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Salesperson', 'مندوب مبيعات');--Salesperson
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Saturday', 'السبت');--Saturday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Save', 'حفظ');--Save
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SaveOrder', 'احفظ الطلب');--Save Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SaveThisFilter', 'حفظ عامل التصفية هذا');--Save this Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Saving', 'جاري الحفظ');--Saving
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ScrudFactoryParameters', 'ScrudFactory معلمات');--ScrudFactory Parameters
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Search', 'بحث');--Search
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Select', 'اختيار');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectAColumn', 'حدد عمود');--Select a Column
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectAFilter', 'قم بتحديد عامل تصفية');--Select a Filter
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectApi', 'حدد API');--Select API
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectCompany', 'اختار شركة');--Select Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectCustomer', 'اختار العميل');--Select Customer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectExpensesGL', 'اختار مصروفات الاستاذ العام');--Select Expenses GL
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectFlag', 'اختار العلامة');--Select a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectForm', 'اختار النموذج');--Select a Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectGroup', 'اختار المجموعة');--Select a Group
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectLanguage', 'اختار اللغة');--Select Language
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectOffice', 'اختار شركة');--Select Office
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectPLAppropriationAccount', 'اختار حساب توزريع الارباح والخسائر');--Select PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectParty', 'احتار الطرف');--Select Party
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectPaymentCard', 'اختار بطاقات الدفع');--Select Payment Card
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectStore', 'اختار المخزن');--Select Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectSupplier', 'اختار المورد');--Select Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectTaxOfficeGL', 'اختار الاستاذ العام للضريبة');--Select Tax Office GL
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectUnit', 'اختار الوحدة');--Select Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectUser', 'اختار المستخدم');--Select User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectYourBranch', 'اختار الفرع');--Select Your Branch
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SelectedWidgets', 'احتار الاداوات');--Selected Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Send', 'إرسال');--Send
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Sent', 'أرسلت');--Sent
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SetupEmail', 'اعداد البريد الالكتروني');--Setup Email
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shift', 'وردية');--Shift
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shifts', 'ورديات');--Shifts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shipper', 'شركة الشحم');--Shipper
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Shippers', 'شركات الشحن');--Shippers
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddress', 'عنوان الشحن');--Shipping Address
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddressMaintenance', 'اعدادات عنوان الشحن');--Shipping Address Maintenance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingAddresses', 'عنوان الشحن (العناوين)');--Shipping Address(es)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingCharge', 'مصاريف الشحن');--Shipping Charge
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShippingCompany', 'شركة الشحن');--Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Show', 'عرض');--Show
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShowAll', 'عرض الكل');--Show All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ShowCompact', 'عرض مختصر');--Show Compact
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SignIn', 'تسجيل الدخول');--Sign In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SignOut', 'تسجيل الخروج');--Sign Out
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SigningIn', 'جاري تسجيل الدخول');--Signing In
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SocialNetworkDetails', 'تفاصيل الشبكة الاجتماعية');--Social Network Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SocialNetworks', 'الشبكات الاجتماعية');--Social Networks
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SourceStore', 'مصدر المخزن');--Source Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Start', 'ابدا');--Start
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StateSalesTax', 'ضريبة مبيعات العامة (الدولة)');--State Sales Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StateSalesTaxes', 'الضرائب على المبيعات الدولة ( العامة)');--State Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StatementOfCashFlows', 'قائمة التدفقات النقدية');--Statement of Cash Flows
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StatementReference', 'مرجع كشف الحساب');--Statement Reference
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'States', 'الدول');--States
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Status', 'الحالة');--Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockAdjustment', 'تسوية المخزون');--Stock Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransaction', 'حركات المخزون');--Stock Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferAcknowledgement', 'اشعار تحويل المخزون');--Stock Transfer Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferAuthorization', 'تفويض تحويل المخزون');--Stock Transfer Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferDelivery', 'تسليم تحويل المخزون');--Stock Transfer Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferJournal', 'يومية تحويل المخزون');--Stock Transfer Journal
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StockTransferRequest', 'طلب تحويل المخزون');--Stock Transfer Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Store', 'مخزن');--Store
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StoreName', 'اسم المخزن');--Store Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'StoreTypes', 'نوع المخزن');--Store Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Stores', 'مخازن');--Stores
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SubTotal', 'اجمالي فرعي');--Sub Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SubmitBugs', 'إرسال الاخطاء');--Submit Bugs
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SuccessfullyUpdated', 'تم التحديث بنجاح');--Successfully Updated
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Sunday', 'الاحد');--Sunday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'SupplierName', 'اسم المورد');--Supplier Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Support', 'الدعم الفني');--Support
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Switches', 'مفاتيح');--Switches
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TableEmptyExceptionMessage', 'الخاصية "Table" لا يمكن أن تترك فارغة.');--The property 'Table' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TableSchemaEmptyExceptionMessage', 'الخاصية  "TableSchema"  لا يمكن أن تترك فارغة.');--The property 'TableSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TagName', 'اسم العلامة');--Tag Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaskCompletedSuccessfully', 'تم الانتهاء من المهمة بنجاح.');--The task was completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Tax', 'ضريبة');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxAuthorities', 'مصلحة الضرائب');--Tax Authorities
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxExemptTypes', 'انواع الضريبة المعفاة');--Tax Exempt Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxForm', 'نموذج الضريبة');--Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxMaster', 'الضريبة الرئيسية');--Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxRate', 'معدل الضريبة');--Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxSetup', 'إعداد الضرائب');--Tax Setup
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxTotal', 'إجمالي الضريبة');--Tax Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxTypes', 'أنواع الضرائب');--Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxableEarning', 'الارباح الخاضعة للضريبة');--Taxable Earning
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TaxableSales', 'المبيعات الخاضعة للضريبة');--Taxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Tel', 'التليفون');--Tel
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Termination', 'انهاء');--Termination
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Terminations', 'الانهاءات');--Terminations
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ThankYou', 'شكرا لك');--Thank You
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Thursday', 'الخميس');--Thursday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'To', 'إلى');--To
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ToPLAppropriationAC', 'الي حساب توزيعات الارباح والخسائر');--To PL Appropriation A/C
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TopSellingProductsOfAllTime', 'أعلى مبيعات في كل الاوقات');--Top Selling Products of All Time
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Total', 'مجموع');--Total
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmount', 'إجمالي المبلغ المستحق');--Total Due Amount
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmountCurrentOffice', 'إجمالي المبلغ المستحق (شركة الحالية)');--Total Due Amount (Current Office)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalDueAmountInBaseCurrency', 'إجمالي المبلغ المستحق (العملة الأساسية)');--Total Due Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TotalSales', 'إجمالي المبيعات :');--Total Sales :
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranCode', 'كود المعاملة');--Tran Code
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranId', 'معرف المعاملة');--Tran Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TranIdParameter', 'TranId: # {0}');--TranId: #{0}
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionDate', 'تاريخ المعاملة');--Transaction Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionDetails', 'تفاصيل المعاملة');--Transaction Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionStartDate', 'تاريخ بداية تسجيل المعاملات');--Transaction Start Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionStatement', 'بيان المعاملة');--TransactionStatement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionStatus', 'حالة المعاملة');--Transaction Status
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionSummary', 'ملخص المعاملة');--Transaction Summary
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionTimestamp', 'الطابع الزمني للمعاملة');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionType', 'نوع المعاملة');--Transaction Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransactionValue', 'قيمة المعاملة');--Transaction Value
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TransferDetails', 'تفاصيل التحويل');--Transfer Details
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'TrialBalance', 'ميزان المراجعة');--Trial Balance
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Tuesday', 'الثلاثاء');--Tuesday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Type', 'نوع');--Type
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UncheckAll', 'الغاء الكل');--Uncheck All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Undo', 'تراجع');--Undo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Unit', 'وحدة');--Unit
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitId', 'معرف الوحدة');--Unit Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitName', 'اسم الوحدة');--Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnitsOfMeasure', 'وحدات القياس');--Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UnknownError', 'فشلت العملية بسبب خطأ غير معروف.');--Operation failed due to an unknown error.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Untitled', 'بدون عنوان');--Untitled
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Update', 'التحديث');--Update
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdateAll', 'تحديث الجميع');--Update All
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdateConsole', 'وحدة التحكم التحديث');--Update Console
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdatedExchangeRates', 'تحديث أسعار الصرف');--Update Exchange Rates
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UpdatedOn', 'تم التحديث في');--Updated On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Upload', 'تحميل');--Upload
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UploadAttachments', 'تحميل المرفقات');--Upload Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UploadAttachmentsForThisTransaction', 'تحميل المرفقات لهذه المعاملة');--Upload Attachments for This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UploadLogo', 'تحميل الشعار');--Upload Logo
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Url', 'رابط');--Url
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Use', 'استعمال');--Use
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'User', 'المستخدم');--User
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UserId', 'معرف المستخدم');--User Id
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'UserManagement', 'إدارة المستخدمين');--User Management
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Username', 'اسم المستخدم');--Username
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Users', 'المستخدمين');--Users
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VAT', 'ضريبة القيمة المضافة (VAT)');--VAT
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VATOrGST', 'VAT/GST');--VAT/GST
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VacuumDatabase', 'تفريغ قاعدة البيانات');--Vacuum Database
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VacuumFullDatabase', 'تفريغ قاعدة البيانات (كاملة)');--Vacuum Database (Full)
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Value', 'القيمة');--Value
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ValueDate', 'قيمة التاريخ');--Value Date
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Verification', 'التحقق');--Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerificationReason', 'سبب التحقق');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifiedBy', 'تم التحقق بواسطة');--Verified By
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifiedOn', 'تم التحقق في');--VerifiedOn
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Verify', 'تحقق من');--Verify
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifyContracts', 'تحقق من العقود');--Verify Contracts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifyExits', 'تحقق التخارج');--Verify Exits
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifyLeaveApplications', 'التحقق من طلبات الإجازة');--Verify Leave Applications
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifyResignations', 'تحقق من الاستقالات');--Verify Resignations
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VerifyTerminations', 'تحقق الإنهاءات');--Verify Terminations
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VersionName', 'اسم الإصدار');--Version Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'View', 'عرض');--View
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewAttachments', 'مشاهدة المرفقات');--View Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewBackups', 'عرض النسخ الاحتياطية');--View Backups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewCustomerCopy', 'عرض نسخة العميل');--View Customer Copy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewEmptyExceptionMessage', 'خاصية "View" لا يمكن أن يترك فارغا.');--The property 'View' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewSalesInovice', 'عرض فاتورة المبيعات');--View Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewSchemaEmptyExceptionMessage', 'الخاصية "ViewSchema" لا يمكن أن تترك فارغة.');--The property 'ViewSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAcknowledgement', 'عرض هذا الاشعار');--View This Acknowledgement
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAdjustment', 'عرض هذه التسوية');--View This Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisAuthorization', 'عرض هذا التفويض');--View This Authorization
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisDelivery', 'عرض هذا التسليم');--View This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisInvoice', 'عرض هذه الفاتورة');--View This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisNote', 'عرض هذه المذكرة');--View This Note
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisOrder', 'عرض هذا الأمر');--View This Order
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisQuotation', 'عرض هذا التسعير');--View This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisRequest', 'عرض هذا الطلب');--View This Request
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisReturn', 'عرض هذه المردودات');--View This Return
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'ViewThisTransfer', 'عرض هذا التحويل');--View This Transfer
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VoucherVerification', 'تحقق سند قيد يومية');--Voucher Verification
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'VoucherVerificationPolicy', 'سياسة تحقق سند قيد اليومية');--Voucher Verification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Wage', 'الأجور');--Wage
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WageProcessing', 'تجهيز الأجور');--Wage Processing
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WageSetups', 'اعدادات الأجور');--Wage Setups
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Wages', 'أجور');--Wages
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Warning', 'تحذير');--Warning
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WasPresent', 'كان حاضرا');--Was Present
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Wednesday', 'الاربعاء');--Wednesday
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WeekStartsOn', 'يبدأ الاسبوع في');--Week Starts On
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WhichBank', 'اي بنك؟');--Which Bank?
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Widget', 'الاداة');--Widget
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WidgetManager', 'مدير الادوات');--Widget Manager
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Widgets', 'الادوات');--Widgets
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Withdraw', 'سحب');--Withdraw
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WithdrawTransaction', 'سحب معاملة');--Withdraw Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Withdrawn', 'سحب');--Withdrawn
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WithdrawnTransactions', 'سحب المعاملات');--Withdrawn Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WorkShifts', 'نوبات العمل');--Work Shifts
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Workflow', 'سير العمل');--Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'WorldSalesStatistics', 'احصائيات مبيعات الشركة العالمية');--World Sales Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Year', 'سنة');--Year
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'Yes', 'نعم');--Yes
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'YourName', 'اسمك');--Your Name
SELECT * FROM localization.add_localized_resource('Titles', 'ar', 'YourOffice', 'شركتك');--Your Office
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'AccessIsDenied', 'تم رفض الوصول.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'BackupDirectoryNotFound', 'دليل النسخ الاحتياطي غير موجود');--Backup directory was not found.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateABackup', 'عذرا، لا يمكن إنشاء نسخة احتياطية قاعدة البيانات في هذا الوقت.');--Sorry, cannot create a database backup at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateFlagTransactionTableNull', 'لا يمكن إنشاء أو تحديث العلامة، لم تدخل جدول المعاملة.');--Cannot create or update flag. Transaction table was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotCreateFlagTransactionTablePrimaryKeyNull', 'لا يمكن إنشاء أو تحديث العلامة، لم تدخل المفتاح الرئيسي جدول المعاملة.');--Cannot create or update flag. Transaction table primary key was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeAlreadyMerged', 'المعاملات المحددة تحتوي علي اصناف تم دمجها. حاول مرة اخرى.');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeDifferentPartyTransaction', 'لا يمكن دمج معاملات اطراف مختلفة دفعة واحدة. حاول مرة اخرى.');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeIncompatibleTax', 'لا يمكن دمج معاملات تحتوي علي أنواع ضرائب غير متوافقة. حاول مرة اخرى.');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotMergeUrlNull', 'لا يمكن دمج المعاملات. لم يتم توفير رابط الدمج.');--Cannot merge transactions. The merge url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CannotSendEmailSMTPInvalid', 'لا يمكنك إرسال البريد الإلكتروني. اعدادات SMTP غير صالحة.');--Cannot send the email. The SMTP configuration is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CashTransactionCannotContainBankInfo', 'لا يمكن أن يحتوي المعاملات النقدية تفاصيل المعاملة البنكية.');--A cash transaction cannot contain bank transaction details.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CompareAmountErrorMessage', '(المبلغ من)  يجب أن تكون أكبر من (المبلغ الي)');--The amount to should be greater than the amount from.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CompareDaysErrorMessage', '(الي ايام) يجب أن تكون أقل من (من ايام)');--From days should be less than to days.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ComparePriceErrorMessage', '(السعر الي) يجب أن يكون أقل من (السعر من)');--Price from should be less than price to.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ConfigurationError', 'لا يمكن الاستمرار في المهمة. يرجى تصحيح مشكلات الاعدادات.');--Cannot continue the task. Please correct configuration issues.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ConfirmationPasswordDoesNotMatch', 'تأكيد كلمة السر غير متطابقة مع كلمة السر');--The confirmation password does not match with the new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CouldNotDetermineEmailImageParserType', 'لا يمكن تحديد نوع صورة محلل للبريد الإلكتروني.');--Could not determine image parser type for email.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'CouldNotRegisterJavascript', 'لا يمكن تسجيل جافا سكريبت في هذه الصفحة لأن  الصفحة غير صالحة أو فارغة.');--Could not register JavaScript on this page because the page instance was invalid or empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DateErrorMessage', 'التاريخ المحدد غير صالح.');--Selected date is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DueFrequencyErrorMessage', 'ايام الاستحقاق بسبب يجب أن تكون صفر إذا تم اختيار فترة الاستحقاق.');--Due days should be 0 if due frequency id is selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DuplicateEntry', 'تكرار الادخال.');--Duplicate entry.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'DuplicateFiles', 'الملفات مكررة.');--Duplicate files.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'GridViewEmpty', 'Gridview فارغ.');--Gridview is empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InsufficientBalanceInCashRepository', 'لا يوجد رصيد كاف في الخزينة النقدية لمعالجة هذه المعاملة.');--There is no sufficient balance in the cash repository to process this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InsufficientStockWarning', 'فقط {0} {1} من {2} متبقي من المخزون.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidAccount', 'الحساب غير صالح.');--Invalid account.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidCashRepository', 'الخزينة النقدية صالح.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidCostCenter', 'مركز تكلفة غير صالح.');--Invalid cost center.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidData', 'بيانات غير صالحة.');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidDate', 'التاريخ غير صالح.');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidFileExtension', 'امتداد الملف خاطئ.');--Invalid file extension.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidParameterName', 'Npgsql اسم المعلمة غير صالح {0}. . تأكد من أن اسم المعلمة متشابه مع نص الأمر.');--Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your command text.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidParty', 'طرف غير صالح');--Invalid party.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidPaymentTerm', 'مصطلح الدفع غير صالحة.');--Invalid payment term.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidPriceType', 'نوع السعر غير صالح.');--Invalid price type.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidReceiptMode', 'ضع الايصال غير صالح.');--Invalid receipt mode.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidRequest', 'طلب غير صالح.');--Invalid Request.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidRequestId', 'RequestId غيرصالح.');--Invalid RequestId.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSalesPerson', 'مندوب مبيعات غير صالح.');--Invalid salesperson.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidShippingCompany', 'شركة الشحن غير صالحة.');--Invalid shipping company.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidStockTransaction', 'معاملة المخزون غير صالحة.');--Invalid stock transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidStore', 'مخزن غير صالح.');--Invalid store.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryDelivery', 'SubTranBook "تسليم المخزون" غير صالح');--Invalid SubTranBook "Inventory Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryDirect', 'SubTranBook "المخزون المباشر" غير صالح');--Invalid SubTranBook "Inventory Direct"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryInvoice', 'SubTranBook "فاتورة المخزون" غير صالحة');--Invalid SubTranBook "Inventory Invoice"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryOrder', 'SubTranBook "طلب المخزون" غير صالح');--Invalid SubTranBook "Inventory Order"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryPayment', 'SubTranBook "مدفوعات المخزون" غير صالحة');--Invalid SubTranBook "Inventory Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryQuotation', 'SubTranBook "تسعير المخزون" غير صالح');--Invalid SubTranBook "Inventory Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryReceipt', 'SubTranBook "استلام المخزون" غير صالح');--Invalid SubTranBook "Inventory Receipt"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookInventoryReturn', 'SubTranBook "مرتجع المخزون" غير صالح');--Invalid SubTranBook "Inventory Return"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseDelivery', 'SubTranBook "تسليم المشتريات" غير صالح');--Invalid SubTranBook "Purchase Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseQuotation', 'SubTranBook "تسعير المشتريات" غير صالح');--Invalid SubTranBook "Purchase Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseSuspense', 'SubTranBook "ارجاء المشتريات" غير صاالح');--Invalid SubTranBook "Purchase Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookPurchaseTransfer', 'SubTranBook "تحويل المشتريات" غير صالح');--Invalid SubTranBook "Purchase Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesPayment', 'SubTranBook "مدفوعات المبيعات" غير صالحة');--Invalid SubTranBook "Sales Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesSuspense', 'SubTranBook "ارجاء المبيعات" غير صالحة');--Invalid SubTranBook "Sales Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidSubTranBookSalesTransfer', 'SubTranBook "نقل مبيعات" غير صالح');--Invalid SubTranBook "Sales Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'InvalidUser', 'مستخدم غير صالح.');--Invalid user.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ItemErrorMessage', 'لديك اختيار إما معرف الصنف أو مركب معرف الصنف.');--You have to select either item id or  compound item id.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'LateFeeErrorMessage', 'يجب اختيار معرف رسوم التأخير ومعرف فترة ترحيل رسوم التاخير او عدم الاختيار.');--Late fee id and late fee posting frequency id both should be either selected or not.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NegativeValueSupplied', 'تم ادخال قيمة سالية.');--Negative value supplied.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NewPasswordCannotBeOldPassword', 'كلمة المرور الجديدة لا يمكن أن تكون كلمة السر القديمة.');--New password can not be old password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NoFileSpecified', 'لا يوجد ملف محدد.');--No file specified.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NoTransactionToPost', 'لا توجد معاملات للترحيل.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NotAuthorized', 'غير مصرح لك بالوصول إلى هذه الموارد في الوقت الحالي.');--You are not authorized to access this resource at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'NothingSelected', 'لم يتم اختيار شئ.');--Nothing selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PasswordCannotBeEmpty', 'كلمة السر لا يمكن أن يكون فارغة.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PleaseEnterCurrentPassword', 'الرجاء إدخال كلمة المرور الحالية.');--Please enter your current password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'PleaseEnterNewPassword', 'يرجى إدخال كلمة مرور جديدة.');--Please enter a new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'RecurringAmountErrorMessage', 'لا ينبغي أن يكون المبلغ المتكرر أقل من أو يساوي 0.');--Recurring amount should not be less than or equal to 0.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ReferencingSidesNotEqual', 'كلا مرجع الجانبين ليست متساوية.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'RestrictedTransactionMode', 'هذه الشركة لا تسمح بترحيل المعاملة.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'ReturnButtonUrlNull', 'لا يمكن العودة . لم يتم توفير رابط العودة.');--Cannot return this entry. The return url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'StartDateGreaterThanEndDate', 'تاريخ البدء لا يمكن أن يكون أكبر من تاريخ انتهاء.');--The start date cannot be greater than end date.
SELECT * FROM localization.add_localized_resource('Warnings', 'ar', 'UserIdOrPasswordIncorrect', 'اسم المستخدم أو كلمة المرور غير صحيحة.');--User id or password incorrect.

