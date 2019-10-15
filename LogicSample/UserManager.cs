using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSample
{
    public class UserManager
    {
        private int currentId;
        private List<User> Users;

        public UserManager()
        {
            Users = new List<User>();
            currentId = 100;
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public User CreateNew(User user)
        {
            user.Id = currentId;
            Users.Add(user);
            currentId++;

            return user;
        }

        public void Delete(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }

        public User Get(int id)
        {
            var user = Users.Find(u => u.Id == id);

            return user;
        }

        public void Update(User user)
        {
            var currentUser = Users.Find(u => u.Id == user.Id);
            // properties to update:
            currentUser.Name = user.Name;

        }

        // STUB data 
        // dummy data
        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Name = "Name 1"
            });

            Users.Add(new User()
            {
                Id = 2,
                Name = "Name 2"
            });
        }
    }
}
