using backeryShop.Models;
using System.Collections.Generic;
 

namespace backeryShop.DataModel
{
    /// <summary>
    ///  Fixed data on the amount and packaging of products
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    public static class StaticProduct
    {

        public static List<ProductPack> Vegemite_Scroll_Pack = new List<ProductPack>()
        {
            new ProductPack { count = 3, id = 1, price = 6.99M },
            new ProductPack { count = 5, id = 2, price = 8.99M }
        };

        public static Product Vegemite_Scroll = new Product() { code = "VS5", id = 1, name = "Vegemite Scroll", productPacks = Vegemite_Scroll_Pack };

        public static List<ProductPack> Blueberry_Muffin_Pack = new List<ProductPack>()
        {
            new ProductPack { count = 2, id = 3, price = 9.95M },
            new ProductPack { count = 5, id = 4, price = 16.95M },
            new ProductPack { count = 8, id = 5, price = 24.95M }
        };

        public static Product Blueberry_Muffin = new Product() { code = "MB11", id = 2, name = "Blueberry Muffin", productPacks = Blueberry_Muffin_Pack };



        public static List<ProductPack> Croissant_Pack = new List<ProductPack>()
        {
            new ProductPack { count = 3, id =6, price = 5.99M },
            new ProductPack { count = 5, id = 7, price = 9.99M },
              new ProductPack { count = 9, id = 8, price = 16.99M }
        };

        public static Product Croissant = new Product() { code = "CF", id = 3, name = "Croissant", productPacks = Croissant_Pack };

    }
}
