// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IStockMasterNonGlRelationRepository
    {
        /// <summary>
        /// Counts the number of StockMasterNonGlRelation in IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <returns>Returns the count of IStockMasterNonGlRelationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StockMasterNonGlRelation. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockMasterNonGlRelation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetAll();

        /// <summary>
        /// Returns all instances of StockMasterNonGlRelation to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockMasterNonGlRelation.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StockMasterNonGlRelation against stockMasterNonGlRelationId. 
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">The column "stock_master_non_gl_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StockMasterNonGlRelation.</returns>
        MixERP.Net.Entities.Transactions.StockMasterNonGlRelation Get(long stockMasterNonGlRelationId);

        /// <summary>
        /// Returns multiple instances of the StockMasterNonGlRelation against stockMasterNonGlRelationIds. 
        /// </summary>
        /// <param name="stockMasterNonGlRelationIds">Array of column "stock_master_non_gl_relation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StockMasterNonGlRelation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> Get(long[] stockMasterNonGlRelationIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StockMasterNonGlRelation.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StockMasterNonGlRelation.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StockMasterNonGlRelation.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StockMasterNonGlRelation class to IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of StockMasterNonGlRelation class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stockMasterNonGlRelation, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StockMasterNonGlRelation class to IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of StockMasterNonGlRelation class to insert.</param>
        object Add(dynamic stockMasterNonGlRelation);

        /// <summary>
        /// Inserts or updates multiple instances of StockMasterNonGlRelation class to IStockMasterNonGlRelationRepository.;
        /// </summary>
        /// <param name="stockMasterNonGlRelations">List of StockMasterNonGlRelation class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stockMasterNonGlRelations);


        /// <summary>
        /// Updates IStockMasterNonGlRelationRepository with an instance of StockMasterNonGlRelation class against the primary key value.
        /// </summary>
        /// <param name="stockMasterNonGlRelation">The instance of StockMasterNonGlRelation class to update.</param>
        /// <param name="stockMasterNonGlRelationId">The value of the column "stock_master_non_gl_relation_id" which will be updated.</param>
        void Update(dynamic stockMasterNonGlRelation, long stockMasterNonGlRelationId);

        /// <summary>
        /// Deletes StockMasterNonGlRelation from  IStockMasterNonGlRelationRepository against the primary key value.
        /// </summary>
        /// <param name="stockMasterNonGlRelationId">The value of the column "stock_master_non_gl_relation_id" which will be deleted.</param>
        void Delete(long stockMasterNonGlRelationId);

        /// <summary>
        /// Produces a paginated result of 10 StockMasterNonGlRelation classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StockMasterNonGlRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StockMasterNonGlRelation classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StockMasterNonGlRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StockMasterNonGlRelation class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStockMasterNonGlRelationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StockMasterNonGlRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStockMasterNonGlRelationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StockMasterNonGlRelation class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStockMasterNonGlRelationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StockMasterNonGlRelation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMasterNonGlRelation> GetFiltered(long pageNumber, string filterName);



    }
}