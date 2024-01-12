using Blazor.Pokedex.Models;

namespace Blazor.Pokedex.Services
{
    public interface IPokeApiClient
    {
        Task<ResultObject> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon> GetPokemon(string name);
    }
}
