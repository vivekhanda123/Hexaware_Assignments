using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.CustomExceptions
{
    public class InvalidEmployeeIdException : Exception
    {
        // Default constructor
        public InvalidEmployeeIdException() : base("Invalid employee ID. Employee does not exist in the system.")
        {
        }

        // Constructor that takes a custom message
        public InvalidEmployeeIdException(string message) : base(message)
        {
        }

        // Constructor that takes a custom message and an inner exception
        public InvalidEmployeeIdException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
