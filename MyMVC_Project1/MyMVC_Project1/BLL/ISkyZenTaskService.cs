using MyMVC_Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVC_Project1.BLL
{
   public interface ISkyZenTaskService
    {
        ResponseModel<SkyZenTask> GetSkyTaskList(SkyZenTask task);
    }
}
