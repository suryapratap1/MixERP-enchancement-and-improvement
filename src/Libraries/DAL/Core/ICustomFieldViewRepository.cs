// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICustomFieldViewRepository
    {
        /// <summary>
        /// Performs count on ICustomFieldViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICustomFieldViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CustomFieldView" class from ICustomFieldViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CustomFieldView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from ICustomFieldViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CustomFieldView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICustomFieldViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CustomFieldView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICustomFieldViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CustomFieldView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICustomFieldViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CustomFieldView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICustomFieldViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CustomFieldView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICustomFieldViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CustomFieldView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldView> GetFiltered(long pageNumber, string filterName);


    }
}