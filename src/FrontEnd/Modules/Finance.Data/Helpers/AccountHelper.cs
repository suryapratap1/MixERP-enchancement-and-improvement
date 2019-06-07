using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Helpers
{
    public static class AccountHelper
    {
        public static bool AccountNumberExists(string catalog, string accountNumber)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_number=@0;";
            return Factory.Get<Account>(catalog, sql, accountNumber).Count().Equals(1);
        }


        public static string GetAccountNameByAccountId(string catalog, long accountId)
        {
            const string sql = "SELECT account_name FROM core.accounts WHERE account_id=@0;";
            return Factory.Scalar<string>(catalog, sql, accountId);
        }

        public static string GetAccountNumberByAccountId(string catalog, long accountId)
        {
            const string sql = "SELECT account_number FROM core.accounts WHERE account_id=@0;";
            return Factory.Scalar<string>(catalog, sql, accountId);
        }

        public static long GetAccountIdByAccountNumber(string catalog, string accountNumber)
        {
            const string sql = "SELECT account_id FROM core.accounts WHERE account_number=@0;";
            return Factory.Scalar<long>(catalog, sql, accountNumber);
        }

        public static IEnumerable<Account> GetAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.accounts ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetLiabilityAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_master_id >= 15000 AND account_master_id <=15999 ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetIncomeTaxExpenseAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_master_id = 20800 ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetPLAppropriationAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_master_id = 15300 ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetChildAccounts(string catalog)
        {
            const string sql =
                "SELECT * FROM core.accounts WHERE is_transaction_node AND NOT sys_type OR account_master_id IN(10101, 10102) ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetNonConfidentialAccounts(string catalog)
        {
            const string sql = "SELECT * FROM core.accounts WHERE NOT confidential ORDER BY account_id;";
            return Factory.Get<Account>(catalog, sql);
        }

        public static IEnumerable<Account> GetNonConfidentialChildAccounts(string catalog)
        {
            const string sql =
                "SELECT * FROM core.accounts WHERE is_transaction_node AND NOT confidential AND (NOT sys_type OR account_master_id IN(10101, 10102));";
            return Factory.Get<Account>(catalog, sql);
        }

        public static bool IsCashAccount(string catalog, long accountId)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_master_id=10101 AND account_id=@0;";
            return Factory.Get<Account>(catalog, sql, accountId).Count().Equals(1);
        }

        public static bool IsCashAccount(string catalog, string accountNumber)
        {
            const string sql = "SELECT * FROM core.accounts WHERE account_master_id=10101 AND account_number=@0;";
            return Factory.Get<Account>(catalog, sql, accountNumber).Count().Equals(1);
        }
    }
}