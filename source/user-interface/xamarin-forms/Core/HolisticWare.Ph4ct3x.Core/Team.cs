using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x
{
    public partial class Team
    {
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public List<Person> Persons
        {
            get;
            set;
        }

        public List<Team> Teams
        {
            get;
            set;
        }
    }
}
