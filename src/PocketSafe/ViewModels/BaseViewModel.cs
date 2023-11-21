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
        protected int prevNumber = 0; 
        protected int safeSize;

        public BaseViewModel()
        {
            hasStarted = false;

            InitializeButtons();
        }

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public bool isBusy;

        protected abstract void ResetButtons();
        protected abstract void InitializeButtons();
    }
}
