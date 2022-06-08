using System;

namespace Dz_11_FacadeKomp
{
    class Program
    {
        static void Main(string[] args)
        { 
            var VideoKarta = new VideoKarta();
            var Datchik = new Datchiki();
            var Ram = new RAM();
            var Bp = new BP();
            var Hdd = new HDD();
             
            Facade facade = new Facade(VideoKarta, Datchik, Ram, Bp, Hdd);
            Client.ClientCode(facade);
        }
    }
}
