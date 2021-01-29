using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService; //generate constructor kullandım

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " : Kimlik doğrulaması başarılı. Kayıt yapıldı.");

            }
            else
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " : Kimlik doğrulaması başarısız. Kayıt yapılamadı.");
            }
            

            
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " : Kayıt silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " : Kayıt güncellendi.");
        }
    }
}

