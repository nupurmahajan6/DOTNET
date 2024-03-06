using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CommonLibrary._0CSharp_Basics
{
    public class Parameter
    {
        public void DemoOptionalParameter(int a, int b = 20)
        {
            Console.WriteLine(a + b);
        }

        public void DemoOptionalParameter(string strFName , string strLName , string strTitle="Mr.")
        {
            Console.WriteLine(strTitle +" " + strFName + " " +strLName + " ");
        }


    }
}
