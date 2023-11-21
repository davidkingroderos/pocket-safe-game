using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketSafe.ViewModels
{
    public partial class MediumViewModel : BaseViewModel
    {
        protected override bool HasWon => throw new NotImplementedException();
        public MediumViewModel()
        {
            Title = "Medium";
            SafeSize = 8;

            InitializeButtons();
        }

        [ObservableProperty]
        private bool r0C0_IsClickable = true;
        [ObservableProperty]
        private bool r0C1_IsClickable = true;
        [ObservableProperty]
        private bool r1C0_IsClickable = true;
        [ObservableProperty]
        private bool r1C1_IsClickable = true;
        [ObservableProperty]
        private bool r2C0_IsClickable = true;
        [ObservableProperty]
        private bool r2C1_IsClickable = true;
        [ObservableProperty]
        private bool r3C0_IsClickable = true;
        [ObservableProperty]
        private bool r3C1_IsClickable = true;


        protected override void ResetButtons()
        {
            R0C0_IsClickable = true;
            R0C1_IsClickable = true;
            R1C0_IsClickable = true;
            R1C1_IsClickable = true;
            R2C0_IsClickable = true;
            R2C1_IsClickable = true;
            R3C0_IsClickable = true;
            R3C1_IsClickable = true;
        }

        #region Commands

        [RelayCommand]
        private void R0C0_Click()
        {

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

        [RelayCommand]
        private void R2C0_Click()
        {

        }

        [RelayCommand]
        private void R2C1_Click()
        {

        }

        [RelayCommand]
        private void R3C0_Click()
        {

        }

        [RelayCommand]
        private void R3C1_Click()
        {

        }

        #endregion
    }
}
