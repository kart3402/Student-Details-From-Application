using Kartavya_Guntewar_Interview_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kartavya_Guntewar_Interview_Assignment.Controllers
{
    public class StudentController : Controller
    {

        Student_detailEntities StudData = new Student_detailEntities();



        public ActionResult Index()
        {
            return View();
        }


        public JsonResult stud()
        {
            List<Student> t = StudData.Students.ToList();
            return Json(t, JsonRequestBehavior.AllowGet);
        }


        public string AddStudent(Student stud)
        {
            StudData.Students.Add(stud);
            StudData.SaveChanges();
            return "Student Add in Database Successfully!!!!!";

        }


        public JsonResult Studentget(int id)
        {
            Student e = StudData.Students.Find(id);
            return Json(e, JsonRequestBehavior.AllowGet);
        }



        public string DeleteStudent(int id)
        {
            Student e = StudData.Students.Find(id);
            StudData.Students.Remove(e);
            StudData.SaveChanges();
            return "Student Deleted Successfully!!!!";
        }

    }
}