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


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}