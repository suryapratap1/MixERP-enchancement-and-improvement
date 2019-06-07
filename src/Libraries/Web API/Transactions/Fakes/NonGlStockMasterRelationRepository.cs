// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class NonGlStockMasterRelationRepository : INonGlStockMasterRelationRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public MixERP.Net.Entities.Transactions.NonGlStockMasterRelation Get(long nonGlStockMasterRelationId)
        {
            return new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> Get([FromUri] long[] nonGlStockMasterRelationIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockMasterRelation(), 1);
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

        public object AddOrEdit(dynamic nonGlStockMasterRelation, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic nonGlStockMasterRelation, long nonGlStockMasterRelationId)
        {
            if (nonGlStockMasterRelationId > 0)
            {
                return;
            }

            throw new ArgumentException("nonGlStockMasterRelationId is null.");
        }

        public object Add(dynamic nonGlStockMasterRelation)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> nonGlStockMasterRelations)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long nonGlStockMasterRelationId)
        {
            if (nonGlStockMasterRelationId > 0)
            {
                return;
            }

            throw new ArgumentException("nonGlStockMasterRelationId is null.");
        }


    }
}