// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IResourceRepository
    {
        /// <summary>
        /// Counts the number of Resource in IResourceRepository.
        /// </summary>
        /// <returns>Returns the count of IResourceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Resource. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Resource.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> GetAll();

        /// <summary>
        /// Returns all instances of Resource to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Resource.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Resource against resourceId. 
        /// </summary>
        /// <param name="resourceId">The column "resource_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resource.</returns>
        MixERP.Net.Entities.Localization.Resource Get(int resourceId);

        /// <summary>
        /// Gets the first record of Resource.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Resource.</returns>
        MixERP.Net.Entities.Localization.Resource GetFirst();

        /// <summary>
        /// Gets the previous record of Resource sorted by resourceId. 
        /// </summary>
        /// <param name="resourceId">The column "resource_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resource.</returns>
        MixERP.Net.Entities.Localization.Resource GetPrevious(int resourceId);

        /// <summary>
        /// Gets the next record of Resource sorted by resourceId. 
        /// </summary>
        /// <param name="resourceId">The column "resource_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resource.</returns>
        MixERP.Net.Entities.Localization.Resource GetNext(int resourceId);

        /// <summary>
        /// Gets the last record of Resource.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Resource.</returns>
        MixERP.Net.Entities.Localization.Resource GetLast();

        /// <summary>
        /// Returns multiple instances of the Resource against resourceIds. 
        /// </summary>
        /// <param name="resourceIds">Array of column "resource_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Resource.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> Get(int[] resourceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IResourceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Resource.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Resource.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Resource.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Resource class to IResourceRepository.
        /// </summary>
        /// <param name="resource">The instance of Resource class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic resource, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Resource class to IResourceRepository.
        /// </summary>
        /// <param name="resource">The instance of Resource class to insert.</param>
        object Add(dynamic resource);

        /// <summary>
        /// Inserts or updates multiple instances of Resource class to IResourceRepository.;
        /// </summary>
        /// <param name="resources">List of Resource class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> resources);


        /// <summary>
        /// Updates IResourceRepository with an instance of Resource class against the primary key value.
        /// </summary>
        /// <param name="resource">The instance of Resource class to update.</param>
        /// <param name="resourceId">The value of the column "resource_id" which will be updated.</param>
        void Update(dynamic resource, int resourceId);

        /// <summary>
        /// Deletes Resource from  IResourceRepository against the primary key value.
        /// </summary>
        /// <param name="resourceId">The value of the column "resource_id" which will be deleted.</param>
        void Delete(int resourceId);

        /// <summary>
        /// Produces a paginated result of 10 Resource classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Resource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Resource classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Resource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IResourceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Resource class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IResourceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Resource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IResourceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Resource class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IResourceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Resource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Resource> GetFiltered(long pageNumber, string filterName);



    }
}