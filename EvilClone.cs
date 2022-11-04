using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainAmazing
{
    internal class EvilClone
    {
        public static int CloneCount = 0;
        public int CloneID { get; } = ++CloneCount;

        public EvilClone() => Console.WriteLine($"Clone #{CloneID} is wreaking havoc");
        ~EvilClone()
        {
            Console.WriteLine($"Clone #{CloneID} destroyed");
        }
    }
}
