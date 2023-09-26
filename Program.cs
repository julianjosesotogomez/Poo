// See https://aka.ms/new-console-template for more information
using Poo.Models;

SuperPower canFly = new SuperPower();
canFly.Name = "Volar";
canFly.Description = "Capacidad de volar y planear";
canFly.Level = PowerLevel.OneLevel;

SuperPower superStrength = new SuperPower();
superStrength.Name = "Super Fuerza";
superStrength.Description = "Capacidad de levantar lo que sea";
superStrength.Level = PowerLevel.TwoLevel;



SuperHeroe superman = new SuperHeroe();
superman.Id = 1;
superman.Name = "Superman";
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
hulk.Name = "Hulk";
hulk.SecretIdentity = "Mark Ruffalo ";
hulk.City = "Ciudad Capital";
hulk.CanFly = false;
List<SuperPower> hulkPowers = new List<SuperPower>();
hulkPowers.Add(superStrength);
hulk.SuperPowers = hulkPowers;
string result =  hulk.UseSuperpowersString();
Console.WriteLine(result);



enum PowerLevel
{
    OneLevel,
    TwoLevel,
    ThreeLevel,
}


