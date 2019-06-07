// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IUserViewRepository
    {
        /// <summary>
        /// Performs count on IUserViewRepository.
        /// </summary>
        /// <returns>Returns the number of IUserViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "UserView" class from IUserViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "UserView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IUserViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IUserViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IUserViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "UserView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IUserViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "UserView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUserViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "UserView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IUserViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "UserView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUserViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "UserView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IUserViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "UserView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.UserView> GetFiltered(long pageNumber, string filterName);


    }
}