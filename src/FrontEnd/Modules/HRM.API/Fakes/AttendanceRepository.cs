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
    public class AttendanceRepository : IAttendanceRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public MixERP.Net.Entities.HRM.Attendance Get(long attendanceId)
        {
            return new MixERP.Net.Entities.HRM.Attendance();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> Get(long[] attendanceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public MixERP.Net.Entities.HRM.Attendance GetFirst()
        {
            return new MixERP.Net.Entities.HRM.Attendance();
        }

        public MixERP.Net.Entities.HRM.Attendance GetPrevious(long attendanceId)
        {
            return new MixERP.Net.Entities.HRM.Attendance();
        }

        public MixERP.Net.Entities.HRM.Attendance GetNext(long attendanceId)
        {
            return new MixERP.Net.Entities.HRM.Attendance();
        }

        public MixERP.Net.Entities.HRM.Attendance GetLast()
        {
            return new MixERP.Net.Entities.HRM.Attendance();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Attendance(), 1);
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

        public object AddOrEdit(dynamic attendance, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic attendance, long attendanceId)
        {
            if (attendanceId > 0)
            {
                return;
            }

            throw new ArgumentException("attendanceId is null.");
        }

        public object Add(dynamic attendance)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> attendances)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long attendanceId)
        {
            if (attendanceId > 0)
            {
                return;
            }

            throw new ArgumentException("attendanceId is null.");
        }


    }
}