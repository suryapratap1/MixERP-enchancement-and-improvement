// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IOfficeHourRepository
    {
        /// <summary>
        /// Counts the number of OfficeHour in IOfficeHourRepository.
        /// </summary>
        /// <returns>Returns the count of IOfficeHourRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of OfficeHour. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of OfficeHour.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetAll();

        /// <summary>
        /// Returns all instances of OfficeHour to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of OfficeHour.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the OfficeHour against officeHourId. 
        /// </summary>
        /// <param name="officeHourId">The column "office_hour_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of OfficeHour.</returns>
        MixERP.Net.Entities.HRM.OfficeHour Get(int officeHourId);

        /// <summary>
        /// Gets the first record of OfficeHour.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of OfficeHour.</returns>
        MixERP.Net.Entities.HRM.OfficeHour GetFirst();

        /// <summary>
        /// Gets the previous record of OfficeHour sorted by officeHourId. 
        /// </summary>
        /// <param name="officeHourId">The column "office_hour_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of OfficeHour.</returns>
        MixERP.Net.Entities.HRM.OfficeHour GetPrevious(int officeHourId);

        /// <summary>
        /// Gets the next record of OfficeHour sorted by officeHourId. 
        /// </summary>
        /// <param name="officeHourId">The column "office_hour_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of OfficeHour.</returns>
        MixERP.Net.Entities.HRM.OfficeHour GetNext(int officeHourId);

        /// <summary>
        /// Gets the last record of OfficeHour.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of OfficeHour.</returns>
        MixERP.Net.Entities.HRM.OfficeHour GetLast();

        /// <summary>
        /// Returns multiple instances of the OfficeHour against officeHourIds. 
        /// </summary>
        /// <param name="officeHourIds">Array of column "office_hour_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of OfficeHour.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> Get(int[] officeHourIds);

        /// <summary>
        /// Custom fields are user defined form elements for IOfficeHourRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for OfficeHour.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding OfficeHour.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for OfficeHour.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of OfficeHour class to IOfficeHourRepository.
        /// </summary>
        /// <param name="officeHour">The instance of OfficeHour class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic officeHour, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of OfficeHour class to IOfficeHourRepository.
        /// </summary>
        /// <param name="officeHour">The instance of OfficeHour class to insert.</param>
        object Add(dynamic officeHour);

        /// <summary>
        /// Inserts or updates multiple instances of OfficeHour class to IOfficeHourRepository.;
        /// </summary>
        /// <param name="officeHours">List of OfficeHour class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> officeHours);


        /// <summary>
        /// Updates IOfficeHourRepository with an instance of OfficeHour class against the primary key value.
        /// </summary>
        /// <param name="officeHour">The instance of OfficeHour class to update.</param>
        /// <param name="officeHourId">The value of the column "office_hour_id" which will be updated.</param>
        void Update(dynamic officeHour, int officeHourId);

        /// <summary>
        /// Deletes OfficeHour from  IOfficeHourRepository against the primary key value.
        /// </summary>
        /// <param name="officeHourId">The value of the column "office_hour_id" which will be deleted.</param>
        void Delete(int officeHourId);

        /// <summary>
        /// Produces a paginated result of 10 OfficeHour classes.
        /// </summary>
        /// <returns>Returns the first page of collection of OfficeHour class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 OfficeHour classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of OfficeHour class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeHourRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of OfficeHour class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IOfficeHourRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of OfficeHour class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeHourRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of OfficeHour class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IOfficeHourRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of OfficeHour class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetFiltered(long pageNumber, string filterName);



    }
}