using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuasCore.Models;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {


        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employee = new List<Employee>();
            Employee employee1 = new Employee();
            employee1.Id = "George";
            employee1.Name = "劉軒志";
            employee1.Age = 20;
            employee.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "Jack";
            employee2.Name = "陳玠任";
            employee2.Age = 20;
            employee.Add(employee2);

            return employee;

        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = null;

            if ("George".Equals(id))
            {
                employee = new Employee();
                employee.Id = "George";
                employee.Name = "劉軒志";
                employee.Age = 20;
            }

            return employee;
        }

    }
}
