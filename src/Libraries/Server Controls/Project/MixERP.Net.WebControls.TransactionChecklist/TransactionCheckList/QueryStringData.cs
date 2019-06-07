using MixERP.Net.Common;
using System.Globalization;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private const string TRAN_ID_PARAMETER_NAME = "TranId";

        private string GetTranId()
        {
            long transactionMasterId = Conversion.TryCastLong(this.Page.Request[TRAN_ID_PARAMETER_NAME]);
            return transactionMasterId.ToString(CultureInfo.InvariantCulture);
        }
    }
}