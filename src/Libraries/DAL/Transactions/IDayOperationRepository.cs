// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IDayOperationRepository
    {
        /// <summary>
        /// Counts the number of DayOperation in IDayOperationRepository.
        /// </summary>
        /// <returns>Returns the count of IDayOperationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of DayOperation. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DayOperation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetAll();

        /// <summary>
        /// Returns all instances of DayOperation to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DayOperation.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the DayOperation against dayId. 
        /// </summary>
        /// <param name="dayId">The column "day_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of DayOperation.</returns>
        MixERP.Net.Entities.Transactions.DayOperation Get(long dayId);

        /// <summary>
        /// Returns multiple instances of the DayOperation against dayIds. 
        /// </summary>
        /// <param name="dayIds">Array of column "day_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of DayOperation.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> Get(long[] dayIds);

        /// <summary>
        /// Custom fields are user defined form elements for IDayOperationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for DayOperation.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding DayOperation.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for DayOperation.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of DayOperation class to IDayOperationRepository.
        /// </summary>
        /// <param name="dayOperation">The instance of DayOperation class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic dayOperation, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of DayOperation class to IDayOperationRepository.
        /// </summary>
        /// <param name="dayOperation">The instance of DayOperation class to insert.</param>
        object Add(dynamic dayOperation);

        /// <summary>
        /// Inserts or updates multiple instances of DayOperation class to IDayOperationRepository.;
        /// </summary>
        /// <param name="dayOperations">List of DayOperation class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> dayOperations);


        /// <summary>
        /// Updates IDayOperationRepository with an instance of DayOperation class against the primary key value.
        /// </summary>
        /// <param name="dayOperation">The instance of DayOperation class to update.</param>
        /// <param name="dayId">The value of the column "day_id" which will be updated.</param>
        void Update(dynamic dayOperation, long dayId);

        /// <summary>
        /// Deletes DayOperation from  IDayOperationRepository against the primary key value.
        /// </summary>
        /// <param name="dayId">The value of the column "day_id" which will be deleted.</param>
        void Delete(long dayId);

        /// <summary>
        /// Produces a paginated result of 10 DayOperation classes.
        /// </summary>
        /// <returns>Returns the first page of collection of DayOperation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 DayOperation classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of DayOperation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDayOperationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of DayOperation class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IDayOperationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of DayOperation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDayOperationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of DayOperation class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IDayOperationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of DayOperation class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperation> GetFiltered(long pageNumber, string filterName);



    }
}