using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class SKU
    {
        public char SkuId { get; set; }
        public int Quantity { get; set; }
        public SKU(char sku,int quantity)
        {
            SkuId = sku;
            Quantity = quantity;          
        }
    }
}
