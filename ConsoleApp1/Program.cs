using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Blabla(List<people> listOfPeople)
        {
            foreach(var people in listOfPeople)
            {
                Console.WriteLine("");
                Console.WriteLine(people.GetFI());
                Console.WriteLine(people.GetAge());
                if ( people.GetType() == typeof(employee))
                {
                    var employee1 = (employee)people;
                    Console.WriteLine(employee1.workspace);
                }
                if( people.GetType() == typeof(child))
                {
                    var child1 = (child)people;
                    child1.Scream();
                }
            }
        }

        static void Heroes(List<hero> listOfHeroes)
        {
            foreach (var hero in listOfHeroes)
            {
                Console.WriteLine("");
                Console.WriteLine("Name - " + hero.Name);
                Console.WriteLine("Class - " + hero.Class);
                Console.WriteLine("Health - " + hero.Health);
                Console.WriteLine("Mana - " + hero.Mana);
            }
        }
        static void Main(string[] args)
        {
            List<people> listOfPeople = new List<people>();
            List<hero> listOfHeroes = new List<hero>();

            var konstantin = new people();
            konstantin.SetAge(23);
            konstantin.SetFI("Gamayunov Konstantin");

            var dmitriy = new people();
            dmitriy.SetAge(23);
            dmitriy.SetFI("Aleksandrov Dmitriy");

            var emil = new employee();
            emil.SetAge(22);
            emil.SetFI("Mambetov Emil");
            emil.workspace = "ugol";

            var misha = new employee();
            misha.SetAge(37);
            misha.SetFI("Tumakov Mikhail");
            misha.workspace = "tron";

            var stas = new child();
            stas.SetAge(27);
            stas.SetFI("Sukhov Stanislav");

            listOfPeople.Add(konstantin);
            listOfPeople.Add(dmitriy);
            listOfPeople.Add(emil);
            listOfPeople.Add(misha);
            listOfPeople.Add(stas);
            Blabla(listOfPeople);
            var konstantin2 = new weaver();
            konstantin2.FirstSkill();

            var clinkz = new hero();
            clinkz.Name = "Clinkz";
            clinkz.Health = 550;
            clinkz.Mana = 300;
            clinkz.Class = "Carry";

            var leoric = new hero();
            leoric.Name = "Skeleton King";
            leoric.Class = "Carry";
            leoric.Health = 650;
            leoric.Mana = 200;

            var dazzle = new hero();
            dazzle.Name = "Dazzle";
            dazzle.Class = "Support";
            dazzle.Health = 500;
            dazzle.Mana = 500;

            var axe = new hero();
            axe.Name = "Axe";
            axe.Class = "Tank";
            axe.Health = 700;
            axe.Mana = 250;

            listOfHeroes.Add(clinkz);
            listOfHeroes.Add(leoric);
            listOfHeroes.Add(axe);
            listOfHeroes.Add(dazzle);
            Heroes(listOfHeroes);

            var breakfast = new breakfast();
            breakfast.MakeABreakfastAsync();
            Console.Read();
        }
    }
}
