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
    [PrimaryKey("item_group_id", autoIncrement=true)]
    [TableName("core.item_groups")]
    [ExplicitColumns]
    public sealed class ItemGroup : PetaPocoDB.Record<ItemGroup>, IPoco
    {
        [Column("item_group_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.item_groups_item_group_id_seq'::regclass)")] 
        public int ItemGroupId { get; set; }
    
        [Column("item_group_code")]
        [ColumnDbType("varchar", 12, false, "")] 
        public string ItemGroupCode { get; set; }
    
        [Column("item_group_name")]
        [ColumnDbType("varchar", 50, false, "")] 
        public string ItemGroupName { get; set; }
    
        [Column("exclude_from_purchase")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool ExcludeFromPurchase { get; set; }
    
        [Column("exclude_from_sales")]
        [ColumnDbType("bool", 0, false, "false")] 
        public bool ExcludeFromSales { get; set; }
    
        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "")] 
        public int SalesTaxId { get; set; }
    
        [Column("sales_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesAccountId { get; set; }
    
        [Column("sales_discount_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesDiscountAccountId { get; set; }
    
        [Column("sales_return_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long SalesReturnAccountId { get; set; }
    
        [Column("purchase_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long PurchaseAccountId { get; set; }
    
        [Column("purchase_discount_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long PurchaseDiscountAccountId { get; set; }
    
        [Column("inventory_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long InventoryAccountId { get; set; }
    
        [Column("cost_of_goods_sold_account_id")]
        [ColumnDbType("int8", 0, false, "")] 
        public long CostOfGoodsSoldAccountId { get; set; }
    
        [Column("parent_item_group_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? ParentItemGroupId { get; set; }
    
        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")] 
        public int? AuditUserId { get; set; }
    
        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")] 
        public DateTime? AuditTs { get; set; }
    }
}