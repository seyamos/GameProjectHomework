using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectHomework
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 2001 && player.FirstName == "Ahmet"
                 && player.LastName == "Aksoy" && player.NationalityId == 123456789) 
            {
                return true;                
            }

            else
            {
                return false;                
            }            

        }
    }
}
