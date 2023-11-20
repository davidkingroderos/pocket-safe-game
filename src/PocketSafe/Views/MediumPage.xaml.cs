using PocketSafe.ViewModels;

namespace PocketSafe.Views;

public partial class MediumPage : ContentPage
{
	public MediumPage(MediumViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}