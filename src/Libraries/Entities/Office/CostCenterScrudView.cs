// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.cost_center_scrud_view")]
    [ExplicitColumns]
    public sealed class CostCenterScrudView : PetaPocoDB.Record<CostCenterScrudView>, IPoco
    {
        [Column("cost_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CostCenterId { get; set; }

        [Column("cost_center_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string CostCenterCode { get; set; }

        [Column("cost_center_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CostCenterName { get; set; }
    }
}