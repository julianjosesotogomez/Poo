﻿// See https://aka.ms/new-console-template for more information
using Poo.Models;
using static Poo.Record;

SuperPower canFly = new SuperPower();
canFly.Name = "Volar";
canFly.Description = "Capacidad de volar y planear";
canFly.Level = PowerLevel.OneLevel;

SuperPower superStrength = new SuperPower();
superStrength.Name = "Super Fuerza";
superStrength.Description = "Capacidad de levantar lo que sea";
superStrength.Level = PowerLevel.TwoLevel;

SuperPower regeneration = new SuperPower();
regeneration.Name = "Regeneracion";
regeneration.Description = "Capacidad de regenerar heridas";
regeneration.Level = PowerLevel.ThreeLevel;




SuperHeroe superman = new SuperHeroe();
superman.Id = 1;
superman.Name = "      Superman    ";
superman.SecretIdentity = "Clark Kent";
superman.City = "Ciudad Capital";
superman.CanFly = true;
List<SuperPower>supermanPowers = new List<SuperPower>();
supermanPowers.Add(canFly);
supermanPowers.Add(superStrength);
superman.SuperPowers = supermanPowers;
superman.UseSuperpowers();


SuperHeroe hulk = new SuperHeroe();
hulk.Id = 1;
hulk.Name = "      Hulk";
hulk.SecretIdentity = "Mark Ruffalo ";
hulk.City = "Ciudad Capital";
hulk.CanFly = false;
List<SuperPower> hulkPowers = new List<SuperPower>();
hulkPowers.Add(superStrength);
hulk.SuperPowers = hulkPowers;
string result =  hulk.UseSuperpowersString();
Console.WriteLine(result);


AntiHeroe wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.City = "Montañas";
wolverine.CanFly = false;
List<SuperPower> wolverinePowers = new List<SuperPower>();
wolverinePowers.Add(regeneration);
wolverinePowers.Add(superStrength);
wolverine.SuperPowers = wolverinePowers;
wolverine.UseSuperpowers();

string antiHeroeAction = wolverine.AntiHeroeAction("Atacar la policia");//Implementación de herencia 
Console.WriteLine(antiHeroeAction);



//Implementacion del Record 

SuperHeroRecord superHeroRecordOne = new(1, "Superman", "Clark Kent", "Ciudad Capital");
SuperHeroRecord superHeroRecordTwo = new(1, "Superman", "Clark Kent", "Ciudad Capital");

Console.WriteLine($"Implementacion de Record, result -> { superHeroRecordOne == superHeroRecordTwo}");


enum PowerLevel
{
    OneLevel,
    TwoLevel,
    ThreeLevel,
}


