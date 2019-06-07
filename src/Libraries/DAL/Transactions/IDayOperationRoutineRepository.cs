// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IDayOperationRoutineRepository
    {
        /// <summary>
        /// Counts the number of DayOperationRoutine in IDayOperationRoutineRepository.
        /// </summary>
        /// <returns>Returns the count of IDayOperationRoutineRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of DayOperationRoutine. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DayOperationRoutine.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetAll();

        /// <summary>
        /// Returns all instances of DayOperationRoutine to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DayOperationRoutine.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the DayOperationRoutine against dayOperationRoutineId. 
        /// </summary>
        /// <param name="dayOperationRoutineId">The column "day_operation_routine_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of DayOperationRoutine.</returns>
        MixERP.Net.Entities.Transactions.DayOperationRoutine Get(long dayOperationRoutineId);

        /// <summary>
        /// Returns multiple instances of the DayOperationRoutine against dayOperationRoutineIds. 
        /// </summary>
        /// <param name="dayOperationRoutineIds">Array of column "day_operation_routine_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of DayOperationRoutine.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> Get(long[] dayOperationRoutineIds);

        /// <summary>
        /// Custom fields are user defined form elements for IDayOperationRoutineRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for DayOperationRoutine.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding DayOperationRoutine.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for DayOperationRoutine.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of DayOperationRoutine class to IDayOperationRoutineRepository.
        /// </summary>
        /// <param name="dayOperationRoutine">The instance of DayOperationRoutine class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic dayOperationRoutine, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of DayOperationRoutine class to IDayOperationRoutineRepository.
        /// </summary>
        /// <param name="dayOperationRoutine">The instance of DayOperationRoutine class to insert.</param>
        object Add(dynamic dayOperationRoutine);

        /// <summary>
        /// Inserts or updates multiple instances of DayOperationRoutine class to IDayOperationRoutineRepository.;
        /// </summary>
        /// <param name="dayOperationRoutines">List of DayOperationRoutine class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> dayOperationRoutines);


        /// <summary>
        /// Updates IDayOperationRoutineRepository with an instance of DayOperationRoutine class against the primary key value.
        /// </summary>
        /// <param name="dayOperationRoutine">The instance of DayOperationRoutine class to update.</param>
        /// <param name="dayOperationRoutineId">The value of the column "day_operation_routine_id" which will be updated.</param>
        void Update(dynamic dayOperationRoutine, long dayOperationRoutineId);

        /// <summary>
        /// Deletes DayOperationRoutine from  IDayOperationRoutineRepository against the primary key value.
        /// </summary>
        /// <param name="dayOperationRoutineId">The value of the column "day_operation_routine_id" which will be deleted.</param>
        void Delete(long dayOperationRoutineId);

        /// <summary>
        /// Produces a paginated result of 10 DayOperationRoutine classes.
        /// </summary>
        /// <returns>Returns the first page of collection of DayOperationRoutine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 DayOperationRoutine classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of DayOperationRoutine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDayOperationRoutineRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of DayOperationRoutine class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IDayOperationRoutineRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of DayOperationRoutine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDayOperationRoutineRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of DayOperationRoutine class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IDayOperationRoutineRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of DayOperationRoutine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.DayOperationRoutine> GetFiltered(long pageNumber, string filterName);



    }
}