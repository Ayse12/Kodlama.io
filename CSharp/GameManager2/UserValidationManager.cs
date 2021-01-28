using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Ayşe" && gamer.LastName == "İlhanlı" && gamer.IdentityNumber == 12345)
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
