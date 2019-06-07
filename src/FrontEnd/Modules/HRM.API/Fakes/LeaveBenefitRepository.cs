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
    public class LeaveBenefitRepository : ILeaveBenefitRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveBenefit Get(int leaveBenefitId)
        {
            return new MixERP.Net.Entities.HRM.LeaveBenefit();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> Get(int[] leaveBenefitIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveBenefit GetFirst()
        {
            return new MixERP.Net.Entities.HRM.LeaveBenefit();
        }

        public MixERP.Net.Entities.HRM.LeaveBenefit GetPrevious(int leaveBenefitId)
        {
            return new MixERP.Net.Entities.HRM.LeaveBenefit();
        }

        public MixERP.Net.Entities.HRM.LeaveBenefit GetNext(int leaveBenefitId)
        {
            return new MixERP.Net.Entities.HRM.LeaveBenefit();
        }

        public MixERP.Net.Entities.HRM.LeaveBenefit GetLast()
        {
            return new MixERP.Net.Entities.HRM.LeaveBenefit();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveBenefit> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveBenefit(), 1);
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

        public object AddOrEdit(dynamic leaveBenefit, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic leaveBenefit, int leaveBenefitId)
        {
            if (leaveBenefitId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveBenefitId is null.");
        }

        public object Add(dynamic leaveBenefit)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> leaveBenefits)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int leaveBenefitId)
        {
            if (leaveBenefitId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveBenefitId is null.");
        }


    }
}