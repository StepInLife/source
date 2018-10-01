using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.Interfaces;

namespace ServiceClient
{
    class Registration : IRegistration
    {
        bool IRegistration.Registration(IUser obj)
        {
            StepInLifeService.ContractClient client = new StepInLifeService.ContractClient();
            Console.WriteLine(client.InsertCheck("qwerty", "qwerty", DateTime.Now, "qwert", "ssmolovoi", "123456789", "Kyiv"));

        }
    }
}
