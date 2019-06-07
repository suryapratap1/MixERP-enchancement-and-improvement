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
    public class MaritalStatusRepository : IMaritalStatusRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public MixERP.Net.Entities.Core.MaritalStatus Get(int maritalStatusId)
        {
            return new MixERP.Net.Entities.Core.MaritalStatus();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> Get(int[] maritalStatusIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public MixERP.Net.Entities.Core.MaritalStatus GetFirst()
        {
            return new MixERP.Net.Entities.Core.MaritalStatus();
        }

        public MixERP.Net.Entities.Core.MaritalStatus GetPrevious(int maritalStatusId)
        {
            return new MixERP.Net.Entities.Core.MaritalStatus();
        }

        public MixERP.Net.Entities.Core.MaritalStatus GetNext(int maritalStatusId)
        {
            return new MixERP.Net.Entities.Core.MaritalStatus();
        }

        public MixERP.Net.Entities.Core.MaritalStatus GetLast()
        {
            return new MixERP.Net.Entities.Core.MaritalStatus();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MaritalStatus> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MaritalStatus(), 1);
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

        public object AddOrEdit(dynamic maritalStatus, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic maritalStatus, int maritalStatusId)
        {
            if (maritalStatusId > 0)
            {
                return;
            }

            throw new ArgumentException("maritalStatusId is null.");
        }

        public object Add(dynamic maritalStatus)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> maritalStatuses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int maritalStatusId)
        {
            if (maritalStatusId > 0)
            {
                return;
            }

            throw new ArgumentException("maritalStatusId is null.");
        }


    }
}