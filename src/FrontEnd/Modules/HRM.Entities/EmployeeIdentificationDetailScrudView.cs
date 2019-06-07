// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.employee_identification_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class EmployeeIdentificationDetailScrudView : PetaPocoDB.Record<EmployeeIdentificationDetailScrudView>, IPoco
    {
        [Column("employee_identification_detail_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? EmployeeIdentificationDetailId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")]
        public string EmployeeName { get; set; }

        [Column("identification_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string IdentificationTypeCode { get; set; }

        [Column("identification_type_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string IdentificationTypeName { get; set; }

        [Column("identification_number")]
        [ColumnDbType("varchar", 128, true, "")]
        public string IdentificationNumber { get; set; }

        [Column("expires_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ExpiresOn { get; set; }
    }
}