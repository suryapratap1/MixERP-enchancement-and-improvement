// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecurringInvoiceSetupScrudViewRepository
    {
        /// <summary>
        /// Performs count on IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRecurringInvoiceSetupScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RecurringInvoiceSetupScrudView" class from IRecurringInvoiceSetupScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RecurringInvoiceSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetupScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRecurringInvoiceSetupScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RecurringInvoiceSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetupScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RecurringInvoiceSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetupScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RecurringInvoiceSetupScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RecurringInvoiceSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetupScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RecurringInvoiceSetupScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRecurringInvoiceSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RecurringInvoiceSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetupScrudView> GetFiltered(long pageNumber, string filterName);


    }
}