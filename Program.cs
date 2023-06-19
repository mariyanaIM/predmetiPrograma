using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predmeti
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                int count = int.Parse(Console.ReadLine());
                List<Ocenki>listOcenki = new List<Ocenki>();
                for (int i = 0; i < count; i++)
                {
                    var danni = Console.ReadLine().Split();
                    Ocenki ocenki = new Ocenki(danni[0], danni[1], danni[2], int.Parse(danni[3]), double.Parse(danni[4]));
                    listOcenki.Add(ocenki);
                }

                listOcenki.Sort();
               
                listOcenki.ForEach(x => x.Print());
                Console.WriteLine(listOcenki.Select(x => x.Uspeh).Max());

            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"ArgException: {exception.Message}");
                throw;
            }
        }
    }
}

