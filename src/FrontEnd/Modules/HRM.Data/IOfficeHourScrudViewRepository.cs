// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IOfficeHourScrudViewRepository
    {
        /// <summary>
        /// Performs count on IOfficeHourScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IOfficeHourScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "OfficeHourScrudView" class from IOfficeHourScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "OfficeHourScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHourScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IOfficeHourScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IOfficeHourScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeHourScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "OfficeHourScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHourScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IOfficeHourScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "OfficeHourScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHourScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOfficeHourScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "OfficeHourScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IOfficeHourScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "OfficeHourScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHourScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOfficeHourScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "OfficeHourScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IOfficeHourScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "OfficeHourScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.OfficeHourScrudView> GetFiltered(long pageNumber, string filterName);


    }
}