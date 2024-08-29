namespace SistemaAdopcion.Mobile.ViewModels
{
    [QueryProperty(nameof(IsFirstTime), nameof(IsFirstTime))]
    public partial class LoginRegisterViewModel : BaseViewModel
    {
        public LoginRegisterViewModel(AuthService authService)
        {
            _authService = authService;
        }

        [ObservableProperty]
        private bool _isRegistrationMode;

        [ObservableProperty]
        private LoginRegisterModel _model = new();

        [ObservableProperty]
        private bool _isFirstTime;

        private readonly AuthService _authService;


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
            var status = await _authService.LoginRegisterAsync(Model);
            if (status)
            {
                await SkipForNow();
            }

            IsBusy = false;
        }
    }
}
