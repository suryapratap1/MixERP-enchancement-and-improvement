// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IOfficeViewRepository
    {
        /// <summary>
        /// Performs count on IOfficeViewRepository.
        /// </summary>
        /// <returns>Returns the number of IOfficeViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "OfficeView" class from IOfficeViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "OfficeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IOfficeViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IOfficeViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "OfficeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "OfficeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "OfficeView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IOfficeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "OfficeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "OfficeView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IOfficeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "OfficeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeView> GetFiltered(long pageNumber, string filterName);


    }
}