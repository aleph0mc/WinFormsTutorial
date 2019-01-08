using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTreeViewAndListView
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Deptid { get; set; }
    }

    public class DataGenerator
    {
        public static List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department {DeptId=1,DeptName="D1",Location="L1" },
                new Department {DeptId=2,DeptName="D2",Location="L2" },
                new Department {DeptId=3,DeptName="D3",Location="L3" },
            };
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee {EmpId=1, EmpName= "E1",  Deptid=1 },
                new Employee {EmpId=2, EmpName= "E2",  Deptid=2 },
                new Employee {EmpId=3, EmpName= "E3",  Deptid=3 },
                new Employee {EmpId=4, EmpName= "E4",  Deptid=3 },
                new Employee {EmpId=5, EmpName= "E5",  Deptid=1 },
                new Employee {EmpId=6, EmpName= "E6",  Deptid=1 },
                new Employee {EmpId=7, EmpName= "E7",  Deptid=2 },
                new Employee {EmpId=8, EmpName= "E8",  Deptid=3 },
                new Employee {EmpId=9, EmpName= "E9",  Deptid=2 },
                new Employee {EmpId=10, EmpName= "E10", Deptid=1 },
            };
        }
    }

}
