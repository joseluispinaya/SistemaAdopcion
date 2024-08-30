using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.ViewModels
{
    [QueryProperty(nameof(PetId), nameof(PetId))]
    public partial class DetailsViewModel : BaseViewModel
    {
        private readonly IPetsApi _petsApi;
        private readonly AuthService _authService;
        private readonly IUserApi _userApi;

        public DetailsViewModel(IPetsApi petsApi, AuthService authService, IUserApi userApi)
        {
            _petsApi = petsApi;
            _authService = authService;
            _userApi = userApi;
        }

        [ObservableProperty]
        private int _petId;

        [ObservableProperty]
        private Pet _petDetail = new();

        async partial void OnPetIdChanging(int value)
        {
            IsBusy = true;

            try
            {
                await Task.Delay(100);

                var apiResponse = _authService.IsLoggedIn
                              ? await _userApi.GetPetDetailsAsync(value)
                              : await _petsApi.GetPetDetailsAsync(value);

                //var apiResponse = await _petsApi.GetPetDetailsAsync(value);
                if (apiResponse.IsSuccess)
                {
                    //var petDto = apiResponse.Data;
                    //PetDetail = apiResponse.Data;
                    //public string PrecioCad => $"Bs/ {petDto.Price:F2}";
                    var petDto = apiResponse.Data;
                    PetDetail = new Pet
                    {
                        AdoptionStatus = petDto.AdoptionStatus,
                        Age = petDto.Age,
                        Breed = petDto.Breed,
                        Description = petDto.Description,
                        GenderDisplay = petDto.GenderDisplay,
                        GenderImage = petDto.GenderImage,
                        Id = petDto.Id,
                        Image = petDto.Image,
                        IsFavorite = petDto.IsFavorite,
                        Name = petDto.Name,
                        Price = petDto.Price,
                        PrecioCad = petDto.PrecioCad
                    };

                }
                else
                {
                    await ShowAlertAsync("Error al obtener los detalles de la mascota", apiResponse.Message!);
                }
            }
            catch (Exception ex)
            {
                await ShowAlertAsync("Error al obtener los detalles de la mascota", ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task GoBack() => await GoToAsync("..");

        [RelayCommand]
        private async Task ToggleFavorite()
        {
            if (!_authService.IsLoggedIn)
            {
                await ShowToastAsync("Debes iniciar sesión para marcar esta mascota como favorita");
                return;
            }

            PetDetail.IsFavorite = !PetDetail.IsFavorite;
            try
            {
                IsBusy = true;
                await _userApi.ToggleFavoritesAsync(PetId);
                IsBusy = false;
            }
            catch (Exception ex)
            {
                IsBusy = false;

                //Revert 
                PetDetail.IsFavorite = !PetDetail.IsFavorite;

                await ShowAlertAsync("Error al alternar el estado de favorito", ex.Message);
            }
        }
    }
}
