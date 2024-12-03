using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        private static UserDal _instance;
        private UserDal()
        {
        }
        public static UserDal instance => _instance ?? (_instance = new UserDal());

        public User GetByUsername(string username)
        {
            using (var ctx = new DbConfig())
            {
                return ctx.users.FirstOrDefault(item => item.email.Equals(username));
            }
        }

        public List<User> GetListUser()
        {
            using (var ctx = new DbConfig())
            {
                return ctx.users
                    .Where(item => !Constant.Admin.Equals(item.role) && Constant.Active.Equals(item.status))
                    .ToList();
            }
        }

        public bool Save(User u)
        {
            using (var ctx = new DbConfig())
            {
                var user = ctx.users.FirstOrDefault(item => item.user_id == u.user_id);
                if (user != null)
                {
                    user.full_name = u.full_name;
                    user.password = u.password;
                    user.updated_at = DateTime.Now;
                }
                else
                {
                    u.status = Constant.Active;
                    u.role = Constant.Staff;
                    u.created_at = DateTime.Now;
                    ctx.users.Add(u);
                }
                return ctx.SaveChanges() > 0;
            }
        }

        public bool Remove(int id)
        {
            using (var ctx = new DbConfig())
            {
                var user = ctx.users.FirstOrDefault(item => item.user_id == id);
                if (user != null)
                {
                    user.status = Constant.Inactive;
                    user.updated_at = DateTime.Now;
                    ctx.SaveChanges();
                }
                else
                {
                    return false;
                }

            }
            return true;
        }
    }
}
