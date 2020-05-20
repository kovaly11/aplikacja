using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Count
    {
        public double temp;
        public double PlnToUSD()
        {
            return temp / 4.12;
        }
        public double PlnToEUR()
        {
            return temp / 4.52;
        }
        public double EURToPln()
        {
            return temp * 4.52;
        }
        public double EURToUsd()
        {
            return temp / 0.91;
        }
        public double UsdToPln()
        {
            return temp * 4.12;
        }
        public double UsdToEUR()
        {
            return temp * 0.91;
        }
    }
}
