// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IEmailQueueRepository
    {
        /// <summary>
        /// Counts the number of EmailQueue in IEmailQueueRepository.
        /// </summary>
        /// <returns>Returns the count of IEmailQueueRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmailQueue. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmailQueue.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetAll();

        /// <summary>
        /// Returns all instances of EmailQueue to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmailQueue.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmailQueue against queueId. 
        /// </summary>
        /// <param name="queueId">The column "queue_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmailQueue.</returns>
        MixERP.Net.Entities.Core.EmailQueue Get(long queueId);

        /// <summary>
        /// Gets the first record of EmailQueue.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmailQueue.</returns>
        MixERP.Net.Entities.Core.EmailQueue GetFirst();

        /// <summary>
        /// Gets the previous record of EmailQueue sorted by queueId. 
        /// </summary>
        /// <param name="queueId">The column "queue_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmailQueue.</returns>
        MixERP.Net.Entities.Core.EmailQueue GetPrevious(long queueId);

        /// <summary>
        /// Gets the next record of EmailQueue sorted by queueId. 
        /// </summary>
        /// <param name="queueId">The column "queue_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmailQueue.</returns>
        MixERP.Net.Entities.Core.EmailQueue GetNext(long queueId);

        /// <summary>
        /// Gets the last record of EmailQueue.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmailQueue.</returns>
        MixERP.Net.Entities.Core.EmailQueue GetLast();

        /// <summary>
        /// Returns multiple instances of the EmailQueue against queueIds. 
        /// </summary>
        /// <param name="queueIds">Array of column "queue_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmailQueue.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> Get(long[] queueIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmailQueueRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmailQueue.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmailQueue.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmailQueue.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmailQueue class to IEmailQueueRepository.
        /// </summary>
        /// <param name="emailQueue">The instance of EmailQueue class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic emailQueue, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmailQueue class to IEmailQueueRepository.
        /// </summary>
        /// <param name="emailQueue">The instance of EmailQueue class to insert.</param>
        object Add(dynamic emailQueue);

        /// <summary>
        /// Inserts or updates multiple instances of EmailQueue class to IEmailQueueRepository.;
        /// </summary>
        /// <param name="emailQueues">List of EmailQueue class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> emailQueues);


        /// <summary>
        /// Updates IEmailQueueRepository with an instance of EmailQueue class against the primary key value.
        /// </summary>
        /// <param name="emailQueue">The instance of EmailQueue class to update.</param>
        /// <param name="queueId">The value of the column "queue_id" which will be updated.</param>
        void Update(dynamic emailQueue, long queueId);

        /// <summary>
        /// Deletes EmailQueue from  IEmailQueueRepository against the primary key value.
        /// </summary>
        /// <param name="queueId">The value of the column "queue_id" which will be deleted.</param>
        void Delete(long queueId);

        /// <summary>
        /// Produces a paginated result of 10 EmailQueue classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmailQueue class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmailQueue classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmailQueue class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmailQueueRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmailQueue class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmailQueueRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmailQueue class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmailQueueRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmailQueue class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmailQueueRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmailQueue class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetFiltered(long pageNumber, string filterName);



    }
}