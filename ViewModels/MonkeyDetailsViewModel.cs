
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model;

namespace TestProject.ViewModels
{
    [QueryProperty("Monkey","Monkey")]
    public partial class MonkeyDetailsViewModel : BaseViewModel
    {
        public MonkeyDetailsViewModel()
        {
            
        }
        [ObservableProperty]
        Monkey monkey;
    }
}
