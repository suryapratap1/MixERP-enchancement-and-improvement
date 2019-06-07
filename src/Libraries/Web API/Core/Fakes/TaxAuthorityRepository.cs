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
    public class TaxAuthorityRepository : ITaxAuthorityRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public MixERP.Net.Entities.Core.TaxAuthority Get(int taxAuthorityId)
        {
            return new MixERP.Net.Entities.Core.TaxAuthority();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> Get(int[] taxAuthorityIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public MixERP.Net.Entities.Core.TaxAuthority GetFirst()
        {
            return new MixERP.Net.Entities.Core.TaxAuthority();
        }

        public MixERP.Net.Entities.Core.TaxAuthority GetPrevious(int taxAuthorityId)
        {
            return new MixERP.Net.Entities.Core.TaxAuthority();
        }

        public MixERP.Net.Entities.Core.TaxAuthority GetNext(int taxAuthorityId)
        {
            return new MixERP.Net.Entities.Core.TaxAuthority();
        }

        public MixERP.Net.Entities.Core.TaxAuthority GetLast()
        {
            return new MixERP.Net.Entities.Core.TaxAuthority();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxAuthority> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxAuthority(), 1);
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

        public object AddOrEdit(dynamic taxAuthority, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic taxAuthority, int taxAuthorityId)
        {
            if (taxAuthorityId > 0)
            {
                return;
            }

            throw new ArgumentException("taxAuthorityId is null.");
        }

        public object Add(dynamic taxAuthority)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> taxAuthorities)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int taxAuthorityId)
        {
            if (taxAuthorityId > 0)
            {
                return;
            }

            throw new ArgumentException("taxAuthorityId is null.");
        }


    }
}