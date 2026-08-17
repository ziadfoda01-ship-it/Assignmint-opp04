using Assignment_opp02;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmint_oop_03
{
    internal class PriorityInternationalShipment : InternationalShipment

    {
        public PriorityInternationalShipment(string tragkingGode, string decscription, decimal weight, decimal deliveryFee, DeliveryAddress destioncountry, string destionCountry, decimal customfee)
       : base(tragkingGode, decscription, weight, deliveryFee, destioncountry, destionCountry, customfee)
        {

        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($" [PRIORITY]Fast - track customs clearanc repirt for{DestinationCountry} ");
        }
    }
}
