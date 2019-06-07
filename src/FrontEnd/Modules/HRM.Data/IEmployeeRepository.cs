// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Counts the number of Employee in IEmployeeRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Employee. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Employee.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> GetAll();

        /// <summary>
        /// Returns all instances of Employee to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Employee.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Employee against employeeId. 
        /// </summary>
        /// <param name="employeeId">The column "employee_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Employee.</returns>
        MixERP.Net.Entities.HRM.Employee Get(int employeeId);

        /// <summary>
        /// Gets the first record of Employee.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Employee.</returns>
        MixERP.Net.Entities.HRM.Employee GetFirst();

        /// <summary>
        /// Gets the previous record of Employee sorted by employeeId. 
        /// </summary>
        /// <param name="employeeId">The column "employee_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Employee.</returns>
        MixERP.Net.Entities.HRM.Employee GetPrevious(int employeeId);

        /// <summary>
        /// Gets the next record of Employee sorted by employeeId. 
        /// </summary>
        /// <param name="employeeId">The column "employee_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Employee.</returns>
        MixERP.Net.Entities.HRM.Employee GetNext(int employeeId);

        /// <summary>
        /// Gets the last record of Employee.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Employee.</returns>
        MixERP.Net.Entities.HRM.Employee GetLast();

        /// <summary>
        /// Returns multiple instances of the Employee against employeeIds. 
        /// </summary>
        /// <param name="employeeIds">Array of column "employee_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Employee.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> Get(int[] employeeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Employee.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Employee.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Employee.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Employee class to IEmployeeRepository.
        /// </summary>
        /// <param name="employee">The instance of Employee class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employee, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Employee class to IEmployeeRepository.
        /// </summary>
        /// <param name="employee">The instance of Employee class to insert.</param>
        object Add(dynamic employee);

        /// <summary>
        /// Inserts or updates multiple instances of Employee class to IEmployeeRepository.;
        /// </summary>
        /// <param name="employees">List of Employee class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employees);


        /// <summary>
        /// Updates IEmployeeRepository with an instance of Employee class against the primary key value.
        /// </summary>
        /// <param name="employee">The instance of Employee class to update.</param>
        /// <param name="employeeId">The value of the column "employee_id" which will be updated.</param>
        void Update(dynamic employee, int employeeId);

        /// <summary>
        /// Deletes Employee from  IEmployeeRepository against the primary key value.
        /// </summary>
        /// <param name="employeeId">The value of the column "employee_id" which will be deleted.</param>
        void Delete(int employeeId);

        /// <summary>
        /// Produces a paginated result of 10 Employee classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Employee class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Employee classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Employee class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Employee class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Employee class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Employee class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Employee class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Employee> GetFiltered(long pageNumber, string filterName);



    }
}