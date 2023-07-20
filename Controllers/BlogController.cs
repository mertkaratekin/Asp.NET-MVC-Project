using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BnazHow.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            //veritabanından bütün blog bilgilerini al ve View üzerine gönder. 
            //Kendisine gelen blog bilgilerini dinamik içerik üreten view yapısı bunu statik html 'e çevirir. 
            
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
     
    }
}