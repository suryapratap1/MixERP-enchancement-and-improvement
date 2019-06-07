// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICustomFieldDefinitionViewRepository
    {
        /// <summary>
        /// Performs count on ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICustomFieldDefinitionViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CustomFieldDefinitionView" class from ICustomFieldDefinitionViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CustomFieldDefinitionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDefinitionView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CustomFieldDefinitionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDefinitionView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CustomFieldDefinitionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDefinitionView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CustomFieldDefinitionView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CustomFieldDefinitionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDefinitionView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CustomFieldDefinitionView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICustomFieldDefinitionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CustomFieldDefinitionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDefinitionView> GetFiltered(long pageNumber, string filterName);


    }
}