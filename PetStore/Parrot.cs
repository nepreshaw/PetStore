using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore {
   public class Parrot : IPetAnimal {

        public int Inventory { get; set; } = 0;
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public int Longevity { get; set; }




    }
}
