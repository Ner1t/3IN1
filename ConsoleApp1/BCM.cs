using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicContol
{
    public class BCM : ElectronicUnits
    {
        public string BERROR {get; set;}

        public BCM(string BError) : base("BCM")
            
        {
            BERROR = BError;
        }

        public override void Display()
        {
            Console.WriteLine($"{BERROR} ошибок в  {BLOCK}");
        }
    }
}
