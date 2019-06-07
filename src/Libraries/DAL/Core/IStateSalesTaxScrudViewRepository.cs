// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IStateSalesTaxScrudViewRepository
    {
        /// <summary>
        /// Performs count on IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStateSalesTaxScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StateSalesTaxScrudView" class from IStateSalesTaxScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StateSalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTaxScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStateSalesTaxScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StateSalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTaxScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StateSalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTaxScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StateSalesTaxScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StateSalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTaxScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StateSalesTaxScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStateSalesTaxScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StateSalesTaxScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.StateSalesTaxScrudView> GetFiltered(long pageNumber, string filterName);


    }
}