// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxExemptDetailRepository
    {
        /// <summary>
        /// Counts the number of SalesTaxExemptDetail in ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTaxExemptDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTaxExemptDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxExemptDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetAll();

        /// <summary>
        /// Returns all instances of SalesTaxExemptDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxExemptDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTaxExemptDetail against salesTaxExemptDetailId. 
        /// </summary>
        /// <param name="salesTaxExemptDetailId">The column "sales_tax_exempt_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExemptDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxExemptDetail Get(int salesTaxExemptDetailId);

        /// <summary>
        /// Gets the first record of SalesTaxExemptDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExemptDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxExemptDetail GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTaxExemptDetail sorted by salesTaxExemptDetailId. 
        /// </summary>
        /// <param name="salesTaxExemptDetailId">The column "sales_tax_exempt_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExemptDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxExemptDetail GetPrevious(int salesTaxExemptDetailId);

        /// <summary>
        /// Gets the next record of SalesTaxExemptDetail sorted by salesTaxExemptDetailId. 
        /// </summary>
        /// <param name="salesTaxExemptDetailId">The column "sales_tax_exempt_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExemptDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxExemptDetail GetNext(int salesTaxExemptDetailId);

        /// <summary>
        /// Gets the last record of SalesTaxExemptDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExemptDetail.</returns>
        MixERP.Net.Entities.Core.SalesTaxExemptDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTaxExemptDetail against salesTaxExemptDetailIds. 
        /// </summary>
        /// <param name="salesTaxExemptDetailIds">Array of column "sales_tax_exempt_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTaxExemptDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> Get(int[] salesTaxExemptDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTaxExemptDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTaxExemptDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTaxExemptDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTaxExemptDetail class to ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <param name="salesTaxExemptDetail">The instance of SalesTaxExemptDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTaxExemptDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTaxExemptDetail class to ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <param name="salesTaxExemptDetail">The instance of SalesTaxExemptDetail class to insert.</param>
        object Add(dynamic salesTaxExemptDetail);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTaxExemptDetail class to ISalesTaxExemptDetailRepository.;
        /// </summary>
        /// <param name="salesTaxExemptDetails">List of SalesTaxExemptDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTaxExemptDetails);


        /// <summary>
        /// Updates ISalesTaxExemptDetailRepository with an instance of SalesTaxExemptDetail class against the primary key value.
        /// </summary>
        /// <param name="salesTaxExemptDetail">The instance of SalesTaxExemptDetail class to update.</param>
        /// <param name="salesTaxExemptDetailId">The value of the column "sales_tax_exempt_detail_id" which will be updated.</param>
        void Update(dynamic salesTaxExemptDetail, int salesTaxExemptDetailId);

        /// <summary>
        /// Deletes SalesTaxExemptDetail from  ISalesTaxExemptDetailRepository against the primary key value.
        /// </summary>
        /// <param name="salesTaxExemptDetailId">The value of the column "sales_tax_exempt_detail_id" which will be deleted.</param>
        void Delete(int salesTaxExemptDetailId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxExemptDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTaxExemptDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxExemptDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTaxExemptDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTaxExemptDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTaxExemptDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTaxExemptDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTaxExemptDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTaxExemptDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTaxExemptDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetFiltered(long pageNumber, string filterName);



    }
}