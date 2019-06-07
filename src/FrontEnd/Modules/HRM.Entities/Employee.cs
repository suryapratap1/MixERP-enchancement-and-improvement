// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_id", autoIncrement = true)]
    [TableName("hrm.employees")]
    [ExplicitColumns]
    public sealed class Employee : PetaPocoDB.Record<Employee>, IPoco
    {
        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.employees_employee_id_seq'::regclass)")]
        public int EmployeeId { get; set; }

        [Column("employee_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string EmployeeCode { get; set; }

        [Column("first_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string LastName { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, false, "")]
        public string EmployeeName { get; set; }

        [Column("gender_code")]
        [ColumnDbType("varchar", 4, false, "")]
        public string GenderCode { get; set; }

        [Column("marital_status_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MaritalStatusId { get; set; }

        [Column("joined_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? JoinedOn { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("employee_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeTypeId { get; set; }

        [Column("current_department_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CurrentDepartmentId { get; set; }

        [Column("current_role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CurrentRoleId { get; set; }

        [Column("current_employment_status_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CurrentEmploymentStatusId { get; set; }

        [Column("current_job_title_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CurrentJobTitleId { get; set; }

        [Column("current_pay_grade_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CurrentPayGradeId { get; set; }

        [Column("current_shift_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CurrentShiftId { get; set; }

        [Column("nationality_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string NationalityCode { get; set; }

        [Column("date_of_birth")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? DateOfBirth { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("bank_account_number")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankAccountNumber { get; set; }

        [Column("bank_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankName { get; set; }

        [Column("bank_branch_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankBranchName { get; set; }

        [Column("bank_reference_number")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankReferenceNumber { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("zip_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ZipCode { get; set; }

        [Column("address_line_1")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine1 { get; set; }

        [Column("address_line_2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine2 { get; set; }

        [Column("street")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Street { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 128, true, "")]
        public string City { get; set; }

        [Column("state")]
        [ColumnDbType("varchar", 128, true, "")]
        public string State { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountryId { get; set; }

        [Column("phone_home")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneHome { get; set; }

        [Column("phone_cell")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneCell { get; set; }

        [Column("phone_office_extension")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneOfficeExtension { get; set; }

        [Column("phone_emergency")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneEmergency { get; set; }

        [Column("phone_emergency2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PhoneEmergency2 { get; set; }

        [Column("email_address")]
        [ColumnDbType("varchar", 128, true, "")]
        public string EmailAddress { get; set; }

        [Column("website")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Website { get; set; }

        [Column("blog")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Blog { get; set; }

        [Column("is_smoker")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSmoker { get; set; }

        [Column("is_alcoholic")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsAlcoholic { get; set; }

        [Column("with_disabilities")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? WithDisabilities { get; set; }

        [Column("low_vision")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? LowVision { get; set; }

        [Column("uses_wheelchair")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? UsesWheelchair { get; set; }

        [Column("hard_of_hearing")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? HardOfHearing { get; set; }

        [Column("is_aphonic")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsAphonic { get; set; }

        [Column("is_cognitively_disabled")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsCognitivelyDisabled { get; set; }

        [Column("is_autistic")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsAutistic { get; set; }

        [Column("service_ended_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ServiceEndedOn { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}