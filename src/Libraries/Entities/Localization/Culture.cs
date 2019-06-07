// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("culture_code", autoIncrement = false)]
    [TableName("localization.cultures")]
    [ExplicitColumns]
    public sealed class Culture : PetaPocoDB.Record<Culture>, IPoco
    {
        [Column("culture_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CultureCode { get; set; }

        [Column("culture_name")]
        [ColumnDbType("text", 0, true, "")]
        public string CultureName { get; set; }
    }
}