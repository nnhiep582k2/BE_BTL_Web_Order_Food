namespace OrderFood.Common.DTOs
{
    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public List<T>? Datas { get; set; }
    }
}
