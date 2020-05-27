using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Models
{
    public struct column
    {
        public string name;
        public long value;
        public long percent;
    };

    public class Chart
    {
        private string nameChart;
        private string nameX;
        private string nameY;
        private int columnCount;
        
        public List<column> listColumn;

        public string NameChart { get => nameChart; set => nameChart = value; }
        public string NameX { get => nameX; set => nameX = value; }
        public string NameY { get => nameY; set => nameY = value; }
        public int ColumnCount { get => columnCount; set => columnCount = value; }
        
        public List<column> ListColumn { get => listColumn; set => listColumn = value; }


        public Chart()
        {
            NameChart = "";
            NameX = "";
            NameY = "";
            ColumnCount = 0;            
            ListColumn = new List<column>();
        }
        public Chart(string NameChart, string NameX, string NameY, int ColumnCount)
        {
            this.NameChart = NameChart;
            this.NameX = NameX;
            this.NameY = NameY;
            this.ColumnCount = ColumnCount;            

            ListColumn = new List<column>(ColumnCount);            
        }

    }
}




