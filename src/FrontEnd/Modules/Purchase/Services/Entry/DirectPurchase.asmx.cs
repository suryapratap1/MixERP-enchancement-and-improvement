using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.WebControls.StockTransactionFactory.Helpers;
using Serilog;

namespace MixERP.Net.Core.Modules.Purchase.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class DirectPurchase : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, int storeId, string partyCode, string referenceNumber, string data,
            string statementReference, string transactionType, int costCenterId, string attachmentsJSON)
        {
            try
            {
                Collection<StockDetail> details = CollectionHelper.GetStockMasterDetailCollection(data, storeId);

                Collection<Attachment> attachments = CollectionHelper.GetAttachmentCollection(attachmentsJSON);

                bool isCredit = !string.IsNullOrWhiteSpace(transactionType) &&
                                !transactionType.ToUpperInvariant().Equals("CASH");
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                return Data.Transactions.DirectPurchase.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId,
                    valueDate, storeId, isCredit, partyCode, details, costCenterId, referenceNumber, statementReference,
                    attachments);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save direct purchase entry. {Exception}", ex);
                throw;
            }
        }
    }
}