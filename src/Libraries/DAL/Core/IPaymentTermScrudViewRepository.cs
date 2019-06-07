// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPaymentTermScrudViewRepository
    {
        /// <summary>
        /// Performs count on IPaymentTermScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPaymentTermScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PaymentTermScrudView" class from IPaymentTermScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PaymentTermScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTermScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPaymentTermScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPaymentTermScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPaymentTermScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PaymentTermScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTermScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPaymentTermScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PaymentTermScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTermScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPaymentTermScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PaymentTermScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPaymentTermScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PaymentTermScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTermScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPaymentTermScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PaymentTermScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPaymentTermScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PaymentTermScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTermScrudView> GetFiltered(long pageNumber, string filterName);


    }
}