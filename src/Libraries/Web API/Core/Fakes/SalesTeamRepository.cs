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
    public class SalesTeamRepository : ISalesTeamRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTeam Get(int salesTeamId)
        {
            return new MixERP.Net.Entities.Core.SalesTeam();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> Get(int[] salesTeamIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTeam GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTeam();
        }

        public MixERP.Net.Entities.Core.SalesTeam GetPrevious(int salesTeamId)
        {
            return new MixERP.Net.Entities.Core.SalesTeam();
        }

        public MixERP.Net.Entities.Core.SalesTeam GetNext(int salesTeamId)
        {
            return new MixERP.Net.Entities.Core.SalesTeam();
        }

        public MixERP.Net.Entities.Core.SalesTeam GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTeam();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTeam> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTeam(), 1);
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

        public object AddOrEdit(dynamic salesTeam, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTeam, int salesTeamId)
        {
            if (salesTeamId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTeamId is null.");
        }

        public object Add(dynamic salesTeam)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTeams)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTeamId)
        {
            if (salesTeamId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTeamId is null.");
        }


    }
}