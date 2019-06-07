// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IStockReturnRepository
    {
        /// <summary>
        /// Counts the number of StockReturn in IStockReturnRepository.
        /// </summary>
        /// <returns>Returns the count of IStockReturnRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StockReturn. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockReturn.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> GetAll();

        /// <summary>
        /// Returns all instances of StockReturn to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockReturn.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StockReturn against salesReturnId. 
        /// </summary>
        /// <param name="salesReturnId">The column "sales_return_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StockReturn.</returns>
        MixERP.Net.Entities.Transactions.StockReturn Get(long salesReturnId);

        /// <summary>
        /// Returns multiple instances of the StockReturn against salesReturnIds. 
        /// </summary>
        /// <param name="salesReturnIds">Array of column "sales_return_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StockReturn.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> Get(long[] salesReturnIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStockReturnRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StockReturn.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StockReturn.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StockReturn.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StockReturn class to IStockReturnRepository.
        /// </summary>
        /// <param name="stockReturn">The instance of StockReturn class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stockReturn, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StockReturn class to IStockReturnRepository.
        /// </summary>
        /// <param name="stockReturn">The instance of StockReturn class to insert.</param>
        object Add(dynamic stockReturn);

        /// <summary>
        /// Inserts or updates multiple instances of StockReturn class to IStockReturnRepository.;
        /// </summary>
        /// <param name="stockReturns">List of StockReturn class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stockReturns);


        /// <summary>
        /// Updates IStockReturnRepository with an instance of StockReturn class against the primary key value.
        /// </summary>
        /// <param name="stockReturn">The instance of StockReturn class to update.</param>
        /// <param name="salesReturnId">The value of the column "sales_return_id" which will be updated.</param>
        void Update(dynamic stockReturn, long salesReturnId);

        /// <summary>
        /// Deletes StockReturn from  IStockReturnRepository against the primary key value.
        /// </summary>
        /// <param name="salesReturnId">The value of the column "sales_return_id" which will be deleted.</param>
        void Delete(long salesReturnId);

        /// <summary>
        /// Produces a paginated result of 10 StockReturn classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StockReturn class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StockReturn classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StockReturn class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStockReturnRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StockReturn class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStockReturnRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StockReturn class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStockReturnRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StockReturn class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStockReturnRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StockReturn class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockReturn> GetFiltered(long pageNumber, string filterName);



    }
}