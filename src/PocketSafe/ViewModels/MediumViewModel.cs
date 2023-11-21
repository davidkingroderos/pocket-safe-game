﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        protected override bool HasWon
        {
            get
            {
                if (!R0C0_IsClickable && !R0C1_IsClickable && !R1C0_IsClickable && !R1C1_IsClickable && 
                    !R2C0_IsClickable && !R2C1_IsClickable && !R3C0_IsClickable && !R3C1_IsClickable)
                    return true;
                else return false;
            }
        }
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
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[0] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[0] == 1))
            {
                ResetButtons();
            }

            R0C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", 
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[0];
        }

        [RelayCommand]
        private void R0C1_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[1] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[1] == 1))
            {
                ResetButtons();
            }

            R0C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", 
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[1];
        }

        [RelayCommand]
        private void R1C0_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[2] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[2] == 1))
            {
                ResetButtons();
            }

            R1C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", 
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[2];
        }

        [RelayCommand]
        private void R1C1_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[3] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[3] == 1))
            {
                ResetButtons();
            }

            R1C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!", 
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[3];
        }

        [RelayCommand]
        private void R2C0_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[4] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[4] == 1))
            {
                ResetButtons();
            }

            R2C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!",
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[4];
        }

        [RelayCommand]
        private void R2C1_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[5] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[5] == 1))
            {
                ResetButtons();
            }

            R2C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!",
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[5];
        }

        [RelayCommand]
        private void R3C0_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[6] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[6] == 1))
            {
                ResetButtons();
            }

            R3C0_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!",
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[6];
        }

        [RelayCommand]
        private void R3C1_Click()
        {
            if (!HasStarted)
            {
                HasStarted = true;
            }
            else if (PrevNumber != (ButtonNumbers[7] - 1) && !(PrevNumber == SafeSize && ButtonNumbers[7] == 1))
            {
                ResetButtons();
            }

            R3C1_IsClickable = false;

            if (HasWon)
            {
                Shell.Current.CurrentPage.DisplayAlert("Unlocked!",
                    "You've unlocked the safe! Try hard difficulty next!", "Restart");

                ResetButtons();
                InitializeButtons();
            }

            PrevNumber = ButtonNumbers[7];
        }

        #endregion
    }
}
