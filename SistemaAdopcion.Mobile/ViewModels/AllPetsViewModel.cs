using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.ViewModels
{
    public partial class AllPetsViewModel : BaseViewModel
    {
        private readonly IPetsApi _petsApi;

        public AllPetsViewModel(IPetsApi petsApi)
        {
            _petsApi = petsApi;
        }

        [ObservableProperty]
        private IEnumerable<PetListDto> _pets = Enumerable.Empty<PetListDto>();

        [ObservableProperty]
        private bool _isRefreshing;

        private bool _isInitialized;

        public async Task InitializeAsync()
        {
            if (_isInitialized)
                return;
            _isInitialized = true;

            await LoadAllPets(true);
        }

        private async Task LoadAllPets(bool initialLoad)
        {
            if (initialLoad)
                IsBusy = true;
            else
                IsRefreshing = true;
            try
            {
                await Task.Delay(100);
                var apiResponse = await _petsApi.GetAllPetsAsync();
                if (apiResponse.IsSuccess)
                {
                    Pets = apiResponse.Data;
                }
                else
                {
                    await ShowAlertAsync("Error al cargar mascotas", apiResponse.Message!);
                }
            }
            catch (Exception ex)
            {
                await ShowAlertAsync("Error al cargar mascotas", ex.Message);
            }
            finally
            {
                IsBusy = IsRefreshing = false;
            }
        }

        [RelayCommand]
        private async Task LoadPets() => await LoadAllPets(false);
    }
}
