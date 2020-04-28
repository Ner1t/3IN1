using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicContol
{
     class PCM : ElectronicUnits
    {
        public string PERROR {get; set;}

        public PCM( string PError) 
            : base("PCM")
        {   
            PERROR = PError;
        }
        public override void Display()
        {
            Console.WriteLine($"{PERROR}  ошибок в  {BLOCK}");
        }
    }
}
