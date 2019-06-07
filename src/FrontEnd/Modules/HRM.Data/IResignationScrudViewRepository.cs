// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IResignationScrudViewRepository
    {
        /// <summary>
        /// Performs count on IResignationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IResignationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ResignationScrudView" class from IResignationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ResignationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IResignationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IResignationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IResignationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ResignationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IResignationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ResignationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IResignationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ResignationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IResignationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ResignationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IResignationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ResignationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IResignationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ResignationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ResignationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}