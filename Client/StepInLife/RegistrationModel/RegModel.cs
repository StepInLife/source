using Modes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modes
{
    public class RegModel : IRegistration
    {
        public DateTime BirthDay { get; set; }

        //public IEnumerable<string> Cities
        //{
        //    get
        //    {
        //        return Cities;
        //    }
        //}

        public string City { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string Password { get; set; }

        public string Specialization { get; set; }

        public string Surname { get; set; }

    }
}
