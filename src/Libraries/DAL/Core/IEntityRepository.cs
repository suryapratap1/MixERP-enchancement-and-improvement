// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IEntityRepository
    {
        /// <summary>
        /// Counts the number of Entity in IEntityRepository.
        /// </summary>
        /// <returns>Returns the count of IEntityRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Entity. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Entity.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> GetAll();

        /// <summary>
        /// Returns all instances of Entity to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Entity.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Entity against entityId. 
        /// </summary>
        /// <param name="entityId">The column "entity_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Entity.</returns>
        MixERP.Net.Entities.Core.Entity Get(int entityId);

        /// <summary>
        /// Gets the first record of Entity.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Entity.</returns>
        MixERP.Net.Entities.Core.Entity GetFirst();

        /// <summary>
        /// Gets the previous record of Entity sorted by entityId. 
        /// </summary>
        /// <param name="entityId">The column "entity_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Entity.</returns>
        MixERP.Net.Entities.Core.Entity GetPrevious(int entityId);

        /// <summary>
        /// Gets the next record of Entity sorted by entityId. 
        /// </summary>
        /// <param name="entityId">The column "entity_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Entity.</returns>
        MixERP.Net.Entities.Core.Entity GetNext(int entityId);

        /// <summary>
        /// Gets the last record of Entity.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Entity.</returns>
        MixERP.Net.Entities.Core.Entity GetLast();

        /// <summary>
        /// Returns multiple instances of the Entity against entityIds. 
        /// </summary>
        /// <param name="entityIds">Array of column "entity_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Entity.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> Get(int[] entityIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEntityRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Entity.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Entity.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Entity.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Entity class to IEntityRepository.
        /// </summary>
        /// <param name="entity">The instance of Entity class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic entity, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Entity class to IEntityRepository.
        /// </summary>
        /// <param name="entity">The instance of Entity class to insert.</param>
        object Add(dynamic entity);

        /// <summary>
        /// Inserts or updates multiple instances of Entity class to IEntityRepository.;
        /// </summary>
        /// <param name="entities">List of Entity class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> entities);


        /// <summary>
        /// Updates IEntityRepository with an instance of Entity class against the primary key value.
        /// </summary>
        /// <param name="entity">The instance of Entity class to update.</param>
        /// <param name="entityId">The value of the column "entity_id" which will be updated.</param>
        void Update(dynamic entity, int entityId);

        /// <summary>
        /// Deletes Entity from  IEntityRepository against the primary key value.
        /// </summary>
        /// <param name="entityId">The value of the column "entity_id" which will be deleted.</param>
        void Delete(int entityId);

        /// <summary>
        /// Produces a paginated result of 10 Entity classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Entity class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Entity classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Entity class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEntityRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Entity class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEntityRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Entity class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEntityRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Entity class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEntityRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Entity class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Entity> GetFiltered(long pageNumber, string filterName);



    }
}