using System.Collections.Generic;


namespace HolisticWare.Ph4ct3x.DiagnosticTests.Morphological.SomatoTypes.ML.Evaluation.Core
{
    public class SomatotypeInputDataMap : CsvHelper.Configuration.ClassMap<SomatotypeInputData>
    {
        public SomatotypeInputDataMap()
        {
            Map(m => m.Id).Index(0).Name("Id");
            Map(m => m.Height).Index(1).Name("Height");
            Map(m => m.Mass).Index(2).Name("Mass");
            Map(m => m.BreadthHumerus).Index(3).Name("BreadthHumerus");
            Map(m => m.BreadthFemur).Index(4).Name("BreadthFemur");
            Map(m => m.GirthArmUpper).Index(5).Name("GirthArmUpper");
            Map(m => m.GirthCalfStanding).Index(6).Name("GirthCalfStanding");
            Map(m => m.SkinfoldSubscapular).Index(7).Name("SkinfoldSubscapular");
            Map(m => m.SkinfoldTriceps).Index(8).Name("SkinfoldTriceps");
            Map(m => m.SkinfoldSupraspinale).Index(9).Name("SkinfoldSupraspinale");
            Map(m => m.SkinfoldMedialCalf).Index(10).Name("SkinfoldMedialCalf");

            return;
        }
    }
    public class SomatotypeInputData
    {
        public SomatotypeInputData()
        {
        }
        public SomatotypeInputData(SomatotypeInputData stid)
        {
            this.Id = stid.Id;
            this.Mass = stid.Mass;
            this.Height = stid.Height;
            this.SkinfoldTriceps = stid.SkinfoldTriceps;
            this.SkinfoldSupraspinale = stid.SkinfoldSupraspinale;
            this.SkinfoldSubscapular = stid.SkinfoldSubscapular;
            this.SkinfoldMedialCalf = stid.SkinfoldMedialCalf;
            this.BreadthFemur = stid.BreadthFemur;
            this.BreadthHumerus = stid.BreadthHumerus;
            this.GirthArmUpper = stid.GirthArmUpper;
            this.GirthCalfStanding = stid.GirthCalfStanding;

            return;
        }

        public int Id
        {
            get;
            set;
        }

        public double Mass
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }

        public double SkinfoldTriceps
        {
            get;
            set;
        }
        
        public double SkinfoldSubscapular
        {
            get;
            set;
        }

        public double SkinfoldSupraspinale
        {
            get;
            set;
        }

        public double SkinfoldMedialCalf
        {
            get;
            set;
        }

        public double BreadthHumerus
        {
            get;
            set;
        }

        public double BreadthFemur
        {
            get;
            set;
        }

        public double GirthArmUpper
        {
            get;
            set;
        }

        public double GirthCalfStanding
        {
            get;
            set;
        }

    }
}