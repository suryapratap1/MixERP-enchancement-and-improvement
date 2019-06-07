// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface ISwitchScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISwitchScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISwitchScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SwitchScrudView" class from ISwitchScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SwitchScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.SwitchScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from ISwitchScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SwitchScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.SwitchScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISwitchScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SwitchScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.SwitchScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISwitchScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SwitchScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISwitchScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SwitchScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.SwitchScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISwitchScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SwitchScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISwitchScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SwitchScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.SwitchScrudView> GetFiltered(long pageNumber, string filterName);


    }
}