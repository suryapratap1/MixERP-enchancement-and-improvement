// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundUnitScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICompoundUnitScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CompoundUnitScrudView" class from ICompoundUnitScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CompoundUnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnitScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICompoundUnitScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CompoundUnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnitScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CompoundUnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnitScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CompoundUnitScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CompoundUnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnitScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CompoundUnitScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICompoundUnitScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CompoundUnitScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnitScrudView> GetFiltered(long pageNumber, string filterName);


    }
}