// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IExchangeRateDetailRepository
    {
        /// <summary>
        /// Counts the number of ExchangeRateDetail in IExchangeRateDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IExchangeRateDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ExchangeRateDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExchangeRateDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetAll();

        /// <summary>
        /// Returns all instances of ExchangeRateDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExchangeRateDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ExchangeRateDetail against exchangeRateDetailId. 
        /// </summary>
        /// <param name="exchangeRateDetailId">The column "exchange_rate_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRateDetail.</returns>
        MixERP.Net.Entities.Core.ExchangeRateDetail Get(long exchangeRateDetailId);

        /// <summary>
        /// Gets the first record of ExchangeRateDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRateDetail.</returns>
        MixERP.Net.Entities.Core.ExchangeRateDetail GetFirst();

        /// <summary>
        /// Gets the previous record of ExchangeRateDetail sorted by exchangeRateDetailId. 
        /// </summary>
        /// <param name="exchangeRateDetailId">The column "exchange_rate_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRateDetail.</returns>
        MixERP.Net.Entities.Core.ExchangeRateDetail GetPrevious(long exchangeRateDetailId);

        /// <summary>
        /// Gets the next record of ExchangeRateDetail sorted by exchangeRateDetailId. 
        /// </summary>
        /// <param name="exchangeRateDetailId">The column "exchange_rate_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRateDetail.</returns>
        MixERP.Net.Entities.Core.ExchangeRateDetail GetNext(long exchangeRateDetailId);

        /// <summary>
        /// Gets the last record of ExchangeRateDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExchangeRateDetail.</returns>
        MixERP.Net.Entities.Core.ExchangeRateDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the ExchangeRateDetail against exchangeRateDetailIds. 
        /// </summary>
        /// <param name="exchangeRateDetailIds">Array of column "exchange_rate_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ExchangeRateDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> Get(long[] exchangeRateDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IExchangeRateDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ExchangeRateDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ExchangeRateDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ExchangeRateDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ExchangeRateDetail class to IExchangeRateDetailRepository.
        /// </summary>
        /// <param name="exchangeRateDetail">The instance of ExchangeRateDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic exchangeRateDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ExchangeRateDetail class to IExchangeRateDetailRepository.
        /// </summary>
        /// <param name="exchangeRateDetail">The instance of ExchangeRateDetail class to insert.</param>
        object Add(dynamic exchangeRateDetail);

        /// <summary>
        /// Inserts or updates multiple instances of ExchangeRateDetail class to IExchangeRateDetailRepository.;
        /// </summary>
        /// <param name="exchangeRateDetails">List of ExchangeRateDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> exchangeRateDetails);


        /// <summary>
        /// Updates IExchangeRateDetailRepository with an instance of ExchangeRateDetail class against the primary key value.
        /// </summary>
        /// <param name="exchangeRateDetail">The instance of ExchangeRateDetail class to update.</param>
        /// <param name="exchangeRateDetailId">The value of the column "exchange_rate_detail_id" which will be updated.</param>
        void Update(dynamic exchangeRateDetail, long exchangeRateDetailId);

        /// <summary>
        /// Deletes ExchangeRateDetail from  IExchangeRateDetailRepository against the primary key value.
        /// </summary>
        /// <param name="exchangeRateDetailId">The value of the column "exchange_rate_detail_id" which will be deleted.</param>
        void Delete(long exchangeRateDetailId);

        /// <summary>
        /// Produces a paginated result of 10 ExchangeRateDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ExchangeRateDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ExchangeRateDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ExchangeRateDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExchangeRateDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ExchangeRateDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IExchangeRateDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ExchangeRateDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExchangeRateDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ExchangeRateDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IExchangeRateDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ExchangeRateDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetFiltered(long pageNumber, string filterName);



    }
}