// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IUnitViewRepository
    {
        /// <summary>
        /// Performs count on IUnitViewRepository.
        /// </summary>
        /// <returns>Returns the number of IUnitViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "UnitView" class from IUnitViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "UnitView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IUnitViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IUnitViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IUnitViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "UnitView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IUnitViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "UnitView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUnitViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "UnitView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IUnitViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "UnitView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUnitViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "UnitView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IUnitViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "UnitView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.UnitView> GetFiltered(long pageNumber, string filterName);


    }
}