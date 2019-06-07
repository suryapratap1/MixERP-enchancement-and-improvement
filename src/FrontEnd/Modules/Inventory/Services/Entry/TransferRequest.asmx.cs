using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Inventory.Data.Transactions;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using Serilog;

namespace MixERP.Net.Core.Modules.Inventory.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class TransferRequest : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, string referenceNumber, string statementReference, string data)
        {
            try
            {
                Collection<StockAdjustmentDetail> models = GetModels(data);

                if (models == null || models.Count.Equals(0))
                {
                    throw new MixERPException(Warnings.GridViewEmpty);
                }

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                return StockTransferRequest.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId, valueDate,
                    referenceNumber, statementReference, models);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save inventory transfer entry. {Exception}", ex);
                throw;
            }
        }

        private static Collection<StockAdjustmentDetail> GetModels(string json)
        {
            Collection<StockAdjustmentDetail> models = new Collection<StockAdjustmentDetail>();

            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic result = jss.Deserialize<dynamic>(json);

            foreach (dynamic item in result)
            {
                StockAdjustmentDetail detail = new StockAdjustmentDetail();
                detail.TransferTypeEnum = TransactionTypeEnum.Debit;

                detail.StoreName = Conversion.TryCastString(item[0]);
                detail.ItemCode = Conversion.TryCastString(item[1]);
                detail.ItemName = Conversion.TryCastString(item[2]);
                detail.UnitName = Conversion.TryCastString(item[3]);
                detail.Quantity = Conversion.TryCastInteger(item[4]);

                models.Add(detail);
            }

            return models;
        }
    }
}