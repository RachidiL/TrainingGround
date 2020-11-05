using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShopingCartModel
    {
        // What this does, it says: this is a definition for an delegate:
        // Think of this almost like an Interface
        public delegate void MetionDiscount(decimal subTotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        // here are the different type of delegates (the three kinds) 
        // The first is the standard delegate which you create by yourself 
        // And the two others, Func and Action - Func returns a value and Action returns void 
        public decimal GenerateTotal(MetionDiscount mentionSubtotal,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);
            mentionSubtotal(subTotal);

            tellUserWeAreDiscounting("We are applying your discount.");

            return calculateDiscountedTotal(Items, subTotal);
        }
    }
}
