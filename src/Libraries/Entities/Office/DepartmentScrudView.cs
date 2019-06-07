// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.department_scrud_view")]
    [ExplicitColumns]
    public sealed class DepartmentScrudView : PetaPocoDB.Record<DepartmentScrudView>, IPoco
    {
        [Column("department_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DepartmentId { get; set; }

        [Column("department_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string DepartmentCode { get; set; }

        [Column("department_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string DepartmentName { get; set; }
    }
}