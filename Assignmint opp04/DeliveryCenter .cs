//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Text;

//namespace Assignment_opp02
//{
//    internal class DeliveryCenter

//    {
//        public string CenterName { get; set; }
//        private Shipment[] shipments = new Shipment[20];
//        private int count = 0;

//        public DeliveryCenter(string centerName)
//        {
//            CenterName = centerName;
//        }
//        public Shipment this[string trackingCode]
//        {
//            get
//            {
//                for (int i = 0; i < count; i++)
//                {
//                    if (shipments[i].TrackingCode == trackingCode)
//                        return shipments[i];
//                }
//                return null;

//            }
//        }
//        public bool AddShipment(Shipment shipment)
//        {
//            if (shipments == null || count <= shipments.Length)
//                return false;
//            shipments[count++] = shipment;
//            return true;
//        }

//        public bool RemoveShipment(string trackingCode)
//        {
//            for (int i = 0; i < count; i++)
//            {

//                if (shipments[i].TrackingCode == trackingCode)
//                {

//                    for (int j = i; j < count - 1; j++)
//                    {
//                        shipments[j] = shipments[j + 1];
//                    }

//                    shipments[count - 1] = null;
//                    count--;
//                    return true;
//                }
//            }


//            return false;
//        }
//        public void PrintAllShipment()
//        {
//            Console.WriteLine($"======================");
//            Console.WriteLine($"Delivery center : {CenterName}");
//            Console.WriteLine($"======================");
//            for (int i = 0; i < count; i++)
//            {
//                shipments[i].PrintShipment();
//                Console.WriteLine("--------------");
//            }
//        }


//    }

//}






