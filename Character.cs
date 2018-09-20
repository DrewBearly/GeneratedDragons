using System;

namespace GeneratedDragons_Source
{
    class Character
    {
        public bool type {get; set;}
        public int STR {get; set;}
        public int DEX {get; set;}
        public int CON {get; set;}
        public int INT {get; set;}
        public int WIS {get; set;}
        public int CHA {get; set;}

        public int HPMax {get; set;}
        public int HPCurrent 
        {
            get {return HPCurrent;} 
            set 
            {
                if (value > HPMax)
                {
                    HPCurrent = HPMax;
                }
            }
        }
    }
}