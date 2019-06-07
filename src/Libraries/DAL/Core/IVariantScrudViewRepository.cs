// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IVariantScrudViewRepository
    {
        /// <summary>
        /// Performs count on IVariantScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IVariantScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "VariantScrudView" class from IVariantScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "VariantScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VariantScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IVariantScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IVariantScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IVariantScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "VariantScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VariantScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IVariantScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "VariantScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VariantScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVariantScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "VariantScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IVariantScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "VariantScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VariantScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVariantScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "VariantScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IVariantScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "VariantScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VariantScrudView> GetFiltered(long pageNumber, string filterName);


    }
}