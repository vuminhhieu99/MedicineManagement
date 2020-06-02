using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineManagement.Controllers
{
    class ConvertFromNumToText
    {
        public static string NumToText(string num)
        {
            string[] Ones = { "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] Tens = { "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            int no = int.Parse(num);
            string strWords = "";

            if (no > 999 && no < 10000)
            {
                int i = no / 1000;
                strWords = strWords + Ones[i - 1] + " nghìn ";
                no = no % 1000;
            }


            if (no > 99 && no < 1000)
            {
                int i = no / 100;
                strWords = strWords + Ones[i - 1] + " trăm ";
                no = no % 100;
            }

            if (no > 19 && no < 100)
            {
                int i = no / 10;
                strWords = strWords + Tens[i - 1] + " ";
                no = no % 10;
            }

            if (no > 0 && no < 20)
            {
                strWords = strWords + Ones[no - 1];
            }
            return strWords;
        }

        public static string Convert(string totalMoney)
        {
            string result = totalMoney;
            string temp = "";
            int len = 9 - result.Length;

            for (int i = 0; i < len; i++)
            {
                temp += "0";
            }
            result = temp + result;

            result = NumToText(result.Substring(0, 3)) + " triệu " + NumToText(result.Substring(3, 3)) + " nghìn đồng";
            temp = result.Substring(0, 1).ToUpper();
            result = result.Substring(1);
            result = temp + result;

            return result;
        }
    }
}
