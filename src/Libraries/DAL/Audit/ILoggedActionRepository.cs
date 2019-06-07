// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Audit.Data
{
    public interface ILoggedActionRepository
    {
        /// <summary>
        /// Counts the number of LoggedAction in ILoggedActionRepository.
        /// </summary>
        /// <returns>Returns the count of ILoggedActionRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LoggedAction. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LoggedAction.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetAll();

        /// <summary>
        /// Returns all instances of LoggedAction to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LoggedAction.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LoggedAction against eventId. 
        /// </summary>
        /// <param name="eventId">The column "event_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LoggedAction.</returns>
        MixERP.Net.Entities.Audit.LoggedAction Get(long eventId);

        /// <summary>
        /// Gets the first record of LoggedAction.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LoggedAction.</returns>
        MixERP.Net.Entities.Audit.LoggedAction GetFirst();

        /// <summary>
        /// Gets the previous record of LoggedAction sorted by eventId. 
        /// </summary>
        /// <param name="eventId">The column "event_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LoggedAction.</returns>
        MixERP.Net.Entities.Audit.LoggedAction GetPrevious(long eventId);

        /// <summary>
        /// Gets the next record of LoggedAction sorted by eventId. 
        /// </summary>
        /// <param name="eventId">The column "event_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LoggedAction.</returns>
        MixERP.Net.Entities.Audit.LoggedAction GetNext(long eventId);

        /// <summary>
        /// Gets the last record of LoggedAction.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LoggedAction.</returns>
        MixERP.Net.Entities.Audit.LoggedAction GetLast();

        /// <summary>
        /// Returns multiple instances of the LoggedAction against eventIds. 
        /// </summary>
        /// <param name="eventIds">Array of column "event_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LoggedAction.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> Get(long[] eventIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILoggedActionRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LoggedAction.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LoggedAction.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LoggedAction.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LoggedAction class to ILoggedActionRepository.
        /// </summary>
        /// <param name="loggedAction">The instance of LoggedAction class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic loggedAction, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LoggedAction class to ILoggedActionRepository.
        /// </summary>
        /// <param name="loggedAction">The instance of LoggedAction class to insert.</param>
        object Add(dynamic loggedAction);

        /// <summary>
        /// Inserts or updates multiple instances of LoggedAction class to ILoggedActionRepository.;
        /// </summary>
        /// <param name="loggedActions">List of LoggedAction class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> loggedActions);


        /// <summary>
        /// Updates ILoggedActionRepository with an instance of LoggedAction class against the primary key value.
        /// </summary>
        /// <param name="loggedAction">The instance of LoggedAction class to update.</param>
        /// <param name="eventId">The value of the column "event_id" which will be updated.</param>
        void Update(dynamic loggedAction, long eventId);

        /// <summary>
        /// Deletes LoggedAction from  ILoggedActionRepository against the primary key value.
        /// </summary>
        /// <param name="eventId">The value of the column "event_id" which will be deleted.</param>
        void Delete(long eventId);

        /// <summary>
        /// Produces a paginated result of 10 LoggedAction classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LoggedAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LoggedAction classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LoggedAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILoggedActionRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LoggedAction class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILoggedActionRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LoggedAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILoggedActionRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LoggedAction class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILoggedActionRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LoggedAction class.</returns>
        IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetFiltered(long pageNumber, string filterName);



    }
}