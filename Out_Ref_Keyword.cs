using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary._0CSharp_Basics
{
    public class Out_Ref_Keyword
    {


        #region MyRegion



        /*Not Allowed---> Console.WriteLine("");
         Above line will not work as statement is not wrapped around by method or function
            
         for (int i=0;i>=1;i++)
            {
                Console.WriteLine("");
            }
         */



        /* To allow this we have to create function and then it can execute
           public void MethodeShow()
            {
                Console.WriteLine("");
            }
        */

        #endregion



        //Ref Keyword
        //Need initial value

        public void Demo()
        {
            int a = 2;
            int b = 4;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(a + "-" + b);
            Swap(ref a, ref b);
            Console.WriteLine(a + "-" + b);


            int sum= 0;
            int difference= 0;
            int multiply= 0;
            decimal avg= 0;


            Calculate(a, b,out sum, out difference, out multiply, out avg);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Sum:" + sum);
            Console.WriteLine("Difference:" + difference);
            Console.WriteLine("Multiply:" + multiply);
            Console.WriteLine("Average:" + avg);



            Console.WriteLine("--------------------------------------");
            DataType(10, "HELLO", 'b', (decimal)20.5, 2.345f, 45323546, 234532,true,DateTime.Now);

            decimal d1 = Convert.ToDecimal(234.5);
            decimal d2 = 234.5m;
            decimal d3 = (decimal)234.5;

            int xray = 2345;
            string strXray = Convert.ToString(xray);  //"2345"


            DemoMethod();

        }


        public void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;

        }


        //Out Keyword
        //Does not require initialization

        public void DemoOut()
        {
            int a = 5;
            int b = 7;

            int total;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(a + "-" + b );
            SwapDemo(ref a, ref b, out total);
            Console.WriteLine(a + "-" + b + "-" +total );
        }



        public void SwapDemo(ref int a, ref int b, out int total )
        {
            int c = b;
            b = a;
            a = c;

            total = a + b;

        }

       public void Calculate(int a,int b , out int sum, out int difference, out int multiply , out decimal avg)
        {
            sum = a + b;
            difference = b-a;
            multiply = a/b;
            avg = (a + b) / 2;
        }


        public void DataType(int i,string str,char c,decimal dec, float flt, double dbl, long lng , bool bl, DateTime dt)
        {

        }


        public void DemoMethod()
        {
            Console.WriteLine("Hii");

            void showMsg(string strMsg)
            {
                Console.WriteLine("Hello-----"+strMsg);
            }
            showMsg("BYE");
            showMsg("GOOD BYE");

        }

    }
}
