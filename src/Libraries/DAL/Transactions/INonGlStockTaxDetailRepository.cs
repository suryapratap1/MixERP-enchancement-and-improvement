// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface INonGlStockTaxDetailRepository
    {
        /// <summary>
        /// Counts the number of NonGlStockTaxDetail in INonGlStockTaxDetailRepository.
        /// </summary>
        /// <returns>Returns the count of INonGlStockTaxDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of NonGlStockTaxDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetAll();

        /// <summary>
        /// Returns all instances of NonGlStockTaxDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockTaxDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the NonGlStockTaxDetail against nonGlStockTaxDetailId. 
        /// </summary>
        /// <param name="nonGlStockTaxDetailId">The column "non_gl_stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of NonGlStockTaxDetail.</returns>
        MixERP.Net.Entities.Transactions.NonGlStockTaxDetail Get(long nonGlStockTaxDetailId);

        /// <summary>
        /// Returns multiple instances of the NonGlStockTaxDetail against nonGlStockTaxDetailIds. 
        /// </summary>
        /// <param name="nonGlStockTaxDetailIds">Array of column "non_gl_stock_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of NonGlStockTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> Get(long[] nonGlStockTaxDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for INonGlStockTaxDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for NonGlStockTaxDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding NonGlStockTaxDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for NonGlStockTaxDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of NonGlStockTaxDetail class to INonGlStockTaxDetailRepository.
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of NonGlStockTaxDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic nonGlStockTaxDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of NonGlStockTaxDetail class to INonGlStockTaxDetailRepository.
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of NonGlStockTaxDetail class to insert.</param>
        object Add(dynamic nonGlStockTaxDetail);

        /// <summary>
        /// Inserts or updates multiple instances of NonGlStockTaxDetail class to INonGlStockTaxDetailRepository.;
        /// </summary>
        /// <param name="nonGlStockTaxDetails">List of NonGlStockTaxDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> nonGlStockTaxDetails);


        /// <summary>
        /// Updates INonGlStockTaxDetailRepository with an instance of NonGlStockTaxDetail class against the primary key value.
        /// </summary>
        /// <param name="nonGlStockTaxDetail">The instance of NonGlStockTaxDetail class to update.</param>
        /// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be updated.</param>
        void Update(dynamic nonGlStockTaxDetail, long nonGlStockTaxDetailId);

        /// <summary>
        /// Deletes NonGlStockTaxDetail from  INonGlStockTaxDetailRepository against the primary key value.
        /// </summary>
        /// <param name="nonGlStockTaxDetailId">The value of the column "non_gl_stock_tax_detail_id" which will be deleted.</param>
        void Delete(long nonGlStockTaxDetailId);

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockTaxDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of NonGlStockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockTaxDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of NonGlStockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on INonGlStockTaxDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of NonGlStockTaxDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against INonGlStockTaxDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of NonGlStockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on INonGlStockTaxDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of NonGlStockTaxDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of INonGlStockTaxDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of NonGlStockTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetFiltered(long pageNumber, string filterName);



    }
}