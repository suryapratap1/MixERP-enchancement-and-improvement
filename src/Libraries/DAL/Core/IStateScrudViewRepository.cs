// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IStateScrudViewRepository
    {
        /// <summary>
        /// Performs count on IStateScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStateScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StateScrudView" class from IStateScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStateScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStateScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStateScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStateScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StateScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStateScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StateScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateScrudView> GetFiltered(long pageNumber, string filterName);


    }
}