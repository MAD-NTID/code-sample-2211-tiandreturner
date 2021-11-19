using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedPokeDex
{
    class Trainer
    {
        private int id;
        private static int trainerID = 1;
        private Pokemon[] battlePokemons;
        private List<Pokemon> pokedex;
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (value != "")
                    name = value;
                else
                    name = "No Name";
            }
        }

        public string TrainerClass {  get; set; }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public Pokemon[] BattlePokemons
        {
            get { return battlePokemons; }
        }

        public Trainer()
        {
            battlePokemons = new Pokemon[6];
            pokedex = new List<Pokemon>();
            id = trainerID++;
        }

        public void UpdateBattlePokemonsList(Pokemon starter)
        {
            battlePokemons[0] = starter;


        }
    }
}
