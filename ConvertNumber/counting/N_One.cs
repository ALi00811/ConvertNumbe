using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_One
    {
        public static string Give(long number)
        {
            string Result = "";
            switch (number)
            {
                case 0:
                    Result = "صفر";
                    break;
                case 1:
                    Result = "یک";
                    break;
                case 2:
                    Result = "دو";
                    break;
                case 3:
                    Result = "سه";
                    break;
                case 4:
                    Result = "چهار";
                    break;
                case 5:
                    Result = "پنج";
                    break;
                case 6:
                    Result = "شش";
                    break;
                case 7:
                    Result = "هفت";
                    break;
                case 8:
                    Result = "هشت";
                    break;
                case 9:
                    Result = "نه";
                    break;

            }
            return Result;
        }


    }
}

