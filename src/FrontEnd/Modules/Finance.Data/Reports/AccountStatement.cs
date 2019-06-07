using System;
using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class AccountStatement
    {
        public static AccountView GetAccountOverview(string catalog, string accountNumber)
        {
            const string sql = "SELECT * FROM core.account_view WHERE account_number=@0;";
            return Factory.Get<AccountView>(catalog, sql, accountNumber).FirstOrDefault();
        }

        public static IEnumerable<DbGetAccountStatementResult> GetAccountStatement(string catalog, DateTime from,
            DateTime to, int userId, string accountNumber, int officeId)
        {
            if (to < from)
            {
                return null;
            }

            const string sql =
                "SELECT * FROM transactions.get_account_statement(@0::date, @1::date, @2::integer, core.get_account_id_by_account_number(@3)::bigint, @4::integer) ORDER BY id;";
            return Factory.Get<DbGetAccountStatementResult>(catalog, sql, from, to, userId, accountNumber, officeId);
        }
    }
}