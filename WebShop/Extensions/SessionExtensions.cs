using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop
{
    public static class SessionExtensions
    {
        private const string MAIL = "usermail";
        private const string ID = "userid";
        private const string BASKET = "userbasket";

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

        public static void SetUserBasket(this ISession session, List<int> items)
        {
            var json = JsonConvert.SerializeObject(items);

            session.SetString(BASKET, json);
        }

        public static List<int> GetUserBasket(this ISession session)
        {
            var json = session.GetString(BASKET);
            return json == null ? null : JsonConvert.DeserializeObject<List<int>>(json);
        }
    }
}
