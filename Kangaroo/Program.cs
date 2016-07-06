using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// https://www.hackerrank.com/challenges/kangaroo

namespace Kangaroo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            consoleOutput = string.Empty;

            string[] tokens_x1 =args;
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v3 = Convert.ToInt32(tokens_x1[3]);
                       
        }

        public static string consoleOutput;


    }

    [TestClass]
    public class tests
    {
        [TestMethod]
        public void Test1()
        {
            string[] args = new string[4] {"0","2","3","5" }; 
            Program.Main(args);
            Assert.AreEqual("xx", Program.consoleOutput);
            
        }
    }
}
