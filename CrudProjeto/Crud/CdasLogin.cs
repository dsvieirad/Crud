using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Crud
{
    public class Login
    {
        private static string email;
        public string Email { get => email; set => email = value; }

        public string Senha { get; set; }

        public string Id { get; set; }
    }
}
