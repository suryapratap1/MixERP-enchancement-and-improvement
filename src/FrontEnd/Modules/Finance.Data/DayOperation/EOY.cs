using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.DayOperation
{
    public static class EOY
    {
        public static IEnumerable<DbGetPlAppropriationDataResult> GetPlAppropriationData(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM transactions.get_pl_appropriation_data(@0::integer);";
            return Factory.Get<DbGetPlAppropriationDataResult>(catalog, sql, officeId);
        }

        public static DbGetEoyProfitSummaryResult GetEoyProfitSummary(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM transactions.get_eoy_profit_summary(@0::integer);";
            return Factory.Get<DbGetEoyProfitSummaryResult>(catalog, sql, officeId).FirstOrDefault();
        }

        public static bool IsNewFiscalYearCreated(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM core.is_new_fiscal_year_created(@0::integer);";
            return Factory.Get<bool>(catalog, sql, officeId).FirstOrDefault();
        }

        public static void CreateNewFiscalYear(string catalog, int officeId, int userId, string fiscalYearCode,
            string fiscalYearName)
        {
            const string sql =
                "SELECT * FROM core.create_new_fiscal_year(@0::integer, @1::integer, @2::character varying(12), @3::character varying(50));";
            Factory.NonQuery(catalog, sql, officeId, userId, fiscalYearCode, fiscalYearName);
        }
    }
}