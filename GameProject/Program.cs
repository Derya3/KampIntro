using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthYear = 1981,
                FirstName = "Derya",
                LastName = "Üçüncü",
                IdentityNumber = 567432189
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1); 
            

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Kampanya1"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            
            Game game1 = new Game
            {
                Id = 1,
                Name = "Oyun1",
                Price = 30,
                Stock = 50
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            

            ISaleService sale = new SaleManager();
            sale.CampaignSale(campaign1, game1, gamer1);
        }
    }
}
