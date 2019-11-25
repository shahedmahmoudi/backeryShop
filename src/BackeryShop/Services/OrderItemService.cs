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
        /// <param name="orderItem">
		/// @return </param>
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

                        answer.Add(PacksData.CreatePacksData(count, packs.ToArray()[j], orderItem.product));

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
        /// <param name="packDat">
        /// @return </param>
        internal List<PacksData> findBestPack(List<List<PacksData>> packDat)
        {
            List<PacksData> result = packDat[0];
            foreach (List<PacksData> answer in packDat)            
                if (totalCount(answer) < totalCount(result) && calculateTotalPrice(answer) <= calculateTotalPrice(result))                
                    result = answer;                
            
            return result;
        }
        /// <param name="answerPacksData">
        /// @return </param>
        private decimal calculateTotalPrice(List<PacksData> answer)
        {
            decimal total = Decimal.Zero;
            foreach (var item in answer)           
                total += decimal.Multiply(Convert.ToDecimal(item.Count), item.ProductPack.price);            

            return total;
        }
        /// <param name="answerPacksData">
        /// @return </param>
        private int totalCount(List<PacksData> answer)
        {
            return answer.Sum(x => x.Count);
        }
    }
}
