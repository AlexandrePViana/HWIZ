using HWIZ.Domain.DataTransferObject;
using HWIZ.Domain.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HWIZ.Web.Components.Pages
{
    public partial class Home
    {
        [Inject]
        private IUtilizadoresService UtilizadoresService { get; set; }
        [Inject]
        private IFeriasService FeriasService { get; set; }

        private List<UtilizadoresDTO> utilizadores;
        private List<FeriasDTO> ferias;
        protected override async Task OnInitializedAsync()
        {
            utilizadores = await UtilizadoresService.GetUtilizadoresAsync();
            ferias = await FeriasService.GetFeriasAsync();
        }

        public string GetUserNameById(int? id)
        {
            return utilizadores.FirstOrDefault(x => x.Id == id).NomeUtilizador;
        }
    }
}
