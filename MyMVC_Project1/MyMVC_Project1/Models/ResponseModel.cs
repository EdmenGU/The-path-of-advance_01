using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC_Project1.Models
{
    public class ResponseModel<T>
    {
        public string message { get; set; }

        public int code { get; set; }

        public List<T> result { get; set; }

        public T resultInfo{ get; set; }
}
}