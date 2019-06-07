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
    public class CashRepositoryRepository : ICashRepositoryRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public MixERP.Net.Entities.Office.CashRepository Get(int cashRepositoryId)
        {
            return new MixERP.Net.Entities.Office.CashRepository();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> Get(int[] cashRepositoryIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public MixERP.Net.Entities.Office.CashRepository GetFirst()
        {
            return new MixERP.Net.Entities.Office.CashRepository();
        }

        public MixERP.Net.Entities.Office.CashRepository GetPrevious(int cashRepositoryId)
        {
            return new MixERP.Net.Entities.Office.CashRepository();
        }

        public MixERP.Net.Entities.Office.CashRepository GetNext(int cashRepositoryId)
        {
            return new MixERP.Net.Entities.Office.CashRepository();
        }

        public MixERP.Net.Entities.Office.CashRepository GetLast()
        {
            return new MixERP.Net.Entities.Office.CashRepository();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.CashRepository(), 1);
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

        public object AddOrEdit(dynamic cashRepository, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic cashRepository, int cashRepositoryId)
        {
            if (cashRepositoryId > 0)
            {
                return;
            }

            throw new ArgumentException("cashRepositoryId is null.");
        }

        public object Add(dynamic cashRepository)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cashRepositories)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int cashRepositoryId)
        {
            if (cashRepositoryId > 0)
            {
                return;
            }

            throw new ArgumentException("cashRepositoryId is null.");
        }


    }
}