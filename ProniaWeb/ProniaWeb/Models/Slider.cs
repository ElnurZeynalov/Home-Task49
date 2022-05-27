using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Threading.Tasks;

namespace ProniaWeb.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,MaxLength(25)]
        public string Title { get; set; }
        [Required,MaxLength (50)]
        public string Description { get; set; }
        [Required]
        public int DiscountPercent {get; set; }
        public string Image { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }

        internal Task CopyToAsync(FileStream stream)
        {
            throw new NotImplementedException();
        }
    }
}
