using System;

namespace GameProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncular:
            
            Player player1 = new Player();
            player1.NationalityId = 123456789;
            player1.FirstName = "Ahmet";
            player1.LastName = "Aksoy";
            player1.BirthYear = 2001;
            player1.IsStudent = true;


            Player player2 = new Player();
            player2.NationalityId = 856312759;
            player2.FirstName = "Elif";
            player2.LastName = "Yılmaz";
            player2.BirthYear = 1975;
            player2.IsStudent = false;

            Player player3 = new Player();
            player3.NationalityId = 389758968;
            player3.FirstName = "Ali";
            player3.LastName = "Atak";
            player3.BirthYear = 1995;
            player3.IsStudent = false;

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player1);
            playerManager.Delete(player2);
            playerManager.Update(player3);

            Console.WriteLine("-----------------");

            //Oyunlar:

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Strategy Game";
            game1.GamePrice = 50;

            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "Card Game";
            game2.GamePrice = 100;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            Console.WriteLine("-----------------");

            //Kampanyalar:

            Campaign campaign1 = new Campaign();
            campaign1.CampaignNo = 3;
            campaign1.CampaignName = "Öğrencilere Özel Kampanya";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignNo = 4;
            campaign2.CampaignName = "40 Yaş Üzeri'ne Özel Kampanya";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);

            Console.WriteLine("-----------------");

            OrderManager orderManager = new OrderManager();
            orderManager.Sold(player1, game2);
            orderManager.Sold(player2, game1);
            orderManager.Sold(player3, game2);
            Console.WriteLine("-----------------");
            orderManager.CampaignApply(player1);
            orderManager.CampaignApply(player2);
            orderManager.CampaignApply(player3);




        }
    }
}
