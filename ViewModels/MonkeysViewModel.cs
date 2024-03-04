
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Toolkit.Mvvm.Input;
using TestProject.Model;
using TestProject.Services;

namespace TestProject.ViewModels
{
    public partial class MonkeysViewModel : BaseViewModel
    {
        MonkeyService monkeyService;
        public ObservableCollection<Monkey> Monkeys { get; } = new();

        public MonkeysViewModel(MonkeyService _monkeyService)
        {
            Title = "Monkey Finder";
            monkeyService = _monkeyService;
        }

        [ICommand]
        async Task GoToDetailsAsync(Monkey monkey)
        {
            if (monkey is null)
                return;
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}",true,new Dictionary<string, object> {
                { "Monkey",monkey }
            });
        }


        [ICommand]
        async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();

                if(Monkeys.Count !=0)
                    Monkeys.Clear();
                foreach(var monkey in monkeys)
                    Monkeys.Add(monkey);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                await Shell.Current.DisplayAlert("", e.Message,"Ok");
            }
            finally
            {
                IsBusy = false;
            }
            
        }
    }
}
