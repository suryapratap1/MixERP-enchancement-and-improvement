// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.party_type_scrud_view")]
    [ExplicitColumns]
    public sealed class PartyTypeScrudView : PetaPocoDB.Record<PartyTypeScrudView>, IPoco
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

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }
    }
}