using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactChatApp.Models
{
    public class ChatUsers
    {
        public virtual long id { get; set; }
        public virtual string first_name { get; set; }
        public virtual string last_name { get; set; }
        public virtual string email { get; set; }
        public virtual string password { get; set; }
    }
}
