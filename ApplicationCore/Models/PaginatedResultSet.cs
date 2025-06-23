namespace ApplicationCore.Models
{
    public class PaginatedResultSet<T>
    {
        public IEnumerable<T>? Items { get; init; }
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}