// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Audit.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Audit.Fakes
{
    public class LoginRepository : ILoginRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public MixERP.Net.Entities.Audit.Login Get(long loginId)
        {
            return new MixERP.Net.Entities.Audit.Login();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> Get(long[] loginIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public MixERP.Net.Entities.Audit.Login GetFirst()
        {
            return new MixERP.Net.Entities.Audit.Login();
        }

        public MixERP.Net.Entities.Audit.Login GetPrevious(long loginId)
        {
            return new MixERP.Net.Entities.Audit.Login();
        }

        public MixERP.Net.Entities.Audit.Login GetNext(long loginId)
        {
            return new MixERP.Net.Entities.Audit.Login();
        }

        public MixERP.Net.Entities.Audit.Login GetLast()
        {
            return new MixERP.Net.Entities.Audit.Login();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.Login> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.Login(), 1);
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

        public object AddOrEdit(dynamic login, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic login, long loginId)
        {
            if (loginId > 0)
            {
                return;
            }

            throw new ArgumentException("loginId is null.");
        }

        public object Add(dynamic login)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> logins)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long loginId)
        {
            if (loginId > 0)
            {
                return;
            }

            throw new ArgumentException("loginId is null.");
        }


    }
}