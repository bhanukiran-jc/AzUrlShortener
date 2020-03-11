using Microsoft.WindowsAzure.Storage.Table;

namespace cloud5mins.models
{
    public class NextId : TableEntity 
    {
        public int Id { get; set; }
    }
}