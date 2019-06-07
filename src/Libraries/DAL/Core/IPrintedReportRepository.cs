// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPrintedReportRepository
    {
        /// <summary>
        /// Counts the number of PrintedReport in IPrintedReportRepository.
        /// </summary>
        /// <returns>Returns the count of IPrintedReportRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PrintedReport. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PrintedReport.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> GetAll();

        /// <summary>
        /// Returns all instances of PrintedReport to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PrintedReport.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PrintedReport against id. 
        /// </summary>
        /// <param name="id">The column "id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PrintedReport.</returns>
        MixERP.Net.Entities.Core.PrintedReport Get(long id);

        /// <summary>
        /// Gets the first record of PrintedReport.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PrintedReport.</returns>
        MixERP.Net.Entities.Core.PrintedReport GetFirst();

        /// <summary>
        /// Gets the previous record of PrintedReport sorted by id. 
        /// </summary>
        /// <param name="id">The column "id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PrintedReport.</returns>
        MixERP.Net.Entities.Core.PrintedReport GetPrevious(long id);

        /// <summary>
        /// Gets the next record of PrintedReport sorted by id. 
        /// </summary>
        /// <param name="id">The column "id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PrintedReport.</returns>
        MixERP.Net.Entities.Core.PrintedReport GetNext(long id);

        /// <summary>
        /// Gets the last record of PrintedReport.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PrintedReport.</returns>
        MixERP.Net.Entities.Core.PrintedReport GetLast();

        /// <summary>
        /// Returns multiple instances of the PrintedReport against ids. 
        /// </summary>
        /// <param name="ids">Array of column "id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PrintedReport.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> Get(long[] ids);

        /// </summary>
        /// <param name="printedReport">The instance of PrintedReport class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(Entities.Core.PrintedReport printedReport);

        /// <summary>
        /// Inserts the instance of PrintedReport class to IPrintedReportRepository.
        /// </summary>
        /// <param name="printedReport">The instance of PrintedReport class to insert.</param>
        object Add(Entities.Core.PrintedReport printedReport);

        /// <summary>
        /// Inserts or updates multiple instances of PrintedReport class to IPrintedReportRepository.;
        /// </summary>
        /// <param name="printedReports">List of PrintedReport class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> printedReports);


        /// <summary>
        /// Updates IPrintedReportRepository with an instance of PrintedReport class against the primary key value.
        /// </summary>
        /// <param name="printedReport">The instance of PrintedReport class to update.</param>
        /// <param name="id">The value of the column "id" which will be updated.</param>
        void Update(Entities.Core.PrintedReport printedReport, long id);

        /// <summary>
        /// Deletes PrintedReport from  IPrintedReportRepository against the primary key value.
        /// </summary>
        /// <param name="id">The value of the column "id" which will be deleted.</param>
        void Delete(long id);

        /// <summary>
        /// Produces a paginated result of 10 PrintedReport classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PrintedReport class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PrintedReport classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PrintedReport class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPrintedReportRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PrintedReport class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPrintedReportRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PrintedReport class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPrintedReportRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PrintedReport class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPrintedReportRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PrintedReport class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PrintedReport> GetFiltered(long pageNumber, string filterName);
    }
}