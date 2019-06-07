// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IEntityAccessRepository
    {
        /// <summary>
        /// Counts the number of EntityAccess in IEntityAccessRepository.
        /// </summary>
        /// <returns>Returns the count of IEntityAccessRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EntityAccess. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EntityAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetAll();

        /// <summary>
        /// Returns all instances of EntityAccess to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EntityAccess.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EntityAccess against entityAccessId. 
        /// </summary>
        /// <param name="entityAccessId">The column "entity_access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EntityAccess.</returns>
        MixERP.Net.Entities.Policy.EntityAccess Get(int entityAccessId);

        /// <summary>
        /// Gets the first record of EntityAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EntityAccess.</returns>
        MixERP.Net.Entities.Policy.EntityAccess GetFirst();

        /// <summary>
        /// Gets the previous record of EntityAccess sorted by entityAccessId. 
        /// </summary>
        /// <param name="entityAccessId">The column "entity_access_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EntityAccess.</returns>
        MixERP.Net.Entities.Policy.EntityAccess GetPrevious(int entityAccessId);

        /// <summary>
        /// Gets the next record of EntityAccess sorted by entityAccessId. 
        /// </summary>
        /// <param name="entityAccessId">The column "entity_access_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EntityAccess.</returns>
        MixERP.Net.Entities.Policy.EntityAccess GetNext(int entityAccessId);

        /// <summary>
        /// Gets the last record of EntityAccess.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EntityAccess.</returns>
        MixERP.Net.Entities.Policy.EntityAccess GetLast();

        /// <summary>
        /// Returns multiple instances of the EntityAccess against entityAccessIds. 
        /// </summary>
        /// <param name="entityAccessIds">Array of column "entity_access_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EntityAccess.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> Get(int[] entityAccessIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEntityAccessRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EntityAccess.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EntityAccess.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EntityAccess.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EntityAccess class to IEntityAccessRepository.
        /// </summary>
        /// <param name="entityAccess">The instance of EntityAccess class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic entityAccess, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EntityAccess class to IEntityAccessRepository.
        /// </summary>
        /// <param name="entityAccess">The instance of EntityAccess class to insert.</param>
        object Add(dynamic entityAccess);

        /// <summary>
        /// Inserts or updates multiple instances of EntityAccess class to IEntityAccessRepository.;
        /// </summary>
        /// <param name="entityAccesses">List of EntityAccess class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> entityAccesses);


        /// <summary>
        /// Updates IEntityAccessRepository with an instance of EntityAccess class against the primary key value.
        /// </summary>
        /// <param name="entityAccess">The instance of EntityAccess class to update.</param>
        /// <param name="entityAccessId">The value of the column "entity_access_id" which will be updated.</param>
        void Update(dynamic entityAccess, int entityAccessId);

        /// <summary>
        /// Deletes EntityAccess from  IEntityAccessRepository against the primary key value.
        /// </summary>
        /// <param name="entityAccessId">The value of the column "entity_access_id" which will be deleted.</param>
        void Delete(int entityAccessId);

        /// <summary>
        /// Produces a paginated result of 10 EntityAccess classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EntityAccess classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEntityAccessRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EntityAccess class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEntityAccessRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEntityAccessRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EntityAccess class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEntityAccessRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EntityAccess class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetFiltered(long pageNumber, string filterName);



    }
}