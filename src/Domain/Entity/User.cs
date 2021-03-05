using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
