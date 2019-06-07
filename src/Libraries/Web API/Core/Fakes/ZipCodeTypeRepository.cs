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
    public class ZipCodeTypeRepository : IZipCodeTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public MixERP.Net.Entities.Core.ZipCodeType Get(int zipCodeTypeId)
        {
            return new MixERP.Net.Entities.Core.ZipCodeType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> Get(int[] zipCodeTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public MixERP.Net.Entities.Core.ZipCodeType GetFirst()
        {
            return new MixERP.Net.Entities.Core.ZipCodeType();
        }

        public MixERP.Net.Entities.Core.ZipCodeType GetPrevious(int zipCodeTypeId)
        {
            return new MixERP.Net.Entities.Core.ZipCodeType();
        }

        public MixERP.Net.Entities.Core.ZipCodeType GetNext(int zipCodeTypeId)
        {
            return new MixERP.Net.Entities.Core.ZipCodeType();
        }

        public MixERP.Net.Entities.Core.ZipCodeType GetLast()
        {
            return new MixERP.Net.Entities.Core.ZipCodeType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ZipCodeType(), 1);
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

        public object AddOrEdit(dynamic zipCodeType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic zipCodeType, int zipCodeTypeId)
        {
            if (zipCodeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("zipCodeTypeId is null.");
        }

        public object Add(dynamic zipCodeType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> zipCodeTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int zipCodeTypeId)
        {
            if (zipCodeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("zipCodeTypeId is null.");
        }


    }
}