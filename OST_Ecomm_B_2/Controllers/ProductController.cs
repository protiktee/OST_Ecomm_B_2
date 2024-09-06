using OST_Ecomm_B_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OST_Ecomm_B_2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SingleProduct()
        {
            return View();
        }
        

        //public ActionResult SingleProduct(int id)
        //{
        //    ProductItem productItem = new ProductItem();
        //    productItem.Title = "Mac M2";
        //    productItem.Description = "Apple Product";
        //    productItem.Specification = "16GB";
        //    productItem.Picture = "";
        //    productItem.Price = "1lk";
        //    productItem.Stock = "10";
        //    productItem.Quantity = "10";
        //    return Json(productItem, JsonRequestBehavior.AllowGet);
        //}
        //public ActionResult ListProduct()
        //{
        //    List<ProductItem> lstProduct= new List<ProductItem>();
        //    //ProductItem productItem = new ProductItem();
        //    //productItem.Title = "Mac M2";
        //    //productItem.Description = "Apple Product";
        //    //productItem.Specification = "16GB";
        //    //productItem.Picture = "";
        //    //productItem.Price = "1lk";
        //    //productItem.Stock = "10";
        //    //productItem.Quantity = "10";

        //    //lstProduct.Add(productItem);

        //    foreach (ProductItem obj in lstProduct)
        //    { 
        //    }

        //    return Json(lstProduct, JsonRequestBehavior.AllowGet);
        //}
    }
}