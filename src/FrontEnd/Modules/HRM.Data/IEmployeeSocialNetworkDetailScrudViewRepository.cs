// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeSocialNetworkDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeSocialNetworkDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeSocialNetworkDetailScrudView" class from IEmployeeSocialNetworkDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeSocialNetworkDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeSocialNetworkDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeSocialNetworkDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeSocialNetworkDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeSocialNetworkDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeSocialNetworkDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeSocialNetworkDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeSocialNetworkDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeSocialNetworkDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}