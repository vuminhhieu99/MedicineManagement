using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    class UserInfo
    {
        private string userName;
        private string userAddress;
        private string userPhone;
        private string userEmail;
        private DateTime createDate;

        public string UserName { get => userName; set => userName = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
        public string UserPhone { get => userPhone; set => userPhone = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }

        public UserInfo()
        {
            UserName = "";
            userAddress = "";
            UserEmail = "";
            userPhone = "";
            CreateDate = DateTime.Now;
        }

        
    }
}
