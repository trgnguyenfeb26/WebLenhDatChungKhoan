using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "LENHDATKHOP");
        }
   
        [HttpPost]
        public ActionResult Create(DatLenh model)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    String connectionString = @"Server=DESKTOP-O30665V;Database=CK;User Id=sa;Password=123;";
                    using (var conn = new SqlConnection(connectionString))
                    using (var command = new SqlCommand("SP_KHOPLENH_LO", conn)
                    {
                        CommandType = CommandType.StoredProcedure

                    })
                    {
                        command.Parameters.Add("@macp", SqlDbType.NVarChar, 50).Value = model.Macp.ToUpper();
                        command.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@LoaiGD", SqlDbType.NVarChar, 1).Value = model.LoaiGD;
                        command.Parameters.Add("@soluongMB", SqlDbType.Int).Value = model.soluongMB;
                        command.Parameters.Add("@giadatMB", SqlDbType.Int).Value = model.giadatMB;
                        conn.Open();
                        for (int i = 0; i < model.NhanLenh; i++) command.ExecuteNonQuery();
                        conn.Close();
                   
                    }
                }
                else
                {
                    return Content("không kết nối database");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
            return RedirectToAction("Index", "LENHDATKHOP");
        }
    }
}