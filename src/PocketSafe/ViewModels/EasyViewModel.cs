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

        public EasyViewModel()
        {
            Title = "Easy";

            Application.Current.RequestedThemeChanged += (s, a) => GetButtonColors();

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
            R0C0_IsClickable = false;

            if (!hasStarted)
            {
                hasStarted = true;
            }

            prevNumber = buttonNumbers[0];
        }

        [RelayCommand]
        private void R0C1_Click()
        {
            R0C1_IsClickable = false;

            if (!hasStarted)
            {
                hasStarted = true;
            }

            prevNumber = buttonNumbers[0];
        }

        [RelayCommand]
        private void R1C0_Click()
        {
            R1C0_IsClickable = false;

            if (!hasStarted)
            {
                hasStarted = true;
            }

            prevNumber = buttonNumbers[0];
        }

        [RelayCommand]
        private void R1C1_Click()
        {
            R1C1_IsClickable = false;

            if (!hasStarted)
            {
                hasStarted = true;
            }

            prevNumber = buttonNumbers[0];
        }

        private void GetButtonColors()
        {

        }

        private void ResetButtons()
        {

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

            buttonNumbers = generatedNumbers.ToArray();
        }
    }
}
