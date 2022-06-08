using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_11_FacadeKomp
{ 
    public class VideoKarta
    {
        private string name = "RTX3020";

        public string Name() => name;

        public string Zapusk() => "Запуск";
        public string TestingMonitor() => "Проверка связи с монитором";
        public string PrintInfoRam() => "Вывод данных об оперативной памяти";
        public string PrintInfoHdd() => "Вывод данных об HDD";

        public string PrintEndMessage() => "Вывести на монитор данные прощальное сообщение"; 
    }

    public class HDD
    {
        private string name = "HDD1000";

        public string Name() => name;

        public string Zapusk() => "Запуск";
        public string TestingSector() => "Проверка загрузочного сектора";

        public string End() => "Остановка устройства"; 
    }

    public class RAM
    {
        private string name = "RAM32";

        public string Name() => name;

        public string Zapusk() => "Запуск  устройств";
        public string Analise() => "Анализ памяти";

        public string Clean() => "Очистка памяти"; 
    }

    public class BP
    {
        private string name = "BP600";

        public string Name() => name;

        public string PitanieOn() => "Подать питание";
        public string PitanieOnVK() => "Подать питание на видеокарту";
        public string PitanieOnRam() => "Подать питание на RAM";
        public string PitanieOnHDD() => "Подать питание на HDD";

        public string PitanieOff() => "Прекратить питание";
        public string PitanieOffVK() => "Прекратить питание на видеокарту";
        public string PitanieOffRam() => "Прекратить питание на RAM";
        public string PitanieOffHDD() => "Прекратить питание на HDD"; 
    }

    public class Datchiki
    {
        private string name = "DatchikiX";

        public string Name() => name;

        public string TestingNapragenie() => "Тестируем напряжение";
        public string TestingTempVK() => "Тестируем Температуру Видеокарты";
        public string TestingTempBP() => "Тестируем Температуру блока питания";
        public string TestingTempRam() => "Тестируем Температуру RAM";
        public string TestingTempAll() => "Тестируем Температуру Всех систем"; 
    }
}
