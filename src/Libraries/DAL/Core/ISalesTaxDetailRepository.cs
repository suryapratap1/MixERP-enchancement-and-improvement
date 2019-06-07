// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxDetailRepository
    {
        /// <summary>
        /// Counts the number of SalesTaxDetail in ISalesTaxDetailRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTaxDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTaxDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetAll();

        /// <summary>
        /// Returns all instances of SalesTaxDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTaxDetail against salesTaxDetailId. 
        /// </summary>
        /// <param name="salesTaxDetailId">The column "sales_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxDetail Get(int salesTaxDetailId);

        /// <summary>
        /// Gets the first record of SalesTaxDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxDetail GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTaxDetail sorted by salesTaxDetailId. 
        /// </summary>
        /// <param name="salesTaxDetailId">The column "sales_tax_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxDetail GetPrevious(int salesTaxDetailId);

        /// <summary>
        /// Gets the next record of SalesTaxDetail sorted by salesTaxDetailId. 
        /// </summary>
        /// <param name="salesTaxDetailId">The column "sales_tax_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxDetail GetNext(int salesTaxDetailId);

        /// <summary>
        /// Gets the last record of SalesTaxDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTaxDetail against salesTaxDetailIds. 
        /// </summary>
        /// <param name="salesTaxDetailIds">Array of column "sales_tax_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTaxDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> Get(int[] salesTaxDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTaxDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTaxDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTaxDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTaxDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTaxDetail class to ISalesTaxDetailRepository.
        /// </summary>
        /// <param name="salesTaxDetail">The instance of SalesTaxDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTaxDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTaxDetail class to ISalesTaxDetailRepository.
        /// </summary>
        /// <param name="salesTaxDetail">The instance of SalesTaxDetail class to insert.</param>
        object Add(dynamic salesTaxDetail);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTaxDetail class to ISalesTaxDetailRepository.;
        /// </summary>
        /// <param name="salesTaxDetails">List of SalesTaxDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTaxDetails);


        /// <summary>
        /// Updates ISalesTaxDetailRepository with an instance of SalesTaxDetail class against the primary key value.
        /// </summary>
        /// <param name="salesTaxDetail">The instance of SalesTaxDetail class to update.</param>
        /// <param name="salesTaxDetailId">The value of the column "sales_tax_detail_id" which will be updated.</param>
        void Update(dynamic salesTaxDetail, int salesTaxDetailId);

        /// <summary>
        /// Deletes SalesTaxDetail from  ISalesTaxDetailRepository against the primary key value.
        /// </summary>
        /// <param name="salesTaxDetailId">The value of the column "sales_tax_detail_id" which will be deleted.</param>
        void Delete(int salesTaxDetailId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTaxDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTaxDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTaxDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTaxDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTaxDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetFiltered(long pageNumber, string filterName);



    }
}