// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFrequencySetupScrudViewRepository
    {
        /// <summary>
        /// Performs count on IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IFrequencySetupScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "FrequencySetupScrudView" class from IFrequencySetupScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "FrequencySetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetupScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IFrequencySetupScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "FrequencySetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetupScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "FrequencySetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetupScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "FrequencySetupScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "FrequencySetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetupScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "FrequencySetupScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IFrequencySetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "FrequencySetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetupScrudView> GetFiltered(long pageNumber, string filterName);


    }
}