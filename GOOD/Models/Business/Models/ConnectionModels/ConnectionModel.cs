using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GOOD.Models.Business.Models.ConnectionModels
{
    public class ConnectionModel
    {
        public string Host { get; set; }
        public string DataBase { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}