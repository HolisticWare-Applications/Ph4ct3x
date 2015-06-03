using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolisticWare.Ph4ct3x.DomainBusinessLogic.Tests.Portable
{
	/// <summary>
	/// Test Model (Data Structure)
	///		
    ///		1.	string Id
    ///			sifra u primjeru
    ///		2.	string Name
    ///		3.	class - Category
    ///			Predmet Mjerenja - sposobnost
    ///		4.	Prerequsites
    ///		    1.	Equipment
    ///				wall
    ///		        measuring tape (meter)
    ///		        drawing material (tape, chalk)
    ///		    2.	ActionItems
    ///		        draw 45 degs
    ///		        90 degs
    ///		        perpendicular to the wall put measuring tape 
    ///		5.	TestProtocol
    ///		    Steps
    ///		        ...
    ///		        ... 
    ///		    InstructionsForTesters
    ///		    InstuctionsForTestees
    ///		    ResultEvaluation 


	/// </summary>
    public partial class Test
    {
		public string  Id 
		{
			get; 
			set;
		}


		public string Name
		{
			get;
			set;
		}

		public Ability Category
		{
			get;
			set;
		}

		public TestPerequisites Perequisites
		{
			get;
			set;
		}

		public TestProtocol Protocol
		{
			get;
			set;
		}

		public ResultEvaluaton ResultEvaluation
		{
			get;
			set;
		}

	}
}
