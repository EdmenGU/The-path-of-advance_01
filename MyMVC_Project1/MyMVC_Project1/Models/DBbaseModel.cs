using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MyMVC_Project1.Models
{
    //数据库连接
    public class DBbaseModel
    {
        protected static string connName = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }
}