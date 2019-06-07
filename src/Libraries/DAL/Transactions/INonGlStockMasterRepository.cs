// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface INonGlStockMasterRepository
    {
        /// <summary>
        /// Counts the number of NonGlStockMaster in INonGlStockMasterRepository.
        /// </summary>
        /// <returns>Returns the count of INonGlStockMasterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of NonGlStockMaster. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> GetAll();

        /// <summary>
        /// Returns all instances of NonGlStockMaster to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockMaster.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the NonGlStockMaster against nonGlStockMasterId. 
        /// </summary>
        /// <param name="nonGlStockMasterId">The column "non_gl_stock_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of NonGlStockMaster.</returns>
        MixERP.Net.Entities.Transactions.NonGlStockMaster Get(long nonGlStockMasterId);

        /// <summary>
        /// Returns multiple instances of the NonGlStockMaster against nonGlStockMasterIds. 
        /// </summary>
        /// <param name="nonGlStockMasterIds">Array of column "non_gl_stock_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of NonGlStockMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> Get(long[] nonGlStockMasterIds);

        /// <summary>
        /// Custom fields are user defined form elements for INonGlStockMasterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for NonGlStockMaster.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding NonGlStockMaster.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for NonGlStockMaster.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of NonGlStockMaster class to INonGlStockMasterRepository.
        /// </summary>
        /// <param name="nonGlStockMaster">The instance of NonGlStockMaster class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic nonGlStockMaster, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of NonGlStockMaster class to INonGlStockMasterRepository.
        /// </summary>
        /// <param name="nonGlStockMaster">The instance of NonGlStockMaster class to insert.</param>
        object Add(dynamic nonGlStockMaster);

        /// <summary>
        /// Inserts or updates multiple instances of NonGlStockMaster class to INonGlStockMasterRepository.;
        /// </summary>
        /// <param name="nonGlStockMasters">List of NonGlStockMaster class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> nonGlStockMasters);


        /// <summary>
        /// Updates INonGlStockMasterRepository with an instance of NonGlStockMaster class against the primary key value.
        /// </summary>
        /// <param name="nonGlStockMaster">The instance of NonGlStockMaster class to update.</param>
        /// <param name="nonGlStockMasterId">The value of the column "non_gl_stock_master_id" which will be updated.</param>
        void Update(dynamic nonGlStockMaster, long nonGlStockMasterId);

        /// <summary>
        /// Deletes NonGlStockMaster from  INonGlStockMasterRepository against the primary key value.
        /// </summary>
        /// <param name="nonGlStockMasterId">The value of the column "non_gl_stock_master_id" which will be deleted.</param>
        void Delete(long nonGlStockMasterId);

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockMaster classes.
        /// </summary>
        /// <returns>Returns the first page of collection of NonGlStockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockMaster classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of NonGlStockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on INonGlStockMasterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of NonGlStockMaster class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against INonGlStockMasterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of NonGlStockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on INonGlStockMasterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of NonGlStockMaster class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of INonGlStockMasterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of NonGlStockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMaster> GetFiltered(long pageNumber, string filterName);



    }
}