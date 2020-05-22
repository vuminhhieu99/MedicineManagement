using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Prescription
    {
        private int iD_Prescription;
        private DateTime createDate;
        private string doctor;
        private int medicalRecord;
        private int drugstores;
        private decimal totalMoney;

        private DateTime search_StartCreateDate;
        private DateTime search_EndCreateDate;
        private decimal search_MinTotalMoney;
        private decimal search_MaxTotalMoney;

        public int ID_Prescription { get => iD_Prescription; set => iD_Prescription = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public int MedicalRecord { get => medicalRecord; set => medicalRecord = value; }
        public int Drugstores { get => drugstores; set => drugstores = value; }
        public decimal TotalMoney { get => totalMoney; set => totalMoney = value; }
        
        public DateTime Search_StartCreateDate { get => search_StartCreateDate; set => search_StartCreateDate = value; }
        public DateTime Search_EndCreateDate { get => search_EndCreateDate; set => search_EndCreateDate = value; }
        public decimal Search_MinTotalMoney { get => search_MinTotalMoney; set => search_MinTotalMoney = value; }
        public decimal Search_MaxTotalMoney { get => search_MaxTotalMoney; set => search_MaxTotalMoney = value; }

        public Prescription()
        {
            TotalMoney = 0;
        }
    }
}
