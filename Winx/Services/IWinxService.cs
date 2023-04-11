using Winx.Models;
namespace Winx.Services;

    public interface IWinxService
    {
        List<Personagem> GetPersonagens();
        Personagem GetPersonagem(int Numero);
        WinxDto GetWinxDto();
        DetailsDto GetDetailedPersonagem(int numero);
    }
