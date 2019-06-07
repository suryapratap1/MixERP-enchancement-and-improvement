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
    public class EmployeeIdentificationDetailScrudViewRepository : IEmployeeIdentificationDetailScrudViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }


        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView(), 1);
        }

    }
}