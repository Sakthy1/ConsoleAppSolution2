using System.ComponentModel.DataAnnotations;

namespace WebApps.Models
{
    public class Newsfeed
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string Message { get; set; }

    }
}
