using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var tempHelth = maximumHealth - currentHealth;
            var tempEnergy = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|',currentHealth)}{new string('.', tempHelth)}|");
            Console.WriteLine($"Energy: |{new string('|',currentEnergy)}{new string('.',tempEnergy)}|");
        }
    }
}
