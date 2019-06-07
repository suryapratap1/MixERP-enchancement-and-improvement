// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("tax_master_id", autoIncrement = true)]
    [TableName("core.tax_master")]
    [ExplicitColumns]
    public sealed class TaxMaster : PetaPocoDB.Record<TaxMaster>, IPoco
    {
        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.tax_master_tax_master_id_seq'::regclass)")]
        public int TaxMasterId { get; set; }

        [Column("tax_master_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string TaxMasterCode { get; set; }

        [Column("tax_master_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string TaxMasterName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}