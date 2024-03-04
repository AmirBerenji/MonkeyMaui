using CommunityToolkit.Mvvm.ComponentModel;


namespace TestProject.ViewModels
{
    
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {
            
        }

        [ObservableProperty]
        bool isBusy;
        [ObservableProperty]
        string title;


        public bool IsNotBusy => !isBusy;
       
    }
}
