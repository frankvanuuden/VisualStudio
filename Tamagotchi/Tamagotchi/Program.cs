using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorGaan = true;
            int keuze;

            while (doorGaan)
            {
                keuze = Menu();
                switch (keuze)
                {
                    case 0:
                        doorGaan = false;
                        break;
                    case 1:
                        Console.WriteLine("Je praat met je huisdier");
                        break;
                    case 2:
                        Console.WriteLine("Je geeft eten aan je huisdier");
                        break;
                    case 3:
                        Console.WriteLine("Je speelt met je huisdier");
                        break;
                    case 4:
                        Console.WriteLine("Je geeft je huisdier een andere naam");
                        break;
                    default:
                        Console.WriteLine("Kies een optie 1 t/m 4");
                        break;
            }
            }
        }

        private static int Menu()
        {
            throw new NotImplementedException();
        }
    }
}
