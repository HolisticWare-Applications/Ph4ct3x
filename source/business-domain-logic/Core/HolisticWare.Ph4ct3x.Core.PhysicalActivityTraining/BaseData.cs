using System;

namespace HolisticWare.Ph4ct3x.PhysicalActivityTraining.Core
{
    public partial class BaseData
    {
        public Version Version
        {
            get;
            set;
        } = new Version("2018-02");

        public BaseData()
        {
            return;
        }

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
    }
}
