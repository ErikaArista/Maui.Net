using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace pruebaMaui.ViewModels
{
    public partial class PrincipalViewModel : ObservableObject
    {
        [RelayCommand]
        public async void RedireccionarLogin()
        {
            await Shell.Current.GoToAsync("PaginaLogin");
        }

    }
}
