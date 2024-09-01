using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.ViewModels
{
    public partial class ProfileViewModel : BaseViewModel
    {
        private readonly AuthService _authService;
        private readonly CommonService _commonService;
        private readonly IUserApi _userApi;
        public ProfileViewModel(AuthService authService, CommonService commonService, IUserApi userApi)
        {
            _authService = authService;
            _commonService = commonService;
            _userApi = userApi;
            _commonService.LoginStatusChanged += OnLoginStatusChanged;
            SetUserInfo();
        }
        private void OnLoginStatusChanged(object? sender, EventArgs e)
        {
            SetUserInfo();
        }
        private void SetUserInfo()
        {
            if (_authService.IsLoggedIn)
            {
                var userInfo = _authService.GetUser();
                UserName = userInfo.Name;
                IsLoggedIn = true;
                _commonService.SetToken(userInfo.Token);
            }
            else
            {
                UserName = "Not Logged In";
                IsLoggedIn = false;
            }
        }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Initials))]
        private string _userName = "Not Logged In";

        [ObservableProperty]
        private bool _isLoggedIn;

        public string Initials
        {
            get
            {
                var parts = UserName.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                if (parts.Length == 1)  //If the username has only one word (e.g. Abhay)
                    return UserName.Length == 1
                            ? UserName              // If username has one word with one character only     (e.g. A)
                            : UserName[..2];    // Username is one word with multiple characters (e.g. Abhay)
                return $"{parts[0][0]}{parts[1][0]}"; // Username has multiple words (e.g. Abhay Prince)
            }
        }

        [RelayCommand]
        private async Task LoginLogoutAsync()
        {
            if (!IsLoggedIn)
            {
                // We pressed login
                await GoToAsync($"//{nameof(LoginRegisterPage)}");
            }
            else
            {
                // We pressed logout
                _authService.Logout();
                await GoToAsync($"//{nameof(HomePage)}");
            }
        }

        [RelayCommand]
        private async Task ChangePasswordAsync()
        {
            if (!_authService.IsLoggedIn)
            {
                await ShowToastAsync("Debe Iniciar sesión para cambiar su contraseña");
                return;
            }
            var newPassword = await App.Current!.MainPage!.DisplayPromptAsync("Cambiar clave", "Cambiar clave", placeholder: "Ingrene nueva clave");
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                IsBusy = true;
                await _userApi.ChangePasswordAsync(new SingleValueDto<string>(newPassword));
                IsBusy = false;
                await ShowToastAsync("Clave cambiada exitosamente");
            }
        }
    }
}
