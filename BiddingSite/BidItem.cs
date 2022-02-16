using System;
using System.Collections.Generic;
using System.Text;

namespace BiddingSite
{
    class BidItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double StartPrice { get; set; }
        public int IncreaseBidAmount { get; set; }

        public BidItem(int id, string name, double price, int increase)
        {
            ID = id;
            Name = name;
            StartPrice = price;
            IncreaseBidAmount = increase;
        }

        public override string ToString()
        {
            return String.Format("{0,-10}  {1,-30:N0} {2,-15:N0} {3,-10:N0}\n",
                      ID, Name, StartPrice, IncreaseBidAmount);
        }

    }
}
