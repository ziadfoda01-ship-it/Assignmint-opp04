using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmint_opp04
{
    internal class DeliveryReport
    {
        public static void PrintSiipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
    
    public static void PrintSiipment(IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
    }
    
}
