// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxExemptScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxExemptScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxExemptScrudView" class from ISalesTaxExemptScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxExemptScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxExemptScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxExemptScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxExemptScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxExemptScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxExemptScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxExemptScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxExemptScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxExemptScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptScrudView> GetFiltered(long pageNumber, string filterName);


    }
}