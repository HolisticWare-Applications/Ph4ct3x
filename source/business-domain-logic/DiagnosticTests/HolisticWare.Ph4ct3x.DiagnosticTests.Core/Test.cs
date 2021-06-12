using System;
using System.Collections.Generic;

namespace HolisticWare.Ph4ct3x.DiagnosticTests.Core
{
    /// <summary>
    /// Test object according to Dizdar, Katovic, ... KIF (kif.hr)
    /// </summary>
    public partial class Test
    {
        public Test()
        {
        }

        /// <summary>
        /// Short Name (Sifra) of the Test
        /// </summary>
        /// <value>The name short identifier.</value>
        public string NameShortID
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the Test
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        /// <summary>
        /// Physical Capabilitiy collection being measured (Sposobnost)
        /// </summary>
        /// <value>The capabilities.</value>
        public IEnumerable<Capability> Capabilities
        {
            get;
            set;
        }

        public IEnumerable<object> Prerequisites
        {
            get;
            set;
        }

        public Equipment Equipment
        {
            get;
            set;
        }

        public IEnumerable<ActionItem> ActionItems
        {
            get;
            set;
        }

        public IEnumerable<ProtocolStep> TestingProtocol
        {
            get;
            set;
        }

        public IEnumerable<Instruction> InstructionsForTesters
        {
            get;
            set;
        }

        public IEnumerable<Instruction> InstructionsForTestees
        {
            get;
            set;
        }

        //public IEnumerable<Result> ResultEvaluation
        //{
        //    get;
        //    set;
        //}

        public IEnumerable<ResultEvaluation> Results
        {
            get;
            set;
        }

    }
}
