
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Number;
namespace Utils
{
    public class Phone
    {
        static string []arrPhone = {"0162", "0163", "0164"," 0165", "0166", "0167", "0168", "0169",
            "0123", "0124", "0125", "0127", "0129", "0120", "0121", "0122", "0126", "0128", "0186", "0199"};
        static string []arrNewPhone = {"032","033","034","035","036","037", "038","039","083","084","085","081","082",
            "070","079","077","076","078","058","059"};
        static string []arrAllFirstnumPhone = {"032","033","034","052","035","036","037", "038","039","083","084","085","081","082",
            "070","079","077","076","078","058","059","089","090","093","092","056","088","091","094","086","097","096","098"};
        // chuyển đổi 11 thành 10 số
        public static string changePhoneNumber(string sNum)
        {
            if (sNum.CompareTo("") == 0)
                return "error_phone";
            if(sNum.Length < 10 || sNum.Length >11)
                return "error_phone";
            string newPhone = changeNumber(sNum) + "";
            if (sNum.CompareTo(newPhone) == 0 && !checkPhoneNumber(sNum)) // nếu đầu số như cũ và không có trong tất cả đầu số mới
                return "error_Phone";
            else
                return newPhone;
        }
        // kiểm tra có phải số
        public static bool checkNumber(string s)
        {
            try
            {
                int num = int.Parse(s);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static string changeNumber(string sNum)
        {
            string fourNumFirst = sNum.Substring(0, 4);
            
            for (int i = 0; i < arrPhone.Length; i++)
            {
                if (arrPhone[i].CompareTo(fourNumFirst) == 0)
                    sNum = arrNewPhone[i] + sNum.Substring(4);
            }
            return sNum;
        }
        public static bool checkPhoneNumber(string sNum)
        {
            if (sNum.Length == 11)
                return false;
            String treeFirstNum = sNum.Substring(0, 3);
            for (int i = 0; i < arrAllFirstnumPhone.Length; i++)
                if (arrAllFirstnumPhone[i].CompareTo(treeFirstNum) == 0)
                    return true;
            return false;
        }
    }
}
