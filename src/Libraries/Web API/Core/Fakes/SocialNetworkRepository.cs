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
    public class SocialNetworkRepository : ISocialNetworkRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public MixERP.Net.Entities.Core.SocialNetwork Get(string socialNetworkName)
        {
            return new MixERP.Net.Entities.Core.SocialNetwork();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> Get(string[] socialNetworkNames)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public MixERP.Net.Entities.Core.SocialNetwork GetFirst()
        {
            return new MixERP.Net.Entities.Core.SocialNetwork();
        }

        public MixERP.Net.Entities.Core.SocialNetwork GetPrevious(string socialNetworkName)
        {
            return new MixERP.Net.Entities.Core.SocialNetwork();
        }

        public MixERP.Net.Entities.Core.SocialNetwork GetNext(string socialNetworkName)
        {
            return new MixERP.Net.Entities.Core.SocialNetwork();
        }

        public MixERP.Net.Entities.Core.SocialNetwork GetLast()
        {
            return new MixERP.Net.Entities.Core.SocialNetwork();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SocialNetwork(), 1);
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

        public object AddOrEdit(dynamic socialNetwork, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic socialNetwork, string socialNetworkName)
        {
            if (!string.IsNullOrWhiteSpace(socialNetworkName))
            {
                return;
            }

            throw new ArgumentException("socialNetworkName is null.");
        }

        public object Add(dynamic socialNetwork)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> socialNetworks)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string socialNetworkName)
        {
            if (!string.IsNullOrWhiteSpace(socialNetworkName))
            {
                return;
            }

            throw new ArgumentException("socialNetworkName is null.");
        }


    }
}