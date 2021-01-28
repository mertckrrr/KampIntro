using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear == 1998 && gamer.FirstName == "MERT" && gamer.LastName == "ÇAKIR" && gamer.IdentityNumber == 37621321937)
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
