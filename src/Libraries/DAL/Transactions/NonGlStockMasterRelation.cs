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
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.non_gl_stock_master_relations".
    /// </summary>
    public class NonGlStockMasterRelation : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
	    public override string ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "non_gl_stock_master_relations".
        /// </summary>
	    public override string ObjectName => "non_gl_stock_master_relations";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "transactions.non_gl_stock_master_relations".
		/// </summary>
		/// <returns>Returns the number of rows of the table "transactions.non_gl_stock_master_relations".</returns>
		public long Count()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return 0;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT COUNT(*) FROM transactions.non_gl_stock_master_relations;";
				return Factory.Scalar<long>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Executes a select query on the table "transactions.non_gl_stock_master_relations" with a where filter on the column "non_gl_stock_master_relation_id" to return a single instance of the "NonGlStockMasterRelation" class. 
		/// </summary>
		/// <param name="nonGlStockMasterRelationId">The column "non_gl_stock_master_relation_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "NonGlStockMasterRelation" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Transactions.NonGlStockMasterRelation Get(long nonGlStockMasterRelationId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations WHERE non_gl_stock_master_relation_id=@0;";
				return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql, nonGlStockMasterRelationId).FirstOrDefault();
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.non_gl_stock_master_relations.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.non_gl_stock_master_relations</returns>
		public IEnumerable<DisplayField> GetDisplayFields()
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return displayFields;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT non_gl_stock_master_relation_id AS key, non_gl_stock_master_relation_id as value FROM transactions.non_gl_stock_master_relations;";
				using (NpgsqlCommand command = new NpgsqlCommand(sql))
				{
					using (DataTable table = DbOperation.GetDataTable(this.Catalog, command))
					{
						if (table?.Rows == null || table.Rows.Count == 0)
						{
							return displayFields;
						}

						foreach (DataRow row in table.Rows)
						{
							if (row != null)
							{
								DisplayField displayField = new DisplayField
								{
									Key = row["key"].ToString(),
									Value = row["value"].ToString()
								};

								displayFields.Add(displayField);
							}
						}
					}
				}

				return displayFields;
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Inserts the instance of NonGlStockMasterRelation class on the database table "transactions.non_gl_stock_master_relations".
		/// </summary>
		/// <param name="nonGlStockMasterRelation">The instance of "NonGlStockMasterRelation" class to insert.</param>
		public void Add(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Create, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Insert(this.Catalog, nonGlStockMasterRelation);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Updates the row of the table "transactions.non_gl_stock_master_relations" with an instance of "NonGlStockMasterRelation" class against the primary key value.
		/// </summary>
		/// <param name="nonGlStockMasterRelation">The instance of "NonGlStockMasterRelation" class to update.</param>
		/// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Transactions.NonGlStockMasterRelation nonGlStockMasterRelation, long nonGlStockMasterRelationId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Edit, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				Factory.Update(this.Catalog, nonGlStockMasterRelation, nonGlStockMasterRelationId);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Deletes the row of the table "transactions.non_gl_stock_master_relations" against the primary key value.
		/// </summary>
		/// <param name="nonGlStockMasterRelationId">The value of the column "non_gl_stock_master_relation_id" which will be deleted.</param>
		public void Delete(long nonGlStockMasterRelationId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Delete, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "DELETE FROM transactions.non_gl_stock_master_relations WHERE non_gl_stock_master_relation_id=@0;";
				Factory.NonQuery(this.Catalog, sql, nonGlStockMasterRelationId);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_master_relations" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "NonGlStockMasterRelation" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations ORDER BY non_gl_stock_master_relation_id LIMIT 25 OFFSET 0;";
				return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}

		/// <summary>
		/// Performs a select statement on table "transactions.non_gl_stock_master_relations" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "NonGlStockMasterRelation" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation> GetPagedResult(long pageNumber)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            try
            {
                if (!this.SkipValidation)
                {
                    if (!this.Validated)
                    {
                        this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                    }
                    if (!this.HasAccess)
                    {
                        throw new UnauthorizedException("Access is denied.");
                    }
                }
	
				long offset = (pageNumber -1) * 25;
				const string sql = "SELECT * FROM transactions.non_gl_stock_master_relations ORDER BY non_gl_stock_master_relation_id LIMIT 25 OFFSET @0;";
				
				return Factory.Get<MixERP.Net.Entities.Transactions.NonGlStockMasterRelation>(this.Catalog, sql, offset);
            }
            catch (UnauthorizedException ex)
            {
                Log.Error("{Exception} {@Exception}", ex.Message, ex);
                throw new MixERPException(ex.Message, ex);
            }
		}
	}
}