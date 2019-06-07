// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ILateFeeScrudViewRepository
    {
        /// <summary>
        /// Performs count on ILateFeeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ILateFeeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "LateFeeScrudView" class from ILateFeeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "LateFeeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ILateFeeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ILateFeeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ILateFeeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "LateFeeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ILateFeeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "LateFeeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILateFeeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "LateFeeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ILateFeeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "LateFeeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILateFeeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "LateFeeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ILateFeeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "LateFeeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}