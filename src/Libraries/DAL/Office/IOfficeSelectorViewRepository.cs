// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IOfficeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IOfficeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IOfficeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "OfficeSelectorView" class from IOfficeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "OfficeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IOfficeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IOfficeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "OfficeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "OfficeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "OfficeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IOfficeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "OfficeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "OfficeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IOfficeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "OfficeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}