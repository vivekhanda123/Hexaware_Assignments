using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.Entity;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    public interface ICourierRepository
    {
        // Task 6
        string ToString();
        void DisplayCourierInfo();
    }
}
