using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UpdatedPokeDex
{
    class Pokemon
    {
        [JsonProperty("index")]
        public int Index { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("type_1")]
        public string Type1 { get; set; }
        
        [JsonProperty("type_2")]
        public string Type2 { get; set; }
        
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("hp")]
        public int HP { get; set; }
        
        [JsonProperty("attack_power")]
        public int Attack { get; set; }
        
        [JsonProperty("defense_power")]
        public int Defense { get; set; }
        
        [JsonProperty("special_attack_power")]
        public int SpecialAttack { get; set; }
        
        [JsonProperty("special_defense_power")]
        public int SpecialDefense { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }
        
        [JsonProperty("generation")]
        public int Generation { get; set; }
        
        [JsonProperty("legendary")]
        public bool Legendary { get; set; }
        

        public override string ToString()
        {
            //string pokemonString = $"#{Index:D3}\n____________\n";
            string pokemonString = $"{Name}\n";
            pokemonString += $"[{Type1}] {(Type2 == "" ? "" : $"[{Type2}]")}\n";
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
