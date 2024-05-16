using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Date
    {
        public static bool checkDate(string s)
        {
            try
            {
                DateTime date = DateTime.Parse(s);
                return true;

            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
