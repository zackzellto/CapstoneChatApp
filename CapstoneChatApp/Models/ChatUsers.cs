using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactChatApp.Models
{
    public class ChatUsers
    {
        public virtual int id { get; set; }
        public virtual string first_name { get; set; }
        public virtual string last_name { get; set; }
        public virtual string email { get; set; }
        public virtual string password { get; set; }

        public ChatUsers(int id, string first_name, string last_name, string email, string password)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.password = password;
        }

        public ChatUsers()
        {
         
        }
    }
}
