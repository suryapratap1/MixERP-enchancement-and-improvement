// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.party_type_selector_view")]
    [ExplicitColumns]
    public sealed class PartyTypeSelectorView : PetaPocoDB.Record<PartyTypeSelectorView>, IPoco
    {
        [Column("party_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PartyTypeId { get; set; }

        [Column("party_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PartyTypeName { get; set; }

        [Column("is_supplier")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSupplier { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}