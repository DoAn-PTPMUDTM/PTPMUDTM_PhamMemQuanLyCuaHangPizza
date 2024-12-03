using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAL
{
    public class CommentDal
    {
        // Sigelton
        private static CommentDal _instance;
        public static CommentDal instance => _instance ?? (_instance = new CommentDal());

        private CommentDal() { }

        public List<comment> GetListComment()
        {
            using (var ctx = new DbConfig())
            {
                return ctx.comments
                    .Include(item => item.user)
                    .Include(item => item.product)
                    .ToList();
            }
        }

        public bool Remove(int commentId)
        {
            using (var ctx = new DbConfig())
            {
                var comment = ctx.comments.FirstOrDefault(item => item.comment_id == commentId);
                if (comment == null) return false;
                ctx.comments.Remove(comment);
                return ctx.SaveChanges() > 0;
            }
        }
    }
}
