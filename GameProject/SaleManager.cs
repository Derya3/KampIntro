using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine("Kampanya Satışı");
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine("Satış");
        }
    }
}
