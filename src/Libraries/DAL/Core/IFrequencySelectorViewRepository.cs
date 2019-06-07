// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFrequencySelectorViewRepository
    {
        /// <summary>
        /// Performs count on IFrequencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IFrequencySelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "FrequencySelectorView" class from IFrequencySelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "FrequencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IFrequencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IFrequencySelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IFrequencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "FrequencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IFrequencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "FrequencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFrequencySelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "FrequencySelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IFrequencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "FrequencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFrequencySelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "FrequencySelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IFrequencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "FrequencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySelectorView> GetFiltered(long pageNumber, string filterName);


    }
}