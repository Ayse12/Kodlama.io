using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager2
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
