// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalespersonScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalespersonScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalespersonScrudView" class from ISalespersonScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalespersonScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalespersonScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalespersonScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalespersonScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalespersonScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalespersonScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalespersonScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalespersonScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalespersonScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalespersonScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonScrudView> GetFiltered(long pageNumber, string filterName);


    }
}