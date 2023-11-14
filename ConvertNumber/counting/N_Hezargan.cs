using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.counting
{
    public static class N_Hezargan
    {
        public static string Give(long number)
        {
            string Result = "";
            switch (number)
            {
                case 1:
                    Result = "یک هزار";
                    break;
                case 2:
                    Result = "دوهزار";
                    break;
                case 3:
                    Result = "سه هزار";
                    break;
                case 4:
                    Result = "چهارهزار";
                    break;
                case 5:
                    Result = "پنج هزار";
                    break;
                case 6:
                    Result = "شش هزار";
                    break;
                case 7:
                    Result = "هفت هزار";
                    break;
                case 8:
                    Result = "هشت هزار";
                    break;
                case 9:
                    Result = "نه هزار";
                    break;
            }
            return Result;
        }
    }
}
