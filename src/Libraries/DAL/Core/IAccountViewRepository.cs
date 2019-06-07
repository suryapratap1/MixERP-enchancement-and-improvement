// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAccountViewRepository
    {
        /// <summary>
        /// Performs count on IAccountViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAccountViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AccountView" class from IAccountViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAccountViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAccountViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccountViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AccountView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccountViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AccountView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAccountViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AccountView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountView> GetFiltered(long pageNumber, string filterName);


    }
}