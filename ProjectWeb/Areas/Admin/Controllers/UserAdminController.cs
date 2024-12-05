using ProjectWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectWeb.Areas.Admin.Controllers
{
    public class UserAdminController : Controller
    {
        // GET: Admin/UserAdmin
        public ActionResult Index()
        {
            using (var ctx = new DBContext())
            {
                var list = ctx.users.Where(item => !"admin".Equals(item.role) && !"inactive".Equals(item.status)).ToList();
                return View(list);
            }
        }

        public ActionResult Add()
        {
            return View(new user()
            {
                role = "staff",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
            });
        }

        public async Task<ActionResult> Edit(int id)
        {
            using (var ctx = new DBContext())
            {
                var u = await ctx.users.FirstOrDefaultAsync(item => item.user_id == id);
                if (u == null) return RedirectToAction("Index");
                return View(u);
            }
        }

        [HttpPost]
        public async Task<ActionResult> doAdd(user u)
        {
            using (var ctx = new DBContext())
            {
                var existUser = await ctx.users.FirstOrDefaultAsync(item => item.email.Equals(u.email));
                if (existUser != null)
                {
                    TempData["error"] = "Email đã tồn tại";
                    return View("Add", u);
                }
                if (!IsPasswordValid(u.password))
                {
                    TempData["error"] = "Mật khẩu phải có ít nhất 8 ký tự, ít nhất 1 chữ số, 1 chữ hoa, 1 chữ thường và 1 ký tự đặc biệt.";
                    return View("Add", u);
                }

                u.created_at = DateTime.Now;
                u.updated_at = DateTime.Now;
                u.role = "staff";
                ctx.users.Add(u);
                await ctx.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> doUpdate(user u)
        {
            using (var ctx = new DBContext())
            {
                var existUser = await ctx.users.FirstOrDefaultAsync(item => item.user_id == u.user_id);
                if (existUser != null)
                {
                    if (!existUser.password.Equals(u.password))
                    {
                        if (!IsPasswordValid(u.password))
                        {
                            TempData["error"] = "Mật khẩu phải có ít nhất 8 ký tự, ít nhất 1 chữ số, 1 chữ hoa, 1 chữ thường và 1 ký tự đặc biệt.";
                            return View("Edit", u);
                        }
                        existUser.password = u.password;
                    }

                    existUser.full_name = u.full_name;
                    existUser.updated_at = DateTime.Now;
                    await ctx.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
        }

        public async Task<ActionResult> Block(int id)
        {
            return await updateStatus(id, "block");
        }
        public async Task<ActionResult> unBlock(int id)
        {
            return await updateStatus(id, "active");
        }

        public async Task<ActionResult> Delete(int id)
        {
            return await updateStatus(id, "inactive");
        }

        private async Task<ActionResult> updateStatus(int id, string status)
        {
            using (var ctx = new DBContext())
            {
                var user = await ctx.users.FirstOrDefaultAsync(item => item.user_id == id);
                if (user != null)
                {
                    user.status = status;
                    await ctx.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }

        private bool IsPasswordValid(string password)
        {
            // Kiểm tra mật khẩu theo yêu cầu của bạn
            Regex pattern = new Regex("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!#$%^&*()\\-_=+{};:,<.>/?]).{8,}");
            return pattern.IsMatch(password);
        }
    }
}