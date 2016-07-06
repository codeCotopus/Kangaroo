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

            string[] tokens_x1 = args;
            int Kangaroo1Position = Convert.ToInt32(tokens_x1[0]);
            int Kangaroo1Speed = Convert.ToInt32(tokens_x1[1]);
            int Kangaroo2Position = Convert.ToInt32(tokens_x1[2]);
            int Kangaroo2Speed = Convert.ToInt32(tokens_x1[3]);

            if (Kangaroo1Position == Kangaroo2Position)
            {
                consoleOutput = "YES";
                return;
            }
            else
            {
                if ((Kangaroo1Position < Kangaroo2Position && Kangaroo1Speed < Kangaroo2Speed) ||
                    (Kangaroo1Position > Kangaroo2Position && Kangaroo1Speed > Kangaroo2Speed))
                {
                    consoleOutput = "NO";
                    return;
                }
            }

            if (Kangaroo1Position < Kangaroo2Position)
            {
                while (Kangaroo1Position < Kangaroo2Position )
                {
                    Kangaroo1Position += Kangaroo1Speed;
                    Kangaroo2Position += Kangaroo2Speed;
                }
                if (Kangaroo1Position == Kangaroo2Position)
                {
                    consoleOutput = "YES";
                    return;
                }
                else
                {
                    consoleOutput = "NO";
                    return;
                }
            }

            if (Kangaroo1Position > Kangaroo2Position)
            {
                while (Kangaroo1Position > Kangaroo2Position)
                {
                    Kangaroo1Position += Kangaroo1Speed;
                    Kangaroo2Position += Kangaroo2Speed;
                }
                if (Kangaroo1Position == Kangaroo2Position)
                {
                    consoleOutput = "YES";
                    return;
                }
                else
                {
                    consoleOutput = "NO";
                    return;
                }
            }



        }

        public static string consoleOutput;


    }

    [TestClass]
    public class tests
    {
        [TestMethod]
        public void Test1()
        {
            CallMain( "0", "3", "4", "2" );       
            Assert.AreEqual("YES", Program.consoleOutput);

        }

        [TestMethod]
        public void Test2()
        {
            CallMain( "0","2","5","3" );
            Assert.AreEqual("NO", Program.consoleOutput);

        }

        private static void CallMain(string param1, string param2 , string param3 , string param4)
        {
            string[] args = new string[4] { param1, param2, param3, param4 };
            Program.Main(args);
        }
    }
}
