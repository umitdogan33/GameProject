using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface GameServices
    {
        void AddGame(GameProp gameProp,Gamer gamer);  //burada gameprop türündeki ürünler eklensin diye komut verdik 
        void DeleteGame(GameProp gameProp, Gamer gamer);
    }
}
