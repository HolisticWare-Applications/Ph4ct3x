using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.Sports.Judo
{
    public class Judoka : Person
    {
        public Judoka()
        {
        }

		public ulong IdInternationalJudoFederation
        {
            get;
            set;
        }

		public Country Country
        {
            get;
            set;
        }

		public IEnumerable<Competition> Competitions
        {
            get;
            set;
        }
    }
}
