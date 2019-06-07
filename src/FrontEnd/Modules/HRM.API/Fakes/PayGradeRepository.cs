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
    public class PayGradeRepository : IPayGradeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public MixERP.Net.Entities.HRM.PayGrade Get(int payGradeId)
        {
            return new MixERP.Net.Entities.HRM.PayGrade();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> Get(int[] payGradeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public MixERP.Net.Entities.HRM.PayGrade GetFirst()
        {
            return new MixERP.Net.Entities.HRM.PayGrade();
        }

        public MixERP.Net.Entities.HRM.PayGrade GetPrevious(int payGradeId)
        {
            return new MixERP.Net.Entities.HRM.PayGrade();
        }

        public MixERP.Net.Entities.HRM.PayGrade GetNext(int payGradeId)
        {
            return new MixERP.Net.Entities.HRM.PayGrade();
        }

        public MixERP.Net.Entities.HRM.PayGrade GetLast()
        {
            return new MixERP.Net.Entities.HRM.PayGrade();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.PayGrade> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.PayGrade(), 1);
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

        public object AddOrEdit(dynamic payGrade, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic payGrade, int payGradeId)
        {
            if (payGradeId > 0)
            {
                return;
            }

            throw new ArgumentException("payGradeId is null.");
        }

        public object Add(dynamic payGrade)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> payGrades)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int payGradeId)
        {
            if (payGradeId > 0)
            {
                return;
            }

            throw new ArgumentException("payGradeId is null.");
        }


    }
}