// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxDetailScrudView" class from ISalesTaxDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}