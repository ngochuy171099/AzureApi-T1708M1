using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureApi.Models
{
    public class Song
    {
        public Song()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = StatusAt.Active;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Singer { get; set; }

        public string Author { get; set; }

        public string Thumbnail { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public StatusAt Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public enum StatusAt
        {
            Active = 1,
            DeActive = 0,
        }
    }
}
