using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamermethod : IGamerServices,GameServices
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname+" "+gamer.Lastname+" "+"adlı kullanıcı eklendi");
        }

        public void AddGame(GameProp gameProp, Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname+" "+gamer.Lastname+" "+"adlı müşteri"+gameProp.GameName+" "+"adlı oyunu"+" "+gameProp.price+" "+"TL'ye satın adlı");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " " + gamer.Lastname + " " + "adlı kullanıcı silindi");
        }

        public void DeleteGame(GameProp gameProp, Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " " + gamer.Lastname + " " + "adlı müşteri" + gameProp.GameName + " " + "adlı oyunu" + " " + gameProp.price + " " + "TL karşılığında iade etti");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Firstname + " " + gamer.Lastname + " " + "adlı kullanıcı güncellendi");
        }
    }
}
