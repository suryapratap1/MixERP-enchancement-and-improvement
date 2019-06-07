/********************************************************************************************************************************************************
Contributors for this translation:
Jonathan Valle https://github.com/JonathanValle

Spanish   es    Español
********************************************************************************************************************************************************/
SELECT * FROM localization.add_localized_resource('CommonResource', 'es', 'DateMustBeGreaterThan', 'Fecha no válida. Debe ser mayor que "{0}".');--Invalid date. Must be greater than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'es', 'DateMustBeLessThan', 'Fecha no válida. Debe ser inferior a "{0}".');--Invalid date. Must be less than "{0}".
SELECT * FROM localization.add_localized_resource('CommonResource', 'es', 'InvalidDate', 'Fecha no válida.');--Invalid date.
SELECT * FROM localization.add_localized_resource('CommonResource', 'es', 'NoRecordFound', 'Lo sentimos, no se encontraron registros.');--Sorry, no record found.
SELECT * FROM localization.add_localized_resource('CommonResource', 'es', 'RequiredField', 'Este es un campo obligatorio.');--This is a required field.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P1301', 'No se puede calcular el interés. No se proporcionó el número de días en un año.');--Cannot calculate interest. The number of days in a year was not provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P1302', 'No se puede publicar ventas. Asignación de cuentas de efectivo no válida en almacén.');--Cannot post sales. Invalid cash account mapping on store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3000', 'Los datos no válidos.');--Invalid data.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3001', 'Nombre de usuario no válido.');--Invalid user name.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3005', 'La contraseña no puede estar vacía.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3006', 'Por favor ingrese su nueva contraseña.');--Please provide a new password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3007', 'Fecha no válida.');--Invalid value date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3008', 'Fecha no válida.');--Invalid date.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3009', 'Período especificado no es válido.');--Invalid period specified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3010', 'Identificación del despacho no es válida.');--Invalid office id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3011', 'La oficina no es válida.');--Invalid office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3012', 'Almacén no válida.');--Invalid store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3013', 'Depósito de efectivo no es válido.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3050', 'Partida no válido.');--Invalid party.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3051', 'Artículo no válido.');--Invalid item.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3052', 'Unidad no válida.');--Invalid unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3053', 'Unidad no válida o incompatible.');--Invalid or incompatible unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3054', 'La unidad de reorden es incompatible con la unidad base.');--The reorder unit is incompatible with the base unit.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3055', 'Tipo de cambio no es válido.');--Invalid exchange rate.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3101', 'Login Id no válido.');--Invalid LoginId.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3105', 'Su contraseña actual es incorrecta.');--Your current password is incorrect.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3201', 'Artículo / Unidad desajustado.');--Item/unit mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3202', 'Formulario de impuestos no congruente.');--Tax form mismatch.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3301', 'Cantidad no válida.');--Invalid quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3302', 'Identificación de la transacción no válida.');--Invalid transaction id.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P3501', 'La columna account_id no puede ser nulo.');--The column account_id cannot be null.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P4010', 'No se encontró el tipo de cambio entre las monedas.');--Exchange rate between the currencies was not found.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P4020', 'Este artículo no está asociada con esta transacción.');--This item is not associated with this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P4030', 'Sin política de verificación para este usuario.');--No verification policy found for this user.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P4031', 'Por favor pedir a otra persona verificar su transacción.');--Please ask someone else to verify your transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5000', 'Diferencia en asientos contables.');--Referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5001', 'Existencia negativa no esta permitida.');--Negative stock is not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5002', 'Publicar esta transacción produciría un saldo negativo de caja .');--Posting this transaction would produce a negative cash balance.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5010', 'Transacciones con fecha anteriores no están permitidas.');--Past dated transactions are not allowed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5100', 'Este establecimiento no permite la publicación de transacciones.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5101', 'No se puede publicar la transacción durante el modo de operación restringido.');--Cannot post transaction during restricted transaction mode.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5102', 'Fin de la operación de día terminada.');--End of day operation was already performed.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5103', 'Transacciones con fecha del pasado en la cola de verificación.');--Past dated transactions in verification queue.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5104', 'Por favor, verificar las transacciones antes de realizar la operación final de día.');--Please verify transactions before performing end of day operation.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5110', 'No se puede proporcionar información impuesto sobre las ventas para las ventas de los no imponibles.');--You cannot provide sales tax information for non taxable sales.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5111', 'Información de la transacción bancaria inválida proporcionada.');--Invalid bank transaction information provided.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5112', 'Información de tarjeta de pago válida.');--Invalid payment card information.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5113', 'No se pudo encontrar una cuenta para publicar los gastos de honorarios de comerciante.');--Could not find an account to post merchant fee expenses.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5201', 'Una entrada de ajuste de valores no puede contener punto (s) de débito.');--A stock adjustment entry can not contain debit item(s).
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5202', 'Un elemento puede aparecer sólo una vez en una tienda.');--An item can appear only once in a store.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5203', 'La cantidad devuelta no puede ser mayor que la cantidad real.');--The returned quantity cannot be greater than actual quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5204', 'El importe devuelto no puede ser mayor que la cantidad real.');--The returned amount cannot be greater than actual amount.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5301', 'Transacción no válida o rechazado.');--Invalid or rejected transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5500', 'Cantidad de artículos insuficiente.');--Insufficient item quantity.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5800', 'Eliminación de una transacción no está permitido. Marque la transacción rechazada en su lugar.');--Deleting a transaction is not allowed. Mark the transaction as rejected instead.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5901', 'Por favor solicitar a otra persona para verificar la transacción.');--Please ask someone else to verify the transaction you posted.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5910', 'Se superó el Límite de Auto verificación .');--Self verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5911', 'Se superó el Límite de verificación de las ventas. La transacción no se verificó.');--Sales verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5912', 'Se superó el Límite de verificación de Compra. La transacción no se verificó.');--Purchase verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P5913', 'Se superó el Límite de verificación CG. La transacción no se verificó.');--GL verification limit exceeded. The transaction was not verified.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P6010', 'Configuración no válida: método de costo de ventas.');--Invalid configuration: COGS method.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8001', 'No se puede producir declaración P / L de oficina (s) con diferentes monedas base.');--Cannot produce P/L statement of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8002', 'No se puede producir balance de comprobación de oficina (s) con diferentes monedas base.');--Cannot produce trial balance of office(s) having different base currencies.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8003', 'No se puede tener una moneda diferente de la cuenta CG asignada.');--You cannot have a different currency on the mapped GL account.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8101', 'Operación FDD ya se ha inicializado.');--EOD operation was already initialized.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8501', 'Sólo se requiere una columna.');--Only one column is required.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8502', 'No se puede actualizar la columna.');--Cannot update column.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8990', 'No se le permite cambiar las cuentas del sistema.');--You are not allowed to change system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8991', 'No se le permite añadir cuentas del sistema.');--You are not allowed to add system accounts.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P8992', 'Un usuario sys no puede tener una contraseña.');--A sys user cannot have a password.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9001', 'Acceso denegado.');--Access is denied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9010', 'Acceso denegado. Usted no está autorizado para publicar esta transacción.');--Access is denied. You are not authorized to post this transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9011', 'Acceso denegado. Los valores suministrados no son válidos.');--Access is denied. Invalid values supplied.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9012', 'Acceso denegado! Una transacción de ajuste de valores no puede referencias múltiples ramas.');--Access is denied! A stock adjustment transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9013', 'Acceso denegado! Una transacción de acciones revista no puede referencias múltiples ramas.');--Access is denied! A stock journal transaction cannot references multiple branches.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9014', 'Acceso denegado. No se puede verificar una transacción de otra oficina.');--Access is denied. You cannot verify a transaction of another office.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9015', 'Acceso denegado. No se puede verificar transacción con fecha pasadas.');--Access is denied. You cannot verify past or futuer dated transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9016', 'Acceso denegado. Usted no tiene derecho de verificar la transacción.');--Access is denied. You don''t have the right to verify the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9017', 'Acceso denegado. Usted no tiene derecho de retirar la transacción.');--Access is denied. You don''t have the right to withdraw the transaction.
SELECT * FROM localization.add_localized_resource('DbErrors', 'es', 'P9201', 'Acess denegado. No se puede actualizar la tabla "transaction_details".');--Acess is denied. You cannot update the "transaction_details" table.
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'actions', 'acciones');--Actions
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'amount', 'cantidad');--Amount
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'currency', 'moneda');--Currency
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'flag_background_color', 'Color de Fondo de la Bandera');--Flag Background Color
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'flag_foreground_color', 'Color de primer plano de la Bandera ');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'id', 'identificador');--ID
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'office', 'oficina');--Office
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'party', 'partida');--Party
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'reference_number', 'Número de referencia');--Reference Number
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'statement_reference', 'Declaración de Referencia');--Statement Reference
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'transaction_ts', 'Marca de tiempo de transacción');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'user', 'usuario');--User
SELECT * FROM localization.add_localized_resource('DbResource', 'es', 'value_date', 'Fecha');--Value Date
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'BothSidesCannotHaveValue', 'Tanto débito y crédito no pueden tener valores.');--Both debit and credit cannot have values.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'CompoundUnitOfMeasureErrorMessage', 'La unidad base y la unidad de comparación no pueden ser iguales.');--Base unit id and compare unit id cannot be same.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InsufficientStockWarning', 'Sólo {0} {1} de {2} dejados en Inventarios.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InvalidSubTranBookPurchaseDelivery', 'Transacciones Subsidiarios en libro "Compra de Entrega" no validos');--Invalid SubTranBook 'Purchase Delivery'.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InvalidSubTranBookPurchaseQuotation', 'Transacciones Subsidiarios en libro "Cotización de Compra" no válidos');--Invalid SubTranBook 'Purchase Quotation'.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InvalidSubTranBookPurchaseReceipt', 'Transacciones Subsidiarios del libro "recibo de compra" Inválido');--Invalid SubTranBook 'Purchase Receipt'.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InvalidSubTranBookSalesPayment', 'Transacciones Subsidiarios libro "de venta" no válida');--Invalid SubTranBook 'Sales Payment'.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'InvalidUserId', 'ID de usuario válido.');--Invalid user id.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'KeyValueMismatch', 'Hay un recuento de una mala adaptación de los elementos clave / valor en esta lista de control.');--There is a mismatching count of key/value items in this ListControl.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'NoTransactionToPost', 'Ninguna transacción para enviar.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Errors', 'es', 'ReferencingSidesNotEqual', 'Los lados que hacen referencia no son iguales.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'AllFieldsRequired', 'Todos los campos son obligatorios.');--All fields are required.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'CannotWithdrawNotValidGLTransaction', 'No se puede retirar transacción. Esto es una transacción de libro mayor no valida.');--Cannot withdraw transaction. This is a not a valid GL transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'CannotWithdrawTransaction', 'No se puede retirar transacción.');--Cannot withdraw transaction.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'ClickHereToDownload', 'Haga clic aquí para descargar.');--Click here to download.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'ConfirmedPasswordDoesNotMatch', 'La confirmación de contraseña no coincide.');--The confirmed password does not match.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'DatabaseBackupSuccessful', 'La copia de Seguridad de Base de Datos se ha Realizado correctamente.');--The database backup was successful.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'DaysLowerCase', 'días');--days
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'EODBegunSaveYourWork', 'Por favor, cierre esta ventana y guarde su trabajo antes de salir automáticamente.');--Please close this window and save your existing work before you will be signed off automatically.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'EmailBody', 'h2> Hola, </ h2> <p> Por favor, encontrar el documento adjunto. </ p> <p> Gracias. <br /> MixERP </ p>');--<h2>Hi,</h2><p>Please find the attached document.</p><p>Thank you.<br />MixERP</p>
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'EmailSentConfirmation', 'Un correo electrónico fue enviado a {0}.');--An email was sent to {0}.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'FlagLabel', 'Puede marcar esta transacción con una bandera, sin embargo usted no será capaz de ver las banderas creadas por otros usuarios.');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'GoToChecklistWindow', 'Ir a la ventana Lista de comprobación.');--Go to checklist window.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'GoToTop', 'Ir a la parte superior.');--Go to top.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'JustAMomentPlease', 'Un momento, por favor!');--Just a moment, please!
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'NumRowsAffected', '{0} filas afectadas.');--{0} rows affected.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'OpeningInventoryAlreadyEntered', 'Inventario de apertura ya se ha introducido para esta función.');--Opening inventory has already been entered for this office.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'PartyDescription', 'Partes se refieren colectivamente a los proveedores, clientes, agentes y distribuidores.');--Parties collectively refer to suppliers, customers, agents, and dealers.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'SelectAFlag', 'Seleccione una bandera.');--Select a flag.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TaskCompletedSuccessfully', 'Tarea completada con éxito.');--Task completed successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'ThankYouForYourBusiness', 'Gracias por su compra.');--Thank you for your business.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'ThisFieldIsRequired', 'Este campo es obligatorio.');--This field is required.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionApprovedDetails', 'Esta operación fue aprobada por {0} del {1}.');--This transaction was approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionAutoApprovedDetails', 'Esta operación fue aprobada automáticamente por {0} del {1}.');--This transaction was automatically approved by {0} on {1}.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionAwaitingVerification', 'Esta transacción está pendiente de verificación por parte de un administrador.');--This transaction is awaiting verification from an administrator.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionClosedDetails', 'Esta operación se ha cerrado por {0} del {1}. Motivo: "{2}".');--This transaction was closed by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionPostedSuccessfully', 'La transacción se registró con éxito.');--The transaction was posted successfully.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionRejectedDetails', 'Esta transacción fue rechazada por {0} del {1}. Motivo: "{2}".');--This transaction was rejected by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionWithdrawalInformation', 'Cuando usted retira una transacción, no se enviará al módulo de flujo de trabajo. Esto significa que sus transacciones retirados son rechazados y no requieren mayor verificación. Sin embargo, usted no será capaz de unwithdraw esta transacción después.');--When you withdraw a transaction, it won't be forwarded to the workflow module. This means that your withdrawn transactions are rejected and require no further verification. However, you won't be able to unwithdraw this transaction later.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionWithdrawnDetails', 'Esta transacción fue retirado por {0} del {1}. Motivo: "{2}".');--This transaction was withdrawn by {0} on {1}. Reason: "{2}".
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'TransactionWithdrawnMessage', 'La transacción fue retirado con éxito. Además, esta acción afectará a los todos los informes producidos en y después de "{0}".');--The transaction was withdrawn successfully. Moreover, this action will affect the all the reports produced on and after "{0}".
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'UserGreeting', 'Hola {0}!');--Hi {0}!
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'YourPasswordWasChanged', 'Su contraseña ha sido cambiada.');--Your password was changed.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'AreYouSure', 'Estás seguro?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'CouldNotDetermineVirtualPathError', 'No se pudo determinar ruta virtual para crear una imagen.');--Could not determine virtual path to create an image.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'DuplicateFile', 'Los archivos duplicados!');--Duplicate File!
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODDoNotCloseWindow', 'Por favor, no cierre esta ventana o salir de esta página durante la inicialización.');--Please do not close this window or navigate away from this page during initialization.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODElevatedPriviledgeCanLogIn', 'Durante el período de días de extremo, sólo se permiten a los usuarios que tienen privilegios elevados para acceder al sistema.');--During the day-end period, only users having elevated privilege are allowed to log-in.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODLogsOffUsers', 'Al inicializar la operación al final del día, el que ya ha iniciado la sesión en los usuarios de aplicaciones incluidas se cierra la sesión en 120 segundos.');--When you initialize day-end operation, the already logged-in application users including you are logged off on 120 seconds.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODProcessIsIrreversible', 'Este proceso es irreversible.');--This process is irreversible.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODRoutineTasks', 'Durante Fin de la operación el día, se llevan a cabo tareas rutinarias, como el cálculo de intereses, los asentamientos, y la generación de informes.');--During EOD operation, routine tasks such as interest calculation, settlements, and report generation are performed.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'EODTransactionPosting', 'Al realizar Fin de la operación el día para una fecha en particular, no hay ninguna transacción en esa fecha o antes de que pueda ser alterado, cambiado o eliminado.');--When you perform EOD operation for a particular date, no transaction on that date or before can be altered, changed, or deleted.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'InvalidFile', 'Archivo no válido!');--Invalid file!
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'TempDirectoryNullError', 'No se puede crear una imagen cuando el directorio temporal es nulo.');--Cannot create an image when the temp directory is null.
SELECT * FROM localization.add_localized_resource('Messages', 'es', 'UploadFilesDeleted', 'Los archivos subidos se eliminaron con éxito.');--The uploaded files were successfully deleted.
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'AreYouSure', 'Estás seguro?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'CannotAccessAccount', 'No se puede acceder a su cuenta?');--Cannot access your account?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'ConfirmAnalyze', 'Esto bloqueará el acceso de base de datos de clientes durante la ejecución. ¿Seguro que deseas ejecutar esta acción en este momento?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'ConfirmVacuum', 'Esto bloqueará el acceso de base de datos de clientes durante la ejecución. ¿Seguro que deseas ejecutar esta acción en este momento?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'ConfirmVacuumFull', 'Esto bloqueará el acceso de base de datos de clientes durante la ejecución. ¿Seguro que deseas ejecutar esta acción en este momento?');--This will lock client database access during execution. Are you sure you want to execute this action right now?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'WhatIsYourHomeCurrency', '¿Cuál es su principal moneda?');--What Is Your Home Currency?
SELECT * FROM localization.add_localized_resource('Questions', 'es', 'WithdrawalReason', '¿Por qué quieres que retire esta transacción?');--Why do you want to withdraw this transaction?
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'Select', 'seleccionar');--Select
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account', 'cuenta');--Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_id', 'Identificador cuenta');--Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_master', 'cuenta Maestra');--Account Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_master_code', 'Código Cuenta Maestra');--Account Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_master_id', 'identificador Cuenta Maestra');--Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_master_name', 'Nombre Cuenta Maestra');--Account Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_name', 'Nombre De La Cuenta');--Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'account_number', 'Número De Cuenta');--Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'address', 'dirección');--Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'address_line_1', 'Dirección Línea 1');--Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'address_line_2', 'Dirección Línea 2');--Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'ageing_slab_id', 'Envejecimiento Slab identificador');--Ageing Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'ageing_slab_name', 'Envejecimiento Slab Nombre');--Ageing Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'allow_credit', 'permitir crédito');--Allow Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'allow_sales', 'permitir Ventas');--Allow Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'allow_transaction_posting', 'Permitir exponer Transacción');--Allow Transaction Posting
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'amount', 'cantidad');--Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'amount_from', 'cantidad De');--Amount From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'amount_to', 'La cantidad a');--Amount To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'analyze_count', 'analizar recuento');--Analyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'api_access_policy_id', 'API de acceso Id Política');--API Access Policy Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'api_access_policy_uix', 'Duplicar entrada para API Política de Acceso');--Duplicate Entry for API Access Policy
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'applied_on_shipping_charge', 'Aplicado en el envío de carga');--Applied on Shipping Charge
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'audit_ts', 'Marca de tiempo de Auditoría');--Audit Timestamp
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'audit_user_id', 'Auditoría identificador de usuario');--Audit User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'auto_trigger_on_sales', 'disparador automático en Ventas');--Automatically Trigger on Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'autoanalyze_count', 'Auto analizar recuento');--Autoanalyze Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'autovacuum_count', 'Recuento de vaciado');--Autovacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'background_color', 'color de fondo');--Background Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'balance', 'el balance');--Balance
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_account_number', 'Número de cuenta bancaria');--Bank Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_account_type', 'Tipo de cuenta bancaria');--Bank Account Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_accounts_account_id_chk', 'El elemento seleccionado no es una cuenta bancaria válida.');--The selected item is not a valid bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_accounts_pkey', 'Duplicar cuenta bancaria.');--Duplicate bank account.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_address', 'Dirección del banco');--Bank Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_branch', 'Sucursal Bancaria');--Bank Branch
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_contact_number', 'Teléfono de contacto del Banco');--Bank Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bank_name', 'Nombre del banco');--Bank Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'base_unit_id', 'identificador Base de unidad');--Base Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'base_unit_name', 'Nombre Unidad Base');--Base Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'based_on_shipping_address', 'Basado en la dirección de envío');--Based On Shipping Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_rate', 'Bono Calificar');--Bonus Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_slab_code', 'Bono Código losa');--Bonus Slab Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_slab_detail_id', 'Bono Identificador Detalle Losa');--Bonus Slab Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_slab_details_amounts_chk', 'El "equivalen a" campo debe ser mayor que "Cantidad De".');--The field "AmountTo" must be greater than "AmountFrom".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_slab_id', 'Bono losa identificador');--Bonus Slab Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'bonus_slab_name', 'Bono Nombre losa');--Bonus Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'book', 'libro');--Book
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'book_date', 'Fecha del libro');--Book Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'brand', 'marca');--Brand
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'brand_code', 'Códigos por Marca');--Brand Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'brand_id', 'Identificador de Marca');--Brand Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'brand_name', 'Marca');--Brand Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'browser', 'navegador');--Browser
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'can_change_password', 'Puede cambiar la contraseña');--Can Change Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'can_self_verify', '¿Puede auto verificarse');--Can Self Verify
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'can_verify_gl_transactions', 'Puede verificar las transacciones libro mayor');--Can Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'can_verify_purchase_transactions', 'Se puede verificar Transacciones de Compra');--Can Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'can_verify_sales_transactions', 'Puede verificar las transacciones de venta');--Can Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'card_type', 'Tipo De Tarjeta');--Card Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'card_type_code', 'Código Tipo de tarjeta');--Card Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'card_type_id', 'identificación de Tipo de tarjeta');--Card Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'card_type_name', 'Nombre Tipo de Tarjeta');--Card Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading', 'Encabezado del Flujo de Caja');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading_cash_flow_heading_type_chk', 'Inválido flujo de caja Tipo de rúbrica. Valores posibles: O, I, F.');--Invalid Cashflow Heading Type. Allowed values: O, I, F.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading_code', 'Código de Encabezado para Flujo de Efectivo');--Cash Flow Heading Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading_id', 'Identificador de Denominación de Flujo de Caja');--Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading_name', 'Flujo de Efectivo Nombre Denominación');--Cash Flow Heading Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_heading_type', 'Tipo Rubro flujo de caja');--Cashflow Heading Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_master_code', 'Código Maestro Flujo de Caja');--Cash Flow Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_master_id', 'Identificador Flujo de Caja maestro ');--Cash Flow Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_master_name', 'Nombre Flujo de Caja maestro ');--Cash Flow Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_flow_setup_id', 'Identificador de configuración del  flujo de caja');--Cashflow Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repositories_cash_repository_code_uix', 'Duplicar Código Repositorio de efectivo ');--Duplicate Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repositories_cash_repository_name_uix', 'Duplicar Nombre del Repositorio de efectivo');--Duplicate Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repository', 'Repositorio de Efectivo');--Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repository_code', 'Código Repositorio de efectivo');--Cash Repository Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repository_id', 'Identificador Repositorio de Efectivo');--Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cash_repository_name', 'Nombre de Repositorio Efectivo');--Cash Repository Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cell', 'célula');--Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'charge_interest', 'cargo de interés');--Charge Interest
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'check_nexus', 'Compruebe nexo');--Check Nexus
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'checking_frequency', 'Comprobación de frecuencia');--Checking Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'checking_frequency_id', 'Identificador  Comprobación Frecuencia');--Checking Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'city', 'ciudad');--City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'collecting_account', 'Recopilación cuenta');--Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'collecting_account_id', 'Identificador Recopilación Cuenta');--Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'collecting_tax_authority', 'Recogida de Administración Tributaria');--Collecting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'collecting_tax_authority_id', 'identificador Recopilación de Administración Tributaria');--Collecting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'commision_rate', 'Comisión de Tarifas');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'commission_rate', 'Comisión de Tarifas');--Commission Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'company_name', 'Nombre De Empresa');--Company Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compare_unit_id', 'identificador Comparar unidad');--Compare Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compare_unit_name', 'Nombre Comparar Unidad');--Compare Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item', 'Compuesto de artículo');--Compound Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item_code', 'Código  Compuesto del artículo');--Compound Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item_detail_id', 'Identificador Detalle Elemento Compuesto ');--Compound Item Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item_details_unit_chk', 'Unidad proporcionada no válida.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item_id', 'Identificador Compuesto de artículo');--Compound Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_item_name', 'Compuesto Nombre del artículo');--Compound Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_unit_id', 'Identificador de la unidad Compuesta');--Compound Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compound_units_chk', 'El identificador unidad base no puede ser el mismo.');--The base unit id cannot same as compare unit id.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'compounding_frequency', 'Combincacion de Frecuencia');--Compounding Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'confidential', 'confidencial');--Confidential
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_address_line_1', 'Dirección de Contacto Línea 1');--Contact Address Line 1
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_address_line_2', 'Dirección de Contacto Línea 2');--Contact Address Line 2
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_cell', 'Contacto Teléfono celular');--Contact Cell
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_city', 'Ciudad');--Contact City
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_country', 'País');--Contact Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_email', 'Correo electrónico de contacto');--Contact Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_number', 'Teléfono de contacto');--Contact Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_person', 'persona De Contacto');--Contact Person
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_phone', 'Teléfono de contacto');--Contact Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_po_box', 'Póngase en contacto con Po Box');--Contact Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_state', 'Estado');--Contact State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'contact_street', 'Calle');--Contact Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_center_code', 'Código centro Costo');--Cost Center Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_center_id', 'identificador Centro de coste');--Cost Center Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_center_name', 'Costo Nombre del centro');--Cost Center Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_of_goods_sold_account_id', 'Identificador Cuenta costo de ventas');--COGS Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_price', 'Precio de Costo');--Cost Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cost_price_includes_tax', 'precio Costo incluye el IVA');--Cost Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'counter_code', 'Código Contador');--Counter Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'counter_id', 'identificador Contador');--Counter Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'counter_name', 'Nombre del contador');--Counter Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'country', 'país');--Country
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'country_code', 'código del país');--Country Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'country_id', 'Identificador país');--Country Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'country_name', 'Nombre del país');--Country Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county', 'condado');--County
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_code', 'Código del Condado');--County Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_id', 'identificador Condado');--County Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_name', 'Nombre del condado');--County Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_sales_tax', 'Impuesto sobre las Ventas del Condado');--County Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_sales_tax_code', 'Condado de Ventas Código Tributario');--County Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_sales_tax_id', 'Identificador Impuestos de venta del condado');--County Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'county_sales_tax_name', 'Nombre Impuesto sobre las Ventas del Condado');--County Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'credit', 'crédito');--Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'cst_number', 'Número Impuesto sobre las Ventas ');--CST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'culture', 'cultura');--Culture
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'currency', 'moneda');--Currency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'currency_code', 'Código de moneda');--Currency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'currency_name', 'Nombre moneda');--Currency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'currency_symbol', 'Símbolo de moneda');--Currency Symbol
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'customer_pays_fee', 'Pago de honorarios al cliente');--Customer Pays Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'date_of_birth', 'Fecha De Nacimiento');--Date Of Birth
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'debit', 'débito');--Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'default_cash_account_id', 'Identificador Cuenta de Efectivo Por defecto');--Default Cash Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'default_cash_repository_id', 'Identificador Repositorio de Efectivo por defecto');--Default Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'department_code', 'Código de departamento');--Department Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'department_id', 'ID Departamento');--Department Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'department_name', 'Nombre Departamento');--Department Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'description', 'descripción');--Description
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'discount', 'descuento');--Discount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'due_days', 'Días de pago');--Due Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'due_frequency', 'Frecuencia de pagos');--Due Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'due_frequency_id', 'Identificador de la frecuencia de pago');--Due Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'due_on_date', 'Pago en Fecha');--Due on Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'effective_from', 'Vigente desde');--Effective From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'elevated', 'Elevado');--Elevated
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'email', 'Correo electrónico');--Email
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'ends_on', 'termina el');--Ends On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'entity_id', 'Id entidad ');--Entity Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'entity_name', 'Nombre entidad');--Entity Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'entry_ts', 'Fecha y hora de entrada');--Entry Ts
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'er', 'Tipo De Cambio');--ER
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'exclude_from_purchase', 'Excluir de Compra');--Exclude From Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'exclude_from_sales', 'Excluir de Ventas');--Exclude From Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'external_code', 'Código externo');--External Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'factory_address', 'Dirección de Fábrica');--Factory Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'fax', 'fax');--Fax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'first_name', 'Primer Nombre');--First Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'fiscal_year_code', 'Código aó Fiscal');--Fiscal Year Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'fiscal_year_name', 'Nombre Año Fiscal');--Fiscal Year Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'flag_id', 'ID Bandera');--Flag Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'flag_type_id', 'id Tipo Bandera');--Flag Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'flag_type_name', 'Nombre Tipo Bandera');--Flag Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'flagged_on', 'Marcados En');--Flagged On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'foreground_color', 'Color primer plano');--Foreground Color
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'frequency_code', 'código de frecuencia');--Frequency Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'frequency_id', 'Identificador de Frecuencia');--Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'frequency_name', 'Frecuencia');--Frequency Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'frequency_setup_code', 'Código  Frecuencia de instalación');--Frequency Setup Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'frequency_setup_id', 'Identificador Frecuencia de configuración');--Frequency Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'from_days', 'De Días');--From Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'full_name', 'Nombre Completo');--Full Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'gl_head', 'Jefe de Contabilidad General');--GL Head
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'gl_verification_limit', 'Limite de verificación Libro mayor');--Gl Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'grace_period', 'Período de gracia');--Grace Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'has_child', 'tiene hijos');--Has Child
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'height_in_centimeters', 'Alto En Centímetros');--Height In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'hot_item', 'artículo con demanda');--Hot item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'http_action_code', 'Código Acción HTTP');--HTTP Action Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'hundredth_name', 'nombre centésimas');--Hundredth Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'id', 'identificador');--Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'includes_tax', 'incluye Impuestos');--Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'income_tax_rate', 'Ingresos Tasa de Impuesto');--Income Tax Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'industry_id', 'identificador Industria');--Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'industry_name', 'Nombre de la Industria');--Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'interest_compounding_frequency_id', 'ID Frecuencia Interés capitalización ');--Interest Compounding Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'interest_rate', 'Tasa De Interés');--Interest Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'inventory_account_id', 'Identificador cuenta Inventario');--Inventory Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'ip_address', 'dirección IP');--IP Address
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_active', 'está activo');--Is Active
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_added', 'se añade');--Is Added
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_admin', 'es admin');--Is Admin
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_cash', '¿Es efectivo');--Is Cash
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_debit', 'es débito');--Is Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_employee', 'es Empleado');--Is Employee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_exempt', 'está exento');--Is Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_exemption', 'es Exención');--Is Exemption
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_flat_amount', 'Es de cantidad fija');--Is Flat Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_merchant_account', 'Es cuenta de comerciante');--Is Merchant Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_party', 'es la partida');--Is Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_purchase', 'es Compra');--Is Purchase
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_rectangular', 'es rectangular');--Is Rectangular
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_sales', 'es Ventas');--Is Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_summary', 'es Resumen');--Is Summary
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_supplier', 'es Proveedor');--Is Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_system', 'es sistema');--Is System
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_transaction_node', 'Es nodo de transacción');--Is Transaction Node
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'is_vat', 'es el IVA');--Is Vat
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item', 'artículo');--Item
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_code', 'Código artículo');--Item Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_cost_price_id', 'Id Precio Costo del Artículo');--Item Cost Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_cost_prices_unit_chk', 'Unidad proveida no válida.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_group', 'Grupo de artículos');--Item Group
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_group_code', 'Código de grupo de Artículo');--Item Group Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_group_id', 'Id Grupo Articulos');--Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_group_name', 'Nombre del elemento Grupo');--Item Group Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_id', 'Identificador de artículo');--Item Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_name', 'Nombre del artículo');--Item Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_opening_inventory_unit_chk', 'Unidad poveida no válida.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_selling_price_id', 'Item Selling Price Identifier');--Item Selling Price Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_selling_prices_unit_chk', 'Unidad no válida siempre.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_type_code', 'Tipo de artículo Código');--Item Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_type_id', 'Tipo de artículo Identificador');--Item Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'item_type_name', 'Tipo de artículo Nombre');--Item Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'items_item_code_uix', 'Duplicar código del artículo.');--Duplicate item code.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'items_item_name_uix', 'Duplicar nombre del artículo.');--Duplicate item name.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'items_reorder_quantity_chk', 'La cantidad de pedido debe ser grande o igual que el nivel de pedido.');--The reorder quantity must be great than or equal to the reorder level.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'last_analyze', 'Ultimo Analisis');--Last Analyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'last_autoanalyze', 'Último Auto analisis');--Last Autoanalyze On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'last_autovacuum', 'Última Auto vacío');--Last Autovacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'last_name', 'apellido');--Last Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'last_vacuum', 'Última vacío en');--Last Vacuum On
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee', 'Cargo por mora');--Late Fee
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee_code', 'Tarde Código de Derechos');--Late Fee Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee_id', 'Identificador cargo por mora');--Late Fee Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee_name', 'Cargo por Nombre');--Late Fee Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee_posting_frequency', 'Cargo por desplazamiento de frecuencia');--Late Fee Posting Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'late_fee_posting_frequency_id', 'Cargo por mora Identificador desplazamiento de frecuencia');--Late Fee Posting Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lc_credit', 'Carta de crédito');--LC Credit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lc_debit', 'Carta de débito');--LC Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_source_code', 'Plomo Código Fuente');--Lead Source Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_source_id', 'Plomo Fuente identificador');--Lead Source Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_source_name', 'El plomo nombre de origen');--Lead Source Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_status_code', 'El plomo Código de estado');--Lead Status Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_status_id', 'Identificador Estado del cable');--Lead Status Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_status_name', 'Estado del cable Nombre');--Lead Status Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'lead_time_in_days', 'Plomo tiempo en días');--Lead Time In Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'length_in_centimeters', 'Longitud en centímetros');--Length In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'login_date_time', 'Login Fecha Hora');--Login Date Time
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'login_id', 'Id De Entrada');--Login Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'machinable', 'mecanizable');--Machinable
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'maintain_stock', 'mantener Stock');--Maintain Stock
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'maintained_by_user_id', 'identificador Gestionado Por usuario');--Maintained By User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'maximum_credit_amount', 'Máximo del Crédito');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'maximum_credit_period', 'Período Máximo del Crédito');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'merchant_account_id', 'Identificador de cuenta de comerciante');--Merchant Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'merchant_fee_setup_id', 'Identificador Configuración Cuota de Comerciante');--Merchant Fee Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'middle_name', 'Segundo Nombre');--Middle Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'nick_name', 'Nombre de Usuario');--Nick Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'non_gl_stock_details_unit_chk', 'Unidad proveida no válida.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'normally_debit', 'normalmente débito');--Normally Debit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'office', 'oficina');--Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'office_code', 'Código de oficina');--Office Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'office_id', 'ID Oficina');--Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'office_name', 'Nombre Oficina');--Office Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'opportunity_stage_code', 'Código Etapa Oportunidad');--Opportunity Stage Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'opportunity_stage_id', 'identificador Oportunidad Etapa');--Opportunity Stage Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'opportunity_stage_name', 'Nombre Oportunidad Etapa');--Opportunity Stage Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'pan_number', 'Número Cuenta Permanente');--Pan Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent', 'padre');--Parent
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_account_id', 'Identificador cuenta para padres');--Parent Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_account_master_id', 'ID Padres cuenta Maestro');--Parent Account Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_account_name', 'Nombre Cuenta de los padres');--Parent Account Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_account_number', 'Número de cuenta para Padres');--Parent Account Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_cash_flow_heading_id', 'Identificador Padres Denominación de Flujos de Efectivo');--Parent Cash Flow Heading Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_cash_repository', 'Padre Repositorio Efectivo');--Parent Cash Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_cash_repository_id', 'Identificador Padres Repositorio Efectivo');--Parent Cash Repository Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_cr_code', 'Efectivo de Padres Código Repositorio');--Parent CR Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_cr_name', 'Repositorio Efectivo de Padres Nombre');--Parent CR Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_industry_id', 'Identificador Industria Padres');--Parent Industry Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_industry_name', 'Nombre de los padres de la Industria');--Parent Industry Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_item_group_id', 'Artículo Padre identificador de grupo');--Parent Item Group Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_office', 'Oficina de Padres');--Parent Office
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'parent_office_id', 'Oficina Identificador de Padres');--Parent Office Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party', 'partido');--Party
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_code', 'Código Partido');--Party Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_id', 'Partido Identificador');--Party Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_name', 'Nombre de la parte');--Party Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_type', 'Tipo Partido');--Party Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_type_code', 'Partido Código Tipo');--Party Tpye Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_type_id', 'Tipo Partido Identificador');--Party Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'party_type_name', 'Tipo del partido Nombre');--Party Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'password', 'contraseña');--Password
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_card_code', 'Código de Tarjetas de Pago');--Payment Card Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_card_id', 'Identificador de Tarjetas de Pago');--Payment Card Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_card_name', 'Tarjetas de Pago Nombre');--Payment Card Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_term', 'Terminos de pago');--Payment Term
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_term_code', 'Código Término del pago');--Payment Term Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_term_id', 'Identificador Termino de pago');--Payment Term Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'payment_term_name', 'Nombre Termino Pago');--Payment Term Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'phone', 'teléfono');--Phone
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'po_box', 'Apartado de correos');--Po Box
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'poco_type_name', 'Poco Tipo Nombre');--Poco Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'policy_id', 'identificador de política');--Policy id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'preferred_shipping_mail_type', 'Tipo de envío preferido Correo');--Preferred Shipping Mail Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'preferred_shipping_mail_type_id', 'Preferidos del envío Tipo de correo identificador');--Preferred Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'preferred_shipping_package_shape', 'Forma preferida de Paquetes Postales');--Preferred Shipping Package Shape
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'preferred_supplier', 'Proveedor preferido');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'preferred_supplier_id', 'Identificador de Proveedor Preferido');--Preferred Supplier Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price', 'precio');--Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price_from', 'Precio Desde');--Price From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price_to', 'Precio Para');--Price To
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price_type_code', 'Precio Código Tipo');--Price Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price_type_id', 'Precio Tipo Identificador');--Price Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'price_type_name', 'Precio Tipo Nombre');--Price Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'priority', 'prioridad');--Priority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'purchase_account_id', 'Compra Cuenta Identificador');--Purchase Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'purchase_discount_account_id', 'Descuento de Compra Cuenta Identificador');--Purchase Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'purchase_verification_limit', 'Compra Verificación Límite');--Purchase Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'quantity', 'cantidad');--Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'rate', 'tarifa');--Rate
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurrence_type_id', 'Recurrencia Identificador de Tipo');--Recurrence Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_amount', 'Monto recurrente');--Recurring Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_duration', 'Duración recurrente');--Recurring Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_frequency', 'Frecuencia recurrente');--Recurring Frequency
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_frequency_id', 'Identificador Frecuencia recurrente');--Recurring Frequency Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoice', 'factura recurrente');--Recurring Invoice
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoice_code', 'Recurrente Código Factura');--Recurring Invoice Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoice_id', 'Recurrente Factura Identificador');--Recurring Invoice Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoice_name', 'Recurrente Nombre Factura');--Recurring Invoice Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoice_setup_id', 'Factura Recurrente Identificador de configuración');--Recurring Invoice Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurring_invoices_item_id_auto_trigger_on_sales_uix', 'No se puede tener más de un disparador automático en las ventas de este artículo.');--You cannot have more than one auto trigger on sales for this item.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'recurs_on_same_calendar_date', 'Es recurrente en Same Calendario Fecha');--Recurs on Same Calendar Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'registration_date', 'Fecha de Registro');--Registration Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'registration_number', 'matrícula');--Registration Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'relationship_officer_name', 'Nombre Oficial Relación');--Relationship Officer Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'relname', 'relación Nombre');--Relation Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'remote_user', 'usuario remoto');--Remote User
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reorder_level', 'Nivel de Reabastecimiento');--Reorder Level
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reorder_quantity', 'Reordenar Cantidad');--Reorder Quantity
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reorder_unit', 'Unidad Reordenar');--Reorder Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reorder_unit_id', 'Reordenar identificador de unidad');--Reorder Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reporting_tax_authority', 'Informes de Administración Tributaria');--Reporting Tax Authority
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'reporting_tax_authority_id', 'Informes de Administración Tributaria identificador');--Reporting Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'repository', 'repositorio');--Repository
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'resource', 'recurso');--Resource
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'resource_id', 'recurso identificador');--Resource Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'resource_key', 'clave de Recursos');--Resource Key
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'role', 'papel');--Role
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'role_code', 'Código Rol');--Role Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'role_id', 'Identificador de papel');--Role Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'role_name', 'Nombre de función');--Role Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'rounding_decimal_places', 'Redondeando decimales');--Rounding Decimal Places
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'rounding_method', 'método de redondeo');--Rounding Method
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'rounding_method_code', 'Completan Código Método');--Rounding Method Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'rounding_method_name', 'Completan Nombre del método');--Rounding Method Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_account_id', 'Identificador venta cuenta');--Sales Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_discount_account_id', 'Ventas Rebajas Cuenta Identificador');--Sales Discount Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_return_account_id', 'Ventas Retorno Cuenta Identificador');--Sales Return Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax', 'impuesto sobre la venta');--Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_code', 'Código Fiscal de Ventas');--Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_detail_code', 'Impuesto sobre las Ventas Código Detalle');--Sales Tax Detail Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_detail_id', 'Impuesto sobre las Ventas Identificador Detalle');--Sales Tax Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_detail_name', 'Impuesto a las Ventas Detalle Nombre');--Sales Tax Detail Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_details_rate_chk', 'Tasa no debe estar vacío a menos que haya seleccionado el impuesto estatal o del condado. Del mismo modo, no se puede proporcionar tanto ritmo y puede elegir en impuestos del estado o condado.');--Rate should not be empty unless you have selected state or county tax. Similarly, you cannot provide both rate and choose to have state or county tax.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempt', 'Exentas de Impuestos de Ventas');--Sales Tax Exempt
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempt_code', 'Impuesto sobre las Ventas Código Exento');--Sales Tax Exempt Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempt_detail_id', 'Impuesto sobre las Ventas Identificador Detalle Exento');--Sales Tax Exempt Detail Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempt_id', 'Impuesto sobre las Ventas Identificador Exento');--Sales Tax Exempt Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempt_name', 'Impuesto sobre las Ventas Nombre Exento');--Sales Tax Exempt Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_exempts_price_to_chk', 'El campo "Desde precio" debe ser inferior "a precio".');--The field "PriceFrom" must be less than "PriceTo".
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_id', 'Identificador de Impuesto a las Ventas');--Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_name', 'Nombre Impuesto sobre las Ventas');--Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_type', 'Tipo de Impuesto a las Ventas');--Sales Tax Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_type_code', 'Ventas Tipo de impuesto Código');--Sales Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_type_id', 'Ventas Tipo de impuesto identificador');--Sales Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_tax_type_name', 'Ventas Tipo de impuesto Nombre');--Sales Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_team_code', 'Ventas Código Equipo');--Sales Team Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_team_id', 'Identificador de Equipo de Ventas');--Sales Team Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_team_name', 'Equipo de Ventas Nombre');--Sales Team Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sales_verification_limit', 'Ventas Verificación Límite');--Sales Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'salesperson_bonus_setup_id', 'Bono vendedor Identificador de configuración');--Salesperson Bonus Setup Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'salesperson_code', 'Código vendedor');--Salesperson Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'salesperson_id', 'Vendedor identificador');--Salesperson Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'salesperson_name', 'Nombre Vendedor');--Salesperson Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'self_verification_limit', 'Auto Verificación Límite');--Self Verification Limit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'selling_price', 'Precio de Venta');--Selling Price
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'selling_price_includes_tax', 'Venta Precio incluye impuesto');--Selling Price Includes Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipper_code', 'Código Shipper');--Shipper Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipper_id', 'Shipper identificador');--Shipper Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipper_name', 'Nombre del remitente');--Shipper Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_address_code', 'Envios Código Dirección');--Shipping Address Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_address_id', 'Identificador Dirección Envío');--Shipping Address Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_mail_type_code', 'El envío del correo Código Tipo');--Shipping Mail Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_mail_type_id', 'Envios Tipo de correo identificador');--Shipping Mail Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_mail_type_name', 'Tipo del envío Correo Nombre');--Shipping Mail Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_package_shape_code', 'Envios Código Forma Paquete');--Shipping Package Shape Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_package_shape_id', 'Envios Identificador Forma Paquete');--Shipping Package Shape Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'shipping_package_shape_name', 'Envío Nombre Forma Paquete');--Shipping Package Shape Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'slab_name', 'Losa Nombre');--Slab Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sst_number', 'Estado Número Impuesto sobre las Ventas');--SST Number
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'starts_from', 'Comienza desde');--Starts From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state', 'estado');--State
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_code', 'Código del Estado');--State Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_id', 'identificador de estado');--State Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_name', 'Nombre Estado');--State Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_sales_tax', 'Impuesto sobre las ventas');--State Sales Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_sales_tax_code', 'Ventas Código Fiscal de Estado');--State Sales Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_sales_tax_id', 'Estado Identificador Impuesto sobre las Ventas');--State Sales Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'state_sales_tax_name', 'Estado Nombre de Impuesto a las Ventas');--State Sales Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'statement_reference', 'Declaración de Referencia');--Statement Reference
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'stock_details_unit_chk', 'Unidad no válida siempre.');--Invalid unit provided.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store', 'tienda');--Store
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_code', 'Código tienda');--Store Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_id', 'Identificador tienda');--Store Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_name', 'Nombre tienda');--Store Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_type', 'Tipo de tienda');--Store Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_type_code', 'Tipo tienda Código');--Store Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_type_id', 'Tipo tienda Identificador');--Store Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'store_type_name', 'Tipo Nombre de la tienda');--Store Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'stores_default_cash_account_id_chk', 'Por favor seleccione una Efectivo válida o cuenta de identificación del banco.');--Please select a valid Cash or Bank AccountId.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'stores_sales_tax_id_chk', 'El SalesTax Identificador elegido no es válido para esta función.');--The chosen SalesTaxId is invalid for this office.
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'street', 'calle');--Street
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sub_total', 'total parcial');--Sub Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'sys_type', 'Tipo de sistema');--Sys Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax', 'impuesto');--Tax
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_authority_code', 'Impuesto Código Autoridad');--Tax Authority Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_authority_id', 'Administración Tributaria identificador');--Tax Authority Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_authority_name', 'Nombre de Administración Tributaria');--Tax Authority Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_base_amount', 'Base imponible');--Tax Base Amount
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_base_amount_type_code', 'Base imponible de Código Tipo');--Tax Base Amount Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_base_amount_type_name', 'Monto Base Imponible Tipo Nombre');--Tax Base Amount Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_code', 'Código Tributario');--Tax Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_exempt_type', 'Impuestos Tipo Exento');--Tax Exempt Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_exempt_type_code', 'Impuestos Tipo Exento Código');--Tax Exempt Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_exempt_type_id', 'Impuestos Tipo Exento identificador');--Tax Exempt Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_exempt_type_name', 'Impuestos Tipo Exento Nombre');--Tax Exempt Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_id', 'Identificador de Impuestos');--Tax Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_master', 'Maestro de Impuestos');--Tax Master
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_master_code', 'Impuesto Código Maestro');--Tax Master Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_master_id', 'Orgánico Tributario identificador');--Tax Master Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_master_name', 'Orgánico Tributario Nombre');--Tax Master Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_name', 'Nombre de Impuestos');--Tax Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_rate_type', 'Tasa de Impuesto Tipo');--Tax Rate Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_rate_type_code', 'Tasa de Impuesto  Código Tipo');--Tax Rate Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_rate_type_name', 'Impuesto Tipo Tasa Nombre');--Tax Rate Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_type_code', 'Tasa de Impuesto   Código');--Tax Type Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_type_id', 'Tipo de impuesto identificador');--Tax Type Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tax_type_name', 'Tipo de impuesto Nombre');--Tax Type Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'to_days', 'para Días');--To Days
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'total', 'entero');--Total
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'total_duration', 'Duración total');--Total Duration
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'total_sales', 'Ventas totales');--Total Sales
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tran_code', 'Código de transacción');--Tran Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'tran_type', 'Tipo Transacción');--Tran Type
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'unit', 'unidad');--Unit
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'unit_code', 'Código de Unidad');--Unit Code
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'unit_id', 'identificador de unidad');--Unit Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'unit_name', 'Nombre de la unidad');--Unit Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'url', 'Recursos Localtor universal');--Url
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'use_tax_collecting_account', 'Use impuesto cuenta recaudadora');--Use Tax Collecting Account
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'use_tax_collecting_account_id', 'Use impuesto Recogida Identificador Cuenta');--Use Tax Collecting Account Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'user_id', 'Identificador de Usuario');--User Id
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'user_name', 'Nombre de usuario');--User Name
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'vacuum_count', 'Conde de vacío');--Vacuum Count
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'valid_from', 'Válido desde');--Valid From
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'valid_till', 'Válido Hasta');--Valid Till
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'value', 'valor');--Value
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'value_date', 'Fecha Valor');--Value Date
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'verify_gl_transactions', 'Verificar las transacciones del libro mayor');--Verify Gl Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'verify_purchase_transactions', 'Verifique Transacciones de Compra');--Verify Purchase Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'verify_sales_transactions', 'Verificar las transacciones de venta');--Verify Sales Transactions
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'weight_in_grams', 'Peso en gramos');--Weight In Grams
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'width_in_centimeters', 'Ancho en cm');--Width In Centimeters
SELECT * FROM localization.add_localized_resource('ScrudResource', 'es', 'zip_code', 'Código Postal');--Zip Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AboutInitializingDayEnd', 'Acerca del Día Inicializando final');--About Initializing Day End
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AboutYourOffice', 'Acerca de su oficina');--About Your Office
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Access', 'acceso');--Access
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccessIsDenied', 'Acceso denegado.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Account', 'cuenta');--Account
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountId', 'Identificador cuenta');--Account Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountMaster', 'cuenta Maestra');--Account Master
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountName', 'Nombre De La Cuenta');--Account Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountNumber', 'Número De Cuenta');--Account Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountOverview', 'Descripción de cuenta');--Account Overview
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AccountStatement', 'Estado de Cuenta');--Account Statement
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Action', 'acción');--Action
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Actions', 'acciones');--Actions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Actual', 'real');--Actual
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Add', 'añadir');--Add
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AddNew', 'Agregar nuevo');--Add New
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Address', 'dirección');--Address
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AddressAndContactInfo', 'Dirección e información de contacto');--Address & Contact Information
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AgeingSlabs', 'Losas Envejecimiento');--Ageing Slabs
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AgentBonusSlabAssignment', 'Bono losa Asignación');--Bonus Slab Assignment
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AgentBonusSlabs', 'Losa bonificación sobre los Vendedores');--Bonus Slab for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Alerts', 'alertas');--Alerts
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Amount', 'cantidad');--Amount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AmountInBaseCurrency', 'Importe (Divisa Base)');--Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AmountInHomeCurrency', 'Importe (Inicio moneda)');--Amount (In Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AnalyzeDatabse', 'analizar base de datos');--Analyze Databse
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Approve', 'aprobar');--Approve
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ApproveThisTransaction', 'Aprobar esta transacción');--Approve This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ApprovedTransactions', 'Transacciones aprobados');--Approved Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AreYouSure', 'Estás seguro?');--Are you sure?
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AssignCashier', 'asignar Cajero');--Assign Cashier
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AttachmentsPlus', 'Adjuntos (+)');--Attachments (+)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AutoVerificationPolicy', 'Política de verificación Auto');--Autoverification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'AutomaticallyApprovedByWorkflow', 'Aprobado automáticamente Por Workflow');--Automatically Approved by Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Back', 'espalda');--Back
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BackToPreviousPage', 'Volver a la página anterior');--Back to Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BackupConsole', 'Consola de reserva');--Backup Console
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BackupDatabase', 'Base de datos de copia de seguridad');--Backup Database
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BackupNow', 'copia de seguridad ahora');--Backup Now
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Balance', 'equilibrio');--Balance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BalanceSheet', 'equilibrio hoja');--Balance Sheet
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BankAccounts', 'Cuentas bancarias');--Bank Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BankTransactionCode', 'Banco Código de transacción');--Bank Transaction Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BaseCurrency', 'moneda de Cuenta');--Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BaseUnitName', 'Nombre Unidad Base');--Base Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BonusSlabDetails', 'Bono losa Detalles para Vendedores');--Bonus Slab Details for Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Book', 'libro');--Book
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'BookDate', 'libro Fecha');--Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Brand', 'marca');--Brand
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Brands', 'Marcas');--Brands
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Browse', 'Explorar');--Browse
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CSTNumber', 'Número CST');--CST Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Cancel', 'cancelar');--Cancel
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashFlowHeading', 'Rubro de Flujo de Caja');--Cash Flow Heading
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashFlowHeadings', 'Las partidas de flujo de caja');--Cash Flow Headings
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashFlowSetup', 'Configuración Cashflow');--Cash Flow Setup
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashRepositories', 'Repositorios efectivo');--Cash Repositories
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashRepository', 'Repositorio Efectivo');--Cash Repository
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashRepositoryBalance', 'Equilibrio Repositorio Efectivo');--Cash Repository Balance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CashTransaction', 'transacción en efectivo');--Cash Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ChangePassword', 'Cambiar La Contraseña');--Change Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ChangeSideWhenNegative', 'Cambio Side Cuando Negativo');--Change Side When Negative
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ChartOfAccounts', 'Plan General de Contabilidad');--Chart of Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Check', 'Comprobar');--Check
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CheckAll', 'Seleccionar Todos');--Check All
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Checklists', 'Las listas de verificación');--Checklists
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Clear', 'claro');--Clear
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Close', 'cerca');--Close
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ClosedTransactions', 'Transacciones cerradas');--Closed Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ClosingBalance', 'Saldo final');--Closing Balance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ClosingCredit', 'crédito de Clausura');--Closing Credit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ClosingDebit', 'débito clausura');--Closing Debit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Comment', 'comentario');--Comment
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CompoundItemDetails', 'Compuesto Detalles del artículo');--Compound Item Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CompoundItems', 'compuesto Artículos');--Compound Items
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CompoundUnitsOfMeasure', 'Unidades compuestas de Medida');--Compound Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Confidential', 'confidencial');--Confidential
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ConfirmPassword', 'confirmar Contraseña');--Confirm Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ConvertedtoBaseCurrency', 'Convierten a la moneda base');--Converted to Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ConvertedtoHomeCurrency', 'Convertido a Inicio moneda');--Converted to Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CostCenter', 'Centro de Costo');--Cost Center
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CostCenters', 'Centros de costes');--Cost Centers
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Counters', 'Contadores');--Counters
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Counties', 'condados');--Counties
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Countries', 'Países');--Countries
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CountySalesTaxes', 'Impuestos del Condado de venta');--County Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CreateaUserAccountforYourself', 'Crear una cuenta de usuario para usted mismo');--Create a User Account for Yourself
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CreatedOn', 'Creado el');--Created On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Credit', 'crédito');--Credit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CreditAllowed', 'animales de crédito');--Credit Allowed
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CreditTotal', 'crédito total');--Credit Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlAltA', 'Ctrl + Alt + A');--Ctrl + Alt + A
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlAltC', 'Ctrl + Alt + C');--Ctrl + Alt + C
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlAltD', 'Ctrl + Alt + D');--Ctrl + Alt + D
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlAltS', 'Ctrl + Alt + S');--Ctrl + Alt + S
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlAltT', 'Ctrl + Alt + T');--Ctrl + Alt + T
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CtrlReturn', 'Ctrl + Return');--Ctrl + Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Currencies', 'Monedas');--Currencies
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Currency', 'moneda');--Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrencyCode', 'Código De Moneda');--Currency Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrencyName', 'Nombre moneda');--Currency Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrencySymbol', 'Símbolo de moneda');--Currency Symbol
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrentBookDate', 'Actual Agenda');--Current Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrentIP', 'IP actual');--Current IP
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrentLoginOn', 'Actual Entrar En');--Current Login On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrentPassword', 'Contraseña Actual');--Current Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CurrentPeriod', 'Período actual');--Current Period
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CustomerCode', 'Código de Cliente');--Customer Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CustomerName', 'Nombre del cliente');--Customer Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CustomerPanNumber', 'Cliente Cuenta Permanente Número #');--Customer PAN #
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'CustomerPaysFees', 'Cliente paga Honorarios');--Customer Pays Fees
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DatabaseBackups', 'Las copias de seguridad de bases de datos');--Database Backups
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DatabaseStatistics', 'Base de Estadísticas');--Database Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Date', 'fecha');--Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Day', 'día');--Day
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Days', 'días');--Days
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Debit', 'débito');--Debit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DebitTotal', 'débito total');--Debit Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DefaultAddress', 'Dirección predeterminada');--Default Address
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DefaultCurrency', 'moneda predeterminada');--Default Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DefaultReorderQuantityAbbreviated', 'Por defecto Reordenar Cantidad');--Default Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Definition', 'definición');--Definition
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Delete', 'borrar');--Delete
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DeleteSelected', 'eliminar seleccionados');--Delete Selected
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DeliverTo', 'entregar a');--Deliver To
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Department', 'departamento');--Department
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Departments', 'Departamentos');--Departments
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Difference', 'diferencia');--Difference
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DirectPurchase', 'Compra Directa');--Direct Purchase
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DirectSales', 'Venta Directa');--Direct Sales
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Discount', 'descuento');--Discount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Documentation', 'documentación');--Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Download', 'descargar');--Download
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DownloadSourceCode', 'Descargar Código Fuente');--Download Source Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'DueDate', 'Fecha De Vencimiento');--Due Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EODBegun', 'Fin de Procesamiento día ha comenzado');--End of Day Processing Has Begun
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EODConsole', 'Al final del día Consola Operación');--EOD Console
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ER', 'Tasa Efectiva');--ER
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ERToBaseCurrency', 'Tipo de Cambio (Para Base moneda)');--Exchange Rate (To Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ERToHomeCurrency', 'Tipo de cambio (a la inicio moneda)');--Exchange Rate (To Home Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EditSelected', 'Editar seleccionado');--Edit Selected
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Email', 'Correo electrónico');--Email
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailAddress', 'Dirección De Correo Electrónico');--Email Address
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisDelivery', 'Enlaces a esta entrega');--Email This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisInvoice', 'Enviar esta factura');--Email This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisNote', 'Enlaces a esta Nota');--Email This Note
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisOrder', 'Enlaces a esta Orden');--Email This Order
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisQuotation', 'Enviar esta cita');--Email This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisReceipt', 'Enlaces a esta Recibo');--Email This Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EmailThisReturn', 'Enviar esto Volver');--Email This Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EndOfDayOperation', 'Al final del día de operación');--End of Day Operation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EnterBackupName', 'Introduzca el nombre de copia de seguridad');--Enter Backup Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EnterNewPassword', 'Introduzca una nueva contraseña');--Enter a New Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'EnteredBy', 'Entró Por');--Entered By
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Entities', 'entidades');--Entities
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ExchangeRate', 'Tipo De Cambio');--Exchange Rate
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Execute', 'ejecutar');--Execute
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ExternalCode', 'Código externo');--External Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Factor', 'factor');--Factor
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Fax', 'fax');--Fax
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FilePath', 'Ruta del archivo');--File Path
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FinalDueAmountinBaseCurrency', 'Final Monto a pagar en moneda Base');--Final Due Amount in Base Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FirstPage', 'primera Página');--First Page
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FiscalYear', 'Año Fiscal');--Fiscal Year
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Flag', 'bandera');--Flag
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FlagBackgroundColor', 'Fondo de la bandera del color');--Flag Background Color
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FlagDescription', 'Puede marcar esta transacción con una bandera, sin embargo usted no será capaz de ver las banderas creadas por otros usuarios.');--You can mark this transaction with a flag, however you will not be able to see the flags created by other users.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FlagForegroundColor', 'Bandera Color de primer plano');--Flag Foreground Color
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FlagThisTransaction', 'Bandera de esta transacción');--Flag This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'FlaggedTransactions', 'Transacciones de bandera');--Flagged Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Flags', 'Banderas');--Flags
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Frequencies', 'frecuencias');--Frequencies
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'From', 'desde');--From
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GLAdvice', 'Jefe de Contabilidad General...');--GL Advice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GLDetails', 'Contabilidad General Detalles');--GL Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GLHead', 'GL Head');--GL Head
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Go', 'ir');--Go
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GoToTop', 'Ir a la parte superior.');--GoToTop
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GoodsReceiptNote', 'Entrada de mercancías Nota');--Goods Receipt Note
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'GrandTotal', 'Gran Total');--Grand Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Home', 'casa');--Home
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'HomeCurrency', 'Inicio moneda');--Home Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'HundredthName', 'centésimo nombre');--Hundredth Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Id', 'identificación');--Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InVerificationStack', 'En Verificación Pila');--In Verification Stack
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'IncludeZeroBalanceAccounts', 'Incluya cuentas de saldo cero');--Include Zero Balance Accounts
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Industries', 'Industrias');--Industries
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InitializeDayEnd', 'Inicialice Día Final');--Initialize Day End
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InstallMixERP', 'Instale MixERP');--Install MixERP
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InstrumentCode', 'Código Instrumento');--Instrument Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InterestApplicable', 'interés Aplicable');--Interest Applicable
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InvalidDate', 'Fecha no válida.');--This is not a valid date.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InvalidImage', 'Esto no es una imagen válida.');--This is not a valid image.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InventoryAdvice', 'Consejos Inventario');--Inventory Advice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InvoiceAmount', 'Importe de la factura');--Invoice Amount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'InvoiceDetails', 'detalles de la factura');--Invoice Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'IsCash', '¿Es efectivo');--Is Cash
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'IsEmployee', 'es Empleado');--Is Employee
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'IsParty', 'es la fiesta');--Is Party
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'IsSystemAccount', 'Es Cuenta del sistema');--Is System Account
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemCode', 'Código del artículo');--Item Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemCostPrices', 'Los precios de coste de artículos');--Item Cost Prices
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemGroup', 'Grupo de artículos');--Item Group
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemGroups', 'los grupos de artículos');--Item Groups
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemId', 'Identificador de artículo');--Item Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemName', 'Nombre del artículo');--Item Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemOverview', 'Resumen de posiciones');--Item Overview
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemSellingPrices', 'Artículo vendedor precios');--Item Selling Prices
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemType', 'Tipo de artículo');--Item Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemTypes', 'Tipos de Elementos');--Item Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Items', 'Artículos');--Items
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ItemsBelowReorderLevel', 'Artículos abajo Nivel de Reabastecimiento');--Items Below Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'JournalVoucher', 'Comprobante de Diario');--Journal Voucher
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'JournalVoucherEntry', 'Entrada Comprobante de Diario');--Journal Voucher Entry
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'KeyColumnEmptyExceptionMessage', 'La propiedad ''Columna de clave'' no se puede dejar vacío.');--The property 'KeyColumn' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LCCredit', 'Carta de crédito de crédito');--LC Credit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LCDebit', 'Carta de débito de crédito');--LC Debit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastAccessedOn', 'Último acceso el');--Last Accessed On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastLoginIP', 'Último ingreso IP');--Last Login IP
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastLoginOn', 'Último ingreso On');--Last Login On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastPage', 'última Página');--Last Page
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastPaymentDate', 'Última Fecha de Pago');--Last Payment Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LastWrittenOn', 'Última Escrito En');--Last Written On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LateFees', 'Recargos');--Late Fees
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LeadSources', 'Fuentes de plomo');--Lead Sources
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LeadStatuses', 'Los estados de plomo');--Lead Statuses
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LeadTime', 'Tiempo De Espera');--Lead Time
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ListItems', 'Elementos de lista');--List Items
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Load', 'carga');--Load
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LoggedInTo', 'Logado para');--Logged in to
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'LoginView', 'Entrar Ver');--Login View
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ManageProfile', 'administrar perfil');--Manage Profile
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MaximumCreditAmount', 'Máximo del Crédito');--Maximum Credit Amount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MaximumCreditPeriod', 'Período Máximo del Crédito');--Maximum Credit Period
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MenuAccessPolicy', 'Menú política de acceso');--Menu Access Policy
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MenuCode', 'Menú Código');--Menu Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MenuId', 'Menú Identificador');--Menu Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MenuText', 'Texto Menú');--Menu Text
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MerchantFeeInPercent', 'Cuota Merchant (Porcentaje)');--Merchant Fee (In percent)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MerchantFeeSetup', 'Configuración Fee Merchant');--Merchant Fee Setup
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MergeBatchToGRN', 'Fusionar lotes de mercancías Nota');--Merge Batch to GRN
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MergeBatchToSalesDelivery', 'Fusionar lotes para entrega Ventas');--Merge Batch to Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MergeBatchToSalesOrder', 'Fusionar lotes para órdenes de venta');--Merge Batch to Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MixERPDocumentation', 'MixERP Documentación');--MixERP Documentation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MixERPLinks', 'Enlaces MixERP');--MixERP Links
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'MixERPOnFacebook', 'MixERP En Facebook');--MixERP on Facebook
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Month', 'mes');--Month
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Name', 'nombre');--Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NewBookDate', 'Nuevo libro Fecha');--New Book Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NewJournalEntry', 'Nueva entrada del diario');--New Journal Entry
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NewPassword', 'nueva Contraseña');--New Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NextPage', 'Siguiente Página');--Next Page
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'No', 'no');--No
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NonTaxableSales', 'Ventas Tributables');--Nontaxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'None', 'ninguno');--None
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NormallyDebit', 'normalmente débito');--Normally Debit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'NothingSelected', 'Nada seleccionado.');--Nothing selected!
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Notifications', 'Notificaciones');--Notifications
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OK', 'Okay');--OK
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Office', 'oficina');--Office
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OfficeCode', 'Código de oficina');--Office Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OfficeInformation', 'Oficina de Información');--Office Information
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OfficeName', 'Nombre Cargo');--Office Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OfficeNickName', 'Nombre Oficina Nick');--Office Nick Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OfficeSetup', 'Configuración oficina');--Office Setup
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OnlyNumbersAllowed', 'Por favor, escriba un número válido.');--Please type a valid number.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OpeningInventory', 'Inventario de apertura');--Opening Inventory
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OpportunityStages', 'Etapas de la oportunidad');--Opportunity Stages
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'OtherDetails', 'otros detalles');--Other Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PANNumber', 'Número PAN');--PAN Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PageN', 'Página {0}');--Page {0}
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ParentAccount', 'cuenta primaria');--Parent Account
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Parties', 'Partes');--Parties
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Party', 'partido');--Party
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PartyCode', 'Código Partido');--Party Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PartyName', 'Nombre de la parte');--Party Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PartySummary', 'Resumen del partido');--Party Summary
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PartyType', 'Tipo Partido');--Party Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PartyTypes', 'Tipos partido');--Party Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Password', 'contraseña');--Password
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PasswordUpdated', 'Contraseña se ha actualizado.');--Password was updated.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PaymentCards', 'Tarjetas de pago');--Payment Cards
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PaymentTerms', 'Condiciones de pago');--Payment Terms
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PerformEODOperation', 'Realice Al final del día de operación');--Perform EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PerformingEODOperation', 'Realización de Fin de Día Operación');--Performing EOD Operation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Phone', 'teléfono');--Phone
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PlaceReorderRequests', 'Coloque Solicitudes Reordenar');--Place Reorder Request(s)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PostTransaction', 'Publicar Transacción');--Post Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PostedBy', 'publicado Por');--Posted By
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PostedDate', 'Fecha de publicación');--Posted Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreferredSupplier', 'Proveedor preferido');--Preferred Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreferredSupplierIdAbbreviated', 'Identificador de proveedor preferido');--Pref SupId
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Prepare', 'preparar');--Prepare
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreparedOn', 'Elaborado sobre');--Prepared On
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Preview', 'preestreno');--Preview
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreviousBalance', 'Saldo Anterior');--Previous Balance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreviousCredit', 'crédito Anterior');--Previous Credit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreviousDebit', 'débito Anterior');--Previous Debit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreviousPage', 'Página Anterior');--Previous Page
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PreviousPeriod', 'Periodo Anterior');--Previous Period  
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Price', 'precio');--Price
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PriceType', 'Precio Tipo');--Price Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Print', 'impresión');--Print
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PrintGlEntry', 'Imprimir Entrada libro mayor');--Print GL Entry
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PrintReceipt', 'Imprimir recibo');--Print Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ProfitAndLossStatement', 'Ganancias y Pérdidas');--Profit & Loss Statement
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Progress', 'progreso');--Progress
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PurchaseInvoice', 'Compra factura');--Purchase Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PurchaseOrder', 'Orden De Compra');--Purchase Order
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PurchaseReturn', 'Compra de Retorno');--Purchase Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'PurchaseType', 'Compra Tipo');--Purchase Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Quantity', 'cantidad');--Quantity
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'QuantityAbbreviated', 'cantidad');--Qty
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'QuantityOnHandAbbreviated', 'Cantidad (en la mano)');--Qty (On Hand)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Rate', 'tarifa');--Rate
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Reason', 'razón');--Reason
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Receipt', 'recibo');--Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReceiptAmount', 'Recibo Importe');--Receipt Amount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReceiptCurrency', 'Recibo moneda');--Receipt Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReceiptType', 'Tipo de Recibo');--Receipt Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReceivedAmountInaboveCurrency', 'Recibió Importe (anteriormente moneda)');--Received Amount (In above Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReceivedCurrency', 'recibido moneda');--Received Currency
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Reconcile', 'conciliar');--Reconcile
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RecurringInvoiceSetup', 'Configuración Factura Recurrente');--Recurring Invoice Setup
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RecurringInvoices', 'facturas recurrentes');--Recurring Invoices
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReferenceNumber', 'Número de referencia');--Reference Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReferenceNumberAbbreviated', 'Referencia #');--Ref#
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RefererenceNumberAbbreviated', 'Referencia #');--Ref #
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RegistrationDate', 'Fecha De Registro');--Registration Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Reject', 'rechazar');--Reject
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RejectThisTransaction', 'Rechazar esta transacción');--Reject This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RejectedTransactions', 'Transacciones rechazadas');--Rejected Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RememberMe', 'Acuérdate De Mí');--Remember Me
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReorderLevel', 'Nivel de Reabastecimiento');--Reorder Level
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReorderQuantityAbbreviated', 'Reordenar Cantidad');--Reorder Qty
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReorderUnitName', 'Nombre Unidad Reordenar');--Reorder Unit Name
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'RequiredField', 'Este es un campo obligatorio.');--This is a required field.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'RequiredFieldDetails', 'Los campos marcados con asterisco (*) son obligatorios.');--The fields marked with asterisk (*) are required.
SELECT * FROM localization.add_localized_resource('Labels', 'es', 'RequiredFieldIndicator', '*');-- *
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Reset', 'reajustar');--Reset
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RestrictedTransactionMode', 'Este establecimiento no permite la publicación de transacciones.');--Restricted Transaction Mode
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RetainedEarnings', 'ganancias Retenidas');--Retained Earnings
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Return', 'retorno');--Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ReturnToView', 'Volver a la vista');--Return to View
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Role', 'papel');--Role
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Roles', 'papeles');--Roles
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RowNumber', 'Número de fila');--Row Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'RunningTotal', 'Asistente de total');--Running Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SSTNumber', 'Número SST');--SST Number
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesByMonthInThousands', 'Ventas por mes (en miles)');--Sales By Month (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesByOfficeInThousands', 'Ventas por oficina (en miles)');--Sales By Office (In Thousands)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesDelivery', 'Entrega Ventas');--Sales Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesDeliveryNote', 'Nota de entrega');--Delivery Note
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesInvoice', 'factura de ventas');--Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesOrder', 'Orden de Venta');--Sales Order
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesPersons', 'vendedores');--Salespersons
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesQuotation', 'Cita Ventas');--Sales Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesReceipt', 'Recibo de Venta');--Sales Receipt
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesReturn', 'Volver Ventas');--Sales Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTaxDetails', 'Detalles de impuesto sobre las ventas');--Sales Tax Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTaxExemptDetails', 'Impuestos a la venta Detalles Exentos');--Sales Tax Exempt Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTaxExempts', 'Exime de impuestos de ventas');--Sales Tax Exempts
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTaxTypes', 'Tipos de Impuestos de Ventas');--Sales Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTaxes', 'impuestos a las Ventas');--Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesTeams', 'Equipos de Ventas');--Sales Teams
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SalesType', 'Tipo de las ventas');--Sales Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Salesperson', 'Vendedor');--Salesperson
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Save', 'Guardar');--Save
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Saving', 'ahorro');--Saving
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Select', 'seleccionar');--Select
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectCompany', 'Seleccione la empresa');--Select Company
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectCustomer', 'Seleccione cliente');--Select Customer
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectFlag', 'Seleccione una bandera');--Select a Flag
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectLanguage', 'Selecciona Idioma de la');--Select Language
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectOffice', 'Seleccione Oficina');--Select Office
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectParty', 'Seleccionar partido');--Select Party
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectPaymentCard', 'Seleccionar Tarjetas de Pago');--Select Payment Card
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectStore', 'Seleccionar tienda');--Select Store
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectSupplier', 'Seleccionar proveedor');--Select Supplier
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectUnit', 'Seleccionar unidad');--Select Unit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectUser', 'Seleccionar usuario');--Select User
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SelectYourBranch', 'Seleccione su sucursal');--Select Your Branch
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Shipper', 'expedidor');--Shipper
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Shippers', 'Transportistas');--Shippers
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShippingAddress', 'Dirección De Envío');--Shipping Address
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShippingAddressMaintenance', 'Dirección de envío Mantenimiento');--Shipping Address Maintenance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShippingAddresses', 'Dirección De Envío');--Shipping Address(es)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShippingCharge', 'La carga de envío');--Shipping Charge
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShippingCompany', 'compañía naviera');--Shipping Company
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Show', 'Mostrar');--Show
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShowAll', 'Mostrar todo');--Show All
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ShowCompact', 'Mostrar compacto');--Show Compact
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SignIn', 'Registrarse');--Sign In
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SignOut', 'Desconectar');--Sign Out
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SigningIn', 'Inicio de sesión en');--Signing In
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Start', 'comienzo');--Start
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StateSalesTaxes', 'Impuestos estatales');--State Sales Taxes
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StatementOfCashFlows', 'Flujo de Efectivo');--Statement of Cash Flows
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StatementReference', 'Declaración de Referencia');--Statement Reference
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'States', 'Unidos');--States
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Status', 'estado');--Status
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StockAdjustment', 'Valores de ajuste');--Stock Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StockTransaction', 'Transacción de acciones');--Stock Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StockTransferJournal', 'Diario de transferencia de acciones');--Stock Transfer Journal
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Store', 'Tienda');--Store
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StoreName', 'Nombre tienda');--Store Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'StoreTypes', 'Tipos Tienda');--Store Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Stores', 'Tiendas');--Stores
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SubTotal', 'Total parcial');--Sub Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SubmitBugs', 'informar sobre fallos');--Submit Bugs
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'SupplierName', 'Nombre del proveedor');--Supplier Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Support', 'apoyo');--Support
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TableEmptyExceptionMessage', 'La propiedad ''Tabla'' no se puede dejar vacío.');--The property 'Table' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TableSchemaEmptyExceptionMessage', 'La propiedad ''esquema de tabla'' no se puede dejar vacío.');--The property 'TableSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaskCompletedSuccessfully', 'Tarea completada con éxito.');--The task was completed successfully.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Tax', 'impuesto');--Tax
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxAuthorities', 'Agencia Tributaria');--Tax Authorities
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxExemptTypes', 'Impuestos Tipos Exentos');--Tax Exempt Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxForm', 'Formulario de impuestos');--Tax Form
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxMaster', 'Maestro de Impuestos');--Tax Master
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxRate', 'Tasa de Impuesto');--Tax Rate
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxSetup', 'Configuración de Impuestos');--Tax Setup
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxTotal', 'Impuesto Total');--Tax Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxTypes', 'Tipos de Impuestos');--Tax Types
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TaxableSales', 'Ventas tributables');--Taxable Sales
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Tel', 'teléfono');--Tel
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'To', 'a');--To
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TopSellingProductsOfAllTime', 'Top productos más vendidos de todos los tiempos');--Top Selling Products of All Time
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Total', 'Total');--Total
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TotalDueAmount', 'La cantidad total debida');--Total Due Amount
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TotalDueAmountCurrentOffice', 'La cantidad total debida (Oficina actual)');--Total Due Amount (Current Office)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TotalDueAmountInBaseCurrency', 'La cantidad total debida (En Base moneda)');--Total Due Amount (In Base Currency)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TotalSales', 'Ventas totales:');--Total Sales :
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TranCode', 'Código de transacción');--Tran Code
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TranId', 'identificador de transacción');--Tran Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TranIdParameter', 'Identificador de Transacción: # {0}');--TranId: #{0}
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionDate', 'Fecha de Transacción');--Transaction Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionDetails', 'Detalles de transacción');--Transaction Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionStatement', 'Declaración de Transacción');--TransactionStatement
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionStatus', 'situación de la operación');--Transaction Status
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionSummary', 'Resumen de transacciones');--Transaction Summary
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionTimestamp', 'Marca de tiempo de transacción');--Transaction Timestamp
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionType', 'Tipo Transacción');--Transaction Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransactionValue', 'Valor de Transacción');--Transaction Value
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TransferDetails', 'detalles de la transferencia');--Transfer Details
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'TrialBalance', 'balance de comprobación');--Trial Balance
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Type', 'tipo');--Type
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UncheckAll', 'Deseleccionar Todos');--Uncheck All
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Undo', 'deshacer');--Undo
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Unit', 'unidad');--Unit
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UnitId', 'identificador de la unidad');--Unit Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UnitName', 'Nombre de la unidad');--Unit Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UnitsOfMeasure', 'Unidades de Medida');--Units of Measure
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UnknownError', 'Error en la operación debido a un error desconocido.');--Operation failed due to an unknown error.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Update', 'actualización');--Update
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Upload', 'Subir');--Upload
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UploadAttachments', 'Sube Adjuntos');--Upload Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UploadAttachmentsForThisTransaction', 'Sube Adjuntos para esta transacción.');--Upload Attachments for This Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Url', 'Localizador de recursos uniforme');--Url
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Use', 'uso');--Use
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'User', 'usuario');--User
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'UserId', 'Identificador de Usuario');--User Id
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Username', 'Nombre de usuario');--Username
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Users', 'Usuarios');--Users
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VacuumDatabase', 'Base de datos de vacío');--Vacuum Database
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VacuumFullDatabase', 'Base de datos de vacío (Completo)');--Vacuum Database (Full)
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ValueDate', 'Fecha Valor');--Value Date
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VerificationReason', 'Verificación Razón');--Verification Reason
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VerifiedBy', 'Por  verificado');--Verified By
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VerifiedOn', 'verificado en');--VerifiedOn
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Verify', 'verificar');--Verify
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'View', 'vista');--View
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewAttachments', 'Ver archivos adjuntos');--View Attachments
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewBackups', 'Ver copias de seguridad');--View Backups
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewCustomerCopy', 'Ver Copia Cliente');--View Customer Copy
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewEmptyExceptionMessage', 'La propiedad "Ver" no se puede dejar vacío.');--The property 'View' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewSalesInovice', 'Ver Factura');--View Sales Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewSchemaEmptyExceptionMessage', 'La propiedad ''Ver esquema'' no se puede dejar vacío.');--The property 'ViewSchema' cannot be left empty.
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisAdjustment', 'Ver este ajuste');--View This Adjustment
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisDelivery', 'Ver este Entrega');--View This Delivery
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisInvoice', 'Ver este Factura');--View This Invoice
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisNote', 'Ver Esta Nota');--View This Note
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisOrder', 'Ver Esta Orden');--View This Order
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisQuotation', 'Ver esta cita');--View This Quotation
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisReturn', 'Ver esto Volver');--View This Return
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'ViewThisTransfer', 'Ver este Transferencia');--View This Transfer
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VoucherVerification', 'Verificación Voucher');--Voucher Verification
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'VoucherVerificationPolicy', 'Vale Política de Verificación');--Voucher Verification Policy
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Warning', 'advertencia');--Warning
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'WhichBank', 'Qué Banco?');--Which Bank?
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'WithdrawTransaction', 'retirar Transacción');--Withdraw Transaction
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'WithdrawnTransactions', 'Transacciones retirados');--Withdrawn Transactions
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Workflow', 'Workflow');--Workflow
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'WorldSalesStatistics', 'Estadísticas de Ventas Mundiales');--World Sales Statistics
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Year', 'año');--Year
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'Yes', 'sí');--Yes
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'YourName', 'Su Nombre');--Your Name
SELECT * FROM localization.add_localized_resource('Titles', 'es', 'YourOffice', 'Su Oficina');--Your Office
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'AccessIsDenied', 'Acceso denegado.');--Access is denied.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotCreateABackup', 'Lo sentimos, no se puede crear una copia de seguridad de base de datos en este momento.');--Sorry, cannot create a database backup at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotCreateFlagTransactionTableNull', 'No se puede crear o actualizar bandera. No se proporcionó tabla de transacciones.');--Cannot create or update flag. Transaction table was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotCreateFlagTransactionTablePrimaryKeyNull', 'No se puede crear o actualizar bandera. No se proporcionó la clave principal tabla de transacciones.');--Cannot create or update flag. Transaction table primary key was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotMergeAlreadyMerged', 'Las transacciones seleccionadas contienen elementos que ya se han fusionado. Por favor, vuelva a intentarlo.');--The selected transactions contain items which have already been merged. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotMergeDifferentPartyTransaction', 'No se puede fusionar las operaciones de los distintos partidos en un solo lote. Por favor, vuelva a intentarlo.');--Cannot merge transactions of different parties into a single batch. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotMergeIncompatibleTax', 'No se puede fusionar las transacciones que tienen tipos impositivos incompatibles. Por favor, vuelva a intentarlo.');--Cannot merge transactions having incompatible tax types. Please try again.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CannotMergeUrlNull', 'No se puede fusionar transacciones. No se proporcionó el url de combinación.');--Cannot merge transactions. The merge url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CashTransactionCannotContainBankInfo', 'Una transacción en efectivo no puede contener bancarias detalles de la transacción.');--A cash transaction cannot contain bank transaction details.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CompareAmountErrorMessage', 'La cantidad que debe ser mayor que la cantidad de.');--The amount to should be greater than the amount from.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CompareDaysErrorMessage', 'De día no debe ser mayor que el a día.');--From days should be less than to days.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ComparePriceErrorMessage', 'Precio de debe ser menor que el precio a.');--Price from should be less than price to.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ConfigurationError', 'No se puede continuar la tarea. Por favor, corrija los problemas de configuración.');--Cannot continue the task. Please correct configuration issues.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ConfirmationPasswordDoesNotMatch', 'La confirmación de contraseña no coincide con la nueva contraseña.');--The confirmation password does not match with the new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CouldNotDetermineEmailImageParserType', 'No se pudo determinar el tipo de imagen analizador de correo electrónico.');--Could not determine image parser type for email.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'CouldNotRegisterJavascript', 'No se pudo registrar JavaScript en esta página porque la instancia página fue válida o vacía.');--Could not register JavaScript on this page because the page instance was invalid or empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'DateErrorMessage', 'Fecha seleccionada está fuera de rango.');--Selected date is invalid.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'DueFrequencyErrorMessage', 'Debido día sólo puede ser 0 si se selecciona la frecuencia debido identificador.');--Due days should be 0 if due frequency id is selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'DuplicateEntry', 'Duplicar entrada.');--Duplicate entry.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'DuplicateFiles', 'Los archivos duplicados.');--Duplicate files.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'GridViewEmpty', 'Vista de cuadrícula está vacía.');--Gridview is empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InsufficientBalanceInCashRepository', 'No hay saldo suficiente en el depósito de dinero en efectivo para procesar esta transacción.');--There is no sufficient balance in the cash repository to process this transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InsufficientStockWarning', 'Sólo {0} {1} de {2} dejados en la acción.');--Only {0} {1} of {2} left in stock.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidAccount', 'Cuenta inválida.');--Invalid account.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidCashRepository', 'Depósito de efectivo no es válida.');--Invalid cash repository.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidCostCenter', 'Centro de costos no es válida.');--Invalid cost center.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidData', 'Los datos no válidos.');--Invalid data.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidDate', 'Fecha no válida.');--Invalid date.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidParameterName', 'Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your command text.');--Invalid Npgsql parameter name {0}. . Make sure that the parameter name matches with your command text.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidParty', 'Partido no válido. Este partido no se asocia con esta transacción.');--Invalid party.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidPaymentTerm', 'Plazo de pago válido.');--Invalid payment term.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidPriceType', 'Tipo Precio incorrecto.');--Invalid price type.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidReceiptMode', 'Modo de recibo válido.');--Invalid receipt mode.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSalesPerson', 'Vendedor no válida.');--Invalid salesperson.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidShippingCompany', 'Naviera no válida.');--Invalid shipping company.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidStockTransaction', 'Inválido transacción de acciones.');--Invalid stock transaction.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidStore', 'Tienda no válida.');--Invalid store.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryDelivery', 'Transacciones no validas Subsidiarios libro "Inventario Entrega"');--Invalid SubTranBook "Inventory Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryDirect', 'Transacciones Subsidiarios no válidos libro "Inventario Directo"');--Invalid SubTranBook "Inventory Direct"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryInvoice', 'nválido Transacciones Subsidiarios libro "Factura de inventario"');--Invalid SubTranBook "Inventory Invoice"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryOrder', 'Inválido Transacciones Subsidiarios libro "Inventario Orden"');--Invalid SubTranBook "Inventory Order"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryPayment', 'Transacciones Subsidiarios válida libro "Inventario de Pago"');--Invalid SubTranBook "Inventory Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryQuotation', 'Inválido Transacciones Subsidiarios libro "Cita de inventario"');--Invalid SubTranBook "Inventory Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryReceipt', 'Inválido Transacciones Subsidiarios libro "Recibo de inventario"');--Invalid SubTranBook "Inventory Receipt"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookInventoryReturn', 'Inválido Transacciones Subsidiarios libro "El regreso de inventario"');--Invalid SubTranBook "Inventory Return"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookPurchaseDelivery', 'Inválido Transacciones Subsidiarios libro "Compra de Entrega"');--Invalid SubTranBook "Purchase Delivery"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookPurchaseQuotation', 'Transacciones Subsidiarios no válidos libro "Cita de Compra"');--Invalid SubTranBook "Purchase Quotation"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookPurchaseSuspense', 'Transacciones Subsidiarios no válidos libro "Suspense Compra"');--Invalid SubTranBook "Purchase Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookPurchaseTransfer', 'Inválido Transacciones Subsidiarios libro "Compra de Transferencia"');--Invalid SubTranBook "Purchase Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookSalesPayment', 'Transacciones Subsidiarios válida libro "de venta"');--Invalid SubTranBook "Sales Payment"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookSalesSuspense', 'Inválido Transacciones Subsidiarios libro "Suspense Ventas"');--Invalid SubTranBook "Sales Suspense"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidSubTranBookSalesTransfer', 'Inválido Transacciones Subsidiarios libro "Transferencia de Ventas"');--Invalid SubTranBook "Sales Transfer"
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'InvalidUser', 'Usuario no válido.');--Invalid user.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ItemErrorMessage', 'Usted tiene que seleccionar entre identificador o identificador de elemento compuesto artículo.');--You have to select either item id or  compound item id.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'LateFeeErrorMessage', 'Identificación del Cargo por y tardía publicación cuota Identificación de frecuencia tanto deben ser bien seleccionados o no.');--Late fee id and late fee posting frequency id both should be either selected or not.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NegativeValueSupplied', 'Valor suministrado negativo.');--Negative value supplied.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NewPasswordCannotBeOldPassword', 'Nueva contraseña no puede ser a una contraseña antigua.');--New password can not be old password.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NoFileSpecified', 'No hay archivo especificado.');--No file specified.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NoTransactionToPost', 'Ninguna transacción para enviar.');--No transaction to post.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NotAuthorized', 'No tiene permisos para acceder a este recurso en este momento.');--You are not authorized to access this resource at this time.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'NothingSelected', 'No se ha seleccionado nada.');--Nothing selected.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'PasswordCannotBeEmpty', 'La contraseña no puede estar vacío.');--Password cannot be empty.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'PleaseEnterCurrentPassword', 'Introduzca su contraseña actual.');--Please enter your current password.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'PleaseEnterNewPassword', 'Por favor, introduzca una nueva contraseña.');--Please enter a new password.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'RecurringAmountErrorMessage', 'cantidad no debe ser menor que o igual a 0.');--Recurring amount should not be less than or equal to 0.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ReferencingSidesNotEqual', 'Los lados que hacen referencia no son iguales.');--The referencing sides are not equal.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'RestrictedTransactionMode', 'Este establecimiento no permite la publicación de transacciones.');--This establishment does not allow transaction posting.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'ReturnButtonUrlNull', 'No se puede volver esta entrada. No se proporcionó el url de retorno.');--Cannot return this entry. The return url was not provided.
SELECT * FROM localization.add_localized_resource('Warnings', 'es', 'UserIdOrPasswordIncorrect', 'Identificador de usuario o contraseña incorrecta.');--User id or password incorrect.
