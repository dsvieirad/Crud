using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud
{
    internal class CadasUser
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string  Email { get; set; }

        public double Senha { get; set; }
        

      
    }
}
