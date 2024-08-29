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
        public DetailsViewModel(IPetsApi petsApi)
        {
            _petsApi = petsApi;
        }

        [ObservableProperty]
        private int _petId;

        [ObservableProperty]
        private PetDetailDto _petDetail = new();

        async partial void OnPetIdChanging(int value)
        {
            IsBusy = true;

            try
            {
                var apiResponse = await _petsApi.GetPetDetailsAsync(value);
                if (apiResponse.IsSuccess)
                {
                    PetDetail = apiResponse.Data;
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
    }
}
