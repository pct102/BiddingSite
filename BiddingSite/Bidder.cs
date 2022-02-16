using System;
using System.Collections.Generic;
using System.Text;

namespace BiddingSite
{
    public class Bidder
    {
        public int BidderID { get; set; }
        public string BidderName { get; set; }
        public int BidItemID { get; set; }
        public double BidPrice { get; set; }
        public Bidder(int id, string name, int itemId, double price)
        {
            BidderID = id;
            BidderName = name;
            BidItemID = itemId;
            BidPrice = price;
        }

        public override string ToString()
        {
            return String.Format("{0,-10}  {1,-20:N0} {2,-10:N0} {3,-10:N0}\n",
                      BidderID, BidderName, BidItemID, BidPrice);
        }
    }
}
