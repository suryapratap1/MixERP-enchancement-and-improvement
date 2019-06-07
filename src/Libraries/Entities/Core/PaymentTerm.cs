// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("payment_term_id", autoIncrement = true)]
    [TableName("core.payment_terms")]
    [ExplicitColumns]
    public sealed class PaymentTerm : PetaPocoDB.Record<PaymentTerm>, IPoco
    {
        [Column("payment_term_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.payment_terms_payment_term_id_seq'::regclass)")]
        public int PaymentTermId { get; set; }

        [Column("payment_term_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string PaymentTermCode { get; set; }

        [Column("payment_term_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string PaymentTermName { get; set; }

        [Column("due_on_date")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool DueOnDate { get; set; }

        [Column("due_days")]
        [ColumnDbType("int4", 0, false, "0")]
        public int DueDays { get; set; }

        [Column("due_frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DueFrequencyId { get; set; }

        [Column("grace_period")]
        [ColumnDbType("int4", 0, false, "0")]
        public int GracePeriod { get; set; }

        [Column("late_fee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LateFeeId { get; set; }

        [Column("late_fee_posting_frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LateFeePostingFrequencyId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}