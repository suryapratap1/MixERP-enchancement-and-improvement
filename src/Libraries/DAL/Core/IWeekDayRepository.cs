// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IWeekDayRepository
    {
        /// <summary>
        /// Counts the number of WeekDay in IWeekDayRepository.
        /// </summary>
        /// <returns>Returns the count of IWeekDayRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of WeekDay. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WeekDay.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetAll();

        /// <summary>
        /// Returns all instances of WeekDay to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WeekDay.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the WeekDay against weekDayId. 
        /// </summary>
        /// <param name="weekDayId">The column "week_day_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of WeekDay.</returns>
        MixERP.Net.Entities.Core.WeekDay Get(int weekDayId);

        /// <summary>
        /// Gets the first record of WeekDay.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WeekDay.</returns>
        MixERP.Net.Entities.Core.WeekDay GetFirst();

        /// <summary>
        /// Gets the previous record of WeekDay sorted by weekDayId. 
        /// </summary>
        /// <param name="weekDayId">The column "week_day_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WeekDay.</returns>
        MixERP.Net.Entities.Core.WeekDay GetPrevious(int weekDayId);

        /// <summary>
        /// Gets the next record of WeekDay sorted by weekDayId. 
        /// </summary>
        /// <param name="weekDayId">The column "week_day_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WeekDay.</returns>
        MixERP.Net.Entities.Core.WeekDay GetNext(int weekDayId);

        /// <summary>
        /// Gets the last record of WeekDay.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WeekDay.</returns>
        MixERP.Net.Entities.Core.WeekDay GetLast();

        /// <summary>
        /// Returns multiple instances of the WeekDay against weekDayIds. 
        /// </summary>
        /// <param name="weekDayIds">Array of column "week_day_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of WeekDay.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> Get(int[] weekDayIds);

        /// <summary>
        /// Custom fields are user defined form elements for IWeekDayRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for WeekDay.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding WeekDay.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for WeekDay.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of WeekDay class to IWeekDayRepository.
        /// </summary>
        /// <param name="weekDay">The instance of WeekDay class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic weekDay, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of WeekDay class to IWeekDayRepository.
        /// </summary>
        /// <param name="weekDay">The instance of WeekDay class to insert.</param>
        object Add(dynamic weekDay);

        /// <summary>
        /// Inserts or updates multiple instances of WeekDay class to IWeekDayRepository.;
        /// </summary>
        /// <param name="weekDays">List of WeekDay class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> weekDays);


        /// <summary>
        /// Updates IWeekDayRepository with an instance of WeekDay class against the primary key value.
        /// </summary>
        /// <param name="weekDay">The instance of WeekDay class to update.</param>
        /// <param name="weekDayId">The value of the column "week_day_id" which will be updated.</param>
        void Update(dynamic weekDay, int weekDayId);

        /// <summary>
        /// Deletes WeekDay from  IWeekDayRepository against the primary key value.
        /// </summary>
        /// <param name="weekDayId">The value of the column "week_day_id" which will be deleted.</param>
        void Delete(int weekDayId);

        /// <summary>
        /// Produces a paginated result of 10 WeekDay classes.
        /// </summary>
        /// <returns>Returns the first page of collection of WeekDay class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 WeekDay classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of WeekDay class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IWeekDayRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of WeekDay class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IWeekDayRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of WeekDay class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IWeekDayRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of WeekDay class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IWeekDayRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of WeekDay class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetFiltered(long pageNumber, string filterName);



    }
}