// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IStateSalesTaxRepository
    {
        /// <summary>
        /// Counts the number of StateSalesTax in IStateSalesTaxRepository.
        /// </summary>
        /// <returns>Returns the count of IStateSalesTaxRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StateSalesTax. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StateSalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetAll();

        /// <summary>
        /// Returns all instances of StateSalesTax to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StateSalesTax.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StateSalesTax against stateSalesTaxId. 
        /// </summary>
        /// <param name="stateSalesTaxId">The column "state_sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StateSalesTax.</returns>
        MixERP.Net.Entities.Core.StateSalesTax Get(int stateSalesTaxId);

        /// <summary>
        /// Gets the first record of StateSalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StateSalesTax.</returns>
        MixERP.Net.Entities.Core.StateSalesTax GetFirst();

        /// <summary>
        /// Gets the previous record of StateSalesTax sorted by stateSalesTaxId. 
        /// </summary>
        /// <param name="stateSalesTaxId">The column "state_sales_tax_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StateSalesTax.</returns>
        MixERP.Net.Entities.Core.StateSalesTax GetPrevious(int stateSalesTaxId);

        /// <summary>
        /// Gets the next record of StateSalesTax sorted by stateSalesTaxId. 
        /// </summary>
        /// <param name="stateSalesTaxId">The column "state_sales_tax_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StateSalesTax.</returns>
        MixERP.Net.Entities.Core.StateSalesTax GetNext(int stateSalesTaxId);

        /// <summary>
        /// Gets the last record of StateSalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StateSalesTax.</returns>
        MixERP.Net.Entities.Core.StateSalesTax GetLast();

        /// <summary>
        /// Returns multiple instances of the StateSalesTax against stateSalesTaxIds. 
        /// </summary>
        /// <param name="stateSalesTaxIds">Array of column "state_sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StateSalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> Get(int[] stateSalesTaxIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStateSalesTaxRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StateSalesTax.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StateSalesTax.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StateSalesTax.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StateSalesTax class to IStateSalesTaxRepository.
        /// </summary>
        /// <param name="stateSalesTax">The instance of StateSalesTax class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stateSalesTax, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StateSalesTax class to IStateSalesTaxRepository.
        /// </summary>
        /// <param name="stateSalesTax">The instance of StateSalesTax class to insert.</param>
        object Add(dynamic stateSalesTax);

        /// <summary>
        /// Inserts or updates multiple instances of StateSalesTax class to IStateSalesTaxRepository.;
        /// </summary>
        /// <param name="stateSalesTaxes">List of StateSalesTax class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stateSalesTaxes);


        /// <summary>
        /// Updates IStateSalesTaxRepository with an instance of StateSalesTax class against the primary key value.
        /// </summary>
        /// <param name="stateSalesTax">The instance of StateSalesTax class to update.</param>
        /// <param name="stateSalesTaxId">The value of the column "state_sales_tax_id" which will be updated.</param>
        void Update(dynamic stateSalesTax, int stateSalesTaxId);

        /// <summary>
        /// Deletes StateSalesTax from  IStateSalesTaxRepository against the primary key value.
        /// </summary>
        /// <param name="stateSalesTaxId">The value of the column "state_sales_tax_id" which will be deleted.</param>
        void Delete(int stateSalesTaxId);

        /// <summary>
        /// Produces a paginated result of 10 StateSalesTax classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StateSalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StateSalesTax classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StateSalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStateSalesTaxRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StateSalesTax class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStateSalesTaxRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StateSalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStateSalesTaxRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StateSalesTax class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStateSalesTaxRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StateSalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTax> GetFiltered(long pageNumber, string filterName);



    }
}