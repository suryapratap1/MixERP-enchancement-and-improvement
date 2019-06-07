using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.StockTransactionFactory;
using System;
using MixERP.Net.Framework.Contracts;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Entry
{
    public partial class DirectSales : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (StockTransactionForm product = new StockTransactionForm())
            {
                product.Book = TranBook.Sales;
                product.SubBook = SubTranBook.Direct;
                product.Text = Titles.DirectSales;
                product.ShowPriceTypes = true;
                product.ShowPaymentTerms = true;
                product.ShowShippingInformation = true;
                product.ShowSalesAgents = true;
                product.ShowTransactionType = true;
                product.ShowStore = true;
                product.ShowCostCenter = true;
                product.ShowSalesType = true;
                product.VerifyStock = true;
                product.Catalog = AppUsers.GetCurrentUserDB();
                product.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

                this.Placeholder1.Controls.Add(product);
            }
        }
    }
}