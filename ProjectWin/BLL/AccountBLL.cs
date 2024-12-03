using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBll
    {
        private static AccountBll _instance;
        public static AccountBll instance
        {
            get => _instance ?? (_instance = new AccountBll());
            private set => _instance = value;
        }

        private AccountBll() { }

        public List<User> FindAll()
        {
            return UserDal.instance.GetListUser();
        }

        public CommonMessage Save(string id, string fullname, string email, string password)
        {
            if (InvalidPassword(password))
            {
                return CommonMessage.Fail(@"Mật khẩu phải có ít nhất 8 ký tự, ít nhất 1 chữ số, 1 chữ hoa, 1 chữ thường và 1 ký tự đặc biệt");
            }

            if(!email.Contains("@"))
            {
                return CommonMessage.Fail("Email không hợp lệ");
            }

            var u = new User
            {
                email = email,
                password = password,
                full_name = fullname,
                role = Constant.Staff,
                status = Constant.Active,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            };

            if (!string.IsNullOrEmpty(id))
            {
                u.user_id = Convert.ToInt32(id);
            }

            return UserDal.instance.Save(u)
                ? CommonMessage.Success("Thành công")
                : CommonMessage.Fail(@"Thất bại");
        }

        public CommonMessage Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return CommonMessage.Fail(@"Vui lòng chọn nhân viên cần xóa");
            }

            return UserDal.instance.Remove(Convert.ToInt32(id))
                ? CommonMessage.Success(@"Xóa nhân viên thành công")
                : CommonMessage.Fail(@"Xóa nhân viên thất bại");
        }

        private bool InvalidPassword(string password)
        {
            // Kiểm tra mật khẩu theo yêu cầu của bạn
            // Mật khẩu phải có ít nhất 8 ký tự, ít nhất 1 chữ số, 1 chữ hoa, 1 chữ thường và 1 ký tự đặc biệt
            var pattern = new Regex("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!#$%^&*()\\-_=+{};:,<.>/?]).{8,}");
            return !pattern.IsMatch(password);
        }
    }
}
