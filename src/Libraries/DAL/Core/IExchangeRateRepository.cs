// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IExchangeRateRepository
    {
        /// <summary>
        /// Counts the number of ExchangeRate in IExchangeRateRepository.
        /// </summary>
        /// <returns>Returns the count of IExchangeRateRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ExchangeRate. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExchangeRate.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetAll();

        /// <summary>
        /// Returns all instances of ExchangeRate to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExchangeRate.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ExchangeRate against exchangeRateId. 
        /// </summary>
        /// <param name="exchangeRateId">The column "exchange_rate_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRate.</returns>
        MixERP.Net.Entities.Core.ExchangeRate Get(long exchangeRateId);

        /// <summary>
        /// Gets the first record of ExchangeRate.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRate.</returns>
        MixERP.Net.Entities.Core.ExchangeRate GetFirst();

        /// <summary>
        /// Gets the previous record of ExchangeRate sorted by exchangeRateId. 
        /// </summary>
        /// <param name="exchangeRateId">The column "exchange_rate_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRate.</returns>
        MixERP.Net.Entities.Core.ExchangeRate GetPrevious(long exchangeRateId);

        /// <summary>
        /// Gets the next record of ExchangeRate sorted by exchangeRateId. 
        /// </summary>
        /// <param name="exchangeRateId">The column "exchange_rate_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRate.</returns>
        MixERP.Net.Entities.Core.ExchangeRate GetNext(long exchangeRateId);

        /// <summary>
        /// Gets the last record of ExchangeRate.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRate.</returns>
        MixERP.Net.Entities.Core.ExchangeRate GetLast();

        /// <summary>
        /// Returns multiple instances of the ExchangeRate against exchangeRateIds. 
        /// </summary>
        /// <param name="exchangeRateIds">Array of column "exchange_rate_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ExchangeRate.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> Get(long[] exchangeRateIds);

        /// <summary>
        /// Custom fields are user defined form elements for IExchangeRateRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ExchangeRate.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ExchangeRate.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ExchangeRate.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ExchangeRate class to IExchangeRateRepository.
        /// </summary>
        /// <param name="exchangeRate">The instance of ExchangeRate class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic exchangeRate, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ExchangeRate class to IExchangeRateRepository.
        /// </summary>
        /// <param name="exchangeRate">The instance of ExchangeRate class to insert.</param>
        object Add(dynamic exchangeRate);

        /// <summary>
        /// Inserts or updates multiple instances of ExchangeRate class to IExchangeRateRepository.;
        /// </summary>
        /// <param name="exchangeRates">List of ExchangeRate class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> exchangeRates);


        /// <summary>
        /// Updates IExchangeRateRepository with an instance of ExchangeRate class against the primary key value.
        /// </summary>
        /// <param name="exchangeRate">The instance of ExchangeRate class to update.</param>
        /// <param name="exchangeRateId">The value of the column "exchange_rate_id" which will be updated.</param>
        void Update(dynamic exchangeRate, long exchangeRateId);

        /// <summary>
        /// Deletes ExchangeRate from  IExchangeRateRepository against the primary key value.
        /// </summary>
        /// <param name="exchangeRateId">The value of the column "exchange_rate_id" which will be deleted.</param>
        void Delete(long exchangeRateId);

        /// <summary>
        /// Produces a paginated result of 10 ExchangeRate classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ExchangeRate classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExchangeRateRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ExchangeRate class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IExchangeRateRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExchangeRateRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ExchangeRate class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IExchangeRateRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ExchangeRate class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetFiltered(long pageNumber, string filterName);



    }
}