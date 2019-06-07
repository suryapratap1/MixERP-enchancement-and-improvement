// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_workflow_model")]
    [ExplicitColumns]
    public sealed class DbGetWorkflowModelResult : PetaPocoDB.Record<DbGetWorkflowModelResult>, IPoco
    {
        [Column("flagged_transactions")]
        [ColumnDbType("integer", 0, false, "")]
        public int FlaggedTransactions { get; set; }

        [Column("in_verification_stack")]
        [ColumnDbType("integer", 0, false, "")]
        public int InVerificationStack { get; set; }

        [Column("auto_approved")]
        [ColumnDbType("integer", 0, false, "")]
        public int AutoApproved { get; set; }

        [Column("approved")]
        [ColumnDbType("integer", 0, false, "")]
        public int Approved { get; set; }

        [Column("rejected")]
        [ColumnDbType("integer", 0, false, "")]
        public int Rejected { get; set; }

        [Column("closed")]
        [ColumnDbType("integer", 0, false, "")]
        public int Closed { get; set; }

        [Column("withdrawn")]
        [ColumnDbType("integer", 0, false, "")]
        public int Withdrawn { get; set; }
    }
}