using System.Collections.Generic;

namespace App.Domain
{
    public class User
    {
        public long UserId { get; set; }
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUri { get; set; } 
        // chats
        public List<long> Friends { get; set; }
    }
}
