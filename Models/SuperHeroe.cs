﻿using System.Text;

namespace Poo.Models
{
    internal class SuperHeroe : Heroe
    {
        private string _name;

        public int Id;
        //Encapsulamiento
        public override string Name 
        {   get 
            { 
                return _name; 
            }
            set
            {
                _name = value.Trim();//Limpiar espacios 
            }
        }
        //Encapsulamiento
        public string SecretIdentityName
        {
            get
            {
                return $"{Name} ({SecretIdentity})";
            }
        }
        public string SecretIdentity;
        public override string City { get; set; }
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
                Console.WriteLine($"{SecretIdentityName} esta usando el super poder {item.Name}");
            }
        }
        public string UseSuperpowersString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPowers)
            {
                sb.AppendLine($"{SecretIdentityName} esta usando el super poder {item.Name}");
            }
            return sb.ToString();
        }

        //Implementacion 
        public override string SaveWorld()
        {
            return $"{SecretIdentityName} ha salvado el mundo";
        }
    }

}
