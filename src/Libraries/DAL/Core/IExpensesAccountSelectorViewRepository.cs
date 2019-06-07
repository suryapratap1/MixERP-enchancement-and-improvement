// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IExpensesAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IExpensesAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ExpensesAccountSelectorView" class from IExpensesAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ExpensesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExpensesAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IExpensesAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ExpensesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExpensesAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ExpensesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExpensesAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ExpensesAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ExpensesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExpensesAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ExpensesAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IExpensesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ExpensesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ExpensesAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}