using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.Entity;

namespace CourierManagementSystem.BusinessLayer.Service
{
    public class CourierAdminService : ICourierAdminService
    {
        private List<Employee> employees = new List<Employee>(); // Simulated staff storage
        private static int employeeCounter = 100; // Simulated employee ID generator

        // Add a new courier staff member and return their ID
        public int AddCourierStaff(Employee obj)
        {
            obj.employeeID = ++employeeCounter;
            employees.Add(obj);
            return obj.employeeID;
        }
    }
}
