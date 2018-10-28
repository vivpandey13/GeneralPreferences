using System.Collections.Generic;

namespace GerneralPreferences.Controllers
{
    public class DepartmentModel
    {
        public int SelectedDepartment { get; set; }
        public List<Department> Departments { get; set; }
        public DepartmentModel()
        {
            Departments = new List<Department>() {
                new Department{ID=1,Name="Use agency Default", IsSelected=true},
                new Department{ID=2,Name="Use Assigned Agent", IsSelected=false},
                new Department{ID=3,Name="Customize", IsSelected=false},
            };
        }
    }
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}