// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecurringInvoiceScrudViewRepository
    {
        /// <summary>
        /// Performs count on IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRecurringInvoiceScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RecurringInvoiceScrudView" class from IRecurringInvoiceScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RecurringInvoiceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRecurringInvoiceScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RecurringInvoiceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RecurringInvoiceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RecurringInvoiceScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RecurringInvoiceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RecurringInvoiceScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRecurringInvoiceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RecurringInvoiceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceScrudView> GetFiltered(long pageNumber, string filterName);


    }
}