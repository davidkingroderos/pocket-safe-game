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

        private bool HasWon
        {
            get
            {
                if (!R0C0_IsClickable && !R0C1_IsClickable && !R1C0_IsClickable && !R1C1_IsClickable)
                    return true;
                else return false;
            }
        }

        public EasyViewModel() : base()
        {
            Title = "Easy";
            safeSize = 4;

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

        protected override void ResetButtons()
        {
            R0C0_IsClickable = true;
            R0C1_IsClickable = true;
            R1C0_IsClickable = true;
            R1C1_IsClickable = true;
        }

        #region Commands

        [RelayCommand]
        private void R0C0_Click()
        {
            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[0] - 1) && !(prevNumber == safeSize && buttonNumbers[0] == 1))
            {
                ResetButtons();
            }

            R0C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", "You've unlocked the safe!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            prevNumber = buttonNumbers[0];
        }

        [RelayCommand]
        private void R0C1_Click()
        {
            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[1] - 1) && !(prevNumber == safeSize && buttonNumbers[1] == 1))
            {
                ResetButtons();
            }

            R0C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", "You've unlocked the safe!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            prevNumber = buttonNumbers[1];
        }

        [RelayCommand]
        private void R1C0_Click()
        {
            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[2] - 1) && !(prevNumber == safeSize && buttonNumbers[2] == 1))
            {
                ResetButtons();
            }

            R1C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", "You've unlocked the safe!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            prevNumber = buttonNumbers[2];
        }

        [RelayCommand]
        private void R1C1_Click()
        {
            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[3] - 1) && !(prevNumber == safeSize && buttonNumbers[3] == 1))
            {
                ResetButtons();
            }

            R1C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", "You've unlocked the safe!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            prevNumber = buttonNumbers[3];
        }

        #endregion
    }
}
