using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Supplier
    {
        private int? iD_Supplier;
        private string name;
        private string address;
        private string phone;
        private string email;

        public int? ID_Supplier { get => iD_Supplier; set => iD_Supplier = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public Supplier()
        {
            ;
        }


    }
}
