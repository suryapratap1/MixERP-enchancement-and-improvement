// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Core.Fakes
{
    public class StateSalesTaxRepository : IStateSalesTaxRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public MixERP.Net.Entities.Core.StateSalesTax Get(int stateSalesTaxId)
        {
            return new MixERP.Net.Entities.Core.StateSalesTax();
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> Get(int[] stateSalesTaxIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public MixERP.Net.Entities.Core.StateSalesTax GetFirst()
        {
            return new MixERP.Net.Entities.Core.StateSalesTax();
        }

        public MixERP.Net.Entities.Core.StateSalesTax GetPrevious(int stateSalesTaxId)
        {
            return new MixERP.Net.Entities.Core.StateSalesTax();
        }

        public MixERP.Net.Entities.Core.StateSalesTax GetNext(int stateSalesTaxId)
        {
            return new MixERP.Net.Entities.Core.StateSalesTax();
        }

        public MixERP.Net.Entities.Core.StateSalesTax GetLast()
        {
            return new MixERP.Net.Entities.Core.StateSalesTax();
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.StateSalesTax(), 1);
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

        public object AddOrEdit(dynamic stateSalesTax, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic stateSalesTax, int stateSalesTaxId)
        {
            if (stateSalesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("stateSalesTaxId is null.");
        }

        public object Add(dynamic stateSalesTax)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> stateSalesTaxes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int stateSalesTaxId)
        {
            if (stateSalesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("stateSalesTaxId is null.");
        }


    }
}