using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_ERRHNDL
{
    class UserList
    {
        private List<UserProfile> users = new List<UserProfile>();

        public void Add(string fullName, UserProfile.Genders gender, DateTime date)
        {
            // pārbaudes
            // 1. Datums nedrīkst būt nākotnē.
            if(date > DateTime.Now)
            {
                throw new InputException("Birth date can not be in future!");
            }
            // 2. Datums nedrīkst būt mazāks par 01.01.1800.
            if (date < new DateTime(1800, 1, 1))
            {
                throw new InputException("Birth date can't be less than 01.01.1800");
            }
            // 3. Pilnais vārds nedrīkst pārsniegt 20 simbolus.
            if (fullName.Length > 20)
            {
                throw new InputException("Full name too long!");
            }

            // lietotāja izveide
            UserProfile user = new UserProfile(fullName, date, gender);

            // lietotāja pievienošana
            users.Add(user);

            Console.WriteLine("User with age {0} added!", user.Age());
        }
    }
}
