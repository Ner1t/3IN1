using NLog;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ElectronicContol
{
    public class Program 
    {
        
        private static Logger Log = LogManager.GetCurrentClassLogger();
        [My(name = "ROMAN")]
        public static void Main(string[] args)
        {
            
            SRS bang = new SRS();
            int u = bang.PLACE;
            Console.WriteLine("Введите число");
            
        Log.Trace("Старт");
            try 
            {
                int PLACE = int.Parse(Console.ReadLine());
                bang.Display();
                Console.WriteLine(PLACE);
            }

            catch (FormatException)
            {
                Log.Error("не число");

                Console.WriteLine("Только числа!");
            }

            Log.Info("Программа");
            PCM real = new PCM("4");
            BCM real1 = new BCM("5");
            
            real.Display();
            real1.Display();

            List<BCM> ErrorsBCM = new List<BCM>();

            ErrorsBCM.Add(new BCM( "p0328"));
            ErrorsBCM.Add(new BCM( "P1402"));
            ErrorsBCM.Add(new BCM( "P1403"));
            ErrorsBCM.Add(new BCM( "P0221"));

            List<PCM> ErrorsPCM = new List<PCM>();
            PCM P1 = new PCM("p0110");
            PCM P2 = new PCM("P0232");
            PCM P3 = new PCM("P1606");
            PCM P4 = new PCM("P0131");
            PCM P5 = new PCM("P0235");
            ErrorsPCM.Add(P1);
            ErrorsPCM.Add(P2);
            ErrorsPCM.Add(P3);
            ErrorsPCM.Add(P4);
            ErrorsPCM.Add(P5);

            int unit = (ErrorsBCM.Where(e => (e.BLOCK == "BCM")&&(e.BERROR != "P1402")).Count());
            Console.WriteLine($" Критических ошибок BCM : {unit}");

            int unit1 = (ErrorsPCM.Where(e => e.PERROR == "P1606")).Count();
            Console.WriteLine($" Критических ошибок PCM : {unit1}");

        }

    }
}
