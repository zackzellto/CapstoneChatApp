using System;
namespace ReactChatApp.Models
{
    public class ChatMessages
    {
        public virtual long user_id { get; set; }
        public virtual int message_id { get; set; }
        public virtual string message { get; set; }

    }
}
