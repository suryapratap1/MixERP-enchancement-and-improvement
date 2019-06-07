// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IStockMasterRepository
    {
        /// <summary>
        /// Counts the number of StockMaster in IStockMasterRepository.
        /// </summary>
        /// <returns>Returns the count of IStockMasterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StockMaster. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetAll();

        /// <summary>
        /// Returns all instances of StockMaster to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockMaster.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StockMaster against stockMasterId. 
        /// </summary>
        /// <param name="stockMasterId">The column "stock_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StockMaster.</returns>
        MixERP.Net.Entities.Transactions.StockMaster Get(long stockMasterId);

        /// <summary>
        /// Returns multiple instances of the StockMaster against stockMasterIds. 
        /// </summary>
        /// <param name="stockMasterIds">Array of column "stock_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StockMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> Get(long[] stockMasterIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStockMasterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StockMaster.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StockMaster.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StockMaster.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StockMaster class to IStockMasterRepository.
        /// </summary>
        /// <param name="stockMaster">The instance of StockMaster class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stockMaster, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StockMaster class to IStockMasterRepository.
        /// </summary>
        /// <param name="stockMaster">The instance of StockMaster class to insert.</param>
        object Add(dynamic stockMaster);

        /// <summary>
        /// Inserts or updates multiple instances of StockMaster class to IStockMasterRepository.;
        /// </summary>
        /// <param name="stockMasters">List of StockMaster class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stockMasters);


        /// <summary>
        /// Updates IStockMasterRepository with an instance of StockMaster class against the primary key value.
        /// </summary>
        /// <param name="stockMaster">The instance of StockMaster class to update.</param>
        /// <param name="stockMasterId">The value of the column "stock_master_id" which will be updated.</param>
        void Update(dynamic stockMaster, long stockMasterId);

        /// <summary>
        /// Deletes StockMaster from  IStockMasterRepository against the primary key value.
        /// </summary>
        /// <param name="stockMasterId">The value of the column "stock_master_id" which will be deleted.</param>
        void Delete(long stockMasterId);

        /// <summary>
        /// Produces a paginated result of 10 StockMaster classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StockMaster classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStockMasterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StockMaster class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStockMasterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStockMasterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StockMaster class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStockMasterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StockMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetFiltered(long pageNumber, string filterName);



    }
}