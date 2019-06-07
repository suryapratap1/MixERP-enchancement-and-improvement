// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingAddressViewRepository
    {
        /// <summary>
        /// Performs count on IShippingAddressViewRepository.
        /// </summary>
        /// <returns>Returns the number of IShippingAddressViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ShippingAddressView" class from IShippingAddressViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ShippingAddressView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IShippingAddressViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IShippingAddressViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingAddressViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ShippingAddressView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingAddressViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ShippingAddressView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingAddressViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ShippingAddressView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IShippingAddressViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ShippingAddressView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingAddressViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ShippingAddressView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IShippingAddressViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ShippingAddressView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressView> GetFiltered(long pageNumber, string filterName);


    }
}