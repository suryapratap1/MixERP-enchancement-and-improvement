// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.contract_verification_scrud_view")]
    [ExplicitColumns]
    public sealed class ContractVerificationScrudView : PetaPocoDB.Record<ContractVerificationScrudView>, IPoco
    {
        [Column("contract_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ContractId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("department")]
        [ColumnDbType("text", 0, true, "")]
        public string Department { get; set; }

        [Column("role")]
        [ColumnDbType("text", 0, true, "")]
        public string Role { get; set; }

        [Column("leave_benefit")]
        [ColumnDbType("text", 0, true, "")]
        public string LeaveBenefit { get; set; }

        [Column("employment_status_code")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatusCode { get; set; }

        [Column("began_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? BeganOn { get; set; }

        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndedOn { get; set; }
    }
}