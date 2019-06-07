// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.employee_type_scrud_view")]
    [ExplicitColumns]
    public sealed class EmployeeTypeScrudView : PetaPocoDB.Record<EmployeeTypeScrudView>, IPoco
    {
        [Column("employee_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeTypeId { get; set; }

        [Column("employee_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string EmployeeTypeCode { get; set; }

        [Column("employee_type_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string EmployeeTypeName { get; set; }
    }
}