using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    interface IReferenceManual
    {
        public void manual();
    }

    class referenceManual
    {
      public referenceManual(IReferenceManual referenceManual)
        {
            referenceManual.manual();
        }

    }
}
