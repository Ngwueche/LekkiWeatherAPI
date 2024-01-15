namespace WeatherAPI.Model.DTOs
{
    public class ReturnObject<T>
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
