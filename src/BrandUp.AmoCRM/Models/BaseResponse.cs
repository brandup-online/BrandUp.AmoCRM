namespace BrandUp.AmoCRM.Models
{
    public abstract class BaseResponse<T>
    {
        public ResponseLinks Links { get; set; }
        public T Embedded { get; set; }
    }
}
