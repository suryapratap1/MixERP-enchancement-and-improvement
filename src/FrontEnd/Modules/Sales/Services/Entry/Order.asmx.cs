using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Hosting;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Sales.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.i18n.Resources;
using MixERP.Net.Messaging.Email;
using Newtonsoft.Json;
using Serilog;
using CollectionHelper = MixERP.Net.WebControls.StockTransactionFactory.Helpers.CollectionHelper;

namespace MixERP.Net.Core.Modules.Sales.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Order : WebService
    {
        [WebMethod]
        public string GetUndeliveredProducts(string partyCode, int storeId)
        {
            if (string.IsNullOrWhiteSpace(partyCode))
            {
                return string.Empty;
            }

            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            var model = Data.Transactions.Order.GetUndeliveredProducts(AppUsers.GetCurrentUserDB(), officeId, partyCode, storeId);
            var response = JsonConvert.SerializeObject(model);
            return response;
        }

        [WebMethod]
        public long Save(DateTime valueDate, int storeId, string partyCode, int priceTypeId, string referenceNumber,
            string data, string statementReference, string transactionIds, string attachmentsJSON, bool nonTaxable,
            int salespersonId, int shipperId, string shippingAddressCode)
        {
            try
            {
                Collection<StockDetail> details = CollectionHelper.GetStockMasterDetailCollection(data, storeId);
                Collection<long> tranIds = new Collection<long>();

                Collection<Attachment> attachments = CollectionHelper.GetAttachmentCollection(attachmentsJSON);

                if (!string.IsNullOrWhiteSpace(transactionIds))
                {
                    foreach (string transactionId in transactionIds.Split(','))
                    {
                        tranIds.Add(Conversion.TryCastLong(transactionId));
                    }
                }

                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                long tranId = Data.Transactions.Order.Add(AppUsers.GetCurrentUserDB(), officeId, userId, loginId,
                    valueDate,
                    partyCode, priceTypeId, details, referenceNumber, statementReference, tranIds, attachments,
                    nonTaxable, salespersonId, shipperId, shippingAddressCode, storeId);

                if (tranId > 0)
                {
                    this.CreateEmail(tranId, partyCode);
                }

                return tranId;
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save sales order entry. {Exception}", ex);
                throw;
            }
        }

        private void CreateEmail(long tranId, string partyCode)
        {
            string sendTo = Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(), partyCode);

            if (string.IsNullOrWhiteSpace(sendTo))
            {
                return;
            }

            string message = ProcessEmailMessage(tranId);
            string attachment =
                HostingEnvironment.MapPath("/Resource/Documents/" + Titles.SalesOrder + "-#" + tranId + ".pdf");

            string subject = string.Format(Labels.SalesOrderEmailSubject, tranId,
                AppUsers.GetCurrent().View.OfficeName);

            MailQueueManager queue = new MailQueueManager(AppUsers.GetCurrentUserDB(), message, attachment, sendTo,
                subject);
            queue.Add();
        }

        private static string ProcessEmailMessage(long tranId)
        {
            string template = EmailTemplateHelper.GetTemplateFileContents("/Static/Templates/Email/Sales/Order.html");

            List<object> dictionary = new List<object>
            {
                AppUsers.GetCurrent().View,
                Data.Transactions.Order.GetSalesOrderView(AppUsers.GetCurrentUserDB(), tranId)
            };

            EmailTemplateProcessor processor = new EmailTemplateProcessor(template, dictionary);
            template = processor.Process();

            return template;
        }
    }
}