using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicContol
{
    class MyAttribute : Attribute
    {
        public string name { get; set; }
        
    }
    public abstract class ElectronicUnits
    {
        
        

        public string BLOCK { get; set; }

        public ElectronicUnits (string block)
        {
            BLOCK = block;

        }



        public abstract void Display();

    }
}
