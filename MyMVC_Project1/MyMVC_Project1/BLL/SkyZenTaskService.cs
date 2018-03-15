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
        SkyZenTaskDBService skyZenTaskDBService = new SkyZenTaskDBService();

        public ResponseModel<SkyZenTask> GetSkyTaskList(SkyZenTask task)
        {
            ResponseModel<SkyZenTask> respon = new ResponseModel<SkyZenTask>();
            SkyZenTask skyZenTask = new SkyZenTask();
            DataTable datatable = new DataTable();
            try
            {
                datatable = skyZenTaskDBService.GetSkyTaskList(task);
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    var row = datatable.Rows[i];
                    skyZenTask.id = int.Parse(row[0].ToString());
                }
                respon.code = (int)ResponseCode.Success;
                respon.resultInfo = skyZenTask;
            }
            catch (Exception)
            {

                throw;
            }
            return respon;

        }
    }
}