using ServiceConsumer.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var proxy = new CalcClient())
            {
                Console.WriteLine(proxy.AddNumbers(2,3));
            }
        }
    }
}
