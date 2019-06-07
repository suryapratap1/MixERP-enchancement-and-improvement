using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions.Models
{
    [ExplicitColumns]
    public class VerificationModel
    {
        [Column("verification_reason")]
        public string VerificationReason { get; set; }

        [Column("verification_status_id")]
        public short VerificationStatusId { get; set; }

        [Column("last_verified_on")]
        public DateTime VerifiedDate { get; set; }

        [Column("verified_by_user_name")]
        public string VerifierName { get; set; }

        [Column("verified_by_user_id")]
        public int VerifierUserId { get; set; }
    }
}