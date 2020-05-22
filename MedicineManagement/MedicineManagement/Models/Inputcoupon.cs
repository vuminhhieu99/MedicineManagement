using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Inputcoupon
    {
        private int iD_InputCoupon;
        private DateTime createDate;
        private int iD_Supplier;
        private decimal totalMoney;

        private DateTime search_StartCreateDate;
        private DateTime search_EndCreateDate;

        private decimal search_MinTotalMoney;
        private decimal search_MaxTotalMoney;

        public int ID_InputCoupon { get => iD_InputCoupon; set => iD_InputCoupon = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public int ID_Supplier { get => iD_Supplier; set => iD_Supplier = value; }
        public decimal TotalMoney { get => totalMoney; set => totalMoney = value; }
        public DateTime Search_StartCreateDate { get => search_StartCreateDate; set => search_StartCreateDate = value; }
        public DateTime Search_EndCreateDate { get => search_EndCreateDate; set => search_EndCreateDate = value; }
        public decimal Search_MinTotalMoney { get => search_MinTotalMoney; set => search_MinTotalMoney = value; }
        public decimal Search_MaxTotalMoney { get => search_MaxTotalMoney; set => search_MaxTotalMoney = value; }

        public Inputcoupon()
        {
            TotalMoney = 0;
        }
    }
}
