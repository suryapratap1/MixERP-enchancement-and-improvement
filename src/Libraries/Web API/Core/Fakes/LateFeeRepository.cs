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
    public class LateFeeRepository : ILateFeeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public MixERP.Net.Entities.Core.LateFee Get(int lateFeeId)
        {
            return new MixERP.Net.Entities.Core.LateFee();
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> Get(int[] lateFeeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public MixERP.Net.Entities.Core.LateFee GetFirst()
        {
            return new MixERP.Net.Entities.Core.LateFee();
        }

        public MixERP.Net.Entities.Core.LateFee GetPrevious(int lateFeeId)
        {
            return new MixERP.Net.Entities.Core.LateFee();
        }

        public MixERP.Net.Entities.Core.LateFee GetNext(int lateFeeId)
        {
            return new MixERP.Net.Entities.Core.LateFee();
        }

        public MixERP.Net.Entities.Core.LateFee GetLast()
        {
            return new MixERP.Net.Entities.Core.LateFee();
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.LateFee> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.LateFee(), 1);
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

        public object AddOrEdit(dynamic lateFee, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic lateFee, int lateFeeId)
        {
            if (lateFeeId > 0)
            {
                return;
            }

            throw new ArgumentException("lateFeeId is null.");
        }

        public object Add(dynamic lateFee)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> lateFees)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int lateFeeId)
        {
            if (lateFeeId > 0)
            {
                return;
            }

            throw new ArgumentException("lateFeeId is null.");
        }


    }
}