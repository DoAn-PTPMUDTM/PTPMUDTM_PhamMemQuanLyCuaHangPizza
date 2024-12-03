using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class DashboardDal
    {
        private static DashboardDal instance;
        public static DashboardDal Instance => instance ?? (instance = new DashboardDal());


        private DashboardDal() { }

        public Dictionary<string, object> GetDashboard()
        {
            var result = new Dictionary<string, object>();
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            using (var ctx = new DbConfig())
            {
                var totalCus = ctx.users
                    .Count(item => Constant.Active.Equals(item.status) && Constant.User.Equals(item.role));
                var totalStaff = ctx.users
                    .Count(item => Constant.Active.Equals(item.status) && Constant.Staff.Equals(item.role));
                var totalProduct = ctx.products
                    .Count(item => Constant.Active.Equals(item.status));
                var revenue = ctx.orders
                    .Where(item => "done".Equals(item.status))
                    .Sum(item => item.total_price) ?? 0;
                var revenueToday = ctx.orders
                    .Where(item => "done".Equals(item.status) 
                    && item.created_at >= today && item.created_at <= tomorrow)
                    .Sum (item => item.total_price) ?? 0;

                result.Add(Constant.TotalCus, totalCus);
                result.Add(Constant.TotalStaff, totalStaff);
                result.Add(Constant.TotalProduct, totalProduct);
                result.Add(Constant.Revenue, revenue);
                result.Add(Constant.RevenueToday, revenueToday);
            }
            return result;
        }
    }
}