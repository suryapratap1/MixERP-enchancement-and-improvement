// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICountyScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICountyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICountyScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CountyScrudView" class from ICountyScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CountyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountyScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICountyScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICountyScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICountyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CountyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountyScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICountyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CountyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountyScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICountyScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CountyScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICountyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CountyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountyScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICountyScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CountyScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICountyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CountyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CountyScrudView> GetFiltered(long pageNumber, string filterName);


    }
}