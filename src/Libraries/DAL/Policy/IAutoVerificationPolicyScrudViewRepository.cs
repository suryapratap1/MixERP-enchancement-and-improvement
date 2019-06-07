// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IAutoVerificationPolicyScrudViewRepository
    {
        /// <summary>
        /// Performs count on IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAutoVerificationPolicyScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AutoVerificationPolicyScrudView" class from IAutoVerificationPolicyScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AutoVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicyScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAutoVerificationPolicyScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AutoVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicyScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AutoVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicyScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AutoVerificationPolicyScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AutoVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicyScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AutoVerificationPolicyScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAutoVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AutoVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicyScrudView> GetFiltered(long pageNumber, string filterName);


    }
}