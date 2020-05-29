using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public class Medicine
    {
        private int iD_Medicine;
        private string name;
        private string medicineGroup;
        private string uses;
        private string unit;
        private decimal price;
        private int totalInventory;
        private string note;
        private string mostUsedMonth;

        private decimal search_MinPrice;
        private decimal search_MaxPrice;
        private decimal search_MinTotalInventory;
        private decimal search_MaxTotalInventory;


        public int ID_Medicine { get => iD_Medicine; set => iD_Medicine = value; }
        public string Name { get => name; set => name = value; }
        public string MedicineGroup { get => medicineGroup; set => medicineGroup = value; }
        public string Uses { get => uses; set => uses = value; }
        public string Unit { get => unit; set => unit = value; }
        public decimal Price { get => price; set => price = value; }
        public int TotalInventory { get => totalInventory; set => totalInventory = value; }
        public string Note { get => note; set => note = value; }
        public string MostUsedMonth { get => mostUsedMonth; set => mostUsedMonth = value; }
        public decimal Search_MinPrice { get => search_MinPrice; set => search_MinPrice = value; }
        public decimal Search_MaxPrice { get => search_MaxPrice; set => search_MaxPrice = value; }
        public decimal Search_MinTotalInventory { get => search_MinTotalInventory; set => search_MinTotalInventory = value; }
        public decimal Search_MaxTotalInventory { get => search_MaxTotalInventory; set => search_MaxTotalInventory = value; }


        public Medicine()
        {
           

            Price = 0;
            TotalInventory = 0;
        }
    }
}
