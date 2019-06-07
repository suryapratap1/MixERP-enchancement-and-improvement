// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IDefaultEntityAccessRepository
    {
        /// <summary>
        /// Counts the number of DefaultEntityAccess in IDefaultEntityAccessRepository.
        /// </summary>
        /// <returns>Returns the count of IDefaultEntityAccessRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of DefaultEntityAccess. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DefaultEntityAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetAll();

        /// <summary>
        /// Returns all instances of DefaultEntityAccess to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DefaultEntityAccess.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the DefaultEntityAccess against defaultEntityAccessId. 
        /// </summary>
        /// <param name="defaultEntityAccessId">The column "default_entity_access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of DefaultEntityAccess.</returns>
        MixERP.Net.Entities.Policy.DefaultEntityAccess Get(int defaultEntityAccessId);

        /// <summary>
        /// Gets the first record of DefaultEntityAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of DefaultEntityAccess.</returns>
        MixERP.Net.Entities.Policy.DefaultEntityAccess GetFirst();

        /// <summary>
        /// Gets the previous record of DefaultEntityAccess sorted by defaultEntityAccessId. 
        /// </summary>
        /// <param name="defaultEntityAccessId">The column "default_entity_access_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of DefaultEntityAccess.</returns>
        MixERP.Net.Entities.Policy.DefaultEntityAccess GetPrevious(int defaultEntityAccessId);

        /// <summary>
        /// Gets the next record of DefaultEntityAccess sorted by defaultEntityAccessId. 
        /// </summary>
        /// <param name="defaultEntityAccessId">The column "default_entity_access_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of DefaultEntityAccess.</returns>
        MixERP.Net.Entities.Policy.DefaultEntityAccess GetNext(int defaultEntityAccessId);

        /// <summary>
        /// Gets the last record of DefaultEntityAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of DefaultEntityAccess.</returns>
        MixERP.Net.Entities.Policy.DefaultEntityAccess GetLast();

        /// <summary>
        /// Returns multiple instances of the DefaultEntityAccess against defaultEntityAccessIds. 
        /// </summary>
        /// <param name="defaultEntityAccessIds">Array of column "default_entity_access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of DefaultEntityAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> Get(int[] defaultEntityAccessIds);

        /// <summary>
        /// Custom fields are user defined form elements for IDefaultEntityAccessRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for DefaultEntityAccess.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding DefaultEntityAccess.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for DefaultEntityAccess.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of DefaultEntityAccess class to IDefaultEntityAccessRepository.
        /// </summary>
        /// <param name="defaultEntityAccess">The instance of DefaultEntityAccess class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic defaultEntityAccess, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of DefaultEntityAccess class to IDefaultEntityAccessRepository.
        /// </summary>
        /// <param name="defaultEntityAccess">The instance of DefaultEntityAccess class to insert.</param>
        object Add(dynamic defaultEntityAccess);

        /// <summary>
        /// Inserts or updates multiple instances of DefaultEntityAccess class to IDefaultEntityAccessRepository.;
        /// </summary>
        /// <param name="defaultEntityAccesses">List of DefaultEntityAccess class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> defaultEntityAccesses);


        /// <summary>
        /// Updates IDefaultEntityAccessRepository with an instance of DefaultEntityAccess class against the primary key value.
        /// </summary>
        /// <param name="defaultEntityAccess">The instance of DefaultEntityAccess class to update.</param>
        /// <param name="defaultEntityAccessId">The value of the column "default_entity_access_id" which will be updated.</param>
        void Update(dynamic defaultEntityAccess, int defaultEntityAccessId);

        /// <summary>
        /// Deletes DefaultEntityAccess from  IDefaultEntityAccessRepository against the primary key value.
        /// </summary>
        /// <param name="defaultEntityAccessId">The value of the column "default_entity_access_id" which will be deleted.</param>
        void Delete(int defaultEntityAccessId);

        /// <summary>
        /// Produces a paginated result of 10 DefaultEntityAccess classes.
        /// </summary>
        /// <returns>Returns the first page of collection of DefaultEntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 DefaultEntityAccess classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of DefaultEntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDefaultEntityAccessRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of DefaultEntityAccess class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IDefaultEntityAccessRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of DefaultEntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDefaultEntityAccessRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of DefaultEntityAccess class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IDefaultEntityAccessRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of DefaultEntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetFiltered(long pageNumber, string filterName);



    }
}