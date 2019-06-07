using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
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
    public partial class Return : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long tranId = Conversion.TryCastLong(this.Request.QueryString["TranId"]);
            
            if (tranId <= 0)
            {
                this.Response.Redirect("~/Modules/Sales/Return.mix");
            }

            using (StockTransactionForm product = new StockTransactionForm())
            {
                product.Book = TranBook.Sales;
                product.SubBook = SubTranBook.Return;
                product.Text = Titles.SalesReturn;
                product.ShowPriceTypes = true;
                product.ShowStore = true;
                product.ShowSalesType = true;
                product.Catalog = AppUsers.GetCurrentUserDB();
                product.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();


                this.Placeholder1.Controls.Add(product);
            }
        }
    }
}