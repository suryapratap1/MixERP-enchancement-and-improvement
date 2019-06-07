// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IEntityScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEntityScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEntityScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EntityScrudView" class from IEntityScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EntityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EntityScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEntityScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEntityScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEntityScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EntityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EntityScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEntityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EntityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EntityScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEntityScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EntityScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEntityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EntityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EntityScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEntityScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EntityScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEntityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EntityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.EntityScrudView> GetFiltered(long pageNumber, string filterName);


    }
}