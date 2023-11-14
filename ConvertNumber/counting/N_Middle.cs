using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_Middle
    {
        public static string Give(long number)
        {
            string Result = "";
            switch (number)
            {
                case 10:
                    Result = "ده";
                    break;
                case 11:
                    Result = "یازده";
                    break;
                case 12:
                    Result = "دوازده";
                    break;
                case 13:
                    Result = "سیزده";
                    break;
                case 14:
                    Result = "چهارده";
                    break;
                case 15:
                    Result = "پانزده";
                    break;
                case 16:
                    Result = "شانزده";
                    break;
                case 17:
                    Result = "هفده";
                    break;
                case 18:
                    Result = "هجده";
                    break;
                case 19:
                    Result = "نوزده";
                    break;

            }
            return Result;
        }
    }
}
