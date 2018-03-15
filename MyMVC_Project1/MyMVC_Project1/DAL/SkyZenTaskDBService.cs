using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MyMVC_Project1.Models;
using MySql.Data.MySqlClient;

namespace MyMVC_Project1.DAL
{
    public class SkyZenTaskDBService : DBbaseModel, ISkyZenTaskDBService
    {
        public DataTable GetSkyTaskList(SkyZenTask task)
        {
            DataTable datatable = new DataTable();
            string sql = "select * from tb_sys_task where id=@id";
            using (MySqlConnection conn = new MySqlConnection(connName))
            {
                MySqlParameter[] map = new MySqlParameter[] {
                    new MySqlParameter("@id",task.id)
                };
                conn.Open();
                try
                {
                    MySqlDataReader read = MySqlHelper.ExecuteReader(conn, sql, map);
                    datatable.Load(read);
                }
                catch (Exception e)
                {
                    throw;
                }
                return datatable;
            }
        }
    }
}