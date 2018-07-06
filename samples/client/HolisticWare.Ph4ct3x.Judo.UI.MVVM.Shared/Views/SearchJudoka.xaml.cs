using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolisticWare.Ph4ct3x.Judo.Views
{
    public partial class SearchJudoka : ContentPage
    {
        public SearchJudoka()
        {
            InitializeComponent();

            buttonSearchJudoka.Clicked += ButtonSearchJudoka_Clicked;
        }

        void ButtonSearchJudoka_Clicked(object sender, EventArgs e)
        {
            string name = this.entryNameJudoka.Text;
            string gender = this.entryGender.Text;
            string country = this.entryCountry.Text;

            // https://www.ijf.org/judoka?name=Cvjetko&nation=CRO&gender=both&category=cad
            // https://www.ijf.org/judoka?name=bozkurt&nation=all&gender=f&category=all


            return;
        }

    }
}
