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
    public class IdentificationTypeRepository : IIdentificationTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public MixERP.Net.Entities.Core.IdentificationType Get(string identificationTypeCode)
        {
            return new MixERP.Net.Entities.Core.IdentificationType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> Get(string[] identificationTypeCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public MixERP.Net.Entities.Core.IdentificationType GetFirst()
        {
            return new MixERP.Net.Entities.Core.IdentificationType();
        }

        public MixERP.Net.Entities.Core.IdentificationType GetPrevious(string identificationTypeCode)
        {
            return new MixERP.Net.Entities.Core.IdentificationType();
        }

        public MixERP.Net.Entities.Core.IdentificationType GetNext(string identificationTypeCode)
        {
            return new MixERP.Net.Entities.Core.IdentificationType();
        }

        public MixERP.Net.Entities.Core.IdentificationType GetLast()
        {
            return new MixERP.Net.Entities.Core.IdentificationType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.IdentificationType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.IdentificationType(), 1);
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

        public object AddOrEdit(dynamic identificationType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic identificationType, string identificationTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(identificationTypeCode))
            {
                return;
            }

            throw new ArgumentException("identificationTypeCode is null.");
        }

        public object Add(dynamic identificationType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> identificationTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string identificationTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(identificationTypeCode))
            {
                return;
            }

            throw new ArgumentException("identificationTypeCode is null.");
        }


    }
}