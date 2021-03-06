using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public class AllPokemonAPI
    {
        public List<ResultObject> results {get; set;}
    }
    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

   public class PokemonInfo
    {
        public int height { get; set; }
        public Sprites sprites { get; set; }
        public int weight { get; set; }
    }
    public class Sprites
    {
        public string frontdefault { get; set; }
        public string backdefault { get; set; }
    }
}
