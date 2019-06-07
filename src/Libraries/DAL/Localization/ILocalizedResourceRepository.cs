// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Localization.Data
{
    public interface ILocalizedResourceRepository
    {
        /// <summary>
        /// Counts the number of LocalizedResource in ILocalizedResourceRepository.
        /// </summary>
        /// <returns>Returns the count of ILocalizedResourceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LocalizedResource. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LocalizedResource.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetAll();

        /// <summary>
        /// Returns all instances of LocalizedResource to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LocalizedResource.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LocalizedResource against localizedResourceId. 
        /// </summary>
        /// <param name="localizedResourceId">The column "localized_resource_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LocalizedResource.</returns>
        MixERP.Net.Entities.Localization.LocalizedResource Get(long localizedResourceId);

        /// <summary>
        /// Gets the first record of LocalizedResource.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LocalizedResource.</returns>
        MixERP.Net.Entities.Localization.LocalizedResource GetFirst();

        /// <summary>
        /// Gets the previous record of LocalizedResource sorted by localizedResourceId. 
        /// </summary>
        /// <param name="localizedResourceId">The column "localized_resource_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LocalizedResource.</returns>
        MixERP.Net.Entities.Localization.LocalizedResource GetPrevious(long localizedResourceId);

        /// <summary>
        /// Gets the next record of LocalizedResource sorted by localizedResourceId. 
        /// </summary>
        /// <param name="localizedResourceId">The column "localized_resource_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LocalizedResource.</returns>
        MixERP.Net.Entities.Localization.LocalizedResource GetNext(long localizedResourceId);

        /// <summary>
        /// Gets the last record of LocalizedResource.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LocalizedResource.</returns>
        MixERP.Net.Entities.Localization.LocalizedResource GetLast();

        /// <summary>
        /// Returns multiple instances of the LocalizedResource against localizedResourceIds. 
        /// </summary>
        /// <param name="localizedResourceIds">Array of column "localized_resource_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LocalizedResource.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> Get(long[] localizedResourceIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILocalizedResourceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LocalizedResource.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LocalizedResource.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LocalizedResource.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LocalizedResource class to ILocalizedResourceRepository.
        /// </summary>
        /// <param name="localizedResource">The instance of LocalizedResource class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic localizedResource, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LocalizedResource class to ILocalizedResourceRepository.
        /// </summary>
        /// <param name="localizedResource">The instance of LocalizedResource class to insert.</param>
        object Add(dynamic localizedResource);

        /// <summary>
        /// Inserts or updates multiple instances of LocalizedResource class to ILocalizedResourceRepository.;
        /// </summary>
        /// <param name="localizedResources">List of LocalizedResource class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> localizedResources);


        /// <summary>
        /// Updates ILocalizedResourceRepository with an instance of LocalizedResource class against the primary key value.
        /// </summary>
        /// <param name="localizedResource">The instance of LocalizedResource class to update.</param>
        /// <param name="localizedResourceId">The value of the column "localized_resource_id" which will be updated.</param>
        void Update(dynamic localizedResource, long localizedResourceId);

        /// <summary>
        /// Deletes LocalizedResource from  ILocalizedResourceRepository against the primary key value.
        /// </summary>
        /// <param name="localizedResourceId">The value of the column "localized_resource_id" which will be deleted.</param>
        void Delete(long localizedResourceId);

        /// <summary>
        /// Produces a paginated result of 10 LocalizedResource classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LocalizedResource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LocalizedResource classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LocalizedResource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILocalizedResourceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LocalizedResource class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILocalizedResourceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LocalizedResource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILocalizedResourceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LocalizedResource class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILocalizedResourceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LocalizedResource class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetFiltered(long pageNumber, string filterName);



    }
}