// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.tax_master_scrud_view")]
    [ExplicitColumns]
    public sealed class TaxMasterScrudView : PetaPocoDB.Record<TaxMasterScrudView>, IPoco
    {
        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TaxMasterId { get; set; }

        [Column("tax_master_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string TaxMasterCode { get; set; }

        [Column("tax_master_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TaxMasterName { get; set; }
    }
}