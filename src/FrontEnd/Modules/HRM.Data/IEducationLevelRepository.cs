// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEducationLevelRepository
    {
        /// <summary>
        /// Counts the number of EducationLevel in IEducationLevelRepository.
        /// </summary>
        /// <returns>Returns the count of IEducationLevelRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EducationLevel. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EducationLevel.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetAll();

        /// <summary>
        /// Returns all instances of EducationLevel to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EducationLevel.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EducationLevel against educationLevelId. 
        /// </summary>
        /// <param name="educationLevelId">The column "education_level_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EducationLevel.</returns>
        MixERP.Net.Entities.HRM.EducationLevel Get(int educationLevelId);

        /// <summary>
        /// Gets the first record of EducationLevel.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EducationLevel.</returns>
        MixERP.Net.Entities.HRM.EducationLevel GetFirst();

        /// <summary>
        /// Gets the previous record of EducationLevel sorted by educationLevelId. 
        /// </summary>
        /// <param name="educationLevelId">The column "education_level_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EducationLevel.</returns>
        MixERP.Net.Entities.HRM.EducationLevel GetPrevious(int educationLevelId);

        /// <summary>
        /// Gets the next record of EducationLevel sorted by educationLevelId. 
        /// </summary>
        /// <param name="educationLevelId">The column "education_level_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EducationLevel.</returns>
        MixERP.Net.Entities.HRM.EducationLevel GetNext(int educationLevelId);

        /// <summary>
        /// Gets the last record of EducationLevel.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EducationLevel.</returns>
        MixERP.Net.Entities.HRM.EducationLevel GetLast();

        /// <summary>
        /// Returns multiple instances of the EducationLevel against educationLevelIds. 
        /// </summary>
        /// <param name="educationLevelIds">Array of column "education_level_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EducationLevel.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> Get(int[] educationLevelIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEducationLevelRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EducationLevel.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EducationLevel.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EducationLevel.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EducationLevel class to IEducationLevelRepository.
        /// </summary>
        /// <param name="educationLevel">The instance of EducationLevel class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic educationLevel, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EducationLevel class to IEducationLevelRepository.
        /// </summary>
        /// <param name="educationLevel">The instance of EducationLevel class to insert.</param>
        object Add(dynamic educationLevel);

        /// <summary>
        /// Inserts or updates multiple instances of EducationLevel class to IEducationLevelRepository.;
        /// </summary>
        /// <param name="educationLevels">List of EducationLevel class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> educationLevels);


        /// <summary>
        /// Updates IEducationLevelRepository with an instance of EducationLevel class against the primary key value.
        /// </summary>
        /// <param name="educationLevel">The instance of EducationLevel class to update.</param>
        /// <param name="educationLevelId">The value of the column "education_level_id" which will be updated.</param>
        void Update(dynamic educationLevel, int educationLevelId);

        /// <summary>
        /// Deletes EducationLevel from  IEducationLevelRepository against the primary key value.
        /// </summary>
        /// <param name="educationLevelId">The value of the column "education_level_id" which will be deleted.</param>
        void Delete(int educationLevelId);

        /// <summary>
        /// Produces a paginated result of 10 EducationLevel classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EducationLevel class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EducationLevel classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EducationLevel class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEducationLevelRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EducationLevel class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEducationLevelRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EducationLevel class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEducationLevelRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EducationLevel class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEducationLevelRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EducationLevel class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetFiltered(long pageNumber, string filterName);



    }
}