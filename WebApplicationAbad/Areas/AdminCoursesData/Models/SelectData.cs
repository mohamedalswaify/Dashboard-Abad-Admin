using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAbad.Areas.AdminCoursesData.Models
{
    public class SelectData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int VlaueData { get; set; }

        public string? MessageData { get; set; }
    }
}
