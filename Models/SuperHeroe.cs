﻿using System.Text;

namespace Poo.Models
{
    internal class SuperHeroe
    {
        public int Id;
        public string Name;
        public string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers;
        public bool CanFly;

        //Constructor
        public SuperHeroe()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        //Funcion
        public void UseSuperpowers()
        {
            foreach (var item in SuperPowers)
            {
                Console.WriteLine($"{Name} esta usando el super poder {item.Name}");
            }
        }
        public string UseSuperpowersString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPowers)
            {
                sb.AppendLine($"{Name} esta usando el super poder {item.Name}");
            }
            return sb.ToString();
        }
    }

}