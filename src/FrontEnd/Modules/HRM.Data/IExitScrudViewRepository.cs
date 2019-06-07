// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IExitScrudViewRepository
    {
        /// <summary>
        /// Performs count on IExitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IExitScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ExitScrudView" class from IExitScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ExitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IExitScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IExitScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IExitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ExitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IExitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ExitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExitScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ExitScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IExitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ExitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExitScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ExitScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IExitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ExitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitScrudView> GetFiltered(long pageNumber, string filterName);


    }
}