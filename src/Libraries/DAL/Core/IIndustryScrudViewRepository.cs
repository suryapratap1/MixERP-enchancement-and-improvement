// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIndustryScrudViewRepository
    {
        /// <summary>
        /// Performs count on IIndustryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IIndustryScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "IndustryScrudView" class from IIndustryScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "IndustryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IndustryScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IIndustryScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IIndustryScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IIndustryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "IndustryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IndustryScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IIndustryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "IndustryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IndustryScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IIndustryScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "IndustryScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IIndustryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "IndustryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IndustryScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IIndustryScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "IndustryScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IIndustryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "IndustryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.IndustryScrudView> GetFiltered(long pageNumber, string filterName);


    }
}