// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IVoucherVerificationPolicyScrudViewRepository
    {
        /// <summary>
        /// Performs count on IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IVoucherVerificationPolicyScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "VoucherVerificationPolicyScrudView" class from IVoucherVerificationPolicyScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "VoucherVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicyScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IVoucherVerificationPolicyScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "VoucherVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicyScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicyScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "VoucherVerificationPolicyScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicyScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "VoucherVerificationPolicyScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IVoucherVerificationPolicyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "VoucherVerificationPolicyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicyScrudView> GetFiltered(long pageNumber, string filterName);


    }
}