using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedPokeDex
{
    class Pokemon
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }

        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }

        public override string ToString()
        {
            string pokemonString = $"#{Index:D3}\n____________";
            pokemonString += $"{Name}\n";
            pokemonString += $"{Type1} {Type2}\n";
            pokemonString += $"HP: {HP}\nAttack: {Attack}\nDefense: {Defense}\n";
            pokemonString += $"Sp. Attack: {SpecialAttack}\nSp. Defense: {SpecialDefense}\nSpeed: {Speed}\nTotal: {Total}\n";
            pokemonString += $"Generation: {Generation}\nIs Legendary?: {(Legendary ? "Yes" : "No")}";
            //if(Legendary)
            //    pokemonString += $"Generation: {Generation}\nIs Legendary?: Yes";
            //else
            //    pokemonString += $"Generation: {Generation}\nIs Legendary?: No";


            return pokemonString;
        }

    }
}
