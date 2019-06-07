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
    public class AccountMasterRepository : IAccountMasterRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public MixERP.Net.Entities.Core.AccountMaster Get(short accountMasterId)
        {
            return new MixERP.Net.Entities.Core.AccountMaster();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> Get(short[] accountMasterIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public MixERP.Net.Entities.Core.AccountMaster GetFirst()
        {
            return new MixERP.Net.Entities.Core.AccountMaster();
        }

        public MixERP.Net.Entities.Core.AccountMaster GetPrevious(short accountMasterId)
        {
            return new MixERP.Net.Entities.Core.AccountMaster();
        }

        public MixERP.Net.Entities.Core.AccountMaster GetNext(short accountMasterId)
        {
            return new MixERP.Net.Entities.Core.AccountMaster();
        }

        public MixERP.Net.Entities.Core.AccountMaster GetLast()
        {
            return new MixERP.Net.Entities.Core.AccountMaster();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AccountMaster(), 1);
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

        public object AddOrEdit(dynamic accountMaster, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic accountMaster, short accountMasterId)
        {
            if (accountMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("accountMasterId is null.");
        }

        public object Add(dynamic accountMaster)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> accountMasters)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(short accountMasterId)
        {
            if (accountMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("accountMasterId is null.");
        }


    }
}