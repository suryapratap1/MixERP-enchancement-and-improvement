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
    public class CostCenterRepository : ICostCenterRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public MixERP.Net.Entities.Office.CostCenter Get(int costCenterId)
        {
            return new MixERP.Net.Entities.Office.CostCenter();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> Get(int[] costCenterIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public MixERP.Net.Entities.Office.CostCenter GetFirst()
        {
            return new MixERP.Net.Entities.Office.CostCenter();
        }

        public MixERP.Net.Entities.Office.CostCenter GetPrevious(int costCenterId)
        {
            return new MixERP.Net.Entities.Office.CostCenter();
        }

        public MixERP.Net.Entities.Office.CostCenter GetNext(int costCenterId)
        {
            return new MixERP.Net.Entities.Office.CostCenter();
        }

        public MixERP.Net.Entities.Office.CostCenter GetLast()
        {
            return new MixERP.Net.Entities.Office.CostCenter();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CostCenter> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CostCenter(), 1);
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

        public object AddOrEdit(dynamic costCenter, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic costCenter, int costCenterId)
        {
            if (costCenterId > 0)
            {
                return;
            }

            throw new ArgumentException("costCenterId is null.");
        }

        public object Add(dynamic costCenter)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> costCenters)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int costCenterId)
        {
            if (costCenterId > 0)
            {
                return;
            }

            throw new ArgumentException("costCenterId is null.");
        }


    }
}