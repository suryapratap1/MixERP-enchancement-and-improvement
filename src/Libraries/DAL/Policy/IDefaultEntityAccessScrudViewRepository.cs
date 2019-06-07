// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IDefaultEntityAccessScrudViewRepository
    {
        /// <summary>
        /// Performs count on IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IDefaultEntityAccessScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DefaultEntityAccessScrudView" class from IDefaultEntityAccessScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DefaultEntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccessScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IDefaultEntityAccessScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DefaultEntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccessScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DefaultEntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccessScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DefaultEntityAccessScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DefaultEntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccessScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DefaultEntityAccessScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDefaultEntityAccessScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DefaultEntityAccessScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccessScrudView> GetFiltered(long pageNumber, string filterName);


    }
}