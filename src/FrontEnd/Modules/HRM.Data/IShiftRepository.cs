// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IShiftRepository
    {
        /// <summary>
        /// Counts the number of Shift in IShiftRepository.
        /// </summary>
        /// <returns>Returns the count of IShiftRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Shift. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Shift.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> GetAll();

        /// <summary>
        /// Returns all instances of Shift to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Shift.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Shift against shiftId. 
        /// </summary>
        /// <param name="shiftId">The column "shift_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shift.</returns>
        MixERP.Net.Entities.HRM.Shift Get(int shiftId);

        /// <summary>
        /// Gets the first record of Shift.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Shift.</returns>
        MixERP.Net.Entities.HRM.Shift GetFirst();

        /// <summary>
        /// Gets the previous record of Shift sorted by shiftId. 
        /// </summary>
        /// <param name="shiftId">The column "shift_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shift.</returns>
        MixERP.Net.Entities.HRM.Shift GetPrevious(int shiftId);

        /// <summary>
        /// Gets the next record of Shift sorted by shiftId. 
        /// </summary>
        /// <param name="shiftId">The column "shift_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shift.</returns>
        MixERP.Net.Entities.HRM.Shift GetNext(int shiftId);

        /// <summary>
        /// Gets the last record of Shift.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Shift.</returns>
        MixERP.Net.Entities.HRM.Shift GetLast();

        /// <summary>
        /// Returns multiple instances of the Shift against shiftIds. 
        /// </summary>
        /// <param name="shiftIds">Array of column "shift_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Shift.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> Get(int[] shiftIds);

        /// <summary>
        /// Custom fields are user defined form elements for IShiftRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Shift.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Shift.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Shift.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Shift class to IShiftRepository.
        /// </summary>
        /// <param name="shift">The instance of Shift class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic shift, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Shift class to IShiftRepository.
        /// </summary>
        /// <param name="shift">The instance of Shift class to insert.</param>
        object Add(dynamic shift);

        /// <summary>
        /// Inserts or updates multiple instances of Shift class to IShiftRepository.;
        /// </summary>
        /// <param name="shifts">List of Shift class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> shifts);


        /// <summary>
        /// Updates IShiftRepository with an instance of Shift class against the primary key value.
        /// </summary>
        /// <param name="shift">The instance of Shift class to update.</param>
        /// <param name="shiftId">The value of the column "shift_id" which will be updated.</param>
        void Update(dynamic shift, int shiftId);

        /// <summary>
        /// Deletes Shift from  IShiftRepository against the primary key value.
        /// </summary>
        /// <param name="shiftId">The value of the column "shift_id" which will be deleted.</param>
        void Delete(int shiftId);

        /// <summary>
        /// Produces a paginated result of 10 Shift classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Shift class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Shift classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Shift class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShiftRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Shift class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IShiftRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Shift class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShiftRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Shift class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IShiftRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Shift class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Shift> GetFiltered(long pageNumber, string filterName);



    }
}