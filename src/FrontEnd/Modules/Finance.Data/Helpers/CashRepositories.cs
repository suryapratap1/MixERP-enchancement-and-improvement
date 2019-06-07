using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Helpers
{
    public static class CashRepositories
    {
        public static bool CashRepositoryCodeExists(string catalog, string cashRepositoryCode)
        {
            const string sql = "SELECT * FROM office.cash_repositories WHERE cash_repository_code=@0;";
            return Factory.Get<CashRepository>(catalog, sql, cashRepositoryCode).Count().Equals(1);
        }

        public static decimal GetBalance(string catalog, int? cashRepositoryId, string currencyCode)
        {
            const string sql =
                "SELECT transactions.get_cash_repository_balance(@0::integer, @1::national character varying(12));";
            return Factory.Scalar<decimal>(catalog, sql, cashRepositoryId, currencyCode);
        }

        public static decimal GetBalance(string catalog, int cashRepositoryId)
        {
            const string sql = "SELECT transactions.get_cash_repository_balance(@0::integer);";
            return Factory.Scalar<decimal>(catalog, sql, cashRepositoryId);
        }

        private static decimal GetBalance(string catalog, string cashRepositoryCode)
        {
            const string sql =
                "SELECT transactions.get_cash_repository_balance(office.get_cash_repository_id_by_cash_repository_code(@0)::integer);";

            return Factory.Scalar<decimal>(catalog, sql, cashRepositoryCode);
        }

        public static decimal GetBalance(string catalog, string cashRepositoryCode, string currencyCode)
        {
            const string sql =
                "SELECT transactions.get_cash_repository_balance(office.get_cash_repository_id_by_cash_repository_code(@0)::integer, @1::national character varying(12));";
            return Factory.Scalar<decimal>(catalog, sql, cashRepositoryCode, currencyCode);
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

        public static CashRepository GetCashRepository(string catalog, int? cashRepositoryId)
        {
            const string sql = "SELECT * FROM office.cash_repositories WHERE cash_repository_id=@0;";
            return Factory.Get<CashRepository>(catalog, sql, cashRepositoryId).FirstOrDefault();
        }

        public static int GetCashRepositoryIdByCashRepositoryCode(string catalog, string cashRepositoryCode)
        {
            const string sql = "SELECT cash_repository_id FROM office.cash_repositories WHERE cash_repository_code=@0;";
            return Factory.Scalar<int>(catalog, sql, cashRepositoryCode);
        }
    }
}