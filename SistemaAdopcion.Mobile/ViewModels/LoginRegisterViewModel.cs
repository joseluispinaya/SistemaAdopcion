namespace SistemaAdopcion.Mobile.ViewModels
{
    [QueryProperty(nameof(IsFirstTime), nameof(IsFirstTime))]
    public partial class LoginRegisterViewModel : BaseViewModel
    {

        [ObservableProperty]
        private bool _isRegistrationMode;

        [ObservableProperty]
        private LoginRegisterModel _model = new();

        [ObservableProperty]
        private bool _isFirstTime;


        partial void OnIsFirstTimeChanging(bool value)
        {
            if (value)
                IsRegistrationMode = true;
        }

        [RelayCommand]
        private void ToggleMode() => IsRegistrationMode = !IsRegistrationMode;

        [RelayCommand]
        private async Task SkipForNow() => await GoToAsync($"//{nameof(HomePage)}");

        [RelayCommand]
        private async Task Submit()
        {
            if (!Model.Validate(IsRegistrationMode))
            {
                await ShowToastAsync("Todos los campos son obligatorios");
                return;
            }

            IsBusy = true;
            //llamo a la api para login o registro
            await Task.Delay(1000);
            await SkipForNow();
            IsBusy = false;
        }
    }
}
