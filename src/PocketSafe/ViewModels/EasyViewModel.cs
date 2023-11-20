using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketSafe.ViewModels
{
    public partial class EasyViewModel : BaseViewModel
    {
        private bool hasStarted = false;
        public EasyViewModel()
        {
            Title = "Easy";

            Application.Current.RequestedThemeChanged += (s, a) => GetButtonColors();
        }

        [ObservableProperty]
        private string r0C0_Color;
        [ObservableProperty]
        private string r0C1_Color;
        [ObservableProperty]
        private string r1C0_Color;
        [ObservableProperty]
        private string r1C1_Color;

        [RelayCommand]
        private void R0C0_Click()
        {
            if (!hasStarted)
            {
                hasStarted = true;

                
            }
        }

        [RelayCommand]
        private void R0C1_Click()
        {

        }

        [RelayCommand]
        private void R1C0_Click()
        {
                
        }

        [RelayCommand]
        private void R1C1_Click()
        {
                
        }

        private void GetButtonColors()
        {

        }
    }
}