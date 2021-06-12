using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Core
{
    /// <summary>
    /// Borg scale.
    /// </summary>
    /// <see cref="https://www.cdc.gov/physicalactivity/basics/measuring/exertion.htm"/>
    /// <see cref="https://www.hsph.harvard.edu/nutritionsource/borg-scale/"/>
    /// <see cref="https://en.wikipedia.org/wiki/Rating_of_perceived_exertion"/>
    /// <see cref="https://www.brianmac.co.uk/borgscale.htm"/>
    public partial class LikertScale
    {
        public Dictionary<double, string> Table
        {
            get;
            set;
        } = new Dictionary<double, string>()
        {
            {  6, "No exertion at all"},
            {  7, "" },
            {  7.5, "Extremely light" },
            {  8, ""},    
            {  9, "Very light" },
            { 10, "" },
            { 11, "Light" },
            { 12, "" },
            { 13, "Somewhat hard" },
            { 14, "" },
            { 15, "Hard(heavy)" },
            { 16, "" },
            { 17, "Very hard" },
            { 18, "" },
            { 19, "Extremely hard" },
            { 20, "Maximal exertion" },
        };

    }
}
