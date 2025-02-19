﻿using ProjectWeb.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWeb.ViewModel
{
    public class ProductViewModel
    {
        public product product;
        public List<category> categories;
        public IPagedList<product> listProduct;
        public policy policy;
        public comment cmt;
        public rating rate;
        public List<comment> listComment;
        public int numberRating;
        public int fullStars;
        public int halfStars;
        public int emptyStars;
        public string textSearch { get; set; }
        public int? cate { get; set; }

        public ProductViewModel(List<category> listCate, product p = null)
        {
            this.product = p;
            this.categories = listCate;
        }
        public ProductViewModel() { }
        public ProductViewModel(IPagedList<product> list, List<category> listCate, int? cate) { this.listProduct = list; this.categories = listCate; this.cate = cate; }

        public ProductViewModel(product pro, policy p, comment c, List<comment> listCmt, rating r, int numberRating, int f, int h, int e)
        {
            this.product = pro;
            this.policy = p;
            this.cmt = c;
            this.listComment = listCmt;
            this.rate = r;
            this.numberRating = numberRating;
            this.fullStars = f;
            this.halfStars = h;
            this.emptyStars = e;
        }
    }
}