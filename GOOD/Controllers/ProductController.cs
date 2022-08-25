using GOOD.Models.Business.Base;
using GOOD.Models.Business.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOOD.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ShowProduct()
        {
            HomeProduct Product = new HomeProduct();
            ViewBag.Product = Product.getProduct();

            return View();
        }
        #region Insert
        [HttpPost]
        public ActionResult Insert(BaseProduct.DataProduct DataProductInput)
        {
            var IDproduct = DataProductInput;
            HomeProduct Product = new HomeProduct();
            var NewInsert = Product.getInsert(IDproduct);
            return Json(NewInsert);
        }
        #endregion

        #region Delete
        [HttpPost]
        public ActionResult Del(BaseProduct.DataProduct DataId)
        {
            var IDproduct = DataId.Product_ID;
            HomeProduct Product = new HomeProduct();
            var ID = Product.getDel(IDproduct);

            return Json(ID);
        }
        #endregion

        #region Edit
        [HttpPost]
        public ActionResult Edit(BaseProduct.DataProduct DataEdit)
        {
            var IDproduct = DataEdit;
            HomeProduct Product = new HomeProduct();
            var NewEdit = Product.getEdit(IDproduct);
            return Json(NewEdit);
        }
        #endregion

        #region Detail
        [HttpPost]
        public ActionResult Detail(BaseProduct.DataProduct DataDetail)
        {
            var IDproduct = DataDetail.Product_ID;
            HomeProduct Product = new HomeProduct();
            var Detail = Product.getDetail(IDproduct);
            return Json(Detail);
        }
        #endregion

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MasterPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}