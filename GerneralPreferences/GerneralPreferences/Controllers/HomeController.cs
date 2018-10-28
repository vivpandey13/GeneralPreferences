using System.Web.Mvc;

namespace GerneralPreferences.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            DepartmentModel department = new DepartmentModel();
            return View(department);
        }

        [HttpPost]
        public string Index(DepartmentModel department)
        {
            if (department.SelectedDepartment == 0)
            {
                return "Please select a dept";
            }
            else
            {
                return department.Departments.Find(x => x.ID == department.SelectedDepartment).Name;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}