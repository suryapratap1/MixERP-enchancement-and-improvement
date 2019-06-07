// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ITerminationScrudViewRepository
    {
        /// <summary>
        /// Performs count on ITerminationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITerminationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TerminationScrudView" class from ITerminationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TerminationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITerminationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITerminationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITerminationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TerminationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITerminationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TerminationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITerminationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TerminationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITerminationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TerminationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITerminationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TerminationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITerminationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TerminationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}