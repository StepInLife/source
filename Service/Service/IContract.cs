using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        RegistrationErrors InsertCheck(string name, string surname, DateTime birthday, string specialization, string email, string password, string city);
    }
}
