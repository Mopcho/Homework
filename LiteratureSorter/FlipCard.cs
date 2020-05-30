using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSorter
{
   public class Engine
   {
        public Dictionary<string, string> Data = new Dictionary<string, string>();
        private Random rnd = new Random();

        public Engine(Dictionary<string, string> data)
        {
            this.Data = data;
        }

        public void Start()
        {
            while (true)
            {
                int index = this.rnd.Next(0, this.Data.Count);

                var pair = this.Data.ElementAt(index);

                Console.WriteLine(pair.Key);

                Console.ReadLine();

                Console.WriteLine(pair.Value);

                Console.ReadLine();

                Console.Clear();

            }
        }
   }
}

