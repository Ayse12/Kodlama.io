using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //field tanımlamak ( alan)
        //public string FirstName;

        //Property - Özellik
        //Bir özellik tanımlayacaksak bunu kullanmalıyız ( classı tanımlamak)
        public int Id { get; set; }

        //Encapsulation
        private string _firstName;
        public string FirstName
        {
            //Bir field üzerinde get veya set ederken başka bir şey ekleyerek ilerlemek istersem eğer bu tarz kullanımı kullanabilirim. 
            get
            {
                //Değer Okurken
                return "Mrs." + " " + _firstName; //Ben okumaya çalıştığım veriyi çektiğim zaman bana önünde Mrs değeri var olarak geri döndürmesini sağlıyorum.
            }
            set
            {
                //Değeri vermek
                _firstName = value;
                //value denilen şey set etmek istediğimiz değere karşılık gelir
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
