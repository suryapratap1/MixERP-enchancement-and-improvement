// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IScrudFactoryScrudViewRepository
    {
        /// <summary>
        /// Performs count on IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IScrudFactoryScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ScrudFactoryScrudView" class from IScrudFactoryScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ScrudFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactoryScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ScrudFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactoryScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ScrudFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactoryScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ScrudFactoryScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ScrudFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactoryScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ScrudFactoryScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IScrudFactoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ScrudFactoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactoryScrudView> GetFiltered(long pageNumber, string filterName);


    }
}