using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest_DBkadai2
{
    public class JetCoaster
    {
        static int i = 0;

        public static int ride(int k, int[] g, int r)
        {
            i = 0;
            int j = 0;
            int n = 0;

            if (!g.Any())
            {
                return n;
            }

            for (int s = 1; s <= r; s++)
            {
                j += ride2(k, g);
            }
            return j;
        }

        public static int ride2(int k, int[] g)
        {
            int t = 0;

            Boolean flg = true;
            while (flg)
            {
                Console.Write(i);
                if (t + g[i] > k)
                {
                    flg = false;

                }
                else
                {
                    t += g[i];
                    if (g.Length == 1)
                    {
                        flg = false;
                    }
                    i = (i + 1) % g.Length;
                }
            }
            return t;

        }
    }
}