using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BiddingSite
{
    class BidItemManager
    {
        List<BidItem> lstItem;
        public BidItemManager()
        {
            lstItem = new List<BidItem>();
        }

        public void AddItem(string name, double price, int increase) {
            int id = lstItem.Count + 1;
            lstItem.Add(new BidItem(id, name, price, increase));
        }

        public void ShowAllItem()
        {
            String s = String.Format("{0,-10}  {1,-30:N0} {2,-15:N0} {3,-10:N0}\n",
                      "ID", "Name", "StartPrice", "IncreaseBidAmount");
            foreach(BidItem item in lstItem)
            {
                s += item.ToString();
            }

            Console.WriteLine($"\n{s}");
        }

        public void FindTheWinnerForAllItem(BidderManager bidderManager)
        {
            string s = "";
            foreach(BidItem item in lstItem)
            {
                string winnerName = "";
                double payPrice = item.StartPrice;

                List<Bidder> userCanWin = bidderManager.FindBidderCanWinItem(item.ID, item.StartPrice);

                if (userCanWin.Count == 0)
                {
                    s += String.Format("There is no winner in the bidding for the {0}.\n", item.Name);
                }
                else if (userCanWin.Count == 1)
                {
                    winnerName = userCanWin.FirstOrDefault().BidderName;
                    payPrice = userCanWin.FirstOrDefault().BidPrice;
                    s += String.Format("{0} winner is {1} with the price to pay is ${2}.\n", item.Name, winnerName, payPrice);
                }
                else
                {
                    var firstUser = userCanWin.FirstOrDefault();
                    winnerName = firstUser.BidderName;
                    var secondUser = userCanWin.Take(2).LastOrDefault();
                    if(secondUser.BidPrice == firstUser.BidPrice)
                    {
                        payPrice = firstUser.BidPrice;
                    }
                    else
                    {
                        payPrice = secondUser.BidPrice + item.IncreaseBidAmount;
                    }
                    
                    s+= String.Format("{0} winner is {1} with the price to pay is ${2}.\n", item.Name, winnerName, payPrice);
                }
            }

            Console.WriteLine(String.Format($"Result:\n\n{s}"));
        
        }
    }
}
