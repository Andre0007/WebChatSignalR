using System;

namespace WebChatSignalR.Web.Models
{
    public class ChatMessage
    {
        public Int64 destination { get; set; }
        public User sender { get; set; }
        public string message { get; set; }
    }
}