using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class CategoryBll
    {
        private static CategoryBll _instance;
        public static CategoryBll instance => _instance ?? (_instance = new CategoryBll());

        private CategoryBll()
        {
        }


        public List<Category> FindAll()
        {
            return CategoryDal.instance.GetListCategory();
        }

        private string Save(Category c)
        {
            return CategoryDal.instance.Save(c)
                ? Constant.Success
                : Constant.Fail;
        }

        public CommonMessage Save(string cateId, string cateName, string cateDes)
        {
            if (string.IsNullOrEmpty(cateName))
            {
                return CommonMessage.Fail("Tên loại sản phẩm không được để trống");
            }

            var category = new Category
            {
                category_name = cateName,
                description = cateDes
            };

            if (!string.IsNullOrEmpty(cateId))
            {
                category.category_id = Convert.ToInt32(cateId);
            }

            return CategoryDal.instance.Save(category)
                ? CommonMessage.Success("Lưu thành công")
                : CommonMessage.Fail("Lưu thất bại");
        }

        public CommonMessage Remove(string cateId)
        {
            if (string.IsNullOrEmpty(cateId))
            {
                return CommonMessage.Fail("Mã loại sản phẩm không được để trống");
            }

            var category = CategoryDal.instance.GetById(Convert.ToInt32(cateId));
            if (category == null)
            {
                return CommonMessage.Fail("Không tìm thấy loại sản phẩm");
            }

            return CategoryDal.instance.Remove(Convert.ToInt32(cateId))
                ? CommonMessage.Success("Xóa thành công")
                : CommonMessage.Fail("Xóa thất bại");
        }
    }
}