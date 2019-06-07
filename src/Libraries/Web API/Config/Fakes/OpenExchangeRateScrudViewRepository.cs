// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Schemas.Config.Data;
using MixERP.Net.EntityParser;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Config.Fakes
{
    public class OpenExchangeRateScrudViewRepository : IOpenExchangeRateScrudViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRateScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRateScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRateScrudView(), 1);
        }



        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRateScrudView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRateScrudView(), 1);
        }

    }
}