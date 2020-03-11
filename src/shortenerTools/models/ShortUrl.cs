using Microsoft.WindowsAzure.Storage.Table;

namespace cloud5mins.models
{
    public class ShortUrl : TableEntity
    {
        public string Url { get; set; }
    }
}
