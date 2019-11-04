using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class UserManager : BaseManager<User>
    {
        public UserManager(WebShopDb db)
            :base(db)
        {
            
        }

        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }

        public User GetByEmail(string email)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email);

            return user;
        }

        public void Seed()
        {
        }
    }
}