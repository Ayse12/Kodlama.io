using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager2
{
    interface IGamer
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
