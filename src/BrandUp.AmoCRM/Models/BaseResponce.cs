namespace BrandUp.AmoCRM.Models
{
    public abstract class BaseResponce
    {
        public ResponceLinks Links { get; set; }
        public object Embedded { get; set; }
    }
}
