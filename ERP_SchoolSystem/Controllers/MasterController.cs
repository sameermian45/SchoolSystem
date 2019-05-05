using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_SchoolSystem.Classes.HelperClasses;
using ERP_SchoolSystem.Models;

namespace ERP_SchoolSystem.Controllers
{
    public class MasterController : Controller
    {
        //private SchoolSystemEntites db = new SchoolSystemEntites();
        public JsonResponce JsonResponce = new JsonResponce();
      
        public MasterController()
        {
           
        }
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }


        // get mathdoe   
        [HttpGet]
        public ActionResult DepartmentIndex()
        {
           
            return View();
        }

        [HttpPost]
        public JsonResult DepartmentIndex(FormCollection formCollection)
        {

            try
            {
                using (var db = new SchoolSystemEntites())
                {
                    string SchoolName = formCollection["SchoolName"];
                    string surname =  formCollection["Department"];
                    Department department = new Department()
                    {
                        SchoolId = 1,
                        CreatedBy = 1,
                        IsActive=true,
                        Title = formCollection["Department"]                        
                    };
                    db.Departments.Add(department);
                    db.SaveChanges();
                    JsonResponce.Message = "Record Save Successfully";
                    JsonResponce.ObjectData = department;
                    //JsonResponce.IsError = false;

                }

            }
            catch (Exception ex)
            {
                JsonResponce.IsError = true;
                JsonResponce.ExceptionMessage = ex.Message;
            }
                           
            return Json(JsonResponce);
        }



    }
}