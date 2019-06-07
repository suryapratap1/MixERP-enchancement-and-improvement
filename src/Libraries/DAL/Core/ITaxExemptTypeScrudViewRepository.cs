// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxExemptTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITaxExemptTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TaxExemptTypeScrudView" class from ITaxExemptTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TaxExemptTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITaxExemptTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TaxExemptTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TaxExemptTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TaxExemptTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TaxExemptTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TaxExemptTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITaxExemptTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TaxExemptTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxExemptTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}