// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("zip_code_id", autoIncrement = true)]
    [TableName("core.zip_codes")]
    [ExplicitColumns]
    public sealed class ZipCode : PetaPocoDB.Record<ZipCode>, IPoco
    {
        [Column("zip_code_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.zip_codes_zip_code_id_seq'::regclass)")]
        public long ZipCodeId { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StateId { get; set; }

        [Column("code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string Code { get; set; }

        [Column("zip_code_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ZipCodeTypeId { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 100, false, "")]
        public string City { get; set; }

        [Column("lat")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Lat { get; set; }

        [Column("lon")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Lon { get; set; }

        [Column("x_axis")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? XAxis { get; set; }

        [Column("y_axis")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? YAxis { get; set; }

        [Column("z_axis")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? ZAxis { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}