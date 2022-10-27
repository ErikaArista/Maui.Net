namespace pruebaMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("PaginaDeInicio", typeof(MainPage));
        Routing.RegisterRoute("PaginaLogin", typeof(Login));
    }
}
