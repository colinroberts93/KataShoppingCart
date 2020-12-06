﻿using KataShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KataShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}