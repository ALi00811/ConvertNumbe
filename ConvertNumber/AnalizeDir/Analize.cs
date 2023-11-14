using ConvertNumber.counting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumber.Analize
{
    public static class Analize
    {
        public static string Dahgan(int numdahgan, int numyekan)
        {
            string SumNumString = $"{numdahgan.ToString() + numyekan.ToString()}";
            int SumNum = int.Parse(SumNumString);
            string? Result;
            if (SumNum >= 10 && SumNum < 20)
            {
                Result = N_Middle.Give(SumNum);
            }
            else
            {
                if (numyekan != 0)
                    Result = $"{N_Dahgan.Middle(numdahgan)} و {N_One.Give(numyekan)}";
                else
                    Result = $"{N_Dahgan.Middle(numdahgan)}";
            }
            return Result;
        }
        public static string Sadgan(int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{N_Sadgan.Give(numsadgan)} و {Dahgan(numdahgan, numyekan)}";
            return Result;
        }

        public static string Hezargan(int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{N_Hezargan.Give(hezargan)} و {Sadgan(numsadgan, numdahgan, numyekan)}";
            return Result;
        }
        public static string Hezargan2(int hezargan2, int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{Dahgan(hezargan2, hezargan)} هزار {Sadgan(numsadgan, numdahgan, numyekan)}";
            return Result;
        }
        public static string Hezargan3(int hezargan3, int hezargan2, int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{Sadgan(hezargan3, hezargan2, hezargan)} هزار و {Sadgan(numsadgan, numdahgan, numyekan)}";
            return Result;
        }
        public static string Mil(int mil, int hezargan3, int hezargan2, int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{N_Mil.Give(mil)} و {Hezargan3(hezargan3, hezargan2, hezargan, numsadgan, numdahgan, numyekan)}";
            return Result;
        }
        public static string Mil2(int mil2, int mil, int hezargan3, int hezargan2, int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{Dahgan(mil2, mil)} میلیون و {Hezargan3(hezargan3, hezargan2, hezargan, numsadgan, numdahgan, numyekan)}";
            return Result;
        }
        public static string Mil3(int mil3, int mil2, int mil, int hezargan3, int hezargan2, int hezargan, int numsadgan, int numdahgan, int numyekan)
        {
            string Result = $"{Sadgan(mil3 ,mil2, mil)} میلیون و {Hezargan3(hezargan3, hezargan2, hezargan, numsadgan, numdahgan, numyekan)}";
            return Result;
        }

    }
}
