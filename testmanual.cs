using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
namespace TelCo.ColorCoder{

class testmanual:IReferenceManual
    {
        private int max_length = colorFromPairnum.colorMapMajor.Length;
        private int min_length = colorFromPairnum.colorMapMinor.Length;
        public  void manual()
        {            Console.WriteLine("Testing reference manual/n **********/n");
             int pno = 1;
            for (int i = 0; i < max_length; i++)
            {
                for (int j = 0; j < min_length; j++)
                {
                    ColorPair testPair = colorFromPairnum.GetColorFromPairNumber(pno);
                    Debug.Assert(testPair.majorColor == colorFromPairnum.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == colorFromPairnum.colorMapMinor[j]);

                   var test = new ColorPair();

                    test.majorColor = colorFromPairnum.colorMapMajor[i];
                    test.minorColor = colorFromPairnum.colorMapMinor[j];
                   
                    int pairNumber = ColorPair.GetPairNumberFromColor(testPair);
                    Debug.Assert(pno == pairNumber);
                    pno++;
                }         }      
				}

    }
}