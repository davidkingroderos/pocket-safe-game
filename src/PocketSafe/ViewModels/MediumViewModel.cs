using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketSafe.ViewModels
{
    public partial class MediumViewModel : BaseViewModel
    {
        public MediumViewModel() : base()
        {
            Title = "Medium";
            safeSize = 8;
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
            throw new NotImplementedException();
        }

        protected override void InitializeButtons()
        {
            throw new NotImplementedException();
        }
    }
}
