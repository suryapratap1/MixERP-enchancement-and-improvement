// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPaymentCardScrudViewRepository
    {
        /// <summary>
        /// Performs count on IPaymentCardScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPaymentCardScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PaymentCardScrudView" class from IPaymentCardScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PaymentCardScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCardScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPaymentCardScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPaymentCardScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPaymentCardScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PaymentCardScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCardScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPaymentCardScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PaymentCardScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCardScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPaymentCardScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PaymentCardScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPaymentCardScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PaymentCardScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCardScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPaymentCardScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PaymentCardScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPaymentCardScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PaymentCardScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCardScrudView> GetFiltered(long pageNumber, string filterName);


    }
}