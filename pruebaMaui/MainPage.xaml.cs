using pruebaMaui.ViewModels;

namespace pruebaMaui;

public partial class MainPage : ContentPage
{

    public MainPage(PrincipalViewModel vm)
    {
        BindingContext = vm;

        InitializeComponent();
    }

}

