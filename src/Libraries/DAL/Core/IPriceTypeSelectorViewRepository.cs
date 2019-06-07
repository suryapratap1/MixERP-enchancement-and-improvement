// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPriceTypeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPriceTypeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PriceTypeSelectorView" class from IPriceTypeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PriceTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceTypeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPriceTypeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PriceTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceTypeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PriceTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceTypeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PriceTypeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PriceTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceTypeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PriceTypeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPriceTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PriceTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceTypeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}