using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class DashboardBll
    {
        private static DashboardBll instance;
        public static DashboardBll Instance => instance ?? (instance = new DashboardBll());

        private DashboardBll() { }

        public Dictionary<string, object> Get()
        {
            return DashboardDal.Instance.GetDashboard();
        }
    }
}
