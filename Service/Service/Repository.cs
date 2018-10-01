//using Service.Database;
using Service.DBCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class Repository
    {
        DBModel context;

        public Repository()
        {
            context = new DBModel();
        }
        public RegistrationErrors InsertCheck(string name, string surname, DateTime birthday, string specialization, string email, string password, string city)
        {
            var emailCheck = from person in context.Users where person.Email == email select new BusinessUser
            {
                Name = person.Name,
                Surname = person.Surname,
                Birthday = person.Birthday,
                Specialization = person.Specialization,
                Email = person.Email,
                Password = person.UserPassword,
                City = person.City
            };
            int strengthCheck = password.Length;

            if (emailCheck == null && strengthCheck > 8)
            {
                User newUser = new User()
                {
                    Name = name,
                    Surname = surname,
                    Birthday = birthday,
                    Specialization = specialization,
                    Email = email,
                    UserPassword = password,
                    City = city
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                return RegistrationErrors.OK;
            }
            else if (emailCheck != null)
                return RegistrationErrors.EmailError;
            else if (strengthCheck < 8)
                return RegistrationErrors.PasswordStrength;
            else
                return RegistrationErrors.UnknownError;


        }
    }
}
