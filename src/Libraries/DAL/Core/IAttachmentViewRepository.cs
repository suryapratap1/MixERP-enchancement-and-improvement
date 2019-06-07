// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAttachmentViewRepository
    {
        /// <summary>
        /// Performs count on IAttachmentViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAttachmentViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AttachmentView" class from IAttachmentViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AttachmentView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAttachmentViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAttachmentViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAttachmentViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AttachmentView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAttachmentViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AttachmentView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttachmentViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AttachmentView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAttachmentViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AttachmentView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttachmentViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AttachmentView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAttachmentViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AttachmentView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentView> GetFiltered(long pageNumber, string filterName);


    }
}