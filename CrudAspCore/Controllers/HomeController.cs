using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudAspCore.Models;
using System.Data;
using System.Data.SqlClient;
namespace CrudAspCore.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        string msg;
        public IActionResult Index()
        {
            
            Employee emp = new Employee();
            emp.flag = "get";
            DataSet ds = dbop.Empget(emp, out msg);
            DataTable dt = new DataTable();

            List<Employee> list = new List<Employee>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new Employee
                {
                    Sr_no = Convert.ToInt32(dr["Sr_no"]),
                    Emp_name = dr["Emp_name"].ToString(),
                    City = dr["City"].ToString(),
                    State = dr["State"].ToString(),
                    Country = dr["Country"].ToString(),
                    Department = dr["Department"].ToString()
                });
            }
            return View(list);
        }
    }
}