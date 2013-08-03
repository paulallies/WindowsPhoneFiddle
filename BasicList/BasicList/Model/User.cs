using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicList.Model
{
    public class User
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
