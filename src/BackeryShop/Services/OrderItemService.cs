using backeryShop.DataModel;
using backeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backeryShop.Services
{
    /// <summary>
    ///  all of transaction for OrderItem
    /// 
    /// @author Shahed Mahmoudi, shahed.mahmoudi@gmail.com
    /// @since 2019-11-25
    /// </summary>
    class OrderItemService
    {

        public List<List<PacksData>> GetAllOfPack(OrderItem orderItem)
        {
            ICollection<ProductPack> packs = orderItem.product.productPacks.OrderByDescending(x => x.count).ToList();
            List<List<PacksData>> AllPack = new List<List<PacksData>>();

            for (int i = 1; i < (1 << packs.Count); i++)
            {
                int CountOrderItem = orderItem.Count;
                List<PacksData> answer = new List<PacksData>();
                for (int j = 0; j < packs.Count; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        int weight = packs.ToArray()[j].count;
                        int count = CountOrderItem >= weight ? CountOrderItem / weight : 0;

                        answer.Add(PacksData.CreatePacksData(count, packs.ToArray()[j]));

                        if (CountOrderItem % weight == 0)
                        {
                            AllPack.Add(answer);
                        }
                        CountOrderItem = CountOrderItem % weight;
                    }
                }
            }

            return AllPack;
          
        }

       
    }
}
