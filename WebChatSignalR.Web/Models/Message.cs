using System;

namespace WebChatSignalR.Web.Models
{
    public class Message
    {
        public Int64 destination { get; set; }
        public User sender { get; set; }
        public object message { get; set; }
    }
}