// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxExemptDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxExemptDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxExemptDetailScrudView" class from ISalesTaxExemptDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxExemptDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxExemptDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxExemptDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxExemptDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxExemptDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxExemptDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxExemptDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxExemptDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxExemptDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}