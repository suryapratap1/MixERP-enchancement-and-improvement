// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IOfficeScrudViewRepository
    {
        /// <summary>
        /// Performs count on IOfficeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IOfficeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "OfficeScrudView" class from IOfficeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "OfficeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IOfficeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IOfficeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "OfficeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "OfficeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "OfficeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IOfficeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "OfficeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "OfficeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IOfficeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "OfficeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.OfficeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}