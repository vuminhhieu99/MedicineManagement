using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Inputcouponline
    {
        private int? iD_InputCouponLine;
        private string name;
        private string unitInput;
        private int? amount;
        private decimal? price;
        private DateTime expiryDate;
        private int? numUnitOutput;
        private string productionBatch;
        private decimal? intoMoney;
        private int? iD_InputCoupon;
        private int? iD_Medicine;

        private int search_MinAmount;
        private int search_MaxAmount;
        private decimal search_MinPrice;
        private decimal search_MaxPrice;
        private DateTime search_StartExpiryDate;
        private DateTime search_EndExpiryDate;
        private decimal search_MinIntoMoney;
        private decimal search_MaxIntoMoney;


        public int? ID_InputCouponLine { get => iD_InputCouponLine; set => iD_InputCouponLine = value; }
        public string Name { get => name; set => name = value; }
        public string UnitInput { get => unitInput; set => unitInput = value; }
        public int? Amount { get => amount; set => amount = value; }
        public decimal? Price { get => price; set => price = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public int? NumUnitOutput { get => numUnitOutput; set => numUnitOutput = value; }
        public string ProductionBatch { get => productionBatch; set => productionBatch = value; }
        public decimal? IntoMoney { get => intoMoney; set => intoMoney = value; }
        public int? ID_InputCoupon { get => iD_InputCoupon; set => iD_InputCoupon = value; }
        public int? ID_Medicine { get => iD_Medicine; set => iD_Medicine = value; }
        public int Search_MinAmount { get => search_MinAmount; set => search_MinAmount = value; }
        public int Search_MaxAmount { get => search_MaxAmount; set => search_MaxAmount = value; }
        public decimal Search_MinPrice { get => search_MinPrice; set => search_MinPrice = value; }
        public decimal Search_MaxPrice { get => search_MaxPrice; set => search_MaxPrice = value; }
        public DateTime Search_StartExpiryDate { get => search_StartExpiryDate; set => search_StartExpiryDate = value; }
        public DateTime Search_EndExpiryDate { get => search_EndExpiryDate; set => search_EndExpiryDate = value; }
        public decimal Search_MinIntoMoney { get => search_MinIntoMoney; set => search_MinIntoMoney = value; }
        public decimal Search_MaxIntoMoney { get => search_MaxIntoMoney; set => search_MaxIntoMoney = value; }

        public Inputcouponline()
        {
            Amount = 0;
            Price = 0;
            NumUnitOutput = 1;
            IntoMoney = 0;
        }
    }
    
}
