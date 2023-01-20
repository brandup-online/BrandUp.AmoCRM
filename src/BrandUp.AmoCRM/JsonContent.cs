using System.Text;

namespace BrandUp.AmoCRM
{
    internal class JsonContent : StringContent
    {
        public JsonContent(string content) : base(content, Encoding.UTF8)
        {
        }

        public JsonContent(string content, Encoding encoding) : base(content, encoding, "application/json")
        {
        }
    }
}
