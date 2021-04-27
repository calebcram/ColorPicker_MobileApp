using System;
using System.Collections.Generic;
using System.Text;
using MyColorPicker.Models;
using MyClock.ViewModels;
using Xamarin.Forms;

namespace MyColorPicker.Models
{
    public static class PickerColorData
    {
        public static IList<PickerColor> Colors { get; private set; }
        static PickerColorData()
        {
            Colors = new List<PickerColor>();
            Colors.Add(new PickerColor
            {
                Name = "Purple",
                Color = Color.Purple,
            });
            Colors.Add(new PickerColor
            {
                Name = "Black",
                Color = Color.Black,
            });
            Colors.Add(new PickerColor
            {
                Name = "Blue",
                Color = Color.Blue,
            });
            Colors.Add(new PickerColor
            {
                Name = "Red",
                Color = Color.Red,
            });
            Colors.Add(new PickerColor
            {
                Name = "Orange",
                Color = Color.Orange,
            });
            Colors.Add(new PickerColor
            {
                Name = "Brown",
                Color = Color.Brown,
            });
            Colors.Add(new PickerColor
            {
                Name = "Yellow",
                Color = Color.Yellow,
            });
            Colors.Add(new PickerColor
            {
                Name = "Green",
                Color = Color.Green,
            });
        }
    }
}
