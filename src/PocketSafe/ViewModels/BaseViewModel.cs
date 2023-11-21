using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketSafe.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        protected bool hasStarted;
        protected int[] buttonNumbers;
        protected int prevNumber;
        protected int safeSize;

        public BaseViewModel()
        {
            hasStarted = false;
            prevNumber = 0;
        }

        [ObservableProperty]
        public string title;

        protected void InitializeButtons()
        {
            HashSet<int> generatedNumbers = new();
            Random random = new();

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

        protected abstract void ResetButtons();
    }
}
