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
    public class LeaveApplicationRepository : ILeaveApplicationRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveApplication Get(long leaveApplicationId)
        {
            return new MixERP.Net.Entities.HRM.LeaveApplication();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> Get(long[] leaveApplicationIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveApplication GetFirst()
        {
            return new MixERP.Net.Entities.HRM.LeaveApplication();
        }

        public MixERP.Net.Entities.HRM.LeaveApplication GetPrevious(long leaveApplicationId)
        {
            return new MixERP.Net.Entities.HRM.LeaveApplication();
        }

        public MixERP.Net.Entities.HRM.LeaveApplication GetNext(long leaveApplicationId)
        {
            return new MixERP.Net.Entities.HRM.LeaveApplication();
        }

        public MixERP.Net.Entities.HRM.LeaveApplication GetLast()
        {
            return new MixERP.Net.Entities.HRM.LeaveApplication();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplication(), 1);
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

        public object AddOrEdit(dynamic leaveApplication, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic leaveApplication, long leaveApplicationId)
        {
            if (leaveApplicationId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveApplicationId is null.");
        }

        public object Add(dynamic leaveApplication)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> leaveApplications)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long leaveApplicationId)
        {
            if (leaveApplicationId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveApplicationId is null.");
        }
        public void Verify(long leaveApplicationId, short verificationStatusId, string reason)
        {
            if (leaveApplicationId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveApplicationId is null.");
        }

    }
}