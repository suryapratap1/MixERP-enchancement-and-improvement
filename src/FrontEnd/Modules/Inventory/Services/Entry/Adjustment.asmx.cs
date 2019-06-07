using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Inventory.Data.Helpers;
using MixERP.Net.Core.Modules.Inventory.Data.Transactions;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.Framework;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using Serilog;

namespace MixERP.Net.Core.Modules.Inventory.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Adjustment : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, string referenceNumber, string statementReference, string models)
        {
            try
            {
                Collection<StockAdjustmentDetail> stockAdjustmentModels = GetModels(models);
                foreach (StockAdjustmentDetail model in stockAdjustmentModels)
                {
                    if (model.TransferTypeEnum == TransactionTypeEnum.Credit)
                    {
                        decimal existingQuantity = Items.CountItemInStock(AppUsers.GetCurrentUserDB(), model.ItemCode,
                            model.UnitName, model.StoreName);

                        if (existingQuantity < model.Quantity)
                        {
                            throw new MixERPException(string.Format(CultureManager.GetCurrent(),
                                Errors.InsufficientStockWarning, Conversion.TryCastInteger(existingQuantity),
                                model.UnitName, model.ItemName));
                        }
                    }
                }

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                return StockAdjustment.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId, valueDate,
                    referenceNumber, statementReference, stockAdjustmentModels);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save inventory adjustment entry. {Exception}", ex);
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
                const TransactionTypeEnum typeEnum = TransactionTypeEnum.Credit;

                detail.TransferTypeEnum = typeEnum;
                detail.StoreName = Conversion.TryCastString(item["StoreName"]);
                detail.ItemCode = Conversion.TryCastString(item["ItemCode"]);
                detail.ItemName = Conversion.TryCastString(item["ItemName"]);
                detail.UnitName = Conversion.TryCastString(item["UnitName"]);
                detail.Quantity = Conversion.TryCastInteger(item["Quantity"]);

                models.Add(detail);
            }

            return models;
        }
    }
}