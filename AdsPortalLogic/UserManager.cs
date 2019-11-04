using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsPortal.Logic
{
    public class UserManager : BaseManager<User>
    {
        public UserManager(AdsPortalDb db)
            :base(db)
        {
            
        }

        protected override DbSet<User> Table
            => _db.Users;

        public User GetByEmailAndPassword(string email, string password)
        {
            return Table.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User GetByEmail(string email)
        {
            return Table.FirstOrDefault(u => u.Email == email);
        }


        public void Seed()
        {
            
        }
    }
}