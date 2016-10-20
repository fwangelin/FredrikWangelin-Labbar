using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredrikWängelin_Labb2
{
    class AnimalManager
    {
        // Mammals
        public List<Dog> Dogs { get; set; }
        public List<Horse> Horse { get; set; }
        // Insects
        public List<Ant> Ants { get; set; }
        public List<Mosquito> Mosquitos { get; set; }
        // Reptiles
        public List<Lizard> Lizards { get; set; }
        public List<Snake> Snakes { get; set; }

        public List<Eagle> Eagles { get; set; }
        public List<Crow> Crows { get; set; }
    }

    public static void AnimalManager()
    {
        Dogs = new List<Dog>();
        Horse = new List<Horse>();
        Ants = new List<Ant>();
        Mosquito = new List<Mosquito>();
        Snakes = new List<Snake>();
        Lizards = new List<Lizard>();
        Eagle = new List<Eagle>();
        Crow = new List<Crow>();
    }

}

