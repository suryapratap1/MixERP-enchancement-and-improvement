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
    public class UserRepository : IUserRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public MixERP.Net.Entities.Office.User Get(int userId)
        {
            return new MixERP.Net.Entities.Office.User();
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> Get(int[] userIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public MixERP.Net.Entities.Office.User GetFirst()
        {
            return new MixERP.Net.Entities.Office.User();
        }

        public MixERP.Net.Entities.Office.User GetPrevious(int userId)
        {
            return new MixERP.Net.Entities.Office.User();
        }

        public MixERP.Net.Entities.Office.User GetNext(int userId)
        {
            return new MixERP.Net.Entities.Office.User();
        }

        public MixERP.Net.Entities.Office.User GetLast()
        {
            return new MixERP.Net.Entities.Office.User();
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.User> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.User(), 1);
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

        public object AddOrEdit(dynamic user, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic user, int userId)
        {
            if (userId > 0)
            {
                return;
            }

            throw new ArgumentException("userId is null.");
        }

        public object Add(dynamic user)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> users)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int userId)
        {
            if (userId > 0)
            {
                return;
            }

            throw new ArgumentException("userId is null.");
        }


    }
}