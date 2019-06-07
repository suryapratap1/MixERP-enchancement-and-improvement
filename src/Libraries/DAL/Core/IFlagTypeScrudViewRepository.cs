// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFlagTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on IFlagTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IFlagTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "FlagTypeScrudView" class from IFlagTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "FlagTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IFlagTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IFlagTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IFlagTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "FlagTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IFlagTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "FlagTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFlagTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "FlagTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IFlagTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "FlagTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFlagTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "FlagTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IFlagTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "FlagTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}