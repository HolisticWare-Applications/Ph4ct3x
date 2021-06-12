using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using HolisticWare.Ph4ct3x.DiagnosticTests.Morphological;

namespace HolisticWare.Ph4ct3x.Server.API.Data.Math
{
    // http://127.0.0.1:5000/
    [Route("api/data/math/samples")]
    public class SamplesController : Controller
    {
        // api/data/math/samples/
        [HttpGet]
        public string Load(string filename)
        {
            if (null == filename)
            {
                filename = "Basketball.Commented.csv";
            }
            string file = System.IO.Path.Combine(directory_domain_base, "Xtras-SampleData", filename);
            string text = System.IO.File.ReadAllText(file);

            return text;
        }

        //----------------------------------------------------------------------
        string directory_current;
        string directory_domain_base;
        string directory_environment_current;

        public SamplesController()
        {
            directory_current = System.IO.Directory.GetCurrentDirectory();
            directory_domain_base = AppDomain.CurrentDomain.BaseDirectory;
            directory_environment_current = Environment.CurrentDirectory;


            return;
        }
        //----------------------------------------------------------------------
    }
}
