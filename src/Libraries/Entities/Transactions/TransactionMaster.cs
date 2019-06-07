// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("transaction_master_id", autoIncrement = true)]
    [TableName("transactions.transaction_master")]
    [ExplicitColumns]
    public sealed class TransactionMaster : PetaPocoDB.Record<TransactionMaster>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.transaction_master_transaction_master_id_seq'::regclass)")]
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")]
        [ColumnDbType("int4", 0, false, "")]
        public int TransactionCounter { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("varchar", 50, false, "")]
        public string TransactionCode { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, false, "")]
        public string Book { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("sys_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SysUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("cost_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CostCenterId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("last_verified_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("int2", 0, false, "0")]
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("varchar", 128, false, "")]
        public string VerificationReason { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("cascading_tran_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? CascadingTranId { get; set; }

        [Column("book_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime BookDate { get; set; }
    }
}