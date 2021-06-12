using System;
using System.Collections.Generic;
using System.Text;

namespace Ph4ct3x.App.XamarinForms.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        SomatoType,
        BodyFatApproximation,
        BodyIndexes,
        BasalMetabolicRate,
        MaxLoadApproximation,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
