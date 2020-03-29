using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    /// <summary>
    /// Class for administrator objects
    /// </summary>
    class Administrator
    {
        public int AdminstratorID {get; set;}

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }
        
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }


        }
    }

