// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeTypeRepository
    {
        /// <summary>
        /// Counts the number of EmployeeType in IEmployeeTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmployeeType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetAll();

        /// <summary>
        /// Returns all instances of EmployeeType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmployeeType against employeeTypeId. 
        /// </summary>
        /// <param name="employeeTypeId">The column "employee_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeType.</returns>
        MixERP.Net.Entities.HRM.EmployeeType Get(int employeeTypeId);

        /// <summary>
        /// Gets the first record of EmployeeType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeType.</returns>
        MixERP.Net.Entities.HRM.EmployeeType GetFirst();

        /// <summary>
        /// Gets the previous record of EmployeeType sorted by employeeTypeId. 
        /// </summary>
        /// <param name="employeeTypeId">The column "employee_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeType.</returns>
        MixERP.Net.Entities.HRM.EmployeeType GetPrevious(int employeeTypeId);

        /// <summary>
        /// Gets the next record of EmployeeType sorted by employeeTypeId. 
        /// </summary>
        /// <param name="employeeTypeId">The column "employee_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeType.</returns>
        MixERP.Net.Entities.HRM.EmployeeType GetNext(int employeeTypeId);

        /// <summary>
        /// Gets the last record of EmployeeType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeType.</returns>
        MixERP.Net.Entities.HRM.EmployeeType GetLast();

        /// <summary>
        /// Returns multiple instances of the EmployeeType against employeeTypeIds. 
        /// </summary>
        /// <param name="employeeTypeIds">Array of column "employee_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmployeeType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> Get(int[] employeeTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmployeeType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmployeeType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmployeeType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmployeeType class to IEmployeeTypeRepository.
        /// </summary>
        /// <param name="employeeType">The instance of EmployeeType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employeeType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmployeeType class to IEmployeeTypeRepository.
        /// </summary>
        /// <param name="employeeType">The instance of EmployeeType class to insert.</param>
        object Add(dynamic employeeType);

        /// <summary>
        /// Inserts or updates multiple instances of EmployeeType class to IEmployeeTypeRepository.;
        /// </summary>
        /// <param name="employeeTypes">List of EmployeeType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employeeTypes);


        /// <summary>
        /// Updates IEmployeeTypeRepository with an instance of EmployeeType class against the primary key value.
        /// </summary>
        /// <param name="employeeType">The instance of EmployeeType class to update.</param>
        /// <param name="employeeTypeId">The value of the column "employee_type_id" which will be updated.</param>
        void Update(dynamic employeeType, int employeeTypeId);

        /// <summary>
        /// Deletes EmployeeType from  IEmployeeTypeRepository against the primary key value.
        /// </summary>
        /// <param name="employeeTypeId">The value of the column "employee_type_id" which will be deleted.</param>
        void Delete(int employeeTypeId);

        /// <summary>
        /// Produces a paginated result of 10 EmployeeType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmployeeType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmployeeType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmployeeType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmployeeType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmployeeType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmployeeType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmployeeType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetFiltered(long pageNumber, string filterName);



    }
}