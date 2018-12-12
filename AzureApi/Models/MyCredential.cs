using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureApi.Models
{
    public class MyCredential
    {
        public MyCredential(long OwnerId)
        {
            AccessToken = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = StatusAt.Active;
            ExpireAt = DateTime.Now.AddDays(7);
        }

        public long OwnerId { get; set; }
        [Key]
        public string AccessToken { get; set; }

        public DateTime ExpireAt { get; set; }

        public StatusAt Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public enum StatusAt
        {
            Active = 0,
            DeActive = 1,
        }

    }
}
