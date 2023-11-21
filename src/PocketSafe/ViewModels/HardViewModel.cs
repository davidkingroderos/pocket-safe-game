using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketSafe.ViewModels
{
    public partial class HardViewModel : BaseViewModel
    {
        public HardViewModel()
        {
            Title = "Hard";
        }

        protected override void ResetButtons()
        {
            throw new NotImplementedException();
        }
    }
}
