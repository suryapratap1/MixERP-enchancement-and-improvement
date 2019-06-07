using MixERP.Net.Common;
using Npgsql;
using System;
using System.Linq;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Transactions
{
    public static class Receipt
    {
        public static long PostTransaction(string catalog, int userId, int officeId, long loginId, string partyCode,
            string currencyCode,
            decimal amount, decimal debitExchangeRate, decimal creditExchangeRate, string referenceNumber,
            string statementReference, int costCenterId, int cashRepositoryId, DateTime? postedDate, long bankAccountId,
            int paymentCardId, string bankInstrumentCode, string bankTransactionCode)
        {
            const string sql = "SELECT transactions.post_receipt" +
                               "(" +
                               "@UserId::integer, " +
                               "@OfficeId::integer, " +
                               "@LoginId::bigint, " +
                               "@PartyCode::national character varying(12), " +
                               "@CurrencyCode::national character varying(12), " +
                               "@Amount::public.money_strict, " +
                               "@DebitExchangeRate::public.decimal_strict, " +
                               "@CreditExchangeRate::public.decimal_strict, " +
                               "@ReferenceNumber::national character varying(24), " +
                               "@StatementReference::national character varying(128), " +
                               "@CostCenterId::integer, " +
                               "@CashRepositoryId::integer, " +
                               "@PostedDate::date, " +
                               "@BankAccountId::bigint, " +
                               "@PaymentCardId::integer, " +
                               "@BankInstrumentCode::national character varying(128), " +
                               "@BankTransactionCode::national character varying(128)" +
                               "); ";


            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@LoginId", loginId);
                command.Parameters.AddWithValue("@PartyCode", partyCode);
                command.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@DebitExchangeRate", debitExchangeRate);
                command.Parameters.AddWithValue("@CreditExchangeRate", creditExchangeRate);
                command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                command.Parameters.AddWithValue("@StatementReference", statementReference);

                if (costCenterId.Equals(0))
                {
                    command.Parameters.AddWithValue("@CostCenterId", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@CostCenterId", costCenterId);
                }

                if (cashRepositoryId.Equals(0))
                {
                    command.Parameters.AddWithValue("@CashRepositoryId", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@CashRepositoryId", cashRepositoryId);
                }

                if (bankAccountId.Equals(0))
                {
                    command.Parameters.AddWithValue("@BankAccountId", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@BankAccountId", bankAccountId);
                }

                if (paymentCardId.Equals(0))
                {
                    command.Parameters.AddWithValue("@PaymentCardId", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PaymentCardId", paymentCardId);
                }

                if (postedDate == null)
                {
                    command.Parameters.AddWithValue("@PostedDate", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PostedDate", postedDate);
                }

                command.Parameters.AddWithValue("@BankInstrumentCode", bankInstrumentCode);
                command.Parameters.AddWithValue("@BankTransactionCode", bankTransactionCode);

                return Conversion.TryCastLong(DbFactory.DbOperation.GetScalarValue(catalog, command));
            }
        }

        public static ReceiptView GetReceiptView(string catalog, long tranId)
        {
            const string sql = "SELECT * FROM transactions.receipt_view WHERE tran_id = @0;";
            return Factory.Get<ReceiptView>(catalog, sql, tranId).FirstOrDefault();
        }

    }
}