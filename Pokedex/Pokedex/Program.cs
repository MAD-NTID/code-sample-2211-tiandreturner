using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Program
    {
        //static List<Pokemon> pokemons = new List<Pokemon>();

        static Dictionary<int, Pokemon> pokemons = new Dictionary<int, Pokemon>();
        static void Main(string[] args)
        {
           
            while(true)
            {
                switch (Menu())
                {
                    case 1:
                        AddPokemon();
                        break;
                    case 2:
                        RemovePokemon();
                        break;
                    case 3:
                        ListAllPokemon();
                        break;
                    case 4:
                        Console.WriteLine("BYE");
                        Environment.Exit(0);
                        break;
                }

            }
        }

        private static void RemovePokemon()
        {
            //for (int i = 0; i < pokemons.Count; i++)
            //{
            //    Console.WriteLine($"{i +1}. {pokemons[i].Name}");
            //}

            foreach(KeyValuePair<int, Pokemon> keyValue in pokemons)
            {
                Console.WriteLine($"{keyValue.Key}. {keyValue.Value.Name}");
            }

            Console.Write("Select a pokemon to remove: ");
            int numberToRemove = int.Parse(Console.ReadLine());

            pokemons.Remove(numberToRemove);
            //pokemons.Remove(pokemons[numberToRemove-1]);

            //pokemons.RemoveAt(numberToRemove - 1);
        }

        private static void ListAllPokemon()
        {
            foreach (KeyValuePair<int, Pokemon> keyValue in pokemons)
            {
                Console.WriteLine($"{keyValue.Value}");
            }
        }

        private static void AddPokemon()
        {
            Pokemon pokemon = new Pokemon();
            Console.Write("Enter the index of a pokemon: ");
            pokemon.Index = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Fire");
            Console.WriteLine("2. Water");
            Console.WriteLine("3. Grass");
            Console.Write("Enter the type of a pokemon: ");
            pokemon.Type = (Pokemon.PokemonType)int.Parse(Console.ReadLine());

            Console.Write("Enter the name of a pokemon: ");
            pokemon.Name = Console.ReadLine();
             
            Console.Write("Enter the height of a pokemon: ");
            pokemon.Height = double.Parse(Console.ReadLine());

            Console.Write("Enter the weight of a pokemon: ");
            pokemon.Weight = double.Parse(Console.ReadLine());

            string[] abilities = new string[5];

            for (int index = 0; index < abilities.Length; index++)
            {
                Console.Write($"Enter ability #{index +1}: ");
                abilities[index] = Console.ReadLine();

            }
           
            pokemon.Abilities = abilities;

            pokemons.Add(pokemon.Index,pokemon);
            //pokemons.Insert(pokemon.Index-1, pokemon);

        }

        public static int Menu()
        {
            Console.WriteLine("1. Add a pokemon");
            Console.WriteLine("2. Remove a pokemon");
            Console.WriteLine("3. List all pokemon");
            Console.WriteLine("4. Exit");
            Console.Write("Select one of these listed: ");
            if(!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Error: invalid input");
            }

            return choice;
        }
    }
}
