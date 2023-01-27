namespace BrandUp.AmoCRM.Models
{
    public abstract class BaseResponce<T>
    {
        public ResponceLinks Links { get; set; }
        public T Embedded { get; set; }
    }
}
