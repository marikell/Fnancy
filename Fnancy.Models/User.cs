using System;
using System.Collections.Generic;
using System.Text;

namespace Fnancy.Models
{
    public class User
    {
        public int IdUser { get; set; }

        public string NamUser { get; set; }

        public string Password { get; set; }

        public string NamPerson { get; set; }

        public string Email { get; set; }

        public DateTime DatBirth { get; set; }

        public string CellNumber { get; set; }
    }
}
