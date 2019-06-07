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
    public class AttachmentLookupRepository : IAttachmentLookupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public MixERP.Net.Entities.Core.AttachmentLookup Get(int attachmentLookupId)
        {
            return new MixERP.Net.Entities.Core.AttachmentLookup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> Get(int[] attachmentLookupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public MixERP.Net.Entities.Core.AttachmentLookup GetFirst()
        {
            return new MixERP.Net.Entities.Core.AttachmentLookup();
        }

        public MixERP.Net.Entities.Core.AttachmentLookup GetPrevious(int attachmentLookupId)
        {
            return new MixERP.Net.Entities.Core.AttachmentLookup();
        }

        public MixERP.Net.Entities.Core.AttachmentLookup GetNext(int attachmentLookupId)
        {
            return new MixERP.Net.Entities.Core.AttachmentLookup();
        }

        public MixERP.Net.Entities.Core.AttachmentLookup GetLast()
        {
            return new MixERP.Net.Entities.Core.AttachmentLookup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AttachmentLookup(), 1);
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

        public object AddOrEdit(dynamic attachmentLookup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic attachmentLookup, int attachmentLookupId)
        {
            if (attachmentLookupId > 0)
            {
                return;
            }

            throw new ArgumentException("attachmentLookupId is null.");
        }

        public object Add(dynamic attachmentLookup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> attachmentLookups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int attachmentLookupId)
        {
            if (attachmentLookupId > 0)
            {
                return;
            }

            throw new ArgumentException("attachmentLookupId is null.");
        }


    }
}