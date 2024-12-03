using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class ProductBll
    {
        private static ProductBll _instance;
        public static ProductBll instance => _instance ?? (_instance = new ProductBll());

        private ProductBll()
        {
        }

        public List<Product> FindAll()
        {
            return ProductDal.instance.GetListProduct();
        }

        private string Save(Product p)
        {
            return ProductDal.instance.Save(p)
                ? Constant.Success
                : Constant.Fail;
        }

        public CommonMessage Save(string productId,
            string productName,
            string productImage,
            string description,
            int cateId,
            decimal price,
            decimal stock)
        {
            if (string.IsNullOrEmpty(productName))
            {
                return CommonMessage.Fail("Vui lòng nhập tên sản phẩm");
            }

            var p = new Product
            {
                product_name = productName,
                product_image = productImage,
                price = price,
                stock = Convert.ToInt32(stock),
                sold = 0,
                status = Constant.Active,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                description = description,
                category_id = cateId
            };

            if (!string.IsNullOrEmpty(productId))
            {
                p.product_id = Convert.ToInt32(productId);
            }

            var result = Save(p);

            return Constant.Success.Equals(result)
                ? CommonMessage.Success("Thành công")
                : CommonMessage.Fail("Thất bại");
        }

        public CommonMessage Remove(string pid)
        {
            if (string.IsNullOrEmpty(pid))
            {
                return CommonMessage.Fail("Mã sản phẩm không được để trống");
            }

            var product = ProductDal.instance.GetById(Convert.ToInt32(pid));
            if (product == null)
            {
                return CommonMessage.Fail("Sản phẩm không tồn tại");
            }

            return ProductDal.instance.Remove(Convert.ToInt32(pid))
                ? CommonMessage.Success(null)
                : CommonMessage.Fail("Xóa thất bại");
        }
    }
}