using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Models
{
    class User
    {
        public int ID { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }

        public List<vehicle> vehicles {get;set;}

        public User()
        {
            this.vehicles = new List<vehicle>();
        }
        public void Register()
        {
            throw new NotImplementedException();
        }

        public void Authenticate()
        {
            throw new NotImplementedException();
        }

    }
}
