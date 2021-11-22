using System;
using static UpdatedPokeDex.PokeDex;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace UpdatedPokeDex
{
    class Program
    {
        static string pokemonCSVPath = "pokemon.csv";
        static string pokemonJSONPath = "pokemon.json";
        static string pokemonJSONDictPath = @"C:\Users\tjtics\Downloads\pokemon_dict.json";
        static string pokemonPropertiesJSONPath = @"C:\Users\tjtics\Downloads\pokemon_properties.json";
        static string pokemonTilde = "pokemon-tilde.csv";
        static string[] menu =
        {
            "Create a new trainer",
            "List All Trainers",
            "List All Pokemon",
            "List All Pokemon by Type",
            "List All Generation Pokemon Starters",
            "Load from JSON",
            "Save to JSON",
            "Exit"
        };

        static List<Trainer> trainers = new List<Trainer>();
        //static Dictionary<int, List<Pokemon>> pokedex = new Dictionary<int, List<Pokemon>>();
        //static List<Pokemon> pokemons = new List<Pokemon>();
        //static List<Pokemon> pokemonList = new List<Pokemon>();
        //static List<string> FUNLIST = new List<string>()
        //{
        //    "HI",
        //    "PickleJeff",
        //    "Bye",
        //    "PickleRick"
        //};

        //static List<string> newFunList;

        static void Main(string[] args)
        {
            LoadFromCSV();
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        CreateNewTrainer();
                        break;
                    case 2:
                        ListAllTrainers();
                        break;
                    case 3:
                        ListAllPokemon();
                        break;
                    case 4:
                        ListAllPokemonByType();
                        break;
                    case 5:
                        ListAllPokemonStarters();
                        break;
                    case 6:
                        LoadFromJSON();
                        break;
                    case 7:
                        SaveToJSON();
                        break;
                    case 8:
                        ExitConformation();
                        break;
                    default:
                        DisplayError("Selected option is not listed");
                        break;
                }
            }
        }

        private static void ListAllTrainers()
        {
            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine($"Index: {trainer.ID} -- {trainer.Name}");
            }
        }

        private static void CreateNewTrainer()
        {
            Trainer trainer = new Trainer();

            Console.Write("Enter your name: ");
            trainer.Name = Console.ReadLine();

            Console.Write("Enter your trainer class: ");
            trainer.TrainerClass = Console.ReadLine();

            //foreach (KeyValuePair<int, List<Pokemon>> generations in generationStarters)
            //{
            //    Console.WriteLine($"{generations.Key}. Generation {generations.Key:D2}");
            //}

            //Console.Write("Select a generation to get the starter pokemons: ");
            //int selection = int.Parse(Console.ReadLine());
            //List<Pokemon> selectedGenerationStarters = generationStarters[selection];

            //for (int i = 0; i < selectedGenerationStarters.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {selectedGenerationStarters[i]}");
            //}

            //Console.Write("Select a starter pokemon: ");
            //selection = int.Parse(Console.ReadLine());


            trainers.Add(trainer);
        }

        private static void ListAllPokemonStarters()
        {
            foreach (KeyValuePair<int, List<Pokemon>> generation in generationStarters)
            {
                Console.WriteLine($"====================== {$"Generation {generation.Key:D2}"} ======================\n");
                foreach (Pokemon pokemon in generation.Value)
                {
                    Console.WriteLine($"{$"#{pokemon.Index:D3}",11}\n___________________\n");
                    Console.WriteLine($"{pokemon}\n");
                }
            }
        }

        private static void ListAllPokemon()
        {
            // using dictionary
            //foreach (KeyValuePair<int, List<Pokemon>> pokemons in pokedex)
            //{
            //    Console.WriteLine($"{$"#{pokemons.Key:D3}",11}\n___________________\n");
            //    foreach (Pokemon pokemon in pokemons.Value)
            //    {
            //        Console.WriteLine($"{pokemon}\n");
            //    }
            //}

            // using list
            foreach (Pokemon pokemon in pokeDices)
            {
                Console.WriteLine(pokemon);
            }
        }

        private static void ListAllPokemonByType()
        {
            Console.WriteLine("Enter a type to filter the pokemon: ");
            string type = Console.ReadLine();

            // using dictionary
            foreach (KeyValuePair<string, List<Pokemon>> pokemons in types)
            {
                if (pokemons.Key == type)
                {
                    Console.WriteLine($"{$"#{pokemons.Key:D3}",11}\n___________________\n");
                    foreach (Pokemon pokemon in pokemons.Value)
                    {

                        Console.WriteLine($"{pokemon}\n");
                    }
                }
            }


            // using list
            //foreach (Pokemon pokemon in pokemonList)
            //{
            //    if (pokemon.Type1 == type || pokemon.Type2 == type)
            //        Console.WriteLine(pokemon);
            //}
        }

        private static void SaveToJSON()
        {
            Console.WriteLine("Writing to JSON....");
            string pokemonStr = JsonConvert.SerializeObject(pokedex);
            StreamWriter writer = new StreamWriter(pokemonJSONDictPath);
            writer.Write(pokemonStr);
            writer.Close();
            Console.WriteLine("Finished writing to JSON...");
            //string pokemonStr = JsonConvert.SerializeObject(FUNLIST);
            //StreamWriter writer = new StreamWriter(@"C:\Users\tjtics\Downloads\fun.json");
        }

        private static void LoadFromJSON()
        {
            Console.WriteLine("Reading from JSON...");
            StreamReader reader = new StreamReader(pokemonPropertiesJSONPath);
            string pokemonStr = reader.ReadToEnd();
            //pokedex = JsonConvert.DeserializeObject<Dictionary<int, List<Pokemon>>>(pokemonStr);
            pokeDices = JsonConvert.DeserializeObject<List<Pokemon>>(pokemonStr);
            reader.Close();
            Console.WriteLine("Finished reading from JSON...");
            //StreamReader reader = new StreamReader(@"C:\Users\tjtics\Downloads\fun.json");
            //string pokemonStr = reader.ReadToEnd();
            //pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(pokemonStr);
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

            using (StreamReader reader = new StreamReader(pokemonCSVPath))
            {
                //reader.ReadLine(); // skipping header
                int index = 0, total = 0, hp = 0, attack = 0, defense = 0,
                    specialAttack = 0, specialDefense = 0, speed = 0, generation = 0;
                generation = 0;
                string name = "", type1, type2;
                bool legendary;

                List<Pokemon> sameIndexPokemons = new List<Pokemon>();
                Pokemon currentPokemon = null;
                int trackingIndex = 1, trackingGenerationStarterIndex = 1;

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
                        currentPokemon = new Pokemon()
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
                        };



                        if (!types.ContainsKey(type1) && type2 != "" && !types.ContainsKey(type2))
                        {
                            types.Add(type1, new List<Pokemon>() { currentPokemon });
                            types.Add(type2, new List<Pokemon>() { currentPokemon });
                        }
                        else if (!types.ContainsKey(type1))
                        {
                            types.Add(type1, new List<Pokemon>() { currentPokemon });
                        }
                        else
                        {
                            types[type1].Add(currentPokemon);
                        }

                        if (!generationStarters.ContainsKey(generation))
                        {
                            trackingGenerationStarterIndex = index;
                            generationStarters.Add(generation, new List<Pokemon>() { currentPokemon });
                            trackingGenerationStarterIndex += 3;
                        }
                        else if (index == trackingGenerationStarterIndex && generationStarters[generation].Count < 3)
                        {
                            generationStarters[generation].Add(currentPokemon);
                            trackingGenerationStarterIndex += 3;
                        }



                        // if the index are not the same
                        if (trackingIndex != index)
                        {
                            // go ahead and add it to pokedex
                            pokedex.Add(trackingIndex, sameIndexPokemons);
                            trackingIndex = index;                   // replace
                            sameIndexPokemons = new List<Pokemon>(); // reset
                        }

                        sameIndexPokemons.Add(currentPokemon);

                        //pokemons.Add(new Pokemon()
                        //{
                        //    Index = index,
                        //    Name = name,
                        //    Type1 = type1,
                        //    Type2 = type2,
                        //    Total = total,
                        //    HP = hp,
                        //    Attack = attack,
                        //    Defense = defense,
                        //    SpecialAttack = specialAttack,
                        //    SpecialDefense = specialDefense,
                        //    Speed = speed,
                        //    Generation = generation,
                        //    Legendary = legendary
                        //});
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
