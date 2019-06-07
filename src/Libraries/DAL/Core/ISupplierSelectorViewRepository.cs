// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISupplierSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISupplierSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISupplierSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SupplierSelectorView" class from ISupplierSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SupplierSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SupplierSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISupplierSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISupplierSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISupplierSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SupplierSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SupplierSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISupplierSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SupplierSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SupplierSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISupplierSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SupplierSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISupplierSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SupplierSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SupplierSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISupplierSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SupplierSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISupplierSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SupplierSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SupplierSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}