// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingPackageShapeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IShippingPackageShapeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ShippingPackageShapeSelectorView" class from IShippingPackageShapeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ShippingPackageShapeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShapeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IShippingPackageShapeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ShippingPackageShapeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShapeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ShippingPackageShapeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShapeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ShippingPackageShapeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ShippingPackageShapeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShapeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ShippingPackageShapeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IShippingPackageShapeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ShippingPackageShapeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShapeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}