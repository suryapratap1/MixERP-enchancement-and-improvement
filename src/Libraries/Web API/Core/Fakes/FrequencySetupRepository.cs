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
    public class FrequencySetupRepository : IFrequencySetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public MixERP.Net.Entities.Core.FrequencySetup Get(int frequencySetupId)
        {
            return new MixERP.Net.Entities.Core.FrequencySetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> Get(int[] frequencySetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public MixERP.Net.Entities.Core.FrequencySetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.FrequencySetup();
        }

        public MixERP.Net.Entities.Core.FrequencySetup GetPrevious(int frequencySetupId)
        {
            return new MixERP.Net.Entities.Core.FrequencySetup();
        }

        public MixERP.Net.Entities.Core.FrequencySetup GetNext(int frequencySetupId)
        {
            return new MixERP.Net.Entities.Core.FrequencySetup();
        }

        public MixERP.Net.Entities.Core.FrequencySetup GetLast()
        {
            return new MixERP.Net.Entities.Core.FrequencySetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FrequencySetup(), 1);
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

        public object AddOrEdit(dynamic frequencySetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic frequencySetup, int frequencySetupId)
        {
            if (frequencySetupId > 0)
            {
                return;
            }

            throw new ArgumentException("frequencySetupId is null.");
        }

        public object Add(dynamic frequencySetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> frequencySetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int frequencySetupId)
        {
            if (frequencySetupId > 0)
            {
                return;
            }

            throw new ArgumentException("frequencySetupId is null.");
        }


    }
}