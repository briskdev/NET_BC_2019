﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class UserManager
    {
        WebShopDb _db;

        public UserManager(WebShopDb db)
        {
            _db = db;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }

        public User Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == email);

            return user;
        }

        public void Delete(int id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public void Update(User user)
        {
            var currentUser = _db.Users.FirstOrDefault(u => u.Id == user.Id);
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;

            _db.SaveChanges();
        }

        public void Seed()
        {
        }
    }
}