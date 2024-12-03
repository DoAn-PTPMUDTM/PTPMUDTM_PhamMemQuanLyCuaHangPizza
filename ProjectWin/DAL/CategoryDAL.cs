using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAL
{
    public class CategoryDal
    {
        private static CategoryDal _instance;
        public static CategoryDal instance => _instance ?? (_instance = new CategoryDal());

        private CategoryDal()
        {
        }

        public List<Category> GetListCategory()
        {
            using (var ctx = new DbConfig())
            {
                return ctx.categories
                    .Where(item => Constant.Active.Equals(item.status))
                    .ToList();
            }
        }

        public Category GetById(int id)
        {
            using (var ctx = new DbConfig())
            {
                return ctx.categories
                    .FirstOrDefault(item => item.category_id == id && Constant.Active.Equals(item.status));
            }
        }

        public bool Save(Category c)
        {
            using (var ctx = new DbConfig())
            {
                var cat = ctx.categories.FirstOrDefault(item => item.category_id == c.category_id);
                if (cat != null)
                {
                    cat.category_name = c.category_name;
                    cat.description = c.description;
                    cat.updated_at = DateTime.Now;
                }
                else
                {
                    c.status = Constant.Active;
                    c.created_at = DateTime.Now;
                    ctx.categories.Add(c);
                }

                return ctx.SaveChanges() > 0;
            }
        }

        public bool Remove(int categoryId)
        {
            using (var ctx = new DbConfig())
            {
                var category = ctx.categories.FirstOrDefault(item => item.category_id == categoryId);
                if (category == null) return false;
                category.status = Constant.Inactive;
                return ctx.SaveChanges() > 0;
            }
        }
    }
}