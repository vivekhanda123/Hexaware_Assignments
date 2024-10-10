using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.BusinessLayer.Repository;
using CourierManagementSystem.BusinessLayer.Service;
using CourierManagementSystem.Entity;
using CourierManagementSystem.DatabaseLayer;
using CourierManagementSystem.BusinessLayer.CustomExceptions;


namespace CourierManagementSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository er = new EmployeeRepository(101, "Vivek Handa", "vivek@email.com", "2323223232", "admin", 22000);
            EmployeeService es = new EmployeeService(er);


            es.DisplayEmployeeInfo();
            es.ToString();

            CourierRepository cr = new CourierRepository();

            ICourierUserService courierUserService = new CourierUserService();
            ICourierAdminService courierAdminService = new CourierAdminService();

            // Admin adds a new courier staff member
            Employee newEmployee = new Employee { employeeName = "John Doe", email = "john.doe@example.com", contactNumber = "1234567890", role = "Courier", salary = 5000 };
            int employeeId = courierAdminService.AddCourierStaff(newEmployee);
            Console.WriteLine($"Added new courier staff with ID: {employeeId}");

            //int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, double weight, string status, string trackingNumber, DateTime deliveryDate, int userId
            // User places a new order
            Courier courier = new Courier
            {
                courierID = 101,
                senderName = "Alice",
                senderAddress = "123 Main St",
                receiverName = "Bob",
                receiverAddress = "456 Park Ave",
                weight = 10.5,
                status = "Delivered",
                TrackingNumber = "abc101",
                deliveryDate = DateTime.Now.AddDays(2),
                userId = employeeId
            };
            //courier.CourierID = employeeId;
            string TrackingNumber = courierUserService.PlaceOrder(courier);
            Console.WriteLine($"Order placed. Tracking number: {TrackingNumber}");

            // Check order status
            string status = courierUserService.GetOrderStatus(TrackingNumber);
            Console.WriteLine($"Order status: {status}");

            // Cancel the order
            bool cancelResult = courierUserService.CancelOrder(TrackingNumber);
            Console.WriteLine($"Order canceled: {cancelResult}");

            // Task 9 Database connection 
            CourierServiceDb courierServiceDb = new CourierServiceDb();

            // 1. Retrieve all employees
            //courierServiceDb.GetEmployeeDetails();

            // 2. Insert a new employee
            //Employee newE = new Employee
            //{
            //    employeeName = "Happy Singh",
            //    email = "Aditya@example.com",
            //    contactNumber = "1234567890",
            //    role = "Manager",
            //    salary = 75000.00D
            //};
            //courierServiceDb.InsertEmployee(newE);

            // 3. Update an employee's details
            //Employee updateEmployee = new Employee
            //{
            //    employeeID = 1, // Assuming EmployeeID 1 exists
            //    email = "new.email@example.com",
            //    contactNumber = "0987654321",
            //    role = "Senior Manager",
            //    salary = 80000.00D
            //};
            //courierServiceDb.UpdateEmployee(updateEmployee);

            // 4. Delete an employee
            //courierServiceDb.DeleteEmployee(2);  // EmployeeID  is  2 

            // 5. Get the employee with the highest salary
            //courierServiceDb.GetEmployeeWithMaxSalary();


            // Task 7
            CourierUserService courierService = new CourierUserService();

            try
            {
                // Example: Cancel an order by tracking number
                bool orderCancelled = courierService.CancelOrder("TN1234");
                if (orderCancelled)
                {
                    Console.WriteLine("Order successfully cancelled.");
                }
                else
                {
                    Console.WriteLine("Order cannot be cancelled as it is already delivered.");
                }
            }
            catch (TrackingNumberNotFoundException ex)
            {
                // Handle custom exception for tracking number not found
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other general exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End of transaction.");
            }

            // TASK 8 
            CourierCompanyCollection companyCollection = new CourierCompanyCollection();

            // Adding companies
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 1" });
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 2" });
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 3" });

            // list of all courier companies
            List<CourierCompany> companies = companyCollection.GetAllCourierCompanies();

            // Display the list of companies
            Console.WriteLine("List of Courier Companies:");
            foreach (var company in companies)
            {
                Console.WriteLine(company.CompanyName);
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
