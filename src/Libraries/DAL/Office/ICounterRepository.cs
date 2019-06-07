// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICounterRepository
    {
        /// <summary>
        /// Counts the number of Counter in ICounterRepository.
        /// </summary>
        /// <returns>Returns the count of ICounterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Counter. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Counter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> GetAll();

        /// <summary>
        /// Returns all instances of Counter to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Counter.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Counter against counterId. 
        /// </summary>
        /// <param name="counterId">The column "counter_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Counter.</returns>
        MixERP.Net.Entities.Office.Counter Get(int counterId);

        /// <summary>
        /// Gets the first record of Counter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Counter.</returns>
        MixERP.Net.Entities.Office.Counter GetFirst();

        /// <summary>
        /// Gets the previous record of Counter sorted by counterId. 
        /// </summary>
        /// <param name="counterId">The column "counter_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Counter.</returns>
        MixERP.Net.Entities.Office.Counter GetPrevious(int counterId);

        /// <summary>
        /// Gets the next record of Counter sorted by counterId. 
        /// </summary>
        /// <param name="counterId">The column "counter_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Counter.</returns>
        MixERP.Net.Entities.Office.Counter GetNext(int counterId);

        /// <summary>
        /// Gets the last record of Counter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Counter.</returns>
        MixERP.Net.Entities.Office.Counter GetLast();

        /// <summary>
        /// Returns multiple instances of the Counter against counterIds. 
        /// </summary>
        /// <param name="counterIds">Array of column "counter_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Counter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> Get(int[] counterIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICounterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Counter.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Counter.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Counter.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Counter class to ICounterRepository.
        /// </summary>
        /// <param name="counter">The instance of Counter class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic counter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Counter class to ICounterRepository.
        /// </summary>
        /// <param name="counter">The instance of Counter class to insert.</param>
        object Add(dynamic counter);

        /// <summary>
        /// Inserts or updates multiple instances of Counter class to ICounterRepository.;
        /// </summary>
        /// <param name="counters">List of Counter class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> counters);


        /// <summary>
        /// Updates ICounterRepository with an instance of Counter class against the primary key value.
        /// </summary>
        /// <param name="counter">The instance of Counter class to update.</param>
        /// <param name="counterId">The value of the column "counter_id" which will be updated.</param>
        void Update(dynamic counter, int counterId);

        /// <summary>
        /// Deletes Counter from  ICounterRepository against the primary key value.
        /// </summary>
        /// <param name="counterId">The value of the column "counter_id" which will be deleted.</param>
        void Delete(int counterId);

        /// <summary>
        /// Produces a paginated result of 10 Counter classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Counter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Counter classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Counter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICounterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Counter class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICounterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Counter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICounterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Counter class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICounterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Counter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Counter> GetFiltered(long pageNumber, string filterName);



    }
}