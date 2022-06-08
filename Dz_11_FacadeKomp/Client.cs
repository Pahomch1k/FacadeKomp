using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_11_FacadeKomp
{
    class Client
    { 
        public static void ClientCode(Facade facade)
        {
            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. Вкл ПК\n" +
                    "2. Выкл ПК\n" +
                    "3. Выход");

                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1: WriteLine(facade.BeginWork()); break;
                    case 2: WriteLine(facade.EndWork()); break;
                    case 3: flag++; break; 
                    default: WriteLine("Try again"); break;
                } 
            } 
        }
    }
}
