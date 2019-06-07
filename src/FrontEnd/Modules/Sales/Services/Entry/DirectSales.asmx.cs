using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Sales.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.StockTransactionFactory.Helpers;
using Serilog;

namespace MixERP.Net.Core.Modules.Sales.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class DirectSales : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, int storeId, string partyCode, int priceTypeId, string referenceNumber,
            string data, string statementReference, string transactionType, int paymentTermId, int salespersonId,
            int shipperId, string shippingAddressCode, decimal shippingCharge, int costCenterId, string transactionIds,
            string attachmentsJSON, bool nonTaxable)
        {
            try
            {
                Collection<StockDetail> details = CollectionHelper.GetStockMasterDetailCollection(data, storeId);

                Collection<Attachment> attachments = CollectionHelper.GetAttachmentCollection(attachmentsJSON);

                bool isCredit = transactionType != null && !transactionType.ToUpperInvariant().Equals("CASH");

                if (!Stores.IsSalesAllowed(AppUsers.GetCurrentUserDB(), storeId))
                {
                    throw new InvalidOperationException("Sales is not allowed here.");
                }

                foreach (StockDetail model in details)
                {
                    if (Items.IsStockItem(AppUsers.GetCurrentUserDB(), model.ItemCode))
                    {
                        decimal available = Items.CountItemInStock(AppUsers.GetCurrentUserDB(),
                            model.ItemCode, model.UnitName, model.StoreId);

                        if (available < model.Quantity)
                        {
                            throw new InvalidOperationException(string.Format(CultureManager.GetCurrent(),
                                Warnings.InsufficientStockWarning, available, model.UnitName, model.ItemCode));
                        }
                    }
                }

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                var tranIds = new Collection<long>();
                if (!string.IsNullOrWhiteSpace(transactionIds))
                {
                    foreach (string transactionId in transactionIds.Split(','))
                    {
                        tranIds.Add(Conversion.TryCastLong(transactionId));
                    }
                }

                return Data.Transactions.DirectSales.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId,
                    valueDate, storeId, isCredit, paymentTermId, partyCode, salespersonId, priceTypeId, details,
                    shipperId, shippingAddressCode, shippingCharge, costCenterId, referenceNumber, statementReference,
                    attachments, nonTaxable, tranIds);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save direct sales entry. {Exception}", ex);
                throw;
            }
        }
    }
}