using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerServices
    {
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void Add(Gamer gamer);
    }
}
