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
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveType Get(int leaveTypeId)
        {
            return new MixERP.Net.Entities.HRM.LeaveType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> Get(int[] leaveTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public MixERP.Net.Entities.HRM.LeaveType GetFirst()
        {
            return new MixERP.Net.Entities.HRM.LeaveType();
        }

        public MixERP.Net.Entities.HRM.LeaveType GetPrevious(int leaveTypeId)
        {
            return new MixERP.Net.Entities.HRM.LeaveType();
        }

        public MixERP.Net.Entities.HRM.LeaveType GetNext(int leaveTypeId)
        {
            return new MixERP.Net.Entities.HRM.LeaveType();
        }

        public MixERP.Net.Entities.HRM.LeaveType GetLast()
        {
            return new MixERP.Net.Entities.HRM.LeaveType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveType(), 1);
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

        public object AddOrEdit(dynamic leaveType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic leaveType, int leaveTypeId)
        {
            if (leaveTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveTypeId is null.");
        }

        public object Add(dynamic leaveType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> leaveTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int leaveTypeId)
        {
            if (leaveTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("leaveTypeId is null.");
        }


    }
}