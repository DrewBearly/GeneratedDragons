using System;

namespace GeneratedDragons_Source
{
    class Character
    {
        public string Name{get; private set;}
        public string Race{get; private set;}
        public int RaceType{get; set;}
        public string Class{get; private set;}
        public int ClassType{get; private set;}
        public bool type {get; private set;}
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


        public Character(string nameIn, string classIn, string raceIn, int typeIn)
        {
            Name = nameIn;
            Class = classIn;
        }
    }
}