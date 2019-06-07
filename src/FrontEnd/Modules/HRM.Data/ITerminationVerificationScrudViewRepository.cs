// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ITerminationVerificationScrudViewRepository
    {
        /// <summary>
        /// Performs count on ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITerminationVerificationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TerminationVerificationScrudView" class from ITerminationVerificationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TerminationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationVerificationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITerminationVerificationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TerminationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationVerificationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TerminationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationVerificationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TerminationVerificationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TerminationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationVerificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TerminationVerificationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITerminationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TerminationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.TerminationVerificationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}