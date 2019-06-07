// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IHolidayRepository
    {
        /// <summary>
        /// Counts the number of Holiday in IHolidayRepository.
        /// </summary>
        /// <returns>Returns the count of IHolidayRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Holiday. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Holiday.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> GetAll();

        /// <summary>
        /// Returns all instances of Holiday to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Holiday.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Holiday against holidayId. 
        /// </summary>
        /// <param name="holidayId">The column "holiday_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Holiday.</returns>
        MixERP.Net.Entities.Office.Holiday Get(int holidayId);

        /// <summary>
        /// Gets the first record of Holiday.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Holiday.</returns>
        MixERP.Net.Entities.Office.Holiday GetFirst();

        /// <summary>
        /// Gets the previous record of Holiday sorted by holidayId. 
        /// </summary>
        /// <param name="holidayId">The column "holiday_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Holiday.</returns>
        MixERP.Net.Entities.Office.Holiday GetPrevious(int holidayId);

        /// <summary>
        /// Gets the next record of Holiday sorted by holidayId. 
        /// </summary>
        /// <param name="holidayId">The column "holiday_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Holiday.</returns>
        MixERP.Net.Entities.Office.Holiday GetNext(int holidayId);

        /// <summary>
        /// Gets the last record of Holiday.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Holiday.</returns>
        MixERP.Net.Entities.Office.Holiday GetLast();

        /// <summary>
        /// Returns multiple instances of the Holiday against holidayIds. 
        /// </summary>
        /// <param name="holidayIds">Array of column "holiday_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Holiday.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> Get(int[] holidayIds);

        /// <summary>
        /// Custom fields are user defined form elements for IHolidayRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Holiday.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Holiday.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Holiday.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Holiday class to IHolidayRepository.
        /// </summary>
        /// <param name="holiday">The instance of Holiday class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic holiday, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Holiday class to IHolidayRepository.
        /// </summary>
        /// <param name="holiday">The instance of Holiday class to insert.</param>
        object Add(dynamic holiday);

        /// <summary>
        /// Inserts or updates multiple instances of Holiday class to IHolidayRepository.;
        /// </summary>
        /// <param name="holidays">List of Holiday class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> holidays);


        /// <summary>
        /// Updates IHolidayRepository with an instance of Holiday class against the primary key value.
        /// </summary>
        /// <param name="holiday">The instance of Holiday class to update.</param>
        /// <param name="holidayId">The value of the column "holiday_id" which will be updated.</param>
        void Update(dynamic holiday, int holidayId);

        /// <summary>
        /// Deletes Holiday from  IHolidayRepository against the primary key value.
        /// </summary>
        /// <param name="holidayId">The value of the column "holiday_id" which will be deleted.</param>
        void Delete(int holidayId);

        /// <summary>
        /// Produces a paginated result of 10 Holiday classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Holiday class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Holiday classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Holiday class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IHolidayRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Holiday class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IHolidayRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Holiday class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IHolidayRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Holiday class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IHolidayRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Holiday class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Holiday> GetFiltered(long pageNumber, string filterName);



    }
}