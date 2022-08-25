using Database.DataBase;
using GOOD.Models.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOOD.Models.Business.Home
{
    public class HomeProduct : BaseProduct
    {
        db_productEntities qDB = new db_productEntities();
        public List<tbcoffeeboy> getProduct()
        {
            List<tbcoffeeboy> Product = qDB.tbcoffeeboys.ToList();

            return Product;
        }
        public tbcoffeeboy getDel(int ProductID)
        {
            var ID = qDB.tbcoffeeboys.Where(w => w.Product_ID == ProductID).FirstOrDefault();
            qDB.tbcoffeeboys.Remove(ID);
            qDB.SaveChanges();

            return ID;
        }
        public tbcoffeeboy getDetail(int ProductID)
        {
            var NewDetail = qDB.tbcoffeeboys.Where(w => w.Product_ID == ProductID).FirstOrDefault();

            return NewDetail;
        }
        public tbcoffeeboy getEdit(DataProduct DataEdit)
        {
            var NewEdit = qDB.tbcoffeeboys.Where(w => w.Product_ID == DataEdit.Product_ID).FirstOrDefault();
            if (NewEdit != null)
            {
                NewEdit.Product_Name = DataEdit.Product_Name;
                NewEdit.Product_Price = DataEdit.Product_Price;
                NewEdit.Product_Detail = DataEdit.Product_Detail;
                qDB.SaveChanges();
            }

            return NewEdit;
        }
        public tbcoffeeboy getInsert(DataProduct DataInsert)
        {
            tbcoffeeboy Newproduct = new tbcoffeeboy();
            Newproduct.Product_Name = DataInsert.Product_Name;
            Newproduct.Product_Price = DataInsert.Product_Price;
            Newproduct.Product_Detail = DataInsert.Product_Detail;
            qDB.tbcoffeeboys.Add(Newproduct);
            qDB.SaveChanges();

            return Newproduct;
        }
    }
}