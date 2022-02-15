using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest_DBkadai2
{
    public class kuriage
    {
        public static int kuriage10(int i)
        {
            if (i == 0)
            {
                return 0;
            }else if (i >= 0){
                double j = i;
                i = Convert.ToInt32(Math.Ceiling(j / 10) * 10);
            }
            else
            {
                double j = i;
                i = Convert.ToInt32(Math.Floor(j / 10) * 10);
            }
            
            return i;
        }
    }
}
