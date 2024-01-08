namespace ProductAPI.DTO
{
    public class ResponseDto<T>
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public T Result { get; set; }
        public string Message { get; set; }
       
    }
}
