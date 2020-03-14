using System;

namespace WebChatSignalR.Web.Models
{
    public class User
    {
        public string name { get; set; }
        public Int64 key { get; set; }
        public DateTime dtConnection { get; set; }
    }
}