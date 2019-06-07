// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IContractVerificationScrudViewRepository
    {
        /// <summary>
        /// Performs count on IContractVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IContractVerificationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ContractVerificationScrudView" class from IContractVerificationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ContractVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractVerificationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IContractVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IContractVerificationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IContractVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ContractVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractVerificationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IContractVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ContractVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractVerificationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IContractVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ContractVerificationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IContractVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ContractVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractVerificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IContractVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ContractVerificationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IContractVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ContractVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractVerificationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}