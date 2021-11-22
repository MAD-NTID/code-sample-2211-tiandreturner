using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedPokeDex
{
    static class PokeDex
    {      
        static public Dictionary<int, List<Pokemon>> pokedex = new Dictionary<int, List<Pokemon>>();
        static public Dictionary<string, List<Pokemon>> types = new Dictionary<string, List<Pokemon>>();
        static public Dictionary<int, List<Pokemon>> generationStarters = new Dictionary<int, List<Pokemon>>();
        static public List<Pokemon> pokeDices = new List<Pokemon>();
    }
}
