using System;
namespace ReactChatApp.Models
{
    public class ChatConversations
    {
        public virtual long conversation_id { get; set; }
        public virtual string created_at{ get; set; }
        public virtual string conversation_users { get; set; }
    }
}
