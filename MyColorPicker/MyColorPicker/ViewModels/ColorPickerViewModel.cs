using System;
using System.Collections.Generic;
using System.Text;
using MyClock.ViewModels;
using MyColorPicker.Models;
using Xamarin.Forms;

namespace MyColorPicker.ViewModels
{
    public class ColorPickerViewModel : ViewModelBase
    {
        private PickerColor pickerColor;
        public IList<PickerColor> PickerColors => PickerColorData.Colors;
        public PickerColor PickerColor
        {
            get => pickerColor;
            set
            {
                if(pickerColor != value)
                {
                    pickerColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public ColorPickerViewModel()
        {
            PickerColor = new PickerColor
            {
                Name = "Black",
                Color = Color.Black,
            };
        }
    }
}
