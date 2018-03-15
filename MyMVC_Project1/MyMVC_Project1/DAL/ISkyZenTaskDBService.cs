using MyMVC_Project1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVC_Project1.DAL
{
    interface ISkyZenTaskDBService
    {
        DataTable GetSkyTaskList(SkyZenTask task);
    }
}
