using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAbad.Areas.CompanyData.Models
{
    public class Partners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [NotMapped]
        public IFormFile? formFile { get; set; }
    }
}
