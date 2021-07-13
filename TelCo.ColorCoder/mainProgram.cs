using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class mainProgram
    {
        private static void Main(string[] args)
        {


            colorManual.manual();
            int pairNumber = 4;
            ColorPair testPair1 = colorFromPairnum.GetColorFromPairNumber(pairNumber);
           

           
            pairNumber = 5;
            testPair1 = colorFromPairnum.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = colorFromPairnum.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

           
        }

    }
}
