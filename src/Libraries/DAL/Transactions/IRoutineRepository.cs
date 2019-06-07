// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IRoutineRepository
    {
        /// <summary>
        /// Counts the number of Routine in IRoutineRepository.
        /// </summary>
        /// <returns>Returns the count of IRoutineRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Routine. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Routine.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetAll();

        /// <summary>
        /// Returns all instances of Routine to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Routine.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Routine against routineId. 
        /// </summary>
        /// <param name="routineId">The column "routine_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Routine.</returns>
        MixERP.Net.Entities.Transactions.Routine Get(int routineId);

        /// <summary>
        /// Returns multiple instances of the Routine against routineIds. 
        /// </summary>
        /// <param name="routineIds">Array of column "routine_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Routine.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> Get(int[] routineIds);

        /// <summary>
        /// Custom fields are user defined form elements for IRoutineRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Routine.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Routine.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Routine.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Routine class to IRoutineRepository.
        /// </summary>
        /// <param name="routine">The instance of Routine class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic routine, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Routine class to IRoutineRepository.
        /// </summary>
        /// <param name="routine">The instance of Routine class to insert.</param>
        object Add(dynamic routine);

        /// <summary>
        /// Inserts or updates multiple instances of Routine class to IRoutineRepository.;
        /// </summary>
        /// <param name="routines">List of Routine class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> routines);


        /// <summary>
        /// Updates IRoutineRepository with an instance of Routine class against the primary key value.
        /// </summary>
        /// <param name="routine">The instance of Routine class to update.</param>
        /// <param name="routineId">The value of the column "routine_id" which will be updated.</param>
        void Update(dynamic routine, int routineId);

        /// <summary>
        /// Deletes Routine from  IRoutineRepository against the primary key value.
        /// </summary>
        /// <param name="routineId">The value of the column "routine_id" which will be deleted.</param>
        void Delete(int routineId);

        /// <summary>
        /// Produces a paginated result of 10 Routine classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Routine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Routine classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Routine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoutineRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Routine class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRoutineRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Routine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoutineRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Routine class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRoutineRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Routine class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetFiltered(long pageNumber, string filterName);



    }
}