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
    public class ExitTypeRepository : IExitTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public MixERP.Net.Entities.HRM.ExitType Get(int exitTypeId)
        {
            return new MixERP.Net.Entities.HRM.ExitType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> Get(int[] exitTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public MixERP.Net.Entities.HRM.ExitType GetFirst()
        {
            return new MixERP.Net.Entities.HRM.ExitType();
        }

        public MixERP.Net.Entities.HRM.ExitType GetPrevious(int exitTypeId)
        {
            return new MixERP.Net.Entities.HRM.ExitType();
        }

        public MixERP.Net.Entities.HRM.ExitType GetNext(int exitTypeId)
        {
            return new MixERP.Net.Entities.HRM.ExitType();
        }

        public MixERP.Net.Entities.HRM.ExitType GetLast()
        {
            return new MixERP.Net.Entities.HRM.ExitType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.ExitType(), 1);
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

        public object AddOrEdit(dynamic exitType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic exitType, int exitTypeId)
        {
            if (exitTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("exitTypeId is null.");
        }

        public object Add(dynamic exitType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> exitTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int exitTypeId)
        {
            if (exitTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("exitTypeId is null.");
        }


    }
}