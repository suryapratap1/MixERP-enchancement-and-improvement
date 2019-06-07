// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("country_id", autoIncrement = true)]
    [TableName("core.countries")]
    [ExplicitColumns]
    public sealed class Country : PetaPocoDB.Record<Country>, IPoco
    {
        [Column("country_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.countries_country_id_seq'::regclass)")]
        public int CountryId { get; set; }

        [Column("country_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CountryCode { get; set; }

        [Column("country_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string CountryName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}