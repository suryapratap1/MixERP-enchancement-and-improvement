// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeExperienceRepository
    {
        /// <summary>
        /// Counts the number of EmployeeExperience in IEmployeeExperienceRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeExperienceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmployeeExperience. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeExperience.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetAll();

        /// <summary>
        /// Returns all instances of EmployeeExperience to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeExperience.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmployeeExperience against employeeExperienceId. 
        /// </summary>
        /// <param name="employeeExperienceId">The column "employee_experience_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeExperience.</returns>
        MixERP.Net.Entities.HRM.EmployeeExperience Get(long employeeExperienceId);

        /// <summary>
        /// Gets the first record of EmployeeExperience.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeExperience.</returns>
        MixERP.Net.Entities.HRM.EmployeeExperience GetFirst();

        /// <summary>
        /// Gets the previous record of EmployeeExperience sorted by employeeExperienceId. 
        /// </summary>
        /// <param name="employeeExperienceId">The column "employee_experience_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeExperience.</returns>
        MixERP.Net.Entities.HRM.EmployeeExperience GetPrevious(long employeeExperienceId);

        /// <summary>
        /// Gets the next record of EmployeeExperience sorted by employeeExperienceId. 
        /// </summary>
        /// <param name="employeeExperienceId">The column "employee_experience_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeExperience.</returns>
        MixERP.Net.Entities.HRM.EmployeeExperience GetNext(long employeeExperienceId);

        /// <summary>
        /// Gets the last record of EmployeeExperience.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeExperience.</returns>
        MixERP.Net.Entities.HRM.EmployeeExperience GetLast();

        /// <summary>
        /// Returns multiple instances of the EmployeeExperience against employeeExperienceIds. 
        /// </summary>
        /// <param name="employeeExperienceIds">Array of column "employee_experience_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmployeeExperience.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> Get(long[] employeeExperienceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeExperienceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmployeeExperience.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmployeeExperience.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmployeeExperience.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmployeeExperience class to IEmployeeExperienceRepository.
        /// </summary>
        /// <param name="employeeExperience">The instance of EmployeeExperience class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employeeExperience, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmployeeExperience class to IEmployeeExperienceRepository.
        /// </summary>
        /// <param name="employeeExperience">The instance of EmployeeExperience class to insert.</param>
        object Add(dynamic employeeExperience);

        /// <summary>
        /// Inserts or updates multiple instances of EmployeeExperience class to IEmployeeExperienceRepository.;
        /// </summary>
        /// <param name="employeeExperiences">List of EmployeeExperience class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employeeExperiences);


        /// <summary>
        /// Updates IEmployeeExperienceRepository with an instance of EmployeeExperience class against the primary key value.
        /// </summary>
        /// <param name="employeeExperience">The instance of EmployeeExperience class to update.</param>
        /// <param name="employeeExperienceId">The value of the column "employee_experience_id" which will be updated.</param>
        void Update(dynamic employeeExperience, long employeeExperienceId);

        /// <summary>
        /// Deletes EmployeeExperience from  IEmployeeExperienceRepository against the primary key value.
        /// </summary>
        /// <param name="employeeExperienceId">The value of the column "employee_experience_id" which will be deleted.</param>
        void Delete(long employeeExperienceId);

        /// <summary>
        /// Produces a paginated result of 10 EmployeeExperience classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmployeeExperience class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmployeeExperience classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmployeeExperience class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeExperienceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmployeeExperience class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeExperienceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmployeeExperience class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeExperienceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmployeeExperience class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeExperienceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmployeeExperience class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperience> GetFiltered(long pageNumber, string filterName);



    }
}