using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICompanyservices //arkadaşlar C harfi company kelimesinin kıslatılmış hali//
    {
        void Cadd(CompanyManager Company);
        void Cdelete(CompanyManager Company);
        void Cupdate(CompanyManager Company);
        
    }
}
