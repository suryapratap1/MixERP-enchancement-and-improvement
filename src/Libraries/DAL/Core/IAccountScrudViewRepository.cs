// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAccountScrudViewRepository
    {
        /// <summary>
        /// Performs count on IAccountScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAccountScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AccountScrudView" class from IAccountScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AccountScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAccountScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAccountScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AccountScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AccountScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccountScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AccountScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAccountScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AccountScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccountScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AccountScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAccountScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AccountScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountScrudView> GetFiltered(long pageNumber, string filterName);


    }
}