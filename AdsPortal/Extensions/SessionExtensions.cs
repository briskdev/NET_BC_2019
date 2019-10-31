using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdsPortal
{
    public static class SessionExtensions
    {
        private const string MAIL = "usermail";
        private const string ID = "userid";
        
        public static void SetUserEmail(this ISession session, string email)
        {
            session.SetString(MAIL, email);
        }

        public static string GetUserEmail(this ISession session)
        {
            return session.GetString(MAIL);
        }

        public static void SetUserId(this ISession session, int id)
        {
            session.SetInt32(ID, id);
        }

        public static int? GetUserId(this ISession session)
        {
            return session.GetInt32(ID);
        }
    }
}
