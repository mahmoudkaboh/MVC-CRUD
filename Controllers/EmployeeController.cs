using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEmp.Models;
namespace MvcEmp.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){ID =10 ,Name="Ahmed",Age=25,Department="CS",City="Cairo",Address="philiphnes" },
            new Employee(){ID =20 ,Name="Sara",Age=30,Department="IS",City="Alex",Address="Myami"},
            new Employee(){ID =30 ,Name="Ola",Age=20,Department="OR",City="Banha",Address="philiphnes" },
            new Employee(){ID =40 ,Name="Mahmoud",Age=23,Department="IS",City="Menouf",Address="King" },
            new Employee(){ID =50 ,Name="Moazz",Age=13,Department="IS",City="Cairo",Address="philiphnes"},
            new Employee(){ID =60 ,Name="Yasmeen",Age=19,Department="CS",City="Cairo",Address="Montzah"},
        };
        // GET: List of Employee
        public ActionResult Index()
        {
            return View(employees);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            employees.Add(e);
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
            
        }
        public ActionResult Update(int id)
        {
            Employee e = employees.FirstOrDefault(x => x.ID == id);

            return View(e);
        }
        [HttpPost]
        public ActionResult Update(Employee e)
        {
            Employee old = employees.FirstOrDefault(x => x.ID == e.ID);
            if (old != null)
            {
                
                old.Name = e.Name;
                old.Age = e.Age;
                old.Department = e.Department;
                old.City = e.City;
                old.Address = e.Address;
            }

            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            Employee e = employees.FirstOrDefault(x => x.ID == id);
            employees.Remove(e);
            return RedirectToAction(nameof(Index));
        }



    }
}