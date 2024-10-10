using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Entity
{
    public class CourierCompanyCollection
    {
        // store all courier companies dynamically
        private List<CourierCompany> courierCompanies;
        public CourierCompanyCollection()
        {
            courierCompanies = new List<CourierCompany>(); // initializing the list
        }

        // add a new courier company to the collection
        public void AddCourierCompany(CourierCompany company)
        {
            courierCompanies.Add(company);
        }

        //public void RemoveCourierCompany(CourierCompany company)
        //{
        //    courierCompanies.Remove(company);
        //}

        // list of courier companies
        public CourierCompany GetCourierCompany(string companyName)
        {
            return courierCompanies.Find(c => c.CompanyName == companyName);
        }

        // Method to get all courier companies
        public List<CourierCompany> GetAllCourierCompanies()
        {
            return courierCompanies;
        }

    }

}