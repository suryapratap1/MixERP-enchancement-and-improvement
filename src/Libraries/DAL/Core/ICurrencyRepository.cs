// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICurrencyRepository
    {
        /// <summary>
        /// Counts the number of Currency in ICurrencyRepository.
        /// </summary>
        /// <returns>Returns the count of ICurrencyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Currency. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Currency.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> GetAll();

        /// <summary>
        /// Returns all instances of Currency to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Currency.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Currency against currencyCode. 
        /// </summary>
        /// <param name="currencyCode">The column "currency_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Currency.</returns>
        MixERP.Net.Entities.Core.Currency Get(string currencyCode);

        /// <summary>
        /// Gets the first record of Currency.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Currency.</returns>
        MixERP.Net.Entities.Core.Currency GetFirst();

        /// <summary>
        /// Gets the previous record of Currency sorted by currencyCode. 
        /// </summary>
        /// <param name="currencyCode">The column "currency_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Currency.</returns>
        MixERP.Net.Entities.Core.Currency GetPrevious(string currencyCode);

        /// <summary>
        /// Gets the next record of Currency sorted by currencyCode. 
        /// </summary>
        /// <param name="currencyCode">The column "currency_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Currency.</returns>
        MixERP.Net.Entities.Core.Currency GetNext(string currencyCode);

        /// <summary>
        /// Gets the last record of Currency.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Currency.</returns>
        MixERP.Net.Entities.Core.Currency GetLast();

        /// <summary>
        /// Returns multiple instances of the Currency against currencyCodes. 
        /// </summary>
        /// <param name="currencyCodes">Array of column "currency_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Currency.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> Get(string[] currencyCodes);

        /// <summary>
        /// Custom fields are user defined form elements for ICurrencyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Currency.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Currency.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Currency.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Currency class to ICurrencyRepository.
        /// </summary>
        /// <param name="currency">The instance of Currency class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic currency, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Currency class to ICurrencyRepository.
        /// </summary>
        /// <param name="currency">The instance of Currency class to insert.</param>
        object Add(dynamic currency);

        /// <summary>
        /// Inserts or updates multiple instances of Currency class to ICurrencyRepository.;
        /// </summary>
        /// <param name="currencies">List of Currency class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> currencies);


        /// <summary>
        /// Updates ICurrencyRepository with an instance of Currency class against the primary key value.
        /// </summary>
        /// <param name="currency">The instance of Currency class to update.</param>
        /// <param name="currencyCode">The value of the column "currency_code" which will be updated.</param>
        void Update(dynamic currency, string currencyCode);

        /// <summary>
        /// Deletes Currency from  ICurrencyRepository against the primary key value.
        /// </summary>
        /// <param name="currencyCode">The value of the column "currency_code" which will be deleted.</param>
        void Delete(string currencyCode);

        /// <summary>
        /// Produces a paginated result of 10 Currency classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Currency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Currency classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Currency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICurrencyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Currency class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICurrencyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Currency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICurrencyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Currency class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICurrencyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Currency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Currency> GetFiltered(long pageNumber, string filterName);



    }
}