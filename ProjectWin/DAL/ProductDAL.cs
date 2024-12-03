using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAL
{
    public class ProductDal
    {
        private static ProductDal _instance;
        public static ProductDal instance => _instance ?? (_instance = new ProductDal());

        private ProductDal()
        {
        }

        public List<Product> GetListProduct()
        {
            using (var ctx = new DbConfig())
            {
                return ctx.products
                    .Include(item => item.category)
                    .Where(item => Constant.Active.Equals(item.status))
                    .ToList();
            }
        }

        public Product GetById(int id)
        {
            using (var ctx = new DbConfig())
            {
                return ctx.products
                    .Include(item => item.category)
                    .FirstOrDefault(item =>
                        item.product_id == id
                        && Constant.Active.Equals(item.status)
                        && Constant.Active.Equals(item.category.status));
            }
        }

        public bool Save(Product p)
        {
            using (var ctx = new DbConfig())
            {
                var pro = ctx.products.FirstOrDefault(item => item.product_id == p.product_id);
                if (pro != null)
                {
                    pro.product_name = p.product_name;
                    pro.price = p.price;
                    pro.description = p.description;
                    pro.product_image = p.product_image;
                    pro.category_id = p.category_id;
                    pro.stock = p.stock;
                    pro.updated_at = DateTime.Now;
                }
                else
                {
                    p.status = Constant.Active;
                    p.created_at = DateTime.Now;
                    p.stock = p.stock;
                    p.sold = 0;
                    ctx.products.Add(p);
                }

                ctx.SaveChanges();
                return true;
            }
        }

        public bool Remove(int productId)
        {
            using (var ctx = new DbConfig())
            {
                var product = ctx.products.FirstOrDefault(item => item.product_id == productId);
                if (product == null) return false;
                product.status = Constant.Inactive;
                return ctx.SaveChanges() > 0;
            }
        }
    }
}