// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IDepartmentRepository
    {
        /// <summary>
        /// Counts the number of Department in IDepartmentRepository.
        /// </summary>
        /// <returns>Returns the count of IDepartmentRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Department. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Department.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> GetAll();

        /// <summary>
        /// Returns all instances of Department to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Department.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Department against departmentId. 
        /// </summary>
        /// <param name="departmentId">The column "department_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Department.</returns>
        MixERP.Net.Entities.Office.Department Get(int departmentId);

        /// <summary>
        /// Gets the first record of Department.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Department.</returns>
        MixERP.Net.Entities.Office.Department GetFirst();

        /// <summary>
        /// Gets the previous record of Department sorted by departmentId. 
        /// </summary>
        /// <param name="departmentId">The column "department_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Department.</returns>
        MixERP.Net.Entities.Office.Department GetPrevious(int departmentId);

        /// <summary>
        /// Gets the next record of Department sorted by departmentId. 
        /// </summary>
        /// <param name="departmentId">The column "department_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Department.</returns>
        MixERP.Net.Entities.Office.Department GetNext(int departmentId);

        /// <summary>
        /// Gets the last record of Department.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Department.</returns>
        MixERP.Net.Entities.Office.Department GetLast();

        /// <summary>
        /// Returns multiple instances of the Department against departmentIds. 
        /// </summary>
        /// <param name="departmentIds">Array of column "department_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Department.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> Get(int[] departmentIds);

        /// <summary>
        /// Custom fields are user defined form elements for IDepartmentRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Department.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Department.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Department.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Department class to IDepartmentRepository.
        /// </summary>
        /// <param name="department">The instance of Department class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic department, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Department class to IDepartmentRepository.
        /// </summary>
        /// <param name="department">The instance of Department class to insert.</param>
        object Add(dynamic department);

        /// <summary>
        /// Inserts or updates multiple instances of Department class to IDepartmentRepository.;
        /// </summary>
        /// <param name="departments">List of Department class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> departments);


        /// <summary>
        /// Updates IDepartmentRepository with an instance of Department class against the primary key value.
        /// </summary>
        /// <param name="department">The instance of Department class to update.</param>
        /// <param name="departmentId">The value of the column "department_id" which will be updated.</param>
        void Update(dynamic department, int departmentId);

        /// <summary>
        /// Deletes Department from  IDepartmentRepository against the primary key value.
        /// </summary>
        /// <param name="departmentId">The value of the column "department_id" which will be deleted.</param>
        void Delete(int departmentId);

        /// <summary>
        /// Produces a paginated result of 10 Department classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Department class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Department classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Department class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDepartmentRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Department class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IDepartmentRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Department class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDepartmentRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Department class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IDepartmentRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Department class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Department> GetFiltered(long pageNumber, string filterName);



    }
}