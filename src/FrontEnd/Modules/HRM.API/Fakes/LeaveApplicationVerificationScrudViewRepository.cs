// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class LeaveApplicationVerificationScrudViewRepository : ILeaveApplicationVerificationScrudViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }


        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView(), 1);
        }

    }
}