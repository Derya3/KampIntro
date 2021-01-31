using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 1981 && gamer.FirstName == "Derya" && gamer.LastName == "Üçüncü" && gamer.IdentityNumber == 567432189) 
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
