using Database.DataBase;
using GOOD.Models.Business.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOOD.Models.Business.Base
{
    public class BaseProduct
    {
        public db_productEntities qDB;
        public bool isResult { get; set; }
        public int totalRow { get; set; }
        public int totalPage { get; set; }

        #region Contructor
        public BaseProduct()
        {
            ConnectionBC bc = new ConnectionBC();
            qDB = bc.GetConnection();
            if (qDB != null)
                qDB.Database.CommandTimeout = 180;
        }

        public BaseProduct(db_productEntities context)
        {
            qDB = context;
            if (qDB != null)
                qDB.Database.CommandTimeout = 180;
        }
        #endregion

        public class DataProduct
        {
            public int Product_ID { get; set; }
            public string Product_Name { get; set; }
            public string Product_Price { get; set; }
            public string Product_Detail { get; set; }
        }
    }
}