using Magazin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Magazin.Controller
{
    internal class UserController
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            for (int i = 0; i < 1000; i++)
            {
                User a = new()
                {
                    Id = i++,
                    Name = $"User{i}",
                    Adres = $"Adres{i}",
                    CreateDate = DateTime.Now.AddDays(i)
                };
                users.Add(a);
            }
            return users;
        }


    }
}
