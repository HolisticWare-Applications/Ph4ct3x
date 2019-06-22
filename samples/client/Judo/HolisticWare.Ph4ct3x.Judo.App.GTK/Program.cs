﻿// /*
//    Copyright (c) 2018-8
//
//    moljac
//    Program.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */
using System;
using Gtk;

namespace HolisticWare.Ph4ct3x.Judo.Apps.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();

            //----------------------------------------------------------------------------------------------------------
            // https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/gtk?tabs=vsmac
            global::Xamarin.Forms.Forms.Init();

            global::HolisticWare.Ph4ct3x.Judo.App app = null;
            global::Xamarin.Forms.Platform.GTK.FormsWindow window = null;

            app = new global::HolisticWare.Ph4ct3x.Judo.App();
            window = new global::Xamarin.Forms.Platform.GTK.FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("HolisticWare.Ph4ct3x.Judo");
            window.Show();
            //----------------------------------------------------------------------------------------------------------

            Gtk.Application.Run();

            return;
        }
    }
}
