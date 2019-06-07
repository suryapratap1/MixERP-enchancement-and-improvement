// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxTypeScrudView" class from ISalesTaxTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}