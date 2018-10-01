using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Contract : IContract
    {
        Repository _repository;

        public Contract()
        {
            _repository = new Repository();
        }
        public RegistrationErrors InsertCheck(string name, string surname, DateTime birthday, string specialization, string email, string password, string city)
        {
            return _repository.InsertCheck(name, surname, birthday, specialization, email, password, city);
        }
    }
}
