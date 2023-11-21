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
        protected abstract bool HasWon { get; }

        protected bool HasStarted { get; set; }
        protected int[] ButtonNumbers { get; set; }
        protected int PrevNumber { get; set; }
        protected int SafeSize { get; set; }

        public BaseViewModel()
        {
            HasStarted = false;
            PrevNumber = 0;
        }

        [ObservableProperty]
        public string title;

        protected void InitializeButtons()
        {
            HashSet<int> generatedNumbers = new();
            Random random = new();

            while (generatedNumbers.Count < SafeSize)
            {
                int randomNumber = random.Next(1, SafeSize + 1);

                if (!generatedNumbers.Contains(randomNumber))
                {
                    generatedNumbers.Add(randomNumber);
                }
            }

            HasStarted = false;
            ButtonNumbers = generatedNumbers.ToArray();
        }

        protected abstract void ResetButtons();
    }
}
