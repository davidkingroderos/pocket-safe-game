using PocketSafe.ViewModels;

namespace PocketSafe.Views;

public partial class HardPage : ContentPage
{
    public HardPage(HardViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}