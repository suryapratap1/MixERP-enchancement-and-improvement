// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IEntityAccessScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEntityAccessScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EntityAccessScrudView" class from IEntityAccessScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccessScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEntityAccessScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccessScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccessScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EntityAccessScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccessScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EntityAccessScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.EntityAccessScrudView> GetFiltered(long pageNumber, string filterName);


    }
}