using ERP_SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_SchoolSystem.Controllers
{
    public class SchoolController : Controller
    {
        ERP_SchoolSystemEntities db = new ERP_SchoolSystemEntities();
        public ActionResult AddNewSchool()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewSchool(string SchoolName , string SRPersonName ,int Country , int City , string RegistrationNo, string PtclNo , string CellNo2
            ,int IsActive, DateTime RegistrationDate , string SROffiersContactNo , int Province , string Address , string NTNNo , string CellNo1 , string Email,
            string Website , HttpPostedFileBase SchoolLogo)
        {
            try
            {
                ViewBag.SuccessMessage = "New School Successfully Added";
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message.ToString();
            }
            return View();
        }

        public PartialViewResult GetProvincesList(int CountryID)
        {
            try
            {
                var ProvincesList = db.TblProvinces.Where(x=>x.CountryID == CountryID).ToList();
                return PartialView("GetProvincesList", ProvincesList);
            }
            catch (Exception ex)
            {
                return PartialView(null);
            }
        }
        public PartialViewResult GetCitiesList(int ProvinceID)
        {
            try
            {
                var CitiesList = db.TblCities.Where(x=>x.ProvincesID == ProvinceID).ToList();
                return PartialView("GetCitiesList", CitiesList);
            }
            catch (Exception ex)
            {
                return PartialView(null);
            }
        }
    }
}