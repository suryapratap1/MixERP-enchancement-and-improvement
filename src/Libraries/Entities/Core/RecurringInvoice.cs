// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("recurring_invoice_id", autoIncrement = true)]
    [TableName("core.recurring_invoices")]
    [ExplicitColumns]
    public sealed class RecurringInvoice : PetaPocoDB.Record<RecurringInvoice>, IPoco
    {
        [Column("recurring_invoice_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.recurring_invoices_recurring_invoice_id_seq'::regclass)")]
        public int RecurringInvoiceId { get; set; }

        [Column("recurring_invoice_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string RecurringInvoiceCode { get; set; }

        [Column("recurring_invoice_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string RecurringInvoiceName { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("total_duration")]
        [ColumnDbType("int4", 0, false, "365")]
        public int TotalDuration { get; set; }

        [Column("recurrence_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RecurrenceTypeId { get; set; }

        [Column("recurring_frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RecurringFrequencyId { get; set; }

        [Column("recurring_duration")]
        [ColumnDbType("integer_strict2", 0, false, "30")]
        public int RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal RecurringAmount { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("payment_term_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int PaymentTermId { get; set; }

        [Column("auto_trigger_on_sales")]
        [ColumnDbType("bool", 0, false, "")]
        public bool AutoTriggerOnSales { get; set; }

        [Column("is_active")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool IsActive { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 100, false, "")]
        public string StatementReference { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}