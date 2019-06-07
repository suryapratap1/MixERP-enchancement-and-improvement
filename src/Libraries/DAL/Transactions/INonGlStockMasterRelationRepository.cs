// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface INonGlStockMasterRelationRepository
    {
        /// <summary>
        /// Counts the number of NonGlStockMasterRelation in INonGlStockMasterRelationRepository.
        /// </summary>
        /// <returns>Returns the count of INonGlStockMasterRelationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of NonGlStockMasterRelation. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockMasterRelation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetAll();

        /// <summary>
        /// Returns all instances of NonGlStockMasterRelation to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockMasterRelation.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the NonGlStockMasterRelation against nonGlStockMasterRelationId. 
        /// </summary>
        /// <param name="nonGlStockMasterRelationId">The column "non_gl_stock_master_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of NonGlStockMasterRelation.</returns>
        MixERP.Net.Entities.Transactions.NonGlStockMasterRelation Get(long nonGlStockMasterRelationId);

        /// <summary>
        /// Returns multiple instances of the NonGlStockMasterRelation against nonGlStockMasterRelationIds. 
        /// </summary>
        /// <param name="nonGlStockMasterRelationIds">Array of column "non_gl_stock_master_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of NonGlStockMasterRelation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> Get(long[] nonGlStockMasterRelationIds);

        /// <summary>
        /// Custom fields are user defined form elements for INonGlStockMasterRelationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for NonGlStockMasterRelation.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding NonGlStockMasterRelation.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for NonGlStockMasterRelation.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of NonGlStockMasterRelation class to INonGlStockMasterRelationRepository.
        /// </summary>
        /// <param name="nonGlStockMasterRelation">The instance of NonGlStockMasterRelation class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic nonGlStockMasterRelation, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of NonGlStockMasterRelation class to INonGlStockMasterRelationRepository.
        /// </summary>
        /// <param name="nonGlStockMasterRelation">The instance of NonGlStockMasterRelation class to insert.</param>
        object Add(dynamic nonGlStockMasterRelation);

        /// <summary>
        /// Inserts or updates multiple instances of NonGlStockMasterRelation class to INonGlStockMasterRelationRepository.;
        /// </summary>
        /// <param name="nonGlStockMasterRelations">List of NonGlStockMasterRelation class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> nonGlStockMasterRelations);


        /// <summary>
        /// Updates INonGlStockMasterRelationRepository with an instance of NonGlStockMasterRelation class against the primary key value.
        /// </summary>
        /// <param name="nonGlStockMasterRelation">The instance of NonGlStockMasterRelation class to update.</param>
        /// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be updated.</param>
        void Update(dynamic nonGlStockMasterRelation, long nonGlStockMasterRelationId);

        /// <summary>
        /// Deletes NonGlStockMasterRelation from  INonGlStockMasterRelationRepository against the primary key value.
        /// </summary>
        /// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be deleted.</param>
        void Delete(long nonGlStockMasterRelationId);

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockMasterRelation classes.
        /// </summary>
        /// <returns>Returns the first page of collection of NonGlStockMasterRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockMasterRelation classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of NonGlStockMasterRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on INonGlStockMasterRelationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of NonGlStockMasterRelation class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against INonGlStockMasterRelationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of NonGlStockMasterRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on INonGlStockMasterRelationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of NonGlStockMasterRelation class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of INonGlStockMasterRelationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of NonGlStockMasterRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetFiltered(long pageNumber, string filterName);



    }
}