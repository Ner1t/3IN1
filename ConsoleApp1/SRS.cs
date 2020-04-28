using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicContol
{
    public class SRS : IElectronicBlocks
    {
        public int PLACE { get; set; }

        public void DevicePlacement(int place) 
        {
            PLACE = place;

        }
        public void Display()
        {
            Console.WriteLine("ошибок в  SRS");
        }
    }
}

