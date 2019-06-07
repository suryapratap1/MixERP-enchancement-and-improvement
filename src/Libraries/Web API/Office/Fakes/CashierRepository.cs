// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Office.Fakes
{
    public class CashierRepository : ICashierRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public MixERP.Net.Entities.Office.Cashier Get(long cashierId)
        {
            return new MixERP.Net.Entities.Office.Cashier();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> Get(long[] cashierIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public MixERP.Net.Entities.Office.Cashier GetFirst()
        {
            return new MixERP.Net.Entities.Office.Cashier();
        }

        public MixERP.Net.Entities.Office.Cashier GetPrevious(long cashierId)
        {
            return new MixERP.Net.Entities.Office.Cashier();
        }

        public MixERP.Net.Entities.Office.Cashier GetNext(long cashierId)
        {
            return new MixERP.Net.Entities.Office.Cashier();
        }

        public MixERP.Net.Entities.Office.Cashier GetLast()
        {
            return new MixERP.Net.Entities.Office.Cashier();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Cashier> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Cashier(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic cashier, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic cashier, long cashierId)
        {
            if (cashierId > 0)
            {
                return;
            }

            throw new ArgumentException("cashierId is null.");
        }

        public object Add(dynamic cashier)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cashiers)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long cashierId)
        {
            if (cashierId > 0)
            {
                return;
            }

            throw new ArgumentException("cashierId is null.");
        }


    }
}