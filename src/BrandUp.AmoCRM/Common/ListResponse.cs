namespace BrandUp.AmoCRM.Models
{
    internal class ListResponse<T> : BaseResponse<T>
    {
        public int Page { get; set; }
    }

}
