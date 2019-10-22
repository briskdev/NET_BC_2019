using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class UserManager
    {
        private int CurrentId;
        private static List<User> Users = new List<User>();

        public UserManager()
        {
            CurrentId = 1000;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = Users.Find(u => u.Email == email && u.Password == password);

            return user;
        }

        public User Create(User user)
        {
            user.Id = CurrentId;
            Users.Add(user);
            CurrentId++;

            return user;
        }

        public User GetByEmail(string email)
        {
            var user = Users.Find(u => u.Email == email);

            return user;
        }

        public void Delete(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }

        public void Update(User user)
        {
            var currentUser = Users.Find(u => u.Id == user.Id);
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
        }

        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "test@mail.com",
                Password = "pass123"
            });
        }
    }
}