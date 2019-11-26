using backeryShop.DataModel;
using backeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;


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
        public List<List<ResultProductPackData>> GetAllOfPack(OrderItem orderItem)
        {
            ICollection<ProductPack> packs = orderItem.product.productPacks.OrderByDescending(x => x.count).ToList();
            List<List<ResultProductPackData>> AllPack = new List<List<ResultProductPackData>>();
            for (int i = 1; i < (1 << packs.Count); i++)
            {
                int CountOrderItem = orderItem.Count;
                List<ResultProductPackData> answer = new List<ResultProductPackData>();
                for (int j = 0; j < packs.Count; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        int weight = packs.ToArray()[j].count;
                        int count = CountOrderItem >= weight ? CountOrderItem / weight : 0;
                        answer.Add(ResultProductPackData.CreatePacksData(count, packs.ToArray()[j], orderItem.product));
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
        internal List<ResultProductPackData> findBestPack(List<List<ResultProductPackData>> packDat)
        {
            List<ResultProductPackData> result = packDat[0];
            foreach (List<ResultProductPackData> answer in packDat)            
                if (totalCount(answer) < totalCount(result) && calculateTotalPrice(answer) <= calculateTotalPrice(result))                
                    result = answer;                
            
            return result;
        }
        /// <param name="answerPacksData">
        /// @return </param>
        private decimal calculateTotalPrice(List<ResultProductPackData> answer)
        {
            decimal total = Decimal.Zero;
            foreach (var item in answer)           
                total += decimal.Multiply(Convert.ToDecimal(item.Count), item.ProductPack.price);            

            return total;
        }
        /// <param name="answerPacksData">
        /// @return </param>
        private int totalCount(List<ResultProductPackData> answer)
        {
            return answer.Sum(x => x.Count);
        }
    }
}
