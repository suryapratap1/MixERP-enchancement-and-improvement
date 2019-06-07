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
    public class FailedLoginRepository : IFailedLoginRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public MixERP.Net.Entities.Audit.FailedLogin Get(long failedLoginId)
        {
            return new MixERP.Net.Entities.Audit.FailedLogin();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> Get(long[] failedLoginIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public MixERP.Net.Entities.Audit.FailedLogin GetFirst()
        {
            return new MixERP.Net.Entities.Audit.FailedLogin();
        }

        public MixERP.Net.Entities.Audit.FailedLogin GetPrevious(long failedLoginId)
        {
            return new MixERP.Net.Entities.Audit.FailedLogin();
        }

        public MixERP.Net.Entities.Audit.FailedLogin GetNext(long failedLoginId)
        {
            return new MixERP.Net.Entities.Audit.FailedLogin();
        }

        public MixERP.Net.Entities.Audit.FailedLogin GetLast()
        {
            return new MixERP.Net.Entities.Audit.FailedLogin();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.FailedLogin> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.FailedLogin(), 1);
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

        public object AddOrEdit(dynamic failedLogin, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic failedLogin, long failedLoginId)
        {
            if (failedLoginId > 0)
            {
                return;
            }

            throw new ArgumentException("failedLoginId is null.");
        }

        public object Add(dynamic failedLogin)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> failedLogins)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long failedLoginId)
        {
            if (failedLoginId > 0)
            {
                return;
            }

            throw new ArgumentException("failedLoginId is null.");
        }


    }
}