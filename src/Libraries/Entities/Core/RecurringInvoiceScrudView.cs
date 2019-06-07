// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.recurring_invoice_scrud_view")]
    [ExplicitColumns]
    public sealed class RecurringInvoiceScrudView : PetaPocoDB.Record<RecurringInvoiceScrudView>, IPoco
    {
        [Column("recurring_invoice_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RecurringInvoiceId { get; set; }

        [Column("recurring_invoice_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string RecurringInvoiceCode { get; set; }

        [Column("recurring_invoice_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RecurringInvoiceName { get; set; }

        [Column("item")]
        [ColumnDbType("text", 0, true, "")]
        public string Item { get; set; }

        [Column("total_duration")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TotalDuration { get; set; }

        [Column("recurrence_type")]
        [ColumnDbType("text", 0, true, "")]
        public string RecurrenceType { get; set; }

        [Column("recurring_frequency")]
        [ColumnDbType("text", 0, true, "")]
        public string RecurringFrequency { get; set; }

        [Column("recurring_duration")]
        [ColumnDbType("integer_strict2", 0, true, "")]
        public int? RecurringDuration { get; set; }

        [Column("recurs_on_same_calendar_date")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? RecursOnSameCalendarDate { get; set; }

        [Column("recurring_amount")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? RecurringAmount { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }

        [Column("payment_term")]
        [ColumnDbType("text", 0, true, "")]
        public string PaymentTerm { get; set; }

        [Column("auto_trigger_on_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AutoTriggerOnSales { get; set; }

        [Column("is_active")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsActive { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 100, true, "")]
        public string StatementReference { get; set; }
    }
}