using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    internal class PaymentRepository : IPaymentRepository
    {
        // Default constructor
        public PaymentRepository() { }

        // Parameterized constructor
        Payment payment = new Payment();
        public PaymentRepository(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            payment.paymentID = paymentID;
            payment.courierID = courierID;
            payment.amount = amount;
            payment.paymentDate = paymentDate;
        }
    }
}
