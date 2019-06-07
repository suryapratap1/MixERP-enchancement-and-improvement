// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxRepository
    {
        /// <summary>
        /// Counts the number of SalesTax in ISalesTaxRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTaxRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTax. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetAll();

        /// <summary>
        /// Returns all instances of SalesTax to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTax.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTax against salesTaxId. 
        /// </summary>
        /// <param name="salesTaxId">The column "sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTax.</returns>
        MixERP.Net.Entities.Core.SalesTax Get(int salesTaxId);

        /// <summary>
        /// Gets the first record of SalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTax.</returns>
        MixERP.Net.Entities.Core.SalesTax GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTax sorted by salesTaxId. 
        /// </summary>
        /// <param name="salesTaxId">The column "sales_tax_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTax.</returns>
        MixERP.Net.Entities.Core.SalesTax GetPrevious(int salesTaxId);

        /// <summary>
        /// Gets the next record of SalesTax sorted by salesTaxId. 
        /// </summary>
        /// <param name="salesTaxId">The column "sales_tax_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTax.</returns>
        MixERP.Net.Entities.Core.SalesTax GetNext(int salesTaxId);

        /// <summary>
        /// Gets the last record of SalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTax.</returns>
        MixERP.Net.Entities.Core.SalesTax GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTax against salesTaxIds. 
        /// </summary>
        /// <param name="salesTaxIds">Array of column "sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> Get(int[] salesTaxIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTaxRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTax.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTax.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTax.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTax class to ISalesTaxRepository.
        /// </summary>
        /// <param name="salesTax">The instance of SalesTax class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTax, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTax class to ISalesTaxRepository.
        /// </summary>
        /// <param name="salesTax">The instance of SalesTax class to insert.</param>
        object Add(dynamic salesTax);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTax class to ISalesTaxRepository.;
        /// </summary>
        /// <param name="salesTaxes">List of SalesTax class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTaxes);


        /// <summary>
        /// Updates ISalesTaxRepository with an instance of SalesTax class against the primary key value.
        /// </summary>
        /// <param name="salesTax">The instance of SalesTax class to update.</param>
        /// <param name="salesTaxId">The value of the column "sales_tax_id" which will be updated.</param>
        void Update(dynamic salesTax, int salesTaxId);

        /// <summary>
        /// Deletes SalesTax from  ISalesTaxRepository against the primary key value.
        /// </summary>
        /// <param name="salesTaxId">The value of the column "sales_tax_id" which will be deleted.</param>
        void Delete(int salesTaxId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTax classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTax classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTax class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTaxRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTax class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTaxRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetFiltered(long pageNumber, string filterName);



    }
}