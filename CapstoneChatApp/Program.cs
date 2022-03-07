using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NHibernate;
using ISession = NHibernate.ISession;
using ReactChatApp;
using ReactChatApp.Models;

namespace CapstoneChatApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            CreateUser();
            GetAllUsers();
        }

        private static void CreateUser()
        {
            ChatUsers chatter = new ChatUsers()
            {
                first_name = "New",
                last_name = "User",
                email = "newuser@email.com",
                password = "Password123"

            };

            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Save(chatter);
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }
        public static void GetAllUsers()
        {
            NHibernate.ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var chatusers = from chatuser in session.Query<ChatUsers>()
                                    select chatuser;

                    foreach (var f in chatusers)
                    {
                        Console.WriteLine("{0} {1} {2}", f.id, f.first_name, f.email);
                    }
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

