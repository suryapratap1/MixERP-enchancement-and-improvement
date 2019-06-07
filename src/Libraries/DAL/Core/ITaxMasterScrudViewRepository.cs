// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxMasterScrudViewRepository
    {
        /// <summary>
        /// Performs count on ITaxMasterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITaxMasterScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TaxMasterScrudView" class from ITaxMasterScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TaxMasterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMasterScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITaxMasterScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITaxMasterScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxMasterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TaxMasterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMasterScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxMasterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TaxMasterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMasterScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxMasterScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TaxMasterScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITaxMasterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TaxMasterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMasterScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxMasterScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TaxMasterScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITaxMasterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TaxMasterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxMasterScrudView> GetFiltered(long pageNumber, string filterName);


    }
}