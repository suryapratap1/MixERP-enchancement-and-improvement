using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.i18n.Resources;
using Serilog;
using System;
using System.Web.Services;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.Entities.Transactions.Models;

namespace MixERP.Net.Core.Modules.Sales.Services.Receipt
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class TransactionPosting : WebService
    {
        [WebMethod]
        public long Save(string partyCode, string currencyCode, decimal amount, decimal debitExchangeRate,
            decimal creditExchangeRate, string referenceNumber, string statementReference, int costCenterId,
            int cashRepositoryId, DateTime? postedDate, long bankAccountId, int paymentCardId, string bankInstrumentCode,
            string bankTransactionCode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(partyCode))
                {
                    throw new ArgumentNullException("partyCode");
                }

                if (string.IsNullOrWhiteSpace(currencyCode))
                {
                    throw new ArgumentNullException("currencyCode");
                }

                if (amount <= 0)
                {
                    throw new ArgumentNullException("amount");
                }

                if (debitExchangeRate <= 0)
                {
                    throw new ArgumentNullException("debitExchangeRate");
                }

                if (creditExchangeRate <= 0)
                {
                    throw new ArgumentNullException("creditExchangeRate");
                }

                if (cashRepositoryId == 0 && bankAccountId == 0)
                {
                    throw new InvalidOperationException(Warnings.InvalidReceiptMode);
                }

                if (cashRepositoryId > 0 &&
                    (bankAccountId > 0 || !string.IsNullOrWhiteSpace(bankInstrumentCode) ||
                     !string.IsNullOrWhiteSpace(bankInstrumentCode)))
                {
                    throw new InvalidOperationException(Warnings.CashTransactionCannotContainBankInfo);
                }

                long tranId = PostTransaction(partyCode, currencyCode, amount, debitExchangeRate, creditExchangeRate,
                    referenceNumber, statementReference, costCenterId, cashRepositoryId, postedDate, bankAccountId,
                    paymentCardId, bankInstrumentCode, bankTransactionCode);

                VerificationModel status = TransactionGovernor.Verification.Status.GetVerificationStatus(AppUsers.GetCurrentUserDB(), tranId, false);


                if (status.VerificationStatusId > 0)
                {
                    Notification.Receipt notification = new Notification.Receipt();
                    notification.Send(tranId);
                }

                return tranId;
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save sales receipt. {Exception}", ex);
                throw;
            }
        }

        private static long PostTransaction(string partyCode, string currencyCode, decimal amount,
            decimal debitExchangeRate, decimal creditExchangeRate, string referenceNumber, string statementReference,
            int costCenterId, int cashRepositoryId, DateTime? postedDate, long bankAccountId, int paymentCardId,
            string bankInstrumentCode, string bankTransactionCode)
        {
            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

            long transactionMasterID = Data.Transactions.Receipt.PostTransaction(AppUsers.GetCurrentUserDB(), userId,
                officeId, loginId, partyCode, currencyCode, amount, debitExchangeRate, creditExchangeRate,
                referenceNumber, statementReference, costCenterId, cashRepositoryId, postedDate, bankAccountId,
                paymentCardId, bankInstrumentCode, bankTransactionCode);

            return transactionMasterID;
        }
    }
}