// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IOpenExchangeRateRepository
    {
        /// <summary>
        /// Counts the number of OpenExchangeRate in IOpenExchangeRateRepository.
        /// </summary>
        /// <returns>Returns the count of IOpenExchangeRateRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of OpenExchangeRate. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of OpenExchangeRate.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetAll();

        /// <summary>
        /// Returns all instances of OpenExchangeRate to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of OpenExchangeRate.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the OpenExchangeRate against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of OpenExchangeRate.</returns>
        MixERP.Net.Entities.Config.OpenExchangeRate Get(string key);

        /// <summary>
        /// Gets the first record of OpenExchangeRate.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of OpenExchangeRate.</returns>
        MixERP.Net.Entities.Config.OpenExchangeRate GetFirst();

        /// <summary>
        /// Gets the previous record of OpenExchangeRate sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of OpenExchangeRate.</returns>
        MixERP.Net.Entities.Config.OpenExchangeRate GetPrevious(string key);

        /// <summary>
        /// Gets the next record of OpenExchangeRate sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of OpenExchangeRate.</returns>
        MixERP.Net.Entities.Config.OpenExchangeRate GetNext(string key);

        /// <summary>
        /// Gets the last record of OpenExchangeRate.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of OpenExchangeRate.</returns>
        MixERP.Net.Entities.Config.OpenExchangeRate GetLast();

        /// <summary>
        /// Returns multiple instances of the OpenExchangeRate against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of OpenExchangeRate.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for IOpenExchangeRateRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for OpenExchangeRate.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding OpenExchangeRate.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for OpenExchangeRate.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of OpenExchangeRate class to IOpenExchangeRateRepository.
        /// </summary>
        /// <param name="openExchangeRate">The instance of OpenExchangeRate class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic openExchangeRate, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of OpenExchangeRate class to IOpenExchangeRateRepository.
        /// </summary>
        /// <param name="openExchangeRate">The instance of OpenExchangeRate class to insert.</param>
        object Add(dynamic openExchangeRate);

        /// <summary>
        /// Inserts or updates multiple instances of OpenExchangeRate class to IOpenExchangeRateRepository.;
        /// </summary>
        /// <param name="openExchangeRates">List of OpenExchangeRate class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> openExchangeRates);


        /// <summary>
        /// Updates IOpenExchangeRateRepository with an instance of OpenExchangeRate class against the primary key value.
        /// </summary>
        /// <param name="openExchangeRate">The instance of OpenExchangeRate class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic openExchangeRate, string key);

        /// <summary>
        /// Deletes OpenExchangeRate from  IOpenExchangeRateRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 OpenExchangeRate classes.
        /// </summary>
        /// <returns>Returns the first page of collection of OpenExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 OpenExchangeRate classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of OpenExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOpenExchangeRateRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of OpenExchangeRate class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IOpenExchangeRateRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of OpenExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOpenExchangeRateRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of OpenExchangeRate class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IOpenExchangeRateRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of OpenExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetFiltered(long pageNumber, string filterName);



    }
}