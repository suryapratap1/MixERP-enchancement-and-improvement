using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class PaymentTerms
    {
        public static IEnumerable<PaymentTerm> GetPaymentTerms(string catalog)
        {
            const string sql = "SELECT * FROM core.payment_terms ORDER BY payment_term_id;";
            return Factory.Get<PaymentTerm>(catalog, sql);
        }
    }
}