using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Prescriptionline
    {
        private int? iD_Prescription;
        private int? iD_Medicine;
        private int? amount;
        private decimal? healthInsurance;
        private decimal? intoMoney;

        private int search_MinAmount;
        private int search_MaxAmount;
        private decimal search_MinIntoMoney;
        private decimal search_MaxIntoMoney;

        public int? ID_Prescription { get => iD_Prescription; set => iD_Prescription = value; }
        public int? ID_Medicine { get => iD_Medicine; set => iD_Medicine = value; }
        public int? Amount { get => amount; set => amount = value; }
        public decimal? HealthInsurance { get => healthInsurance; set => healthInsurance = value; }
        public decimal? IntoMoney { get => intoMoney; set => intoMoney = value; }
        public int Search_MinAmount { get => search_MinAmount; set => search_MinAmount = value; }
        public int Search_MaxAmount { get => search_MaxAmount; set => search_MaxAmount = value; }
        public decimal Search_MinIntoMoney { get => search_MinIntoMoney; set => search_MinIntoMoney = value; }
        public decimal Search_MaxIntoMoney { get => search_MaxIntoMoney; set => search_MaxIntoMoney = value; }

        public Prescriptionline()
        {
            Amount = 0;
            HealthInsurance = 0;
            IntoMoney = 0;
        }
    }
}
