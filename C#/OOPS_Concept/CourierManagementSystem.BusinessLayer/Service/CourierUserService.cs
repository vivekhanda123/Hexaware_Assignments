using CourierManagementSystem.BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.Entity;
using CourierManagementSystem.BusinessLayer.CustomExceptions;

namespace CourierManagementSystem.BusinessLayer.Service
{
    public class CourierUserService : ICourierUserService
    {
        private List<Courier> courierOrders = new List<Courier>(); // Simulated order storage

        // Place a new courier order and return a unique tracking number
        public string PlaceOrder(Courier courierObj)
        {
            courierOrders.Add(courierObj);
            return courierObj.TrackingNumber;
        }


        public string GetOrderStatus(string trackingNumber)
        {
            Courier order = courierOrders.Find(c => c.TrackingNumber == trackingNumber);
            if (order != null)
            {
                return order.status;
            }
            return "Order not found";
        }

        public bool CancelOrder(string trackingNumber)
        {
            Courier order = courierOrders.Find(c => c.TrackingNumber == trackingNumber);
            //if (order != null && order.status != "Delivered")
            //{
            //    courierOrders.Remove(order);
            //    return true;
            //}
            //return false;
            if (order == null)
            {
                // Throw custom exception if tracking number is not found
                throw new TrackingNumberNotFoundException($"Tracking number {trackingNumber} was not found.");
            }

            if (order.status == "Delivered")
            {
                return false;
            }

            courierOrders.Remove(order);
            return true;
        }

        public List<Courier> GetAssignedOrder(int courierStaffId)
        {
            return courierOrders.FindAll(c => c.userId == courierStaffId);
        }
    }
}
