using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string Specialization { get; set; }
        DateTime BirthDay { get; set; }
        string City { get; set; }
        string Password { get; set; }
        string Email { get; set; }
    }
}
