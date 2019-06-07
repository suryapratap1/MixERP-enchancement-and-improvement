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
    public class IncomeTaxSetupRepository : IIncomeTaxSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public MixERP.Net.Entities.Core.IncomeTaxSetup Get(int incomeTaxSetupId)
        {
            return new MixERP.Net.Entities.Core.IncomeTaxSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> Get(int[] incomeTaxSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public MixERP.Net.Entities.Core.IncomeTaxSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.IncomeTaxSetup();
        }

        public MixERP.Net.Entities.Core.IncomeTaxSetup GetPrevious(int incomeTaxSetupId)
        {
            return new MixERP.Net.Entities.Core.IncomeTaxSetup();
        }

        public MixERP.Net.Entities.Core.IncomeTaxSetup GetNext(int incomeTaxSetupId)
        {
            return new MixERP.Net.Entities.Core.IncomeTaxSetup();
        }

        public MixERP.Net.Entities.Core.IncomeTaxSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.IncomeTaxSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IncomeTaxSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IncomeTaxSetup(), 1);
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

        public object AddOrEdit(dynamic incomeTaxSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic incomeTaxSetup, int incomeTaxSetupId)
        {
            if (incomeTaxSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("incomeTaxSetupId is null.");
        }

        public object Add(dynamic incomeTaxSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> incomeTaxSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int incomeTaxSetupId)
        {
            if (incomeTaxSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("incomeTaxSetupId is null.");
        }


    }
}