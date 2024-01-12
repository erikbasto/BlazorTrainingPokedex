using Newtonsoft.Json;

namespace Blazor.Pokedex.Models
{
    public class ResultObject
    {      
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
