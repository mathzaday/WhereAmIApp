using WhereAmIApp.ViewModels;

namespace WhereAmIApp.Views;

public partial class LocalPage : ContentPage
{
	public LocalPage(LocalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}