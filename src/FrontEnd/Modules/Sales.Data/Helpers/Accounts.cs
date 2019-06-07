using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Accounts
    {
        public static IEnumerable<BankAccount> GetBankAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.bank_accounts ORDER BY account_id;";
            return Factory.Get<BankAccount>(catalog, sql);
        }

        public static IEnumerable<BankAccount> GetBankAccounts(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM core.bank_accounts WHERE office_id=@0 ORDER BY account_id;";
            return Factory.Get<BankAccount>(catalog, sql, officeId);
        }

        public static IEnumerable<PaymentCard> GetPaymentCards(string catalog)
        {
            const string sql = "SELECT * FROM core.payment_cards;";
            return Factory.Get<PaymentCard>(catalog, sql);
        }

        public static bool IsMerchantAccount(string catalog, long AccountId)
        {
            const string sql = "SELECT * FROM core.bank_accounts WHERE account_id=@0 AND is_merchant_account;";
            return Factory.Get<BankAccount>(catalog, sql, AccountId).Count().Equals(1);
        }

        public static IEnumerable<CashRepository> GetCashRepositories(string catalog)
        {
            const string sql = "SELECT * FROM office.cash_repositories ORDER BY cash_repository_id;";
            return Factory.Get<CashRepository>(catalog, sql);
        }

        public static IEnumerable<CashRepository> GetCashRepositories(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM office.cash_repositories WHERE office_id=@0 ORDER BY cash_repository_id;";
            return Factory.Get<CashRepository>(catalog, sql, officeId);
        }

        public static IEnumerable<CostCenter> GetCostCenters(string catalog)
        {
            const string sql = "SELECT * FROM office.cost_centers ORDER BY cost_center_id;";
            ;
            return Factory.Get<CostCenter>(catalog, sql);
        }

        public static IEnumerable<FlagType> GetFlagTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.flag_types ORDER BY flag_type_id;";
            return Factory.Get<FlagType>(catalog, sql);
        }

        public static MerchantFeeSetup GetMerchantFeeSetup(string catalog, long merchantAccountId, int paymentCardId)
        {
            const string sql =
                "SELECT * FROM core.merchant_fee_setup WHERE merchant_account_id=@0 AND payment_card_id=@1;";
            return Factory.Get<MerchantFeeSetup>(catalog, sql, merchantAccountId, paymentCardId).FirstOrDefault();
        }
    }
}