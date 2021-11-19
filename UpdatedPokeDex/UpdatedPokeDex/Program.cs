using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UpdatedPokeDex
{
    class Program
    {
        static string pokemonCSVPath = "pokemon.csv";
        static string pokemonJSONPath = "pokemon.json";
        static string pokemonTilde = "pokemon-tilde.csv";
        static string[] menu =
        {
            "List All Pokemon",
            "List All Pokemon by Type",
            "Load from CSV",
            "Load from JSON",
            "Save to JSON",
            "Exit"
        };

        //static Dictionary<int, List<Pokemon>> pokedex = new Dictionary<int, List<Pokemon>>();
        static List<Pokemon> pokemons = new List<Pokemon>();
        static List<Pokemon> pokemonList = new List<Pokemon>();
        static List<string> FUNLIST = new List<string>()
        {
            "HI",
            "PickleJeff",
            "Bye",
            "PickleRick"
        };

        static List<string> newFunList;

        static void Main(string[] args)
        {
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        ListAllPokemon();
                        break;
                    case 2:
                        ListAllPokemonByType();
                        break;
                    case 3:
                        LoadFromCSV();
                        break;
                    case 4:
                        LoadFromJSON();
                        break;
                    case 5:
                        SaveToJSON();
                        break;
                    case 6:
                        ExitConformation();
                        break;
                    default:
                        DisplayError("Selected option is not listed");
                        break;
                }
            }
        }

        private static void ListAllPokemon()
        {
            foreach (Pokemon pokemon in pokemons)
            {
                Console.WriteLine(pokemon);
            }
        }

        private static void ListAllPokemonByType()
        {
            Console.WriteLine("Enter a type to filter the pokemon: ");
            string type = Console.ReadLine();
            foreach (Pokemon pokemon in pokemonList)
            {
                if(pokemon.Type1 == type  || pokemon.Type2 == type)
                    Console.WriteLine(pokemon);
            }
        }

        private static void SaveToJSON()
        {
            string pokemonStr = JsonConvert.SerializeObject(pokemons);
            //string pokemonStr = JsonConvert.SerializeObject(FUNLIST);
            //StreamWriter writer = new StreamWriter(@"C:\Users\tjtics\Downloads\fun.json");
            StreamWriter writer = new StreamWriter(pokemonJSONPath);
            writer.Write(pokemonStr);
            writer.Close();
        }

        private static void LoadFromJSON()
        {
            StreamReader reader = new StreamReader(pokemonJSONPath);
            //StreamReader reader = new StreamReader(@"C:\Users\tjtics\Downloads\fun.json");
            string pokemonStr = reader.ReadToEnd();
            pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(pokemonStr);
            //newFunList = JsonConvert.DeserializeObject<List<string>>(pokemonStr);
            reader.Close();
        }

        private static void LoadFromCSV()
        {
            if (!File.Exists(pokemonCSVPath))
            {
                DisplayError("File does not exist");
                return;
            }

            using(StreamReader reader = new StreamReader(pokemonCSVPath))
            {
                //reader.ReadLine(); // skipping header
                int index = 0, total = 0, hp = 0, attack = 0, defense = 0,
                    specialAttack = 0, specialDefense = 0, speed = 0, generation = 0;
                    generation = 0;
                string name = "", type1, type2;
                bool legendary;

                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');

                    if (int.TryParse(data[0], out index))
                    {
                        //index = int.Parse(data[0]);
                        name = data[1];
                        type1 = data[2];
                        type2 = data[3];
                        total = int.Parse(data[4]);
                        hp = int.Parse(data[5]);
                        attack = int.Parse(data[6]);
                        defense = int.Parse(data[7]);
                        specialAttack = int.Parse(data[8]);
                        specialDefense = int.Parse(data[9]);
                        speed = int.Parse(data[10]);
                        generation = int.Parse(data[11]);
                        legendary = bool.Parse(data[12]);

                        pokemons.Add(new Pokemon()
                        {
                            Index = index,
                            Name = name,
                            Type1 = type1,
                            Type2 = type2,
                            Total = total,
                            HP = hp,
                            Attack = attack,
                            Defense = defense,
                            SpecialAttack = specialAttack,
                            SpecialDefense = specialDefense,
                            Speed = speed,
                            Generation = generation,
                            Legendary = legendary
                        });
                    }

                }
            }    
        }

        private static void ExitConformation()
        {
            Console.Write("Are you sure you want to exit? (Y/N): ");
            if(Console.ReadLine().ToUpper()[0] == 'Y')
            {
                Console.WriteLine("Thank you for using our PokeDex database!");
                Environment.Exit(0);
            }
        }

        static int Menu()
        {
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
            while (true)
            {
                Console.Write("Select one of these options: ");

                if(int.TryParse(Console.ReadLine(), out int option))
                {
                    return option;
                }

                DisplayError("Cannot be alphabetical entry");
            }
        }

        static void DisplayError(string errorMsg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {errorMsg}.");
            Console.ResetColor();
        }
    }
}
