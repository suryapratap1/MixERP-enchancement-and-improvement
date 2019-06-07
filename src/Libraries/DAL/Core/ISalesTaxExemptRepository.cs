// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxExemptRepository
    {
        /// <summary>
        /// Counts the number of SalesTaxExempt in ISalesTaxExemptRepository.
        /// </summary>
        /// <returns>Returns the count of ISalesTaxExemptRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SalesTaxExempt. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxExempt.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetAll();

        /// <summary>
        /// Returns all instances of SalesTaxExempt to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SalesTaxExempt.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SalesTaxExempt against salesTaxExemptId. 
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExempt.</returns>
        MixERP.Net.Entities.Core.SalesTaxExempt Get(int salesTaxExemptId);

        /// <summary>
        /// Gets the first record of SalesTaxExempt.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExempt.</returns>
        MixERP.Net.Entities.Core.SalesTaxExempt GetFirst();

        /// <summary>
        /// Gets the previous record of SalesTaxExempt sorted by salesTaxExemptId. 
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExempt.</returns>
        MixERP.Net.Entities.Core.SalesTaxExempt GetPrevious(int salesTaxExemptId);

        /// <summary>
        /// Gets the next record of SalesTaxExempt sorted by salesTaxExemptId. 
        /// </summary>
        /// <param name="salesTaxExemptId">The column "sales_tax_exempt_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExempt.</returns>
        MixERP.Net.Entities.Core.SalesTaxExempt GetNext(int salesTaxExemptId);

        /// <summary>
        /// Gets the last record of SalesTaxExempt.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SalesTaxExempt.</returns>
        MixERP.Net.Entities.Core.SalesTaxExempt GetLast();

        /// <summary>
        /// Returns multiple instances of the SalesTaxExempt against salesTaxExemptIds. 
        /// </summary>
        /// <param name="salesTaxExemptIds">Array of column "sales_tax_exempt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SalesTaxExempt.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> Get(int[] salesTaxExemptIds);

        /// <summary>
        /// Custom fields are user defined form elements for ISalesTaxExemptRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SalesTaxExempt.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SalesTaxExempt.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SalesTaxExempt.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SalesTaxExempt class to ISalesTaxExemptRepository.
        /// </summary>
        /// <param name="salesTaxExempt">The instance of SalesTaxExempt class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic salesTaxExempt, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SalesTaxExempt class to ISalesTaxExemptRepository.
        /// </summary>
        /// <param name="salesTaxExempt">The instance of SalesTaxExempt class to insert.</param>
        object Add(dynamic salesTaxExempt);

        /// <summary>
        /// Inserts or updates multiple instances of SalesTaxExempt class to ISalesTaxExemptRepository.;
        /// </summary>
        /// <param name="salesTaxExempts">List of SalesTaxExempt class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> salesTaxExempts);


        /// <summary>
        /// Updates ISalesTaxExemptRepository with an instance of SalesTaxExempt class against the primary key value.
        /// </summary>
        /// <param name="salesTaxExempt">The instance of SalesTaxExempt class to update.</param>
        /// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be updated.</param>
        void Update(dynamic salesTaxExempt, int salesTaxExemptId);

        /// <summary>
        /// Deletes SalesTaxExempt from  ISalesTaxExemptRepository against the primary key value.
        /// </summary>
        /// <param name="salesTaxExemptId">The value of the column "sales_tax_exempt_id" which will be deleted.</param>
        void Delete(int salesTaxExemptId);

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxExempt classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SalesTaxExempt class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SalesTaxExempt classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SalesTaxExempt class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SalesTaxExempt class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISalesTaxExemptRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SalesTaxExempt class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SalesTaxExempt class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISalesTaxExemptRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SalesTaxExempt class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetFiltered(long pageNumber, string filterName);



    }
}