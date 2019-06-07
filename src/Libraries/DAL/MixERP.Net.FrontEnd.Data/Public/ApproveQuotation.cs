using System.Linq;
using MixERP.Net.Entities.Public.Meta;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Public
{
    public static class ApproveQuotation
    {
        public static SalesQuotationValidation GetQuotation(string validationId)
        {
            const string sql = "SELECT * FROM public.sales_quotation_validation WHERE validation_id=@0;";
            return Factory.Get<SalesQuotationValidation>(Factory.MetaDatabase, sql, validationId).FirstOrDefault();
        }

        public static void AcceptQuote(string validationId)
        {
            const string sql = @"UPDATE public.sales_quotation_validation
                                SET accepted = true, accepted_on = NOW()
                                WHERE validation_id = @0;";

            Factory.NonQuery(Factory.MetaDatabase, sql, validationId);
        }
    }
}