// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundItemDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICompoundItemDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CompoundItemDetailScrudView" class from ICompoundItemDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CompoundItemDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICompoundItemDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CompoundItemDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CompoundItemDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CompoundItemDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CompoundItemDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CompoundItemDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICompoundItemDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CompoundItemDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}