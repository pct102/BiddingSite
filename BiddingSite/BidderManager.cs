using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BiddingSite
{
    public class BidderManager
    {
        List<Bidder> lstBidder;
        public BidderManager()
        {
            lstBidder = new List<Bidder>();
        }

        public void AddBidder(string name, int itemId, double price)
        {
            int id = lstBidder.Count + 1;
            lstBidder.Add(new Bidder(id, name, itemId, price));
        }

        public void ShowAllBidder()
        {
            String s = String.Format("{0,-10}  {1,-20:N0} {2,-10:N0} {3,-10:N0}\n",
                      "BidderID", "BidderName", "BidItemID", "BidPrice");
            foreach (Bidder item in lstBidder)
            {
                s += item.ToString();
            }

            Console.WriteLine($"\n{s}");
        }

        public List<Bidder> FindBidderCanWinItem(int itemID, double itemPrice)
        {
            return lstBidder.Where(b => b.BidPrice >= itemPrice && b.BidItemID == itemID).OrderByDescending(b => b.BidPrice).ToList();
        }
    }
}
