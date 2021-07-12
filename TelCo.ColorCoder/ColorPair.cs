using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
        class ColorPair
        {
            private Color majorColor;
            private Color minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
			 private static int GetPairNumberFromColor(ColorPair pair)
        {
		// Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < Program.colorMapMajor.Length; i++)
            {
                if (Program.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < Program.colorMapMinor.Length; i++)
            {
                if (Program.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
              if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * Program.colorMapMinor.Length) + (minorIndex + 1);
        }
        }
       }
