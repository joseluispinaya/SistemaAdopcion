namespace SistemaAdopcion.Mobile.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly ProfileViewModel _viewModel;

    public ProfilePage(ProfileViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private async void ProfileOptionRow_Tapped(object sender, string optionText)
    {
        switch (optionText)
        {
            case "Mi Adpciones":
                await _viewModel.ShowToastAsync("Tapp Mi Adopciones");
                break;
            case "Cambiar Clave":
                await _viewModel.ShowToastAsync("Tapp Cambiar Clave");
                break;
        }
    }
}