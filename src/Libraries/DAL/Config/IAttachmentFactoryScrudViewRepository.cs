// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IAttachmentFactoryScrudViewRepository
    {
        /// <summary>
        /// Performs count on IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAttachmentFactoryScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AttachmentFactoryScrudView" class from IAttachmentFactoryScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AttachmentFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactoryScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AttachmentFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactoryScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AttachmentFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactoryScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AttachmentFactoryScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AttachmentFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactoryScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AttachmentFactoryScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAttachmentFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AttachmentFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactoryScrudView> GetFiltered(long pageNumber, string filterName);


    }
}