using System;
using System.Collections.Generic;
using System.Linq;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes
{
    /// <summary>
    ///
    ///
    ///
    /// <a href="http://stackoverflow.com">here</a>
    /// </summary>
    public class HeathCarterBase : SomatotypeBase
    {
        public HeathCarterBase() : base()
        {

            return;
        }

        public Skinfolds Skinfolds
        {
            get;
            set;
        }

        public Bicondyles Bicondyles
        {
            get;
            set;
        }

        public Circumferences Circumferences
        {
            get;
            set;
        }

    }
}

