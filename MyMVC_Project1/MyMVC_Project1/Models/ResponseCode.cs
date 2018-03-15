using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyMVC_Project1.Models
{
    public enum ResponseCode
    {
        [Description("请求成功")]
        Success =0000,
        [Description("请求失败")]
        field =4000
    }
}