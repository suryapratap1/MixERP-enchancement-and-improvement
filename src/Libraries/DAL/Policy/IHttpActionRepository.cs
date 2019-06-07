// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IHttpActionRepository
    {
        /// <summary>
        /// Counts the number of HttpAction in IHttpActionRepository.
        /// </summary>
        /// <returns>Returns the count of IHttpActionRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of HttpAction. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of HttpAction.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetAll();

        /// <summary>
        /// Returns all instances of HttpAction to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of HttpAction.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the HttpAction against httpActionCode. 
        /// </summary>
        /// <param name="httpActionCode">The column "http_action_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of HttpAction.</returns>
        MixERP.Net.Entities.Policy.HttpAction Get(string httpActionCode);

        /// <summary>
        /// Gets the first record of HttpAction.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of HttpAction.</returns>
        MixERP.Net.Entities.Policy.HttpAction GetFirst();

        /// <summary>
        /// Gets the previous record of HttpAction sorted by httpActionCode. 
        /// </summary>
        /// <param name="httpActionCode">The column "http_action_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of HttpAction.</returns>
        MixERP.Net.Entities.Policy.HttpAction GetPrevious(string httpActionCode);

        /// <summary>
        /// Gets the next record of HttpAction sorted by httpActionCode. 
        /// </summary>
        /// <param name="httpActionCode">The column "http_action_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of HttpAction.</returns>
        MixERP.Net.Entities.Policy.HttpAction GetNext(string httpActionCode);

        /// <summary>
        /// Gets the last record of HttpAction.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of HttpAction.</returns>
        MixERP.Net.Entities.Policy.HttpAction GetLast();

        /// <summary>
        /// Returns multiple instances of the HttpAction against httpActionCodes. 
        /// </summary>
        /// <param name="httpActionCodes">Array of column "http_action_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of HttpAction.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> Get(string[] httpActionCodes);

        /// <summary>
        /// Custom fields are user defined form elements for IHttpActionRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for HttpAction.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding HttpAction.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for HttpAction.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of HttpAction class to IHttpActionRepository.
        /// </summary>
        /// <param name="httpAction">The instance of HttpAction class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic httpAction, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of HttpAction class to IHttpActionRepository.
        /// </summary>
        /// <param name="httpAction">The instance of HttpAction class to insert.</param>
        object Add(dynamic httpAction);

        /// <summary>
        /// Inserts or updates multiple instances of HttpAction class to IHttpActionRepository.;
        /// </summary>
        /// <param name="httpActions">List of HttpAction class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> httpActions);


        /// <summary>
        /// Updates IHttpActionRepository with an instance of HttpAction class against the primary key value.
        /// </summary>
        /// <param name="httpAction">The instance of HttpAction class to update.</param>
        /// <param name="httpActionCode">The value of the column "http_action_code" which will be updated.</param>
        void Update(dynamic httpAction, string httpActionCode);

        /// <summary>
        /// Deletes HttpAction from  IHttpActionRepository against the primary key value.
        /// </summary>
        /// <param name="httpActionCode">The value of the column "http_action_code" which will be deleted.</param>
        void Delete(string httpActionCode);

        /// <summary>
        /// Produces a paginated result of 10 HttpAction classes.
        /// </summary>
        /// <returns>Returns the first page of collection of HttpAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 HttpAction classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of HttpAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IHttpActionRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of HttpAction class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IHttpActionRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of HttpAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IHttpActionRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of HttpAction class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IHttpActionRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of HttpAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetFiltered(long pageNumber, string filterName);



    }
}