/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MixERP.Net.DbFactory;
using Npgsql;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public class TaxRateTypeSelectorView
    {
		/// <summary>
		/// Performs SQL count on the table "core.tax_rate_type_selector_view".
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the number of rows of the table "core.tax_rate_type_selector_view".</returns>
		public long Count(string catalog)
		{
			const string sql = "SELECT COUNT(*) FROM core.tax_rate_type_selector_view;";
			return Factory.Scalar<long>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.tax_rate_type_selector_view" producing a paged result of 25.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <returns>Returns the first page of collection of "TaxRateTypeSelectorView" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetPagedResult(string catalog)
		{
			const string sql = "SELECT * FROM core.tax_rate_type_selector_view ORDER BY  LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Core.TaxRateTypeSelectorView>(catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "core.tax_rate_type_selector_view" producing a paged result of 25.
		/// </summary>
        /// <param name="catalog">The name of the database on which queries are being executed to.</param>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "TaxRateTypeSelectorView" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetPagedResult(string catalog, long pageNumber)
		{
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM core.tax_rate_type_selector_view ORDER BY  LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Core.TaxRateTypeSelectorView>(catalog, sql, offset);
		}
	}
}