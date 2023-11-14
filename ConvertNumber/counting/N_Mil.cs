using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_Mil
    {
        public static string Give(long number)
        {
            string Result = "";
            switch (number)
            {
                case 1:
                    Result = "یک ملیون";
                    break;
                case 2:
                    Result = "دومیلیون";
                    break;
                case 3:
                    Result = "سه میلیون";
                    break;
                case 4:
                    Result = "چهار میلیون";
                    break;
                case 5:
                    Result = "پنج میلیون";
                    break;
                case 6:
                    Result = "شش میلیون";
                    break;
                case 7:
                    Result = "هفت میلیون";
                    break;
                case 8:
                    Result = "هشت میلیون";
                    break;
                case 9:
                    Result = "نه میلیون";
                    break;


            }
            return Result;
        }
    }
}
