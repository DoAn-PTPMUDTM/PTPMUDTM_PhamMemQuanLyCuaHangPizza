using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        private static OrderDAL instance;
        public static OrderDAL Instance => instance ?? (instance = new OrderDAL());

        private OrderDAL() { }

        public List<Order> GetAll()
        {
            using (var ctx = new DbConfig())
            {
                return ctx.orders.ToList();
            }
        }
    }
}
