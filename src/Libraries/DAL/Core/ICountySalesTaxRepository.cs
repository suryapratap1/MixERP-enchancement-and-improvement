// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICountySalesTaxRepository
    {
        /// <summary>
        /// Counts the number of CountySalesTax in ICountySalesTaxRepository.
        /// </summary>
        /// <returns>Returns the count of ICountySalesTaxRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CountySalesTax. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CountySalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetAll();

        /// <summary>
        /// Returns all instances of CountySalesTax to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CountySalesTax.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CountySalesTax against countySalesTaxId. 
        /// </summary>
        /// <param name="countySalesTaxId">The column "county_sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CountySalesTax.</returns>
        MixERP.Net.Entities.Core.CountySalesTax Get(int countySalesTaxId);

        /// <summary>
        /// Gets the first record of CountySalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CountySalesTax.</returns>
        MixERP.Net.Entities.Core.CountySalesTax GetFirst();

        /// <summary>
        /// Gets the previous record of CountySalesTax sorted by countySalesTaxId. 
        /// </summary>
        /// <param name="countySalesTaxId">The column "county_sales_tax_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CountySalesTax.</returns>
        MixERP.Net.Entities.Core.CountySalesTax GetPrevious(int countySalesTaxId);

        /// <summary>
        /// Gets the next record of CountySalesTax sorted by countySalesTaxId. 
        /// </summary>
        /// <param name="countySalesTaxId">The column "county_sales_tax_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CountySalesTax.</returns>
        MixERP.Net.Entities.Core.CountySalesTax GetNext(int countySalesTaxId);

        /// <summary>
        /// Gets the last record of CountySalesTax.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CountySalesTax.</returns>
        MixERP.Net.Entities.Core.CountySalesTax GetLast();

        /// <summary>
        /// Returns multiple instances of the CountySalesTax against countySalesTaxIds. 
        /// </summary>
        /// <param name="countySalesTaxIds">Array of column "county_sales_tax_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CountySalesTax.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> Get(int[] countySalesTaxIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICountySalesTaxRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CountySalesTax.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CountySalesTax.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CountySalesTax.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CountySalesTax class to ICountySalesTaxRepository.
        /// </summary>
        /// <param name="countySalesTax">The instance of CountySalesTax class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic countySalesTax, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CountySalesTax class to ICountySalesTaxRepository.
        /// </summary>
        /// <param name="countySalesTax">The instance of CountySalesTax class to insert.</param>
        object Add(dynamic countySalesTax);

        /// <summary>
        /// Inserts or updates multiple instances of CountySalesTax class to ICountySalesTaxRepository.;
        /// </summary>
        /// <param name="countySalesTaxes">List of CountySalesTax class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> countySalesTaxes);


        /// <summary>
        /// Updates ICountySalesTaxRepository with an instance of CountySalesTax class against the primary key value.
        /// </summary>
        /// <param name="countySalesTax">The instance of CountySalesTax class to update.</param>
        /// <param name="countySalesTaxId">The value of the column "county_sales_tax_id" which will be updated.</param>
        void Update(dynamic countySalesTax, int countySalesTaxId);

        /// <summary>
        /// Deletes CountySalesTax from  ICountySalesTaxRepository against the primary key value.
        /// </summary>
        /// <param name="countySalesTaxId">The value of the column "county_sales_tax_id" which will be deleted.</param>
        void Delete(int countySalesTaxId);

        /// <summary>
        /// Produces a paginated result of 10 CountySalesTax classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CountySalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CountySalesTax classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CountySalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICountySalesTaxRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CountySalesTax class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICountySalesTaxRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CountySalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICountySalesTaxRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CountySalesTax class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICountySalesTaxRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CountySalesTax class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountySalesTax> GetFiltered(long pageNumber, string filterName);



    }
}