// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartySelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPartySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartySelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartySelectorView" class from IPartySelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartySelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartySelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartySelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartySelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartySelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartySelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartySelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartySelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartySelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartySelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartySelectorView> GetFiltered(long pageNumber, string filterName);


    }
}