//using Assignmint_oop_03;
//using Assignmint_opp04;

//namespace Assignment_opp02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //#region Q1
//            //            //            a) Abstraction

//            //            What is Abstraction in Object - Oriented Programming?

//            //Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object.
//            //b) Why is Abstraction considered one of the four pillars of OOP?

//            //Abstraction is one of the four pillars of OOP because it helps hide complex implementation details, reduce complexity, and focus on the essential features of an object.
//            //            #endregion
//            //            #region Q2
//            ////             Abstract Classes vs. Interfaces


//            //b) When would you choose an Interface instead of an Abstract Class?

//            //We choose an Interface when we want to define a common behavior or capability that different classes should implement, without requiring them to share the same base class.

//            //For example:
//            // b)Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

//            //No, a class cannot inherit from multiple classes in C#.

//            //However, a class can implement multiple interfaces.

//            //For example, a shipment can implement both:


//            //    #endregion


//            //#endregion
//            Console.Write("Enter Delivery Center Name: ");
//            string centerName = Console.ReadLine();

//            DeliveryCenter center = new DeliveryCenter(centerName);

//            DeliveryAddress addr = new DeliveryAddress { City = "Cairo", Strreet = "Tahrir", Building = "10" };

//            center.AddShipment(new StandarShipment("SH001", "Laptop", 3, 80, addr));
//            center.AddShipment(new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr, 30));
//            center.AddShipment(new InternationalShipment("SH003", "Television", 8, 120, addr, "Germany", 100));

//            center.PrintAllShipment();

//            Console.Write("\nEnter Tracking Code to Remove: ");
//            string codeToRemove = Console.ReadLine();

//            if (center.RemoveShipment(codeToRemove))
//            {
//                Console.WriteLine("\nShipment Removed Successfully.\n");
//            }

//            center.PrintAllShipment();

//            Console.WriteLine("==================================");
//            Console.WriteLine("Testing sealed class & sealed Method...\n");

//            CompletedShipment completed = new CompletedShipment("SH999", "Delivered package", 4.50m, 50m, addr, DateTime.Now);
//            Console.WriteLine($"Completed Shipment Created for Date : {completed.compeletDate.ToShortDateString()}");

//            PriorityInternationalShipment priority = new PriorityInternationalShipment("SH004", "Express tv", 10, 150, addr, "France", 120);
//            priority.GenerateCustomsReport();

       
//            Console.WriteLine("\n==================================");
//            Console.WriteLine("Testing ITrackable & IInsurable Interfaces\n");

          
//            ITrackable[] trackableShipments = {
//                new StandarShipment("SH001", "Laptop", 3, 80, addr),
//                new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr, 30),
//                new InternationalShipment("SH003", "Television", 8, 120, addr, "Germany", 100)
//            };

//            Console.WriteLine("--- Tracking Statuses ---");
//            foreach (var item in trackableShipments)
//            {
//                DeliveryReport.PrintSiipment(item);
//            }

//            IInsurable[] insurableShipments = {
//                new StandarShipment("SH001", "Laptop", 3, 80, addr),
//                new ExpressShipment("SH002", "Mobile Phone", 2, 60, addr, 30),
//                new InternationalShipment("SH003", "Television", 8, 120, addr, "Germany", 100)
//            };

//            Console.WriteLine("\n--- Insurance Calculations ---");
//            foreach (var item in insurableShipments)
//            {
//                DeliveryReport.PrintSiipment(item);
//            }
//        }
//    }
//}
