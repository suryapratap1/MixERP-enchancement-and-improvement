// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IStockTaxDetailRepository
    {
        /// <summary>
        /// Counts the number of StockTaxDetail in IStockTaxDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IStockTaxDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StockTaxDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetAll();

        /// <summary>
        /// Returns all instances of StockTaxDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockTaxDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StockTaxDetail against stockTaxDetailId. 
        /// </summary>
        /// <param name="stockTaxDetailId">The column "stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StockTaxDetail.</returns>
        MixERP.Net.Entities.Transactions.StockTaxDetail Get(long stockTaxDetailId);

        /// <summary>
        /// Returns multiple instances of the StockTaxDetail against stockTaxDetailIds. 
        /// </summary>
        /// <param name="stockTaxDetailIds">Array of column "stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StockTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> Get(long[] stockTaxDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStockTaxDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StockTaxDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StockTaxDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StockTaxDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StockTaxDetail class to IStockTaxDetailRepository.
        /// </summary>
        /// <param name="stockTaxDetail">The instance of StockTaxDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stockTaxDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StockTaxDetail class to IStockTaxDetailRepository.
        /// </summary>
        /// <param name="stockTaxDetail">The instance of StockTaxDetail class to insert.</param>
        object Add(dynamic stockTaxDetail);

        /// <summary>
        /// Inserts or updates multiple instances of StockTaxDetail class to IStockTaxDetailRepository.;
        /// </summary>
        /// <param name="stockTaxDetails">List of StockTaxDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stockTaxDetails);


        /// <summary>
        /// Updates IStockTaxDetailRepository with an instance of StockTaxDetail class against the primary key value.
        /// </summary>
        /// <param name="stockTaxDetail">The instance of StockTaxDetail class to update.</param>
        /// <param name="stockTaxDetailId">The value of the column "stock_tax_detail_id" which will be updated.</param>
        void Update(dynamic stockTaxDetail, long stockTaxDetailId);

        /// <summary>
        /// Deletes StockTaxDetail from  IStockTaxDetailRepository against the primary key value.
        /// </summary>
        /// <param name="stockTaxDetailId">The value of the column "stock_tax_detail_id" which will be deleted.</param>
        void Delete(long stockTaxDetailId);

        /// <summary>
        /// Produces a paginated result of 10 StockTaxDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StockTaxDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStockTaxDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StockTaxDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStockTaxDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStockTaxDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StockTaxDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStockTaxDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetFiltered(long pageNumber, string filterName);



    }
}