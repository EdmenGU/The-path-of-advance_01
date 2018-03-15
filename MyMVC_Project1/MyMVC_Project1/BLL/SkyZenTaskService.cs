using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMVC_Project1.Models;
using MyMVC_Project1.DAL;
using System.Data;

namespace MyMVC_Project1.BLL
{
    public class SkyZenTaskService : ISkyZenTaskService
    {
        /// <summary>
        /// 创建一个私有的(只在本类中可以使用) 只读的 
        /// </summary>
      private readonly ISkyZenTaskDBService skyZenTaskDBService = new SkyZenTaskDBService();

        public SkyZenTask GetSkyTaskList(SkyZenTask task)
        {
            SkyZenTask skyZenTask = new SkyZenTask();
            DataTable datatable = new DataTable();
            try
            {
                datatable = skyZenTaskDBService.GetSkyTaskList(task);
                skyZenTask = DataTableToModel.ToSingleModel<SkyZenTask>(datatable);
            }
            catch (Exception e)
            {
                throw e;
            }
            return skyZenTask;

        }

    }
}