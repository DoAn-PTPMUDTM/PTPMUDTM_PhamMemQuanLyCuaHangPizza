using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class CommentBll
    {
        private static CommentBll _instance;
        public static CommentBll instance => _instance ?? (_instance = new CommentBll());

        private CommentBll()
        {
        }

        public List<comment> FindAll()
        {
            return CommentDal.instance.GetListComment();
        }

        public CommonMessage Remove(string commentId)
        {
            if (string.IsNullOrEmpty(commentId))
            {
                return CommonMessage.Fail("Mã bình luận không được để trống");
            }

            return CommentDal.instance.Remove(Convert.ToInt32(commentId))
                ? CommonMessage.Success("Xóa thành công")
                : CommonMessage.Fail("Xóa thất bại");
        }
    }
}