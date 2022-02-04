using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTestKadai
{
    public class kuriage
    {
        public static int kuriage10(int i)
        {
            int result = i;
            bool flg = false;
            if (i < 0)
            {
                result = Math.Abs(i);
                flg = true;
            }

            result = (int)(Math.Ceiling(result * 0.1) * 10);  //切り上げ

            if (flg)    //負の数に戻す
            {
                result *= -1;
            }

            return result;
        }
    }
}
