// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICounterScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICounterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICounterScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CounterScrudView" class from ICounterScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CounterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CounterScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICounterScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICounterScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICounterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CounterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CounterScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICounterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CounterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CounterScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICounterScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CounterScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICounterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CounterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CounterScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICounterScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CounterScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICounterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CounterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CounterScrudView> GetFiltered(long pageNumber, string filterName);


    }
}