using PocketSafe.ViewModels;

namespace PocketSafe.Views;

public partial class EasyPage : ContentPage
{
	public EasyPage(EasyViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}