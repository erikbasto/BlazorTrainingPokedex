namespace Blazor.Pokedex.Models
{
    public class PaginationParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set;} = 5;
        public int Offset => (PageNumber - 1) * PageSize;
        public int PageCount { get; set;} = 10;
    }
}
