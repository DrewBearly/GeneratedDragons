using System;
using System.Collections.Generic;

namespace GeneratedDragons_Source
{
    class StatGen
    {
        private int seed;

        private Character randomStatGenerator(Character charIn)
        {
            return charIn;
        } //generates 6 different scores based on rolling method

        private Character healthGenerator(Character charIn)
        {
            return charIn;
        } //generates health based on CON score

        public StatGen(Character charIn)
        {
            if (charIn.type)
            {
                charIn = randomStatGenerator(charIn);
                charIn = healthGenerator(charIn);
            }
            
        }

    }
}