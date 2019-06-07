// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class ResignationRepository : IResignationRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public MixERP.Net.Entities.HRM.Resignation Get(int resignationId)
        {
            return new MixERP.Net.Entities.HRM.Resignation();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> Get(int[] resignationIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public MixERP.Net.Entities.HRM.Resignation GetFirst()
        {
            return new MixERP.Net.Entities.HRM.Resignation();
        }

        public MixERP.Net.Entities.HRM.Resignation GetPrevious(int resignationId)
        {
            return new MixERP.Net.Entities.HRM.Resignation();
        }

        public MixERP.Net.Entities.HRM.Resignation GetNext(int resignationId)
        {
            return new MixERP.Net.Entities.HRM.Resignation();
        }

        public MixERP.Net.Entities.HRM.Resignation GetLast()
        {
            return new MixERP.Net.Entities.HRM.Resignation();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Resignation(), 1);
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

        public object AddOrEdit(dynamic resignation, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic resignation, int resignationId)
        {
            if (resignationId > 0)
            {
                return;
            }

            throw new ArgumentException("resignationId is null.");
        }

        public object Add(dynamic resignation)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> resignations)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int resignationId)
        {
            if (resignationId > 0)
            {
                return;
            }

            throw new ArgumentException("resignationId is null.");
        }
        public void Verify(int resignationId, short verificationStatusId, string reason)
        {
            if (resignationId > 0)
            {
                return;
            }

            throw new ArgumentException("resignationId is null.");
        }

    }
}