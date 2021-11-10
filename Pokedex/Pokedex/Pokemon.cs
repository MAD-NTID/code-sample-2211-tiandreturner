using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Pokemon
    {
        public enum PokemonType
        {
            FIRE =1,
            WATER,
            GRASS
        }

        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                if(value.Length != 0)
                    name = value; 
            }
        }

        private PokemonType type;

        public PokemonType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string[] abilities;

        public string[] Abilities
        {
            get { return abilities; }
            set { abilities = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public override string ToString()
        {
            string information = $"Index: #{Index:D4}\nName: {Name}\nType: {Type}\nHeight: {Height}\nWeight: {Weight}\nAbilities:\n";

            for (int i = 0; i < abilities.Length; i++)
            {
                information += abilities[i] + " ";
            }
            
            return information;
        }


    }
}
