using Database.DataBase;
using GOOD.Models.Business.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOOD.Models.Business.Base
{
    public class BaseMember
    {
        public db_productEntities qDB;
        public bool isResult { get; set; }
        public int totalRow { get; set; }
        public int totalPage { get; set; }

        #region Contructor
        public BaseMember()
        {
            ConnectionBC bc = new ConnectionBC();
            qDB = bc.GetConnection();
            if (qDB != null)
                qDB.Database.CommandTimeout = 180;
        }

        public BaseMember(db_productEntities context)
        {
            qDB = context;
            if (qDB != null)
                qDB.Database.CommandTimeout = 180;
        }
        #endregion
        public class DataMember
        {
            public int User_ID { get; set; }
            public string User_Name { get; set; }
            public string User_Password { get; set; }
            public string User_Email { get; set; }
            public string User_Phone { get; set; }
            public string User_Gender { get; set; }
            public Nullable<bool> User_isAdmin { get; set; }
        }

        public class DataLogin
        {
            public string User_Name { get; set; }
            public string User_Password { get; set; }
        }
    }
}