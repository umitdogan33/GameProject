using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CompanyAdmin : ICompanyservices
    {
        public void Cadd(CompanyManager Company)
        {
            Console.WriteLine(Company.Name+" "+"adlı kampanya eklendi" );
        }

        public void Cdelete(CompanyManager Company)
        {
            Console.WriteLine(Company.Name + " " + "adlı kampanya silindi");
        }

        public void Cupdate(CompanyManager Company)
        {
            Console.WriteLine(Company.Name + " " + "adlı kampanya güncellendi");
        }
    }
}
