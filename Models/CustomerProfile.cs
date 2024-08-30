using Azure;
using Azure.Data.Tables;
using System;

namespace ST10262898_CLDV6212_POEPART1.Models
{
    public class CustomerProfile : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? TimeStamp {get; set;}
        public Etag Etag { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerProfile()
        {
            PartitionKey = "CustomerProfile";
            RowKey =Guid.NewGuid().ToString(); 
        }
    }
}
