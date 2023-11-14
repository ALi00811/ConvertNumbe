using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_Dahgan
    {
        public static string Middle(long number)
        {
            string Result = "";
            switch (number)
            {
                case 1:
                    Result = "ده";
                    break;
                case 2:
                    Result = "بیست";
                    break;
                case 3:
                    Result = "سی";
                    break;
                case 4:
                    Result = "چهل";
                    break;
                case 5:
                    Result = "پنجاه";
                    break;
                case 6:
                    Result = "شصت";
                    break;
                case 7:
                    Result = "هفتاد";
                    break;
                case 8:
                    Result = "هشتاد";
                    break;
                case 9:
                    Result = "نود";
                    break;
                

            }
            return Result;
        }
    }
}
