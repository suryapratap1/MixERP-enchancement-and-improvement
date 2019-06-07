// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IUserSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IUserSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IUserSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "UserSelectorView" class from IUserSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "UserSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IUserSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IUserSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IUserSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "UserSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IUserSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "UserSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUserSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "UserSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IUserSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "UserSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUserSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "UserSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IUserSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "UserSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}