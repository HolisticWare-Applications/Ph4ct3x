using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x
{
    public partial class Athlete : Person
    {
        public IEnumerable<Team> Teams
        {
            get;
            set;
        }

    }
}
