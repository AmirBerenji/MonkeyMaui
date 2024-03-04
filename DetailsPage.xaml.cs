using TestProject.Model;
using TestProject.ViewModels;

namespace TestProject;

public partial class DetailsPage : ContentPage
{
	
	public DetailsPage(MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}