using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class OrderManager : IOrderService
    {
        public void Sold(Player player, Game game)
        {
            Console.WriteLine(player.NationalityId + " TC No'lu, " + player.FirstName + " " + player.LastName + " isimli oyuncu; " + game.GameName + " oyununu satın aldı.");
        }

        public void CampaignApply(Player player)           

        {
            if ((player.IsStudent) == true)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu için, Öğrencilere Özel Kampanya indirimi yapıldı");
            }
            else if(player.BirthYear<=1981)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu için, 40 Yaş Üzeri'ne Özel Kampanya indirimi yapıldı");
            }
            else
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu için, kampanya uygulanmadı");
            }

            
        }


        
    }
}
