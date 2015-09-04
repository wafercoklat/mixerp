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
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("item_selling_price_id", autoIncrement=true)]
    [TableName("core.item_selling_prices")]
    [ExplicitColumns]
    public sealed class ItemSellingPrice : PetaPocoDB.Record<ItemSellingPrice>, IPoco
    {
        [Column("item_selling_price_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.item_selling_prices_item_selling_price_id_seq'::regclass)")] 
        public long ItemSellingPriceId { get; set; }
    
        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int ItemId { get; set; }
    
        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int UnitId { get; set; }
    
        [Column("party_type_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? PartyTypeId { get; set; }
    
        [Column("price_type_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? PriceTypeId { get; set; }
    
        [Column("includes_tax")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool IncludesTax { get; set; }
    
        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")] 
        public decimal Price { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}