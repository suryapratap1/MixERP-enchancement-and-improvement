using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.i18n.Resources;
using MixERP.Net.TransactionGovernor;
using MixERP.Net.WebControls.StockTransactionFactory.Helpers;
using Serilog;

namespace MixERP.Net.Core.Modules.Purchase.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Return : WebService
    {
        [WebMethod]
        public long Save(long tranId, DateTime valueDate, int storeId, string partyCode, int priceTypeId,
            string referenceNumber, string data, string statementReference, string attachmentsJSON)
        {
            try
            {
                if (!StockTransaction.IsValidStockTransactionByTransactionMasterId(AppUsers.GetCurrentUserDB(), tranId))
                {
                    throw new InvalidOperationException(Warnings.InvalidStockTransaction);
                }

                if (!StockTransaction.IsValidPartyByTransactionMasterId(AppUsers.GetCurrentUserDB(), tranId, partyCode))
                {
                    throw new InvalidOperationException(Warnings.InvalidParty);
                }

                Collection<StockDetail> details = CollectionHelper.GetStockMasterDetailCollection(data, storeId);


                Collection<Attachment> attachments = CollectionHelper.GetAttachmentCollection(attachmentsJSON);

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                return Data.Transactions.Return.PostTransaction(AppUsers.GetCurrentUserDB(), tranId, valueDate, officeId,
                    userId, loginId, storeId,
                    partyCode, priceTypeId, referenceNumber, statementReference, details, attachments);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save purchase return entry. {Exception}", ex);
                throw;
            }
        }
    }
}