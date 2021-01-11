using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace loginSystem.Models
{
    public class Login
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Login>(this);
        
    }
}
