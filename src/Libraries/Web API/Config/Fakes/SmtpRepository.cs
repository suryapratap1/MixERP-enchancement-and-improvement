// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Config.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Config.Fakes
{
    public class SmtpRepository : ISmtpRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public MixERP.Net.Entities.Config.Smtp Get(int smtpId)
        {
            return new MixERP.Net.Entities.Config.Smtp();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> Get(int[] smtpIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public MixERP.Net.Entities.Config.Smtp GetFirst()
        {
            return new MixERP.Net.Entities.Config.Smtp();
        }

        public MixERP.Net.Entities.Config.Smtp GetPrevious(int smtpId)
        {
            return new MixERP.Net.Entities.Config.Smtp();
        }

        public MixERP.Net.Entities.Config.Smtp GetNext(int smtpId)
        {
            return new MixERP.Net.Entities.Config.Smtp();
        }

        public MixERP.Net.Entities.Config.Smtp GetLast()
        {
            return new MixERP.Net.Entities.Config.Smtp();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Smtp> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Smtp(), 1);
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

        public object AddOrEdit(dynamic smtp, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic smtp, int smtpId)
        {
            if (smtpId > 0)
            {
                return;
            }

            throw new ArgumentException("smtpId is null.");
        }

        public object Add(dynamic smtp)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> smtps)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int smtpId)
        {
            if (smtpId > 0)
            {
                return;
            }

            throw new ArgumentException("smtpId is null.");
        }


    }
}