using DAL;
using DTO;

namespace BLL
{
    public class LoginBll
    {
        private static LoginBll _instance;

        public static LoginBll instance => _instance ?? (_instance = new LoginBll());

        private LoginBll()
        {
        }

        public CommonMessage DoLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return CommonMessage.Fail("Vui lòng nhập đầy đủ thông tin");
            }

            var u = UserDal.instance.GetByUsername(username);

            if (u == null || (!u.password.Equals(password)))
            {
                return CommonMessage.Fail("Tên đăng nhập hoặc mật khẩu không đúng");
            }

            switch (u.status)
            {
                case Constant.Block:
                    return CommonMessage.Fail("Tài khoản của bạn đã bị khóa");
                case Constant.Inactive:
                    return CommonMessage.Fail("Vui lòng liên hệ quản trị viên để kích hoạt");
                default:
                    return CommonMessage.Success(u);
            }
        }
    }
}