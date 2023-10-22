using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Model
{
      public class User : BaseModel
      {
        public DateTime CreateDate { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string Login { get; set; }
        public string Adres { get; set; }
        public long RolesId { get; set; }


      }
}
