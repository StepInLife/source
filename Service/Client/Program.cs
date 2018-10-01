using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            StepInLifeService.ContractClient client = new StepInLifeService.ContractClient();

            Console.WriteLine(client.InsertCheck("qwerty", "qwerty", DateTime.Now, "qwert", "ssmolovoi", "123456789", "Kyiv"));
            Console.ReadKey();
        }
    }
}
