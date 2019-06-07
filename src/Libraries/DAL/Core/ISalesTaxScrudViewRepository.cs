// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxScrudView" class from ISalesTaxScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxScrudView> GetFiltered(long pageNumber, string filterName);


    }
}