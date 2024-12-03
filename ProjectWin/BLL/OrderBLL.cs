using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBLL
    {
        private static OrderBLL instance;
        public static OrderBLL Instance => instance ?? (instance = new OrderBLL());

        private OrderBLL() { }

        public List<Order> GetAll()
        {
            return OrderDAL.Instance.GetAll();
        }
    }
}
