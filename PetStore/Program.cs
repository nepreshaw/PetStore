using System;
using System.Collections.Generic;

namespace PetStore {
    class Program {
        static void Main(string[] args) {
            Parrot parrot = new Parrot() {
                Inventory = 17,
                Sound = "Squak",
                Price = 3000,
                Longevity = 60
            };
            Hedgehog hedgehog = new Hedgehog() {
                Inventory = 3,
                Sound = "Squeak",
                Price = 200,
                CuteLevel = "Ultimate"
            };
            Hamster hamster = new Hamster() {
                Inventory = 200,
                Sound = "Squeak'em",
                Price = 10,
                Color = "Brown"
            };

            List <IPetAnimal> animals = new List <IPetAnimal>();

            animals.Add(parrot);
            animals.Add(hedgehog);
            animals.Add(hamster);

            decimal total = 0;
            foreach(IPetAnimal a in animals) {
                decimal value = a.Price * a.Inventory;
                total += value;
                //.Name refers to class name
                Console.WriteLine($"All {a.GetType().Name}s will net {value:c}");
            }
            Console.WriteLine($"Total value os {total:c}");
        }
    }
}
