using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ConvertNumber.counting;
using ConvertNumber.Analize;


namespace ConvertNumber.Main
{
    public static class ConvertNumber
    {
        static List<int> SetNumber = new List<int>();

        public static string Converter(string number)
        {
            SetNumber.Clear();

            number = number.Replace(",", "");
            for (int i = 0; i < number.Length; i++)
            {
                SetNumber.Add(int.Parse(number[i].ToString()));
            }

            string Result = "";
            try
            {
                switch (SetNumber.Count)
                {
                    case 1:
                        Result = N_One.Give(SetNumber[0]);
                        break;
                    case 2:
                        Result = Analize.Analize.Dahgan(SetNumber[0], SetNumber[1]);
                        break;
                    case 3:
                        Result = Analize.Analize.Sadgan(SetNumber[0], SetNumber[1], SetNumber[2]);
                        break;
                    case 4:
                        Result = Analize.Analize.Hezargan(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3]);
                        break;
                    case 5:
                        Result = Analize.Analize.Hezargan2(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3], SetNumber[4]);
                        break;
                    case 6:
                        Result = Analize.Analize.Hezargan3(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3], SetNumber[4], SetNumber[5]);
                        break;
                    case 7:
                        Result = Analize.Analize.Mil(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3], SetNumber[4], SetNumber[5], SetNumber[6]);
                        break;
                    case 8:
                        Result = Analize.Analize.Mil2(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3], SetNumber[4], SetNumber[5], SetNumber[6], SetNumber[7]);
                        break;
                    case 9:
                        Result = Analize.Analize.Mil3(SetNumber[0], SetNumber[1], SetNumber[2], SetNumber[3], SetNumber[4], SetNumber[5], SetNumber[6], SetNumber[7], SetNumber[8]);
                        break;
                    default:
                        Result = "خطا!";
                        break;

                }
            }
            catch (Exception)
            {
                Result = "خطا!";
            }

            return Result;
        }
    }
}
