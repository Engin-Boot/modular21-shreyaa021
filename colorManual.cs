using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
namespace TelCo.ColorCoder{
    class printManual:IReferenceManual
    {
        private int max_length = colorFromPairnum.colorMapMajor.Length;
        private int min_length = colorFromPairnum.colorMapMinor.Length;
        public  void manual()
        {
            Console.WriteLine(" Printing color manual \n**********\n");
          int pno = 1;
            for (int i = 0; i < max_length; i++)
            {
                for (int j = 0; j < min_length; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", pno, colorFromPairnum.colorMapMajor[i], colorFromPairnum.colorMapMinor[j]);
                    pno++;
                }            }        }    }
    
}
