using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using MixERP.Net.Entities.Transactions.Models;
using Npgsql;

namespace MixERP.Net.Core.Modules.Sales.Data
{
    public static class StockMasterDetailHelper
    {
        public static IEnumerable<NpgsqlParameter> AddStockMasterDetailParameter(Collection<StockDetail> details)
        {
            Collection<NpgsqlParameter> collection = new Collection<NpgsqlParameter>();

            if (details != null)
            {
                for (int i = 0; i < details.Count; i++)
                {
                    collection.Add(new NpgsqlParameter("@StoreId" + i, details[i].StoreId));
                    collection.Add(new NpgsqlParameter("@ItemCode" + i, details[i].ItemCode));
                    collection.Add(new NpgsqlParameter("@Quantity" + i, details[i].Quantity));
                    collection.Add(new NpgsqlParameter("@UnitName" + i, details[i].UnitName));
                    collection.Add(new NpgsqlParameter("@Price" + i, details[i].Price));
                    collection.Add(new NpgsqlParameter("@Discount" + i, details[i].Discount));
                    collection.Add(new NpgsqlParameter("@ShippingCharge" + i, details[i].ShippingCharge));
                    collection.Add(new NpgsqlParameter("@TaxForm" + i, details[i].TaxForm));
                    collection.Add(new NpgsqlParameter("@Tax" + i, details[i].Tax));
                }
            }

            return collection;
        }

        public static string CreateStockMasterDetailParameter(Collection<StockDetail> details)
        {
            if (details == null)
            {
                return "NULL::transactions.stock_detail_type";
            }

            Collection<string> detailCollection = new Collection<string>();
            for (int i = 0; i < details.Count; i++)
            {
                detailCollection.Add(string.Format(CultureInfo.InvariantCulture,
                    "ROW(@StoreId{0}, @ItemCode{0}, @Quantity{0}, @UnitName{0},@Price{0}, @Discount{0}, @ShippingCharge{0}, @TaxForm{0}, @Tax{0})::transactions.stock_detail_type",
                    i.ToString(CultureInfo.InvariantCulture)));
            }

            return string.Join(",", detailCollection);
        }
    }
}