﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        static void Main(string[] args)
        {
            rooms = new List<Room>();
            Room r1 = new Room("Mark", "En stor og grøn mark med masser af smukke planter og dyr");
            Room r2 = new Room("Hus", "Indgangen til et mørkt hus");
            Room r3 = new Room("Mørkt rum", "Et meget mørkt rum");
            Room r4 = new Room("Fangekælder", "Uhyggeligt rum med masser af sjove lyde, du kan ikke se noget i dette rum");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

            r1.AddEast(r2);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }


    }
}

-------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDesign
{
    public class Room
    {
        public Room north;
        public Room south;
        public Room west;
        public Room east;
        public string navn;
        public string beskrivelse;

        public Room(string navn, string beskrivelse)
        {
            this.navn = navn;
            this.beskrivelse = beskrivelse;
        }

        public void AddNorth(Room r)
        {
            north = r;
        }

        public void AddSouth(Room r)
        {
            south = r;
        }
        public void AddWest(Room r)
        {
            west = r;
        }
        public void AddEast(Room r)
        {
            east = r;
        }

        public override string ToString()
        {
            string s = "";
            s += "Navn: " + navn + "\n";
            s += "Beskrivelse: " + beskrivelse + "\n";
            if (north != null) s += "Udgang til: " + north.navn + "\n";
            if (south != null) s += "Udgang til: " + south.navn + "\n";
            if (west != null) s += "Udgang til: " + west.navn + "\n";
            if (east != null) s += "Udgang til: " + east.navn + "\n";
            return s;
        }


    }
}