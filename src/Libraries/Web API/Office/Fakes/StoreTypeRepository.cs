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
    public class StoreTypeRepository : IStoreTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public MixERP.Net.Entities.Office.StoreType Get(int storeTypeId)
        {
            return new MixERP.Net.Entities.Office.StoreType();
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> Get(int[] storeTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public MixERP.Net.Entities.Office.StoreType GetFirst()
        {
            return new MixERP.Net.Entities.Office.StoreType();
        }

        public MixERP.Net.Entities.Office.StoreType GetPrevious(int storeTypeId)
        {
            return new MixERP.Net.Entities.Office.StoreType();
        }

        public MixERP.Net.Entities.Office.StoreType GetNext(int storeTypeId)
        {
            return new MixERP.Net.Entities.Office.StoreType();
        }

        public MixERP.Net.Entities.Office.StoreType GetLast()
        {
            return new MixERP.Net.Entities.Office.StoreType();
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.StoreType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.StoreType(), 1);
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

        public object AddOrEdit(dynamic storeType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic storeType, int storeTypeId)
        {
            if (storeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("storeTypeId is null.");
        }

        public object Add(dynamic storeType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> storeTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int storeTypeId)
        {
            if (storeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("storeTypeId is null.");
        }


    }
}