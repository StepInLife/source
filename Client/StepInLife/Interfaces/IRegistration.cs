using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modes.Interfaces
{
    interface IRegistration
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string Specialization { get; set; }
        DateTime BirthDay { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string City { get; set; }
        //IEnumerable<string> Cities { get; }

    }
}
