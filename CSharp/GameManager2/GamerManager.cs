using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager2
{
    class GamerManager : IGamer
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService uSerValidationService)
        {
            this.userValidationService = uSerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız!!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
