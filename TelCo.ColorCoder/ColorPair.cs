using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            
            int minorIndex = -1;
            for (int i = 0; i < colorFromPairnum.colorMapMajor.Length; i++)
            {
                if (colorFromPairnum.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    
                }
                  if (colorFromPairnum.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                   
                }
            }

            // Find the minor color in the array and get the index
            
           
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorFromPairnum.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
