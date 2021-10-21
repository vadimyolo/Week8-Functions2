using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = RandomHero();
            string villain = RandomVillain();
            string weapon = RandomWeapon();
            Console.WriteLine($"fight will be between {hero} and {villain} and the weapon will be used; {weapon}");

        }
        private static string RandomHero()
        {
            string[] heroes = {"George Bush", "JFK", "Osama"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            return heroes[randomIndex];

           
        }
        private static string RandomVillain()
        {
            string[] villains = { "G.Floyd", "Joe Biden", "Your momma" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            return villains[randomIndex];
            



        }
        private static string RandomWeapon()
        {
            string[] weapons = { "Marko Mõistt ", "Airpods", "Prillid" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapons.Length);

            return weapons[randomIndex];
        }
    }
}
