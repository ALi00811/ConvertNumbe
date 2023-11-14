using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_Sadgan
    {
        public static string Give(long number)
        {
            string Result = "";
            switch (number)
            {
                case 1:
                    Result = "صد";
                    break;
                case 2:
                    Result = "دویست";
                    break;
                case 3:
                    Result = "سیصد";
                    break;
                case 4:
                    Result = "چهارصد";
                    break;
                case 5:
                    Result = "پانصد";
                    break;
                case 6:
                    Result = "ششصد";
                    break;
                case 7:
                    Result = "هفتصد";
                    break;
                case 8:
                    Result = "هشتصد";
                    break;
                case 9:
                    Result = "نهصد";
                    break;


            }
            return Result;
        }
    }
}
