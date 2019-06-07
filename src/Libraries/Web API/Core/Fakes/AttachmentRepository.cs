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
    public class AttachmentRepository : IAttachmentRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public MixERP.Net.Entities.Core.Attachment Get(long attachmentId)
        {
            return new MixERP.Net.Entities.Core.Attachment();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> Get(long[] attachmentIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public MixERP.Net.Entities.Core.Attachment GetFirst()
        {
            return new MixERP.Net.Entities.Core.Attachment();
        }

        public MixERP.Net.Entities.Core.Attachment GetPrevious(long attachmentId)
        {
            return new MixERP.Net.Entities.Core.Attachment();
        }

        public MixERP.Net.Entities.Core.Attachment GetNext(long attachmentId)
        {
            return new MixERP.Net.Entities.Core.Attachment();
        }

        public MixERP.Net.Entities.Core.Attachment GetLast()
        {
            return new MixERP.Net.Entities.Core.Attachment();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attachment> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attachment(), 1);
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

        public object AddOrEdit(dynamic attachment, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic attachment, long attachmentId)
        {
            if (attachmentId > 0)
            {
                return;
            }

            throw new ArgumentException("attachmentId is null.");
        }

        public object Add(dynamic attachment)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> attachments)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long attachmentId)
        {
            if (attachmentId > 0)
            {
                return;
            }

            throw new ArgumentException("attachmentId is null.");
        }


    }
}