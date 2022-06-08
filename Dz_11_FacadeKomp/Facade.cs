using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_11_FacadeKomp
{
    class Facade
    {  
        protected VideoKarta videoKarta;
        protected Datchiki Datchik;
        protected RAM Ram;
        protected BP Bp;
        protected HDD Hdd;
         
        public Facade(VideoKarta VK, Datchiki D, RAM R, BP B, HDD H)
        {
            videoKarta = VK;
            Datchik = D;
            Ram = R;
            Bp = B;
            Hdd = H;
        }
         
        public string BeginWork()
        {
            string result = "BeginWork Komp:\n";

            result += Bp.Name() + " - " + Bp.PitanieOn() + "\n";
             
            result += Datchik.Name() + " - " + Datchik.TestingNapragenie() + "\n";
            result += Datchik.Name() + " - " + Datchik.TestingTempBP() + "\n";
            result += Datchik.Name() + " - " + Datchik.TestingTempVK() + "\n";

            result += Bp.Name() + " - " + Bp.PitanieOnVK() + "\n"; 

            result += videoKarta.Name() + " - " + videoKarta.Zapusk() + "\n";
            result += videoKarta.Name() + " - " + videoKarta.TestingMonitor() + "\n";

            result += Datchik.Name() + " - " + Datchik.TestingTempRam() + "\n";
            result += Bp.Name() + " - " + Bp.PitanieOnRam() + "\n";

            result += Ram.Name() + " - " + Ram.Zapusk() + "\n";
            result += Ram.Name() + " - " + Ram.Analise() + "\n";

            result += videoKarta.Name() + " - " + videoKarta.PrintInfoRam() + "\n";
            result += Bp.Name() + " - " + Bp.PitanieOnHDD() + "\n";

            result += Hdd.Name() + " - " + Hdd.Zapusk() + "\n";
            result += Hdd.Name() + " - " + Hdd.TestingSector() + "\n";

            result += videoKarta.Name() + " - " + videoKarta.PrintInfoHdd() + "\n";
            result += Datchik.Name() + " - " + Datchik.TestingTempAll() + "\n";

            return result;
        }

        public string EndWork()
        {
            string result = "EndWork Komp:\n";

            result += Hdd.Name() + " - " + Hdd.End() + "\n";

            result += Ram.Name() + " - " + Ram.Clean() + "\n";
            result += Ram.Name() + " - " + Ram.Analise() + "\n";

            result += videoKarta.Name() + " - " + videoKarta.PrintEndMessage() + "\n";

            result += Bp.Name() + " - " + Bp.PitanieOffHDD() + "\n";
            result += Bp.Name() + " - " + Bp.PitanieOffRam() + "\n";
            result += Bp.Name() + " - " + Bp.PitanieOffVK() + "\n";

            result += Datchik.Name() + " - " + Datchik.TestingNapragenie() + "\n";
            result += Bp.Name() + " - " + Bp.PitanieOff() + "\n"; 

            return result;
        }
    }
}
