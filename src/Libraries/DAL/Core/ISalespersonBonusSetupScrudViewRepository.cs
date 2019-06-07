// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonBonusSetupScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalespersonBonusSetupScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalespersonBonusSetupScrudView" class from ISalespersonBonusSetupScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonBonusSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetupScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalespersonBonusSetupScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalespersonBonusSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetupScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalespersonBonusSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetupScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalespersonBonusSetupScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalespersonBonusSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetupScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalespersonBonusSetupScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalespersonBonusSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalespersonBonusSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetupScrudView> GetFiltered(long pageNumber, string filterName);


    }
}