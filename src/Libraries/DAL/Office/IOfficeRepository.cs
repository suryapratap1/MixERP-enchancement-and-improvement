// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IOfficeRepository
    {
        /// <summary>
        /// Counts the number of Office in IOfficeRepository.
        /// </summary>
        /// <returns>Returns the count of IOfficeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Office. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Office.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> GetAll();

        /// <summary>
        /// Returns all instances of Office to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Office.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Office against officeId. 
        /// </summary>
        /// <param name="officeId">The column "office_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Office.</returns>
        MixERP.Net.Entities.Office.Office Get(int officeId);

        /// <summary>
        /// Gets the first record of Office.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Office.</returns>
        MixERP.Net.Entities.Office.Office GetFirst();

        /// <summary>
        /// Gets the previous record of Office sorted by officeId. 
        /// </summary>
        /// <param name="officeId">The column "office_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Office.</returns>
        MixERP.Net.Entities.Office.Office GetPrevious(int officeId);

        /// <summary>
        /// Gets the next record of Office sorted by officeId. 
        /// </summary>
        /// <param name="officeId">The column "office_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Office.</returns>
        MixERP.Net.Entities.Office.Office GetNext(int officeId);

        /// <summary>
        /// Gets the last record of Office.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Office.</returns>
        MixERP.Net.Entities.Office.Office GetLast();

        /// <summary>
        /// Returns multiple instances of the Office against officeIds. 
        /// </summary>
        /// <param name="officeIds">Array of column "office_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Office.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> Get(int[] officeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IOfficeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Office.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Office.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Office.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Office class to IOfficeRepository.
        /// </summary>
        /// <param name="office">The instance of Office class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic office, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Office class to IOfficeRepository.
        /// </summary>
        /// <param name="office">The instance of Office class to insert.</param>
        object Add(dynamic office);

        /// <summary>
        /// Inserts or updates multiple instances of Office class to IOfficeRepository.;
        /// </summary>
        /// <param name="offices">List of Office class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> offices);


        /// <summary>
        /// Updates IOfficeRepository with an instance of Office class against the primary key value.
        /// </summary>
        /// <param name="office">The instance of Office class to update.</param>
        /// <param name="officeId">The value of the column "office_id" which will be updated.</param>
        void Update(dynamic office, int officeId);

        /// <summary>
        /// Deletes Office from  IOfficeRepository against the primary key value.
        /// </summary>
        /// <param name="officeId">The value of the column "office_id" which will be deleted.</param>
        void Delete(int officeId);

        /// <summary>
        /// Produces a paginated result of 10 Office classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Office class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Office classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Office class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Office class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IOfficeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Office class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Office class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IOfficeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Office class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Office> GetFiltered(long pageNumber, string filterName);



    }
}