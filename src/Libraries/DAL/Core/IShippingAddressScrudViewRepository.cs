// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingAddressScrudViewRepository
    {
        /// <summary>
        /// Performs count on IShippingAddressScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IShippingAddressScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ShippingAddressScrudView" class from IShippingAddressScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ShippingAddressScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IShippingAddressScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IShippingAddressScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingAddressScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ShippingAddressScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingAddressScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ShippingAddressScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingAddressScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ShippingAddressScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IShippingAddressScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ShippingAddressScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingAddressScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ShippingAddressScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IShippingAddressScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ShippingAddressScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddressScrudView> GetFiltered(long pageNumber, string filterName);


    }
}