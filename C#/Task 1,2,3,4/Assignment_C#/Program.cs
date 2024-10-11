using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace AssignmentWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n Choose an Option: ");
                Console.WriteLine("1. Check Order Status: ");
                Console.WriteLine("2. Categorize Parcel by Weight: ");
                Console.WriteLine("3. User Authentication: ");
                Console.WriteLine("4. Assign Courier to Shipment: ");
                Console.WriteLine("5. Display Customer Orders (For Loop)");
                Console.WriteLine("6. Track Courier Location (While Loop)");
                Console.WriteLine("7. Store Tracking History in Array");
                Console.WriteLine("8. Find Nearest Available Courier");
                Console.WriteLine("9. Parcel Tracking with 2D Array");
                Console.WriteLine("10. Validate Customer Data");
                Console.WriteLine("11. Format Address");
                Console.WriteLine("12. Generate Order Confirmation Email");
                Console.WriteLine("13. Calculate Shipping Cost");
                Console.WriteLine("14. Generate Secure Password");
                Console.WriteLine("15. Find Similar Addresses");
                Console.WriteLine("16. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CheckOrderStatus();
                        break;
                    case 2:
                        CategorizeParcel();
                        break;
                    case 3:
                        UserAuthentication();
                        break;
                    case 4:
                        AssignCourier();
                        break;
                    case 5:
                        DisplayCustomerOrders();
                        break;
                    case 6:
                        TrackCourierLocation();
                        break;
                    case 7:
                        StoreTrackingHistory();
                        break;
                    case 8:
                        FindNearestCourier();
                        break;
                    case 9:
                        ParcelTracking();
                        break;
                    case 10:
                        ValidateCustomerData();
                        break;
                    case 11:
                        FormatAddress();
                        break;
                    case 12:
                        GenerateOrderConfirmationEmail();
                        break;
                    case 13:
                        CalculateShippingCost();
                        break;
                    case 14:
                        GenerateSecurePassword();
                        break;
                    case 15:
                        FindSimilarAddresses();
                        break;
                    case 16:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }

            }
        }
        //Task 1: Control Flow Statements
        // Task 1 Question 1
        static void CheckOrderStatus()
        {
            Console.WriteLine("Enter order status like Processing, Delivered, Cancelled:");
            string status = Console.ReadLine();

            if (status == "Delivered")
            {
                Console.WriteLine("The order has been delivered.");
            }
            else if (status == "Processing")
            {
                Console.WriteLine("The order is in processing stage.");
            }
            else if (status == "Cancelled")
            {
                Console.WriteLine("The order has been cancelled");
            }
            else
            {
                Console.WriteLine("Invalid status");
            }
        }

        // Task 1 Question 2
        static void CategorizeParcel()
        {
            Console.WriteLine("\nEnter the parcel weight in kg:");
            double weight = Convert.ToDouble(Console.ReadLine());

            switch (weight)
            {
                case double w when (w < 3):
                    Console.WriteLine("The parcel is of 'Light' category");
                    break;

                case double w when (w >= 3 && w <= 7):
                    Console.WriteLine("The parcel is of 'Medium' category");
                    break;

                case double w when (w > 7):
                    Console.WriteLine("The parcel is of 'Large' category");
                    break;

                default:
                    Console.WriteLine("Invalid Weight");
                    break;
            }
        }

        // Task 1 Question 3
        static void UserAuthentication()
        {
            Console.WriteLine("Enter your role like Employee or Customer or Developer");
            string role = Console.ReadLine().ToLower();

            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (role == "developer" && userName == "developer123" && password == "pass123")
            {
                Console.WriteLine("Developer logged in successfully.");
            }
            else if (role == "customer" && userName == "customer123" && password == "pass123")
            {
                Console.WriteLine("Customer logged in successfully");
            }
            else if (role == "tester" && userName == "tester123" && password == "pass123")
            {
                Console.WriteLine("Tester logged in successfully");
            }
            else
            {
                Console.WriteLine("Invalid login credentials.");
            }
        }

        // Task 1 Question 4
        static void AssignCourier()
        {
            string[] couriers = { "Courier1", "Courier2", "Courier3" };
            int[] proximity = { 10, 5, 15 }; // proximity in km
            int[] loadCapacity = { 20, 10, 30 }; // max load capacity in kg

            Console.WriteLine("\nEnter shipment weight in kg: ");
            int shipmentWeight = Convert.ToInt32(Console.ReadLine());

            int assignedCourier = -1;
            for (int i = 0; i < couriers.Length; i++)
            {
                if (shipmentWeight <= loadCapacity[i])
                {
                    if (assignedCourier == -1 || proximity[i] < proximity[assignedCourier])
                    {
                        assignedCourier = i;
                    }
                }
            }

            if (assignedCourier != -1)
            {
                Console.WriteLine($"The shipment is assigned to {couriers[assignedCourier]} (Proximity: {proximity[assignedCourier]} km, Load Capacity: {loadCapacity[assignedCourier]} kg).");
            }
            else
            {
                Console.WriteLine("No courier available to handle the shipment.");
            }
        }

        //Task 2: Loops and Iteration
        // Task 2 Question 5 Display Customer Orders (For Loop)
        static void DisplayCustomerOrders()
        {
            string[] orders = { "Order1: Book", "Order2: Laptop", "Order3: Phone" };
            Console.WriteLine("\nCustomer Orders:");
            for (int i = 0; i < orders.Length; i++)
            {
                Console.WriteLine(orders[i]);
            }
        }

        // Task 2 Question 6 Track Courier Location (While Loop)
        static void TrackCourierLocation()
        {
            string[] locations = { "Warehouse", "In Transit", "Out for Delivery", "Delivered" };
            int i = 0;
            while (i < locations.Length)
            {
                Console.WriteLine("Courier location is currently: {0}", locations[i]);
                if (locations[i] == "Delivered") break;
                i++;
            }
        }

        //Task 3: Arrays and Data Structures
        // Task 3 Question 7 Store Tracking History in Array
        static void StoreTrackingHistory()
        {
            string[] trackingHistory = { "Location1: Dispatched", "Location2: In Transit", "Location3: Out for Delivery", "Location4: Delivered" };
            Console.WriteLine("\nTracking History:");
            foreach (var location in trackingHistory)
            {
                Console.WriteLine(location);
            }
        }

        // Task 3 Question 8 Find Nearest Courier
        static void FindNearestCourier()
        {
            string[] couriers = { "Courier1", "Courier2", "Courier3" };
            int[] distances = { 10, 5, 20 };
            int minIndex = 0;
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] < distances[minIndex])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"Nearest courier is {couriers[minIndex]} at {distances[minIndex]} km");
        }

        //Task 4: Strings,2d Arrays, user defined functions,Hashmap
        // Task 4 Question 9 Parcel Tracking with 2D Array
        static void ParcelTracking()
        {
            string[,] parcels =
            {
                {"123", "In Transit"},
                {"456", "Out for Delivery"},
                {"789", "Delivered"}
            };
            Console.WriteLine("\nEnter your Tracking Number: ");
            string trackingNumber = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < parcels.GetLength(0); i++)
            {
                if (parcels[i, 0] == trackingNumber)
                {
                    Console.WriteLine($"Parcel {trackingNumber} is {parcels[i, 1]}.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Tracking number not found");
            }
        }

        // Task 4 Question 10 Validate Customer Data
        static void ValidateCustomerData()
        {
            Console.WriteLine("\nEnter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("\nEnter phone number (format ###-###-####): ");
            string phoneNumber = Console.ReadLine();


            if (Regex.IsMatch(name, @"^[A-Za-z]+$") && char.IsUpper(name[0]))
            {
                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Invalid name.");
            }

            if (!Regex.IsMatch(address, @"[^A-Za-z0-9\s]"))
            {
                Console.WriteLine("Address is valid.");
            }
            else
            {
                Console.WriteLine("Invalid address.");
            }

            if (Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Invalid phone number.");
            }
        }

        // Task 4 Question 11 Format Address
        static void FormatAddress()
        {
            Console.WriteLine("\nEnter street: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zip code: ");
            string zip = Console.ReadLine();

            string formattedAddress = $"{Capitalize(street)}, {Capitalize(city)}, {Capitalize(state)}, {zip}";
            Console.WriteLine($"Formatted Address: {formattedAddress}");
        }

        static string Capitalize(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }

        // Task 4 Question 12  Generate Order Confirmation Email
        static void GenerateOrderConfirmationEmail()
        {
            Console.WriteLine("\nEnter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter order number: ");
            string orderNumber = Console.ReadLine();
            Console.WriteLine("Enter delivery address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter expected delivery date: ");
            string deliveryDate = Console.ReadLine();

            string email = $"Dear {name},\nYour order {orderNumber} will be delivered to {address} by {deliveryDate}.";
            Console.WriteLine($"\nOrder Confirmation Email:\n{email}");
        }

        //  Task 4 Question 13 Calculate Shipping Cost
        static void CalculateShippingCost()
        {
            Console.WriteLine("\nEnter source address: ");
            string source = Console.ReadLine();
            Console.WriteLine("Enter destination address: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter parcel weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Calculation of the shipping cost of the customer
            double costPerKm = 0.5;
            double distance = new Random().Next(10, 100);
            double cost = distance * weight * costPerKm;

            Console.WriteLine($"Shipping cost from {source} to {destination} for a {weight} kg parcel is: {cost}");
        }

        // Task 4 Question 14 Generate Secure Password
        static void GenerateSecurePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            var random = new Random();
            string password = new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine($"Generated Secure Password: {password}");
        }

        //  Task 4 Question 15 Find Similar Addresses
        static void FindSimilarAddresses()
        {
            string[] addresses = { "1, Lal bagh", "2, Lal bagh", "3, Lal bagh", "4, Lal bagh" };
            Console.WriteLine("\nEnter address to search: ");
            string inputAddress = Console.ReadLine();

            var similarAddress = addresses.Where(a => a.ToLower().Contains(inputAddress)).ToList();
            if (similarAddress.Count > 0)
            {
                Console.WriteLine("Similar Address found");
            }
            else
            {
                Console.WriteLine("No similar address found");
            }
        }
    }
}
