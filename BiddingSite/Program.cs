using System;

namespace BiddingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            BidItemManager itemManager = new BidItemManager();

            itemManager.AddItem("iPhone 11", 200, 10);
            itemManager.AddItem("SamSung Note 10", 150, 5);

            itemManager.ShowAllItem();

            BidderManager bidderManager = new BidderManager();
            bidderManager.AddBidder("A", 1, 400); 
            bidderManager.AddBidder("B", 1, 300);
           
            bidderManager.ShowAllBidder();

            itemManager.FindTheWinnerForAllItem(bidderManager);
        }
    }
}
