using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day1HW;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Day1HW.Tests
{
    [TestClass()]
    public class GroupByCategoryTests
    {
        [TestMethod()]
        public void GroupByCostTest_get_group_of_sum_of_cost_per_3_items()
        {
            //需求不是一個array放著 cost 的資料，而是一筆 product 身上有 cost, sellprice, revenue 等 property
            //因此這樣的測試案例並沒有完整表達出來需求的context
            int[] costValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            GroupByCategory gbc = new GroupByCategory();
            
            //如果未來還要group by sellprice, 那麼gbc就得新增一個方法，這樣的擴充性是比較不足的
            var result = gbc.GroupByCost(costValues);
            int[] expected = new int[]{6, 15, 24, 21};
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void GroupByRevenueTest_get_groups_of_sum_of_revenue_per_4_items()
        {
            int[] revenueValues = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            GroupByCategory gbc = new GroupByCategory();
            var result = gbc.GroupByRevenue(revenueValues);
            int[] expected = new int[] { 50,66,60 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
