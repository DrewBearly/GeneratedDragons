using System;
using System.Collections.Generic;

namespace GeneratedDragons_Source
{
    class Character
    {
        public string Name{get; private set;}
        public string Race{get; private set;}
        public string Class{get; private set;}
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

        public bool statSet;

        List<int> statCache = new List<int>();
        Random randNumb = new Random();

        public Character(string nameIn, string classIn, string raceIn, int typeIn)
        {
            Name = nameIn;
            Class = classIn;
        }

        private Character randomStatGenerator(Character charIn)
        {
            return charIn;
        } //generates 6 different scores based on rolling method

        private Character healthGenerator(Character charIn)
        {
            return charIn;
        } //generates health based on CON score

        private int roll4d4()
        {
            int roll = 0;
            int[] rolls = new int[4];
            for (int i = 0; i < 4; i++)
            {
                rolls[i] = randNumb.Next(1, 5);
            }
            Array.Sort(rolls);
            for (int i = 1; i < 4; i++)
            {
                roll += rolls[i];
            }
            
            return roll;

        }
    }
}