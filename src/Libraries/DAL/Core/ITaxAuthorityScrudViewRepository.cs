// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxAuthorityScrudViewRepository
    {
        /// <summary>
        /// Performs count on ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITaxAuthorityScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TaxAuthorityScrudView" class from ITaxAuthorityScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TaxAuthorityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxAuthorityScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITaxAuthorityScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TaxAuthorityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxAuthorityScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TaxAuthorityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxAuthorityScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TaxAuthorityScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TaxAuthorityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxAuthorityScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TaxAuthorityScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITaxAuthorityScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TaxAuthorityScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxAuthorityScrudView> GetFiltered(long pageNumber, string filterName);


    }
}