// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IContractScrudViewRepository
    {
        /// <summary>
        /// Performs count on IContractScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IContractScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ContractScrudView" class from IContractScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ContractScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IContractScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IContractScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IContractScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ContractScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IContractScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ContractScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IContractScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ContractScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IContractScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ContractScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IContractScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ContractScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IContractScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ContractScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ContractScrudView> GetFiltered(long pageNumber, string filterName);


    }
}