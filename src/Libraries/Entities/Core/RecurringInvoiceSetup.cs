// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("recurring_invoice_setup_id", autoIncrement = true)]
    [TableName("core.recurring_invoice_setup")]
    [ExplicitColumns]
    public sealed class RecurringInvoiceSetup : PetaPocoDB.Record<RecurringInvoiceSetup>, IPoco
    {
        [Column("recurring_invoice_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.recurring_invoice_setup_recurring_invoice_setup_id_seq'::regclass)")]
        public int RecurringInvoiceSetupId { get; set; }

        [Column("recurring_invoice_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RecurringInvoiceId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("starts_from")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime StartsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime EndsOn { get; set; }

        [Column("recurrence_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RecurrenceTypeId { get; set; }

        [Column("recurring_frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RecurringFrequencyId { get; set; }

        [Column("recurring_duration")]
        [ColumnDbType("integer_strict2", 0, false, "0")]
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