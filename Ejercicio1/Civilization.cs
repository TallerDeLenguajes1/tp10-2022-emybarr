
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Ejercicio1
{
    public class Civilization
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expansion")]
        public string Expansion { get; set; }

        [JsonPropertyName("army_type")]
        public string ArmyType { get; set; }

        [JsonPropertyName("unique_unit")]
        public List<string> UniqueUnit { get; set; }

        [JsonPropertyName("unique_tech")]
        public List<string> UniqueTech { get; set; }

        [JsonPropertyName("team_bonus")]
        public string TeamBonus { get; set; }

        [JsonPropertyName("civilization_bonus")]
        public List<string> CivilizationBonus { get; set; }
    

   

 
    public void mostrarCivilizacion() {
    Console.WriteLine($"Id: { Id }");
    Console.WriteLine($"Name: { Name }");
    Console.WriteLine($"Expansion: { Expansion }");
    Console.WriteLine($"ArmyType: { ArmyType }");
    Console.WriteLine("UniqueUnit: ");
    if (UniqueUnit != null) 
    {
      foreach (string uniqueUnit in UniqueUnit) {
        Console.WriteLine(uniqueUnit);
      };
    };
    Console.WriteLine("UniqueTech: ");
    if (UniqueTech != null) 
    {
      foreach (string uniqueTech in UniqueTech) {
        Console.WriteLine(uniqueTech);
      };
    };
    Console.WriteLine("CivilizationBonus: ");
    if (CivilizationBonus != null) 
    {
      foreach (string civilizationBonus in CivilizationBonus) {
        Console.WriteLine( civilizationBonus);
      };
    };
  }
}

 public class CivilizationLista
    {
        [JsonPropertyName("civilizations")]
        public List<Civilization> Civilizations { get; set; }
    }

}