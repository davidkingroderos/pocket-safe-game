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
        private int[] buttonNumbers;
        private int prevNumber = 0;
        private readonly int safeSize = 4;

        private bool HasWon
        {
            get
            {
                if (!R0C0_IsClickable && !R0C1_IsClickable && !R1C0_IsClickable && !R1C1_IsClickable)
                    return true;
                else return false;
            }
        }

        public EasyViewModel()
        {
            Title = "Easy";

            InitializeButtons();
        }

        [ObservableProperty]
        private string r0C0_Color;
        [ObservableProperty]
        private string r0C1_Color;
        [ObservableProperty]
        private string r1C0_Color;
        [ObservableProperty]
        private string r1C1_Color;

        [ObservableProperty]
        private bool r0C0_IsClickable = true;
        [ObservableProperty]
        private bool r0C1_IsClickable = true;
        [ObservableProperty]
        private bool r1C0_IsClickable = true;
        [ObservableProperty]
        private bool r1C1_IsClickable = true;

        [RelayCommand]
        private void R0C0_Click()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[0] - 1) && !(prevNumber == safeSize && buttonNumbers[0] == 1))
            //else if (prevNumber != (buttonNumbers[0] - 1) && prevNumber != safeSize && buttonNumbers[0] != 1)
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

            IsBusy = false;
        }

        [RelayCommand]
        private void R0C1_Click()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[1] - 1) && !(prevNumber == safeSize && buttonNumbers[1] == 1))
            //else if (prevNumber != (buttonNumbers[1] - 1) && prevNumber != safeSize && buttonNumbers[1] != 1)
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

            IsBusy = false;
        }

        [RelayCommand]
        private void R1C0_Click()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[2] - 1) && !(prevNumber == safeSize && buttonNumbers[2] == 1))
            //else if (prevNumber != (buttonNumbers[2] - 1) && prevNumber != safeSize && buttonNumbers[2] != 1)
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

            IsBusy = false;
        }

        [RelayCommand]
        private void R1C1_Click()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;
            if (!hasStarted)
            {
                hasStarted = true;
            }
            else if (prevNumber != (buttonNumbers[3] - 1) && !(prevNumber == safeSize && buttonNumbers[3] == 1))
            //else if (prevNumber != (buttonNumbers[3] - 1) && prevNumber != safeSize && buttonNumbers[3] != 1)
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

            IsBusy = false;
        }

        private void ResetButtons()
        {
            R0C0_IsClickable = true;
            R0C1_IsClickable = true;
            R1C0_IsClickable = true;
            R1C1_IsClickable = true;
        }

        private void InitializeButtons()
        {
            HashSet<int> generatedNumbers = new();
            Random random = new();

            int safeSize = 4;

            while (generatedNumbers.Count < safeSize)
            {
                int randomNumber = random.Next(1, safeSize + 1);

                if (!generatedNumbers.Contains(randomNumber))
                {
                    generatedNumbers.Add(randomNumber);
                }
            }

            hasStarted = false;
            buttonNumbers = generatedNumbers.ToArray();
        }
    }
}
