using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameProp oyun1 = new GameProp();
            oyun1.GameName = "minecraft";
            oyun1.price = 40;
            oyun1.VerisonDate = 2015;


            CompanyManager kampanya1 = new CompanyManager();
            kampanya1.Name = "simülasyon oyunlarında yüzde 30 indirim ";


            
            Gamer gamer1 = new Gamer() {Firstname = "ümit", Lastname = "doğan" };
            Gamer gamer2 = new Gamer() {Firstname="Engin",Lastname="Demirog" };
            Gamer gamer3 = new Gamer() {Firstname = "ömer", Lastname = "Çolakoğlu",};
            IGamerServices Oyuncuişlemleri = new Gamermethod();
            Gamermethod gamermethod = new Gamermethod();
            CompanyAdmin companyAdmin = new CompanyAdmin();
            companyAdmin.Cadd(kampanya1);
            gamermethod.AddGame(oyun1,gamer1);
            


            
        }
    }
}
