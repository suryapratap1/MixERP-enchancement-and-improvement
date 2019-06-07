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
    public class MerchantFeeSetupRepository : IMerchantFeeSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public MixERP.Net.Entities.Core.MerchantFeeSetup Get(int merchantFeeSetupId)
        {
            return new MixERP.Net.Entities.Core.MerchantFeeSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> Get(int[] merchantFeeSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public MixERP.Net.Entities.Core.MerchantFeeSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.MerchantFeeSetup();
        }

        public MixERP.Net.Entities.Core.MerchantFeeSetup GetPrevious(int merchantFeeSetupId)
        {
            return new MixERP.Net.Entities.Core.MerchantFeeSetup();
        }

        public MixERP.Net.Entities.Core.MerchantFeeSetup GetNext(int merchantFeeSetupId)
        {
            return new MixERP.Net.Entities.Core.MerchantFeeSetup();
        }

        public MixERP.Net.Entities.Core.MerchantFeeSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.MerchantFeeSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MerchantFeeSetup(), 1);
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

        public object AddOrEdit(dynamic merchantFeeSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic merchantFeeSetup, int merchantFeeSetupId)
        {
            if (merchantFeeSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("merchantFeeSetupId is null.");
        }

        public object Add(dynamic merchantFeeSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> merchantFeeSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int merchantFeeSetupId)
        {
            if (merchantFeeSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("merchantFeeSetupId is null.");
        }


    }
}