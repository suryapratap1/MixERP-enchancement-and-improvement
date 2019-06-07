// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("verification_status_id", autoIncrement = false)]
    [TableName("core.verification_statuses")]
    [ExplicitColumns]
    public sealed class VerificationStatus : PetaPocoDB.Record<VerificationStatus>, IPoco
    {
        [Column("verification_status_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short VerificationStatusId { get; set; }

        [Column("verification_status_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string VerificationStatusName { get; set; }
    }
}