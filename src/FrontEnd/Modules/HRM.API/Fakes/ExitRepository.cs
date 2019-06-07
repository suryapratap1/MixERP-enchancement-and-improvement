// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class ExitRepository : IExitRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public MixERP.Net.Entities.HRM.Exit Get(long exitId)
        {
            return new MixERP.Net.Entities.HRM.Exit();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> Get(long[] exitIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public MixERP.Net.Entities.HRM.Exit GetFirst()
        {
            return new MixERP.Net.Entities.HRM.Exit();
        }

        public MixERP.Net.Entities.HRM.Exit GetPrevious(long exitId)
        {
            return new MixERP.Net.Entities.HRM.Exit();
        }

        public MixERP.Net.Entities.HRM.Exit GetNext(long exitId)
        {
            return new MixERP.Net.Entities.HRM.Exit();
        }

        public MixERP.Net.Entities.HRM.Exit GetLast()
        {
            return new MixERP.Net.Entities.HRM.Exit();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Exit> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Exit(), 1);
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

        public object AddOrEdit(dynamic exit, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic exit, long exitId)
        {
            if (exitId > 0)
            {
                return;
            }

            throw new ArgumentException("exitId is null.");
        }

        public object Add(dynamic exit)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> exits)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long exitId)
        {
            if (exitId > 0)
            {
                return;
            }

            throw new ArgumentException("exitId is null.");
        }
        public void Verify(long exitId, short verificationStatusId, string reason)
        {
            if (exitId > 0)
            {
                return;
            }

            throw new ArgumentException("exitId is null.");
        }

    }
}