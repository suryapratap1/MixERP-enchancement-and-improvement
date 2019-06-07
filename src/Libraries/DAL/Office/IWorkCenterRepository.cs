// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IWorkCenterRepository
    {
        /// <summary>
        /// Counts the number of WorkCenter in IWorkCenterRepository.
        /// </summary>
        /// <returns>Returns the count of IWorkCenterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of WorkCenter. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WorkCenter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetAll();

        /// <summary>
        /// Returns all instances of WorkCenter to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WorkCenter.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the WorkCenter against workCenterId. 
        /// </summary>
        /// <param name="workCenterId">The column "work_center_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of WorkCenter.</returns>
        MixERP.Net.Entities.Office.WorkCenter Get(int workCenterId);

        /// <summary>
        /// Gets the first record of WorkCenter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WorkCenter.</returns>
        MixERP.Net.Entities.Office.WorkCenter GetFirst();

        /// <summary>
        /// Gets the previous record of WorkCenter sorted by workCenterId. 
        /// </summary>
        /// <param name="workCenterId">The column "work_center_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WorkCenter.</returns>
        MixERP.Net.Entities.Office.WorkCenter GetPrevious(int workCenterId);

        /// <summary>
        /// Gets the next record of WorkCenter sorted by workCenterId. 
        /// </summary>
        /// <param name="workCenterId">The column "work_center_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WorkCenter.</returns>
        MixERP.Net.Entities.Office.WorkCenter GetNext(int workCenterId);

        /// <summary>
        /// Gets the last record of WorkCenter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WorkCenter.</returns>
        MixERP.Net.Entities.Office.WorkCenter GetLast();

        /// <summary>
        /// Returns multiple instances of the WorkCenter against workCenterIds. 
        /// </summary>
        /// <param name="workCenterIds">Array of column "work_center_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of WorkCenter.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> Get(int[] workCenterIds);

        /// <summary>
        /// Custom fields are user defined form elements for IWorkCenterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for WorkCenter.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding WorkCenter.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for WorkCenter.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of WorkCenter class to IWorkCenterRepository.
        /// </summary>
        /// <param name="workCenter">The instance of WorkCenter class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic workCenter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of WorkCenter class to IWorkCenterRepository.
        /// </summary>
        /// <param name="workCenter">The instance of WorkCenter class to insert.</param>
        object Add(dynamic workCenter);

        /// <summary>
        /// Inserts or updates multiple instances of WorkCenter class to IWorkCenterRepository.;
        /// </summary>
        /// <param name="workCenters">List of WorkCenter class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> workCenters);


        /// <summary>
        /// Updates IWorkCenterRepository with an instance of WorkCenter class against the primary key value.
        /// </summary>
        /// <param name="workCenter">The instance of WorkCenter class to update.</param>
        /// <param name="workCenterId">The value of the column "work_center_id" which will be updated.</param>
        void Update(dynamic workCenter, int workCenterId);

        /// <summary>
        /// Deletes WorkCenter from  IWorkCenterRepository against the primary key value.
        /// </summary>
        /// <param name="workCenterId">The value of the column "work_center_id" which will be deleted.</param>
        void Delete(int workCenterId);

        /// <summary>
        /// Produces a paginated result of 10 WorkCenter classes.
        /// </summary>
        /// <returns>Returns the first page of collection of WorkCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 WorkCenter classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of WorkCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IWorkCenterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of WorkCenter class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IWorkCenterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of WorkCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IWorkCenterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of WorkCenter class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IWorkCenterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of WorkCenter class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.WorkCenter> GetFiltered(long pageNumber, string filterName);



    }
}